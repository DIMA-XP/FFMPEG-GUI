namespace WindowsFormsApplication1
{
    partial class Form12
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form12));
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.rbOutAvi = new System.Windows.Forms.RadioButton();
            this.rbOutMkv = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbOutOgg = new System.Windows.Forms.RadioButton();
            this.rbOutMp4 = new System.Windows.Forms.RadioButton();
            this.rbOutWav = new System.Windows.Forms.RadioButton();
            this.rbOutWebm = new System.Windows.Forms.RadioButton();
            this.rbOutMp3 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(36)))), ((int)(((byte)(87)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(80, 37);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(177, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Выбор файла";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(21, 326);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(293, 17);
            this.progressBar1.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // rbOutAvi
            // 
            this.rbOutAvi.AutoSize = true;
            this.rbOutAvi.Checked = true;
            this.rbOutAvi.ForeColor = System.Drawing.Color.White;
            this.rbOutAvi.Location = new System.Drawing.Point(14, 19);
            this.rbOutAvi.Name = "rbOutAvi";
            this.rbOutAvi.Size = new System.Drawing.Size(42, 17);
            this.rbOutAvi.TabIndex = 0;
            this.rbOutAvi.TabStop = true;
            this.rbOutAvi.Text = "AVI";
            this.rbOutAvi.UseVisualStyleBackColor = true;
            // 
            // rbOutMkv
            // 
            this.rbOutMkv.AutoSize = true;
            this.rbOutMkv.ForeColor = System.Drawing.Color.White;
            this.rbOutMkv.Location = new System.Drawing.Point(14, 42);
            this.rbOutMkv.Name = "rbOutMkv";
            this.rbOutMkv.Size = new System.Drawing.Size(48, 17);
            this.rbOutMkv.TabIndex = 4;
            this.rbOutMkv.Text = "MKV";
            this.rbOutMkv.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbOutOgg);
            this.groupBox2.Controls.Add(this.rbOutAvi);
            this.groupBox2.Controls.Add(this.rbOutMkv);
            this.groupBox2.Controls.Add(this.rbOutMp4);
            this.groupBox2.Controls.Add(this.rbOutWav);
            this.groupBox2.Controls.Add(this.rbOutWebm);
            this.groupBox2.Controls.Add(this.rbOutMp3);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(116, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(114, 196);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выход";
            // 
            // rbOutOgg
            // 
            this.rbOutOgg.AutoSize = true;
            this.rbOutOgg.ForeColor = System.Drawing.Color.White;
            this.rbOutOgg.Location = new System.Drawing.Point(14, 134);
            this.rbOutOgg.Name = "rbOutOgg";
            this.rbOutOgg.Size = new System.Drawing.Size(49, 17);
            this.rbOutOgg.TabIndex = 7;
            this.rbOutOgg.Text = "OGG";
            this.rbOutOgg.UseVisualStyleBackColor = true;
            // 
            // rbOutMp4
            // 
            this.rbOutMp4.AutoSize = true;
            this.rbOutMp4.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbOutMp4.ForeColor = System.Drawing.Color.White;
            this.rbOutMp4.Location = new System.Drawing.Point(14, 65);
            this.rbOutMp4.Name = "rbOutMp4";
            this.rbOutMp4.Size = new System.Drawing.Size(47, 17);
            this.rbOutMp4.TabIndex = 4;
            this.rbOutMp4.Text = "MP4";
            this.rbOutMp4.UseVisualStyleBackColor = true;
            // 
            // rbOutWav
            // 
            this.rbOutWav.AutoSize = true;
            this.rbOutWav.ForeColor = System.Drawing.Color.White;
            this.rbOutWav.Location = new System.Drawing.Point(14, 157);
            this.rbOutWav.Name = "rbOutWav";
            this.rbOutWav.Size = new System.Drawing.Size(50, 17);
            this.rbOutWav.TabIndex = 8;
            this.rbOutWav.Text = "WAV";
            this.rbOutWav.UseVisualStyleBackColor = true;
            // 
            // rbOutWebm
            // 
            this.rbOutWebm.AutoSize = true;
            this.rbOutWebm.ForeColor = System.Drawing.Color.White;
            this.rbOutWebm.Location = new System.Drawing.Point(14, 88);
            this.rbOutWebm.Name = "rbOutWebm";
            this.rbOutWebm.Size = new System.Drawing.Size(59, 17);
            this.rbOutWebm.TabIndex = 5;
            this.rbOutWebm.Text = "WEBM";
            this.rbOutWebm.UseVisualStyleBackColor = true;
            // 
            // rbOutMp3
            // 
            this.rbOutMp3.AutoSize = true;
            this.rbOutMp3.ForeColor = System.Drawing.Color.White;
            this.rbOutMp3.Location = new System.Drawing.Point(14, 111);
            this.rbOutMp3.Name = "rbOutMp3";
            this.rbOutMp3.Size = new System.Drawing.Size(47, 17);
            this.rbOutMp3.TabIndex = 6;
            this.rbOutMp3.Text = "MP3";
            this.rbOutMp3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(36)))), ((int)(((byte)(87)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(60, 368);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(217, 62);
            this.button2.TabIndex = 4;
            this.button2.Text = "Конвертировать";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(56, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "FFMPEG GUI BY DIMA XP";
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(335, 444);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form12";
            this.Text = "FFMPEG GUI BY DIMA XP V1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RadioButton rbOutOgg;
        private System.Windows.Forms.RadioButton rbOutMp3;
        private System.Windows.Forms.RadioButton rbOutWebm;
        private System.Windows.Forms.RadioButton rbOutWav;
        private System.Windows.Forms.RadioButton rbOutMp4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbOutMkv;
        private System.Windows.Forms.RadioButton rbOutAvi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
    }
}

