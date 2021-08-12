
namespace StokTakipOtomasyonu
{
    partial class FormMusteriEkle
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
            this.LblTc = new System.Windows.Forms.Label();
            this.LblAdSoyad = new System.Windows.Forms.Label();
            this.LblTelefon = new System.Windows.Forms.Label();
            this.LblAdres = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.TxtTc = new System.Windows.Forms.TextBox();
            this.TxtAdSoyad = new System.Windows.Forms.TextBox();
            this.TxtTelefon = new System.Windows.Forms.TextBox();
            this.TxtAdres = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblTc
            // 
            this.LblTc.AutoSize = true;
            this.LblTc.Location = new System.Drawing.Point(62, 53);
            this.LblTc.Name = "LblTc";
            this.LblTc.Size = new System.Drawing.Size(21, 13);
            this.LblTc.TabIndex = 0;
            this.LblTc.Text = "TC";
            // 
            // LblAdSoyad
            // 
            this.LblAdSoyad.AutoSize = true;
            this.LblAdSoyad.Location = new System.Drawing.Point(62, 85);
            this.LblAdSoyad.Name = "LblAdSoyad";
            this.LblAdSoyad.Size = new System.Drawing.Size(53, 13);
            this.LblAdSoyad.TabIndex = 1;
            this.LblAdSoyad.Text = "Ad Soyad";
            // 
            // LblTelefon
            // 
            this.LblTelefon.AutoSize = true;
            this.LblTelefon.Location = new System.Drawing.Point(62, 117);
            this.LblTelefon.Name = "LblTelefon";
            this.LblTelefon.Size = new System.Drawing.Size(43, 13);
            this.LblTelefon.TabIndex = 2;
            this.LblTelefon.Text = "Telefon";
            // 
            // LblAdres
            // 
            this.LblAdres.AutoSize = true;
            this.LblAdres.Location = new System.Drawing.Point(63, 149);
            this.LblAdres.Name = "LblAdres";
            this.LblAdres.Size = new System.Drawing.Size(34, 13);
            this.LblAdres.TabIndex = 3;
            this.LblAdres.Text = "Adres";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(62, 181);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(35, 13);
            this.LblEmail.TabIndex = 4;
            this.LblEmail.Text = "E-mail";
            // 
            // TxtTc
            // 
            this.TxtTc.Location = new System.Drawing.Point(150, 50);
            this.TxtTc.Name = "TxtTc";
            this.TxtTc.Size = new System.Drawing.Size(100, 20);
            this.TxtTc.TabIndex = 5;
            // 
            // TxtAdSoyad
            // 
            this.TxtAdSoyad.Location = new System.Drawing.Point(150, 82);
            this.TxtAdSoyad.Name = "TxtAdSoyad";
            this.TxtAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.TxtAdSoyad.TabIndex = 6;
            // 
            // TxtTelefon
            // 
            this.TxtTelefon.Location = new System.Drawing.Point(150, 114);
            this.TxtTelefon.Name = "TxtTelefon";
            this.TxtTelefon.Size = new System.Drawing.Size(100, 20);
            this.TxtTelefon.TabIndex = 7;
            // 
            // TxtAdres
            // 
            this.TxtAdres.Location = new System.Drawing.Point(150, 146);
            this.TxtAdres.Name = "TxtAdres";
            this.TxtAdres.Size = new System.Drawing.Size(100, 20);
            this.TxtAdres.TabIndex = 8;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(150, 178);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(100, 20);
            this.TxtEmail.TabIndex = 9;
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(146, 218);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(104, 33);
            this.BtnEkle.TabIndex = 10;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // FormMusteriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(356, 293);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtAdres);
            this.Controls.Add(this.TxtTelefon);
            this.Controls.Add(this.TxtAdSoyad);
            this.Controls.Add(this.TxtTc);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LblAdres);
            this.Controls.Add(this.LblTelefon);
            this.Controls.Add(this.LblAdSoyad);
            this.Controls.Add(this.LblTc);
            this.Name = "FormMusteriEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Musteri Ekleme Sayfası";
            this.Load += new System.EventHandler(this.FormMusteriEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTc;
        private System.Windows.Forms.Label LblAdSoyad;
        private System.Windows.Forms.Label LblTelefon;
        private System.Windows.Forms.Label LblAdres;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.TextBox TxtTc;
        private System.Windows.Forms.TextBox TxtAdSoyad;
        private System.Windows.Forms.TextBox TxtTelefon;
        private System.Windows.Forms.TextBox TxtAdres;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Button BtnEkle;
    }
}