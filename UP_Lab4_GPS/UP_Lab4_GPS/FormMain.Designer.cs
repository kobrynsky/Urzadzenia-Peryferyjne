namespace UP_Lab4_GPS
{
    partial class FormMain
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelCords = new System.Windows.Forms.Label();
            this.labelLattitudeVal = new System.Windows.Forms.Label();
            this.labelLongVal = new System.Windows.Forms.Label();
            this.labelAltitude = new System.Windows.Forms.Label();
            this.labelValText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelLatText = new System.Windows.Forms.Label();
            this.buttonShowMap = new System.Windows.Forms.Button();
            this.webBrowserMap = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(21, 15);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(100, 38);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelCords
            // 
            this.labelCords.AutoSize = true;
            this.labelCords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCords.Location = new System.Drawing.Point(16, 76);
            this.labelCords.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCords.Name = "labelCords";
            this.labelCords.Size = new System.Drawing.Size(65, 25);
            this.labelCords.TabIndex = 1;
            this.labelCords.Text = "Dane:";
            // 
            // labelLattitudeVal
            // 
            this.labelLattitudeVal.AutoSize = true;
            this.labelLattitudeVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLattitudeVal.Location = new System.Drawing.Point(141, 139);
            this.labelLattitudeVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLattitudeVal.Name = "labelLattitudeVal";
            this.labelLattitudeVal.Size = new System.Drawing.Size(61, 25);
            this.labelLattitudeVal.TabIndex = 2;
            this.labelLattitudeVal.Text = "latVal";
            // 
            // labelLongVal
            // 
            this.labelLongVal.AutoSize = true;
            this.labelLongVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLongVal.Location = new System.Drawing.Point(137, 167);
            this.labelLongVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLongVal.Name = "labelLongVal";
            this.labelLongVal.Size = new System.Drawing.Size(78, 25);
            this.labelLongVal.TabIndex = 3;
            this.labelLongVal.Text = "longVal";
            // 
            // labelAltitude
            // 
            this.labelAltitude.AutoSize = true;
            this.labelAltitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAltitude.Location = new System.Drawing.Point(137, 110);
            this.labelAltitude.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAltitude.Name = "labelAltitude";
            this.labelAltitude.Size = new System.Drawing.Size(61, 25);
            this.labelAltitude.TabIndex = 4;
            this.labelAltitude.Text = "altVal";
            // 
            // labelValText
            // 
            this.labelValText.AutoSize = true;
            this.labelValText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValText.Location = new System.Drawing.Point(16, 110);
            this.labelValText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelValText.Name = "labelValText";
            this.labelValText.Size = new System.Drawing.Size(110, 25);
            this.labelValText.TabIndex = 7;
            this.labelValText.Text = "Wysokość:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Długość:";
            // 
            // labelLatText
            // 
            this.labelLatText.AutoSize = true;
            this.labelLatText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLatText.Location = new System.Drawing.Point(16, 139);
            this.labelLatText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLatText.Name = "labelLatText";
            this.labelLatText.Size = new System.Drawing.Size(111, 25);
            this.labelLatText.TabIndex = 5;
            this.labelLatText.Text = "Szerokość:";
            // 
            // buttonShowMap
            // 
            this.buttonShowMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowMap.Location = new System.Drawing.Point(249, 15);
            this.buttonShowMap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonShowMap.Name = "buttonShowMap";
            this.buttonShowMap.Size = new System.Drawing.Size(208, 38);
            this.buttonShowMap.TabIndex = 8;
            this.buttonShowMap.Text = "Pokaż na mapie";
            this.buttonShowMap.UseVisualStyleBackColor = true;
            this.buttonShowMap.Click += new System.EventHandler(this.buttonShowMap_Click);
            // 
            // webBrowserMap
            // 
            this.webBrowserMap.Location = new System.Drawing.Point(481, 15);
            this.webBrowserMap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.webBrowserMap.MinimumSize = new System.Drawing.Size(27, 25);
            this.webBrowserMap.Name = "webBrowserMap";
            this.webBrowserMap.Size = new System.Drawing.Size(736, 549);
            this.webBrowserMap.TabIndex = 9;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 577);
            this.Controls.Add(this.webBrowserMap);
            this.Controls.Add(this.buttonShowMap);
            this.Controls.Add(this.labelValText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelLatText);
            this.Controls.Add(this.labelAltitude);
            this.Controls.Add(this.labelLongVal);
            this.Controls.Add(this.labelLattitudeVal);
            this.Controls.Add(this.labelCords);
            this.Controls.Add(this.buttonStart);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMain";
            this.Text = "Okno główne";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelCords;
        private System.Windows.Forms.Label labelLattitudeVal;
        private System.Windows.Forms.Label labelLongVal;
        private System.Windows.Forms.Label labelAltitude;
        private System.Windows.Forms.Label labelValText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelLatText;
        private System.Windows.Forms.Button buttonShowMap;
        private System.Windows.Forms.WebBrowser webBrowserMap;
    }
}

