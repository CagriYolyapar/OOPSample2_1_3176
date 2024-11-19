namespace OOPSample2_1
{
    partial class Form2
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
            this.LblOgrenci = new System.Windows.Forms.Label();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.TxtIsim = new System.Windows.Forms.TextBox();
            this.LstOgrenciler = new System.Windows.Forms.ListBox();
            this.TxtSoyIsim = new System.Windows.Forms.TextBox();
            this.CmbLablar = new System.Windows.Forms.ComboBox();
            this.LblLab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblOgrenci
            // 
            this.LblOgrenci.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblOgrenci.Location = new System.Drawing.Point(282, 386);
            this.LblOgrenci.Name = "LblOgrenci";
            this.LblOgrenci.Size = new System.Drawing.Size(345, 51);
            this.LblOgrenci.TabIndex = 9;
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(30, 245);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(100, 23);
            this.BtnEkle.TabIndex = 8;
            this.BtnEkle.Text = "Ogrenci Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            // 
            // TxtIsim
            // 
            this.TxtIsim.Location = new System.Drawing.Point(30, 40);
            this.TxtIsim.Name = "TxtIsim";
            this.TxtIsim.Size = new System.Drawing.Size(100, 22);
            this.TxtIsim.TabIndex = 6;
            // 
            // LstOgrenciler
            // 
            this.LstOgrenciler.FormattingEnabled = true;
            this.LstOgrenciler.ItemHeight = 16;
            this.LstOgrenciler.Location = new System.Drawing.Point(285, 12);
            this.LstOgrenciler.Name = "LstOgrenciler";
            this.LstOgrenciler.Size = new System.Drawing.Size(295, 356);
            this.LstOgrenciler.TabIndex = 5;
            // 
            // TxtSoyIsim
            // 
            this.TxtSoyIsim.Location = new System.Drawing.Point(30, 88);
            this.TxtSoyIsim.Name = "TxtSoyIsim";
            this.TxtSoyIsim.Size = new System.Drawing.Size(100, 22);
            this.TxtSoyIsim.TabIndex = 6;
            // 
            // CmbLablar
            // 
            this.CmbLablar.FormattingEnabled = true;
            this.CmbLablar.Location = new System.Drawing.Point(30, 156);
            this.CmbLablar.Name = "CmbLablar";
            this.CmbLablar.Size = new System.Drawing.Size(109, 24);
            this.CmbLablar.TabIndex = 10;
            // 
            // LblLab
            // 
            this.LblLab.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblLab.Location = new System.Drawing.Point(27, 190);
            this.LblLab.Name = "LblLab";
            this.LblLab.Size = new System.Drawing.Size(146, 29);
            this.LblLab.TabIndex = 9;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CmbLablar);
            this.Controls.Add(this.LblLab);
            this.Controls.Add(this.LblOgrenci);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.TxtSoyIsim);
            this.Controls.Add(this.TxtIsim);
            this.Controls.Add(this.LstOgrenciler);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblOgrenci;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.TextBox TxtIsim;
        private System.Windows.Forms.ListBox LstOgrenciler;
        private System.Windows.Forms.TextBox TxtSoyIsim;
        private System.Windows.Forms.ComboBox CmbLablar;
        private System.Windows.Forms.Label LblLab;
    }
}