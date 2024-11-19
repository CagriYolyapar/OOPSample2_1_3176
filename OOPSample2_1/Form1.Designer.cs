namespace OOPSample2_1
{
    partial class Form1
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
            this.LstLablar = new System.Windows.Forms.ListBox();
            this.TxtLabNo = new System.Windows.Forms.TextBox();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.lblLab = new System.Windows.Forms.Label();
            this.BtnForm2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstLablar
            // 
            this.LstLablar.FormattingEnabled = true;
            this.LstLablar.ItemHeight = 16;
            this.LstLablar.Location = new System.Drawing.Point(268, 42);
            this.LstLablar.Name = "LstLablar";
            this.LstLablar.Size = new System.Drawing.Size(295, 356);
            this.LstLablar.TabIndex = 0;
            // 
            // TxtLabNo
            // 
            this.TxtLabNo.Location = new System.Drawing.Point(13, 70);
            this.TxtLabNo.Name = "TxtLabNo";
            this.TxtLabNo.Size = new System.Drawing.Size(100, 22);
            this.TxtLabNo.TabIndex = 1;
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(13, 127);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(75, 23);
            this.BtnEkle.TabIndex = 2;
            this.BtnEkle.Text = "Lab Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            // 
            // lblLab
            // 
            this.lblLab.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLab.Location = new System.Drawing.Point(265, 416);
            this.lblLab.Name = "lblLab";
            this.lblLab.Size = new System.Drawing.Size(345, 51);
            this.lblLab.TabIndex = 4;
            // 
            // BtnForm2
            // 
            this.BtnForm2.Location = new System.Drawing.Point(625, 69);
            this.BtnForm2.Name = "BtnForm2";
            this.BtnForm2.Size = new System.Drawing.Size(75, 23);
            this.BtnForm2.TabIndex = 2;
            this.BtnForm2.Text = "Form2";
            this.BtnForm2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 509);
            this.Controls.Add(this.lblLab);
            this.Controls.Add(this.BtnForm2);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.TxtLabNo);
            this.Controls.Add(this.LstLablar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstLablar;
        private System.Windows.Forms.TextBox TxtLabNo;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Label lblLab;
        private System.Windows.Forms.Button BtnForm2;
    }
}

