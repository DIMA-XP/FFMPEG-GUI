using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;


namespace WindowsFormsApplication1
{
    public partial class Form12 : Form
    {
        // 1. Глобальные переменные (видны всем методам)
        string selectedFile = ""; 
        double totalSeconds = 0; // ДОБАВЬ ЭТУ СТРОКУ

        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // Фильтр, чтобы видеть только видеофайлы и аудиофайлы
            open.Filter = "Видео и аудио файлы|*.mp4;*.avi;*.mkv;*.mp3;*.ogg;*.wav;*.webm;*.mov|Все файлы|*.*";

            if (open.ShowDialog() == DialogResult.OK)
            {
                selectedFile = open.FileName;
                System.Media.SystemSounds.Exclamation.Play();
                MessageBox.Show("Файл выбран: " + Path.GetFileName(selectedFile));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // проверяем наличия API
            if (!System.IO.File.Exists("ffmpeg.exe"))
            {
                MessageBox.Show("Положите файл ffmpeg.exe в папку с программой!", "Ошибка"); return;
            } 

            if (string.IsNullOrEmpty(selectedFile)) return;

            // 1. Узнаем длительность видео перед стартом (хитрый трюк)
            Process getDuration = new Process();
            getDuration.StartInfo.FileName = "ffmpeg.exe";
            getDuration.StartInfo.Arguments = string.Format("-i \"{0}\"", selectedFile);
            getDuration.StartInfo.UseShellExecute = false;
            getDuration.StartInfo.RedirectStandardError = true;
            getDuration.StartInfo.CreateNoWindow = true;
            getDuration.Start();

            string info = getDuration.StandardError.ReadToEnd();
            // Ищем строку Duration: 00:00:00.00
            if (info.Contains("Duration: "))
            {
                string dur = info.Substring(info.IndexOf("Duration: ") + 10, 11);
                totalSeconds = TimeSpan.Parse(dur).TotalSeconds;
            }

            progressBar1.Value = 0;
            button2.Enabled = false;
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // Определяем формат и параметры
            string ext = ".mp4";
            string extraArgs = "";

            if (rbOutMp4.Checked)
            {
                ext = ".mp4";
                // Явно указываем видеокодек libx264 и аудиокодек aac
                // "pix_fmt yuv420p" нужен, чтобы видео открывалось стандартным плеером Windows
                extraArgs = "-c:v libx264 -pix_fmt yuv420p -c:a aac -strict experimental";
            }
            if (rbOutAvi.Checked) ext = ".avi";
            if (rbOutMkv.Checked) ext = ".mkv";
            if (rbOutWebm.Checked) { ext = ".webm"; extraArgs = "-c:v libvpx -c:a libvorbis"; }
            if (rbOutMp3.Checked) { ext = ".mp3"; extraArgs = "-vn -ab 192k"; } // -vn убирает видео
            if (rbOutOgg.Checked) { ext = ".ogg"; extraArgs = "-vn -acodec libvorbis"; }
            if (rbOutWav.Checked) { ext = ".wav"; extraArgs = "-vn"; }

            string resultFile = Path.ChangeExtension(selectedFile, ext);

            Process ffmpeg = new Process();
            ffmpeg.StartInfo.FileName = "ffmpeg.exe";
            // -y разрешает перезапись файла
            ffmpeg.StartInfo.Arguments = string.Format("-i \"{0}\" {1} \"{2}\" -y", selectedFile, extraArgs, resultFile);

            ffmpeg.StartInfo.UseShellExecute = false;
            ffmpeg.StartInfo.CreateNoWindow = true;
            ffmpeg.StartInfo.RedirectStandardError = true;
            ffmpeg.Start();

            using (StreamReader reader = ffmpeg.StandardError)
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Ищем в строке time=00:00:00.00
                    if (line.Contains("time=") && totalSeconds > 0)
                    {
                        try
                        {
                            string timePart = line.Substring(line.IndexOf("time=") + 5, 11);
                            double currentSeconds = TimeSpan.Parse(timePart).TotalSeconds;
                            int percent = (int)((currentSeconds / totalSeconds) * 100);

                            if (percent >= 0 && percent <= 100)
                                backgroundWorker1.ReportProgress(percent);
                        }
                        catch { /* игнорим ошибки парсинга */ }
                    }
                }
            }
            ffmpeg.WaitForExit();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Теперь здесь реальные проценты!
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Value = 100;
            button2.Enabled = true;
            MessageBox.Show("Готово!");
        }

        private void backgroundWorker1_RunWorkerCompleted_1(object sender, RunWorkerCompletedEventArgs e)
        {
            // Возвращаем кнопку в рабочее состояние
            button2.Enabled = true;

            // Заполняем прогресс-бар до конца для красоты
            progressBar1.Value = 100;

            if (e.Error != null)
            {
                System.Media.SystemSounds.Hand.Play(); // Звук критической ошибки (крестик)
                MessageBox.Show("Ошибка!");

            }
            else
            {
                System.Media.SystemSounds.Asterisk.Play(); // Приятный звук уведомления
                MessageBox.Show("Конвертация успешно завершена!");

            }
        }
    }
}
