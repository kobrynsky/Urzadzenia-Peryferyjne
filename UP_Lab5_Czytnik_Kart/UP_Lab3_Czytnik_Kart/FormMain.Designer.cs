namespace UP_Lab3_Czytnik_Kart
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
            this.labelSmsResponse = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxSmsHexResponse = new System.Windows.Forms.RichTextBox();
            this.labelResponseSmsASCII = new System.Windows.Forms.Label();
            this.richTextBoxSmsResponseASCII = new System.Windows.Forms.RichTextBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSmsResponse
            // 
            this.labelSmsResponse.AutoSize = true;
            this.labelSmsResponse.Location = new System.Drawing.Point(12, 41);
            this.labelSmsResponse.Name = "labelSmsResponse";
            this.labelSmsResponse.Size = new System.Drawing.Size(155, 17);
            this.labelSmsResponse.TabIndex = 0;
            this.labelSmsResponse.Text = "Odpowiedź SMS [HEX]:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 1;
            // 
            // richTextBoxSmsHexResponse
            // 
            this.richTextBoxSmsHexResponse.Location = new System.Drawing.Point(178, 41);
            this.richTextBoxSmsHexResponse.Name = "richTextBoxSmsHexResponse";
            this.richTextBoxSmsHexResponse.Size = new System.Drawing.Size(261, 217);
            this.richTextBoxSmsHexResponse.TabIndex = 3;
            this.richTextBoxSmsHexResponse.Text = "";
            // 
            // labelResponseSmsASCII
            // 
            this.labelResponseSmsASCII.AutoSize = true;
            this.labelResponseSmsASCII.Location = new System.Drawing.Point(12, 310);
            this.labelResponseSmsASCII.Name = "labelResponseSmsASCII";
            this.labelResponseSmsASCII.Size = new System.Drawing.Size(160, 17);
            this.labelResponseSmsASCII.TabIndex = 4;
            this.labelResponseSmsASCII.Text = "Odpowiedź SMS [ASCII]:";
            // 
            // richTextBoxSmsResponseASCII
            // 
            this.richTextBoxSmsResponseASCII.Location = new System.Drawing.Point(178, 298);
            this.richTextBoxSmsResponseASCII.Name = "richTextBoxSmsResponseASCII";
            this.richTextBoxSmsResponseASCII.Size = new System.Drawing.Size(261, 39);
            this.richTextBoxSmsResponseASCII.TabIndex = 5;
            this.richTextBoxSmsResponseASCII.Text = "";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(364, 366);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 6;
            this.buttonConnect.Text = "Polacz";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 402);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.richTextBoxSmsResponseASCII);
            this.Controls.Add(this.labelResponseSmsASCII);
            this.Controls.Add(this.richTextBoxSmsHexResponse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelSmsResponse);
            this.Name = "FormMain";
            this.Text = "Okno glowne";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSmsResponse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxSmsHexResponse;
        private System.Windows.Forms.Label labelResponseSmsASCII;
        private System.Windows.Forms.RichTextBox richTextBoxSmsResponseASCII;
        private System.Windows.Forms.Button buttonConnect;
    }
}

