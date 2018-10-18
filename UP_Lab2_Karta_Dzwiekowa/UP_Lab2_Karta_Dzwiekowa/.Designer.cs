namespace UP_Lab2_Karta_Dzwiekowa
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.buttonPlay = new System.Windows.Forms.Button();
            this.WindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.buttonChoseFile = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.labelFileName = new System.Windows.Forms.Label();
            this.labelSystemMediaSoundPlayer = new System.Windows.Forms.Label();
            this.labelWindowsMediaPlayerTitle = new System.Windows.Forms.Label();
            this.buttonSpeedUp = new System.Windows.Forms.Button();
            this.buttonSlowDown = new System.Windows.Forms.Button();
            this.buttonShowHead = new System.Windows.Forms.Button();
            this.labelHeaders = new System.Windows.Forms.Label();
            this.checkBoxEcho = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(24, 147);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(75, 23);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.Text = "GRAJ ";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // WindowsMediaPlayer
            // 
            this.WindowsMediaPlayer.Enabled = true;
            this.WindowsMediaPlayer.Location = new System.Drawing.Point(600, 62);
            this.WindowsMediaPlayer.Name = "WindowsMediaPlayer";
            this.WindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WindowsMediaPlayer.OcxState")));
            this.WindowsMediaPlayer.Size = new System.Drawing.Size(464, 376);
            this.WindowsMediaPlayer.TabIndex = 1;
            this.WindowsMediaPlayer.Enter += new System.EventHandler(this.WindowsMediaPlayer_Enter);
            // 
            // buttonChoseFile
            // 
            this.buttonChoseFile.Location = new System.Drawing.Point(24, 74);
            this.buttonChoseFile.Name = "buttonChoseFile";
            this.buttonChoseFile.Size = new System.Drawing.Size(75, 23);
            this.buttonChoseFile.TabIndex = 2;
            this.buttonChoseFile.Text = "Wybierz plik";
            this.buttonChoseFile.UseVisualStyleBackColor = true;
            this.buttonChoseFile.Click += new System.EventHandler(this.buttonChoseFile_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(24, 118);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.Text = "STOP";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(105, 79);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(91, 13);
            this.labelFileName.TabIndex = 4;
            this.labelFileName.Text = "Nie wybrano pliku";
            // 
            // labelSystemMediaSoundPlayer
            // 
            this.labelSystemMediaSoundPlayer.AutoSize = true;
            this.labelSystemMediaSoundPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSystemMediaSoundPlayer.Location = new System.Drawing.Point(19, 23);
            this.labelSystemMediaSoundPlayer.Name = "labelSystemMediaSoundPlayer";
            this.labelSystemMediaSoundPlayer.Size = new System.Drawing.Size(301, 25);
            this.labelSystemMediaSoundPlayer.TabIndex = 5;
            this.labelSystemMediaSoundPlayer.Text = "System.Media.SoundPlayer";
            // 
            // labelWindowsMediaPlayerTitle
            // 
            this.labelWindowsMediaPlayerTitle.AutoSize = true;
            this.labelWindowsMediaPlayerTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWindowsMediaPlayerTitle.Location = new System.Drawing.Point(727, 23);
            this.labelWindowsMediaPlayerTitle.Name = "labelWindowsMediaPlayerTitle";
            this.labelWindowsMediaPlayerTitle.Size = new System.Drawing.Size(251, 25);
            this.labelWindowsMediaPlayerTitle.TabIndex = 6;
            this.labelWindowsMediaPlayerTitle.Text = "Windows Media Player";
            // 
            // buttonSpeedUp
            // 
            this.buttonSpeedUp.Location = new System.Drawing.Point(610, 459);
            this.buttonSpeedUp.Name = "buttonSpeedUp";
            this.buttonSpeedUp.Size = new System.Drawing.Size(93, 23);
            this.buttonSpeedUp.TabIndex = 7;
            this.buttonSpeedUp.Text = "PRZYSPIESZ";
            this.buttonSpeedUp.UseVisualStyleBackColor = true;
            this.buttonSpeedUp.Click += new System.EventHandler(this.buttonSpeedUp_Click);
            // 
            // buttonSlowDown
            // 
            this.buttonSlowDown.Location = new System.Drawing.Point(709, 459);
            this.buttonSlowDown.Name = "buttonSlowDown";
            this.buttonSlowDown.Size = new System.Drawing.Size(93, 23);
            this.buttonSlowDown.TabIndex = 8;
            this.buttonSlowDown.Text = "ZWOLNIJ";
            this.buttonSlowDown.UseVisualStyleBackColor = true;
            this.buttonSlowDown.Click += new System.EventHandler(this.buttonSlowDown_Click);
            // 
            // buttonShowHead
            // 
            this.buttonShowHead.Location = new System.Drawing.Point(24, 196);
            this.buttonShowHead.Name = "buttonShowHead";
            this.buttonShowHead.Size = new System.Drawing.Size(146, 23);
            this.buttonShowHead.TabIndex = 9;
            this.buttonShowHead.Text = "WYSWIETL NAGLOWKI";
            this.buttonShowHead.UseVisualStyleBackColor = true;
            this.buttonShowHead.Click += new System.EventHandler(this.buttonShowHead_Click);
            // 
            // labelHeaders
            // 
            this.labelHeaders.AutoSize = true;
            this.labelHeaders.Location = new System.Drawing.Point(21, 241);
            this.labelHeaders.Name = "labelHeaders";
            this.labelHeaders.Size = new System.Drawing.Size(85, 13);
            this.labelHeaders.TabIndex = 10;
            this.labelHeaders.Text = "brak naglowkow";
            // 
            // checkBoxEcho
            // 
            this.checkBoxEcho.AutoSize = true;
            this.checkBoxEcho.Location = new System.Drawing.Point(124, 147);
            this.checkBoxEcho.Name = "checkBoxEcho";
            this.checkBoxEcho.Size = new System.Drawing.Size(56, 17);
            this.checkBoxEcho.TabIndex = 11;
            this.checkBoxEcho.Text = "ECHO";
            this.checkBoxEcho.UseVisualStyleBackColor = true;
            this.checkBoxEcho.CheckedChanged += new System.EventHandler(this.checkBoxEcho_CheckedChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 585);
            this.Controls.Add(this.checkBoxEcho);
            this.Controls.Add(this.labelHeaders);
            this.Controls.Add(this.buttonShowHead);
            this.Controls.Add(this.buttonSlowDown);
            this.Controls.Add(this.buttonSpeedUp);
            this.Controls.Add(this.labelWindowsMediaPlayerTitle);
            this.Controls.Add(this.labelSystemMediaSoundPlayer);
            this.Controls.Add(this.labelFileName);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonChoseFile);
            this.Controls.Add(this.WindowsMediaPlayer);
            this.Controls.Add(this.buttonPlay);
            this.Name = "MainWindow";
            this.Text = "Okno główne";
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPlay;
        private AxWMPLib.AxWindowsMediaPlayer WindowsMediaPlayer;
        private System.Windows.Forms.Button buttonChoseFile;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.Label labelSystemMediaSoundPlayer;
        private System.Windows.Forms.Label labelWindowsMediaPlayerTitle;
        private System.Windows.Forms.Button buttonSpeedUp;
        private System.Windows.Forms.Button buttonSlowDown;
        private System.Windows.Forms.Button buttonShowHead;
        private System.Windows.Forms.Label labelHeaders;
        private System.Windows.Forms.CheckBox checkBoxEcho;
    }
}

