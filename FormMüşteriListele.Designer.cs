
namespace StokTakipOtomasyonu
{
    partial class FormMüşteriListele
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtAdres = new System.Windows.Forms.TextBox();
            this.TxtTelefon = new System.Windows.Forms.TextBox();
            this.TxtAdSoyad = new System.Windows.Forms.TextBox();
            this.TxtTc = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblAdres = new System.Windows.Forms.Label();
            this.LblTelefon = new System.Windows.Forms.Label();
            this.LblAdSoyad = new System.Windows.Forms.Label();
            this.LblTc = new System.Windows.Forms.Label();
            this.BtnSil = new System.Windows.Forms.Button();
            this.TxtTcAra = new System.Windows.Forms.TextBox();
            this.LblTcAra = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(248, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(524, 281);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(106, 229);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(104, 33);
            this.BtnGuncelle.TabIndex = 21;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(110, 189);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(100, 20);
            this.TxtEmail.TabIndex = 20;
            // 
            // TxtAdres
            // 
            this.TxtAdres.Location = new System.Drawing.Point(110, 157);
            this.TxtAdres.Name = "TxtAdres";
            this.TxtAdres.Size = new System.Drawing.Size(100, 20);
            this.TxtAdres.TabIndex = 19;
            // 
            // TxtTelefon
            // 
            this.TxtTelefon.Location = new System.Drawing.Point(110, 125);
            this.TxtTelefon.Name = "TxtTelefon";
            this.TxtTelefon.Size = new System.Drawing.Size(100, 20);
            this.TxtTelefon.TabIndex = 18;
            // 
            // TxtAdSoyad
            // 
            this.TxtAdSoyad.Location = new System.Drawing.Point(110, 93);
            this.TxtAdSoyad.Name = "TxtAdSoyad";
            this.TxtAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.TxtAdSoyad.TabIndex = 17;
            // 
            // TxtTc
            // 
            this.TxtTc.Location = new System.Drawing.Point(110, 61);
            this.TxtTc.Name = "TxtTc";
            this.TxtTc.Size = new System.Drawing.Size(100, 20);
            this.TxtTc.TabIndex = 16;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(22, 192);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(35, 13);
            this.LblEmail.TabIndex = 15;
            this.LblEmail.Text = "E-mail";
            // 
            // LblAdres
            // 
            this.LblAdres.AutoSize = true;
            this.LblAdres.Location = new System.Drawing.Point(23, 160);
            this.LblAdres.Name = "LblAdres";
            this.LblAdres.Size = new System.Drawing.Size(34, 13);
            this.LblAdres.TabIndex = 14;
            this.LblAdres.Text = "Adres";
            // 
            // LblTelefon
            // 
            this.LblTelefon.AutoSize = true;
            this.LblTelefon.Location = new System.Drawing.Point(22, 128);
            this.LblTelefon.Name = "LblTelefon";
            this.LblTelefon.Size = new System.Drawing.Size(43, 13);
            this.LblTelefon.TabIndex = 13;
            this.LblTelefon.Text = "Telefon";
            // 
            // LblAdSoyad
            // 
            this.LblAdSoyad.AutoSize = true;
            this.LblAdSoyad.Location = new System.Drawing.Point(22, 96);
            this.LblAdSoyad.Name = "LblAdSoyad";
            this.LblAdSoyad.Size = new System.Drawing.Size(53, 13);
            this.LblAdSoyad.TabIndex = 12;
            this.LblAdSoyad.Text = "Ad Soyad";
            // 
            // LblTc
            // 
            this.LblTc.AutoSize = true;
            this.LblTc.Location = new System.Drawing.Point(22, 64);
            this.LblTc.Name = "LblTc";
            this.LblTc.Size = new System.Drawing.Size(21, 13);
            this.LblTc.TabIndex = 11;
            this.LblTc.Text = "TC";
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(790, 64);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(74, 29);
            this.BtnSil.TabIndex = 22;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // TxtTcAra
            // 
            this.TxtTcAra.Location = new System.Drawing.Point(422, 26);
            this.TxtTcAra.Name = "TxtTcAra";
            this.TxtTcAra.Size = new System.Drawing.Size(100, 20);
            this.TxtTcAra.TabIndex = 23;
            this.TxtTcAra.TextChanged += new System.EventHandler(this.TxtTcAra_TextChanged);
            // 
            // LblTcAra
            // 
            this.LblTcAra.AutoSize = true;
            this.LblTcAra.Location = new System.Drawing.Point(341, 29);
            this.LblTcAra.Name = "LblTcAra";
            this.LblTcAra.Size = new System.Drawing.Size(40, 13);
            this.LblTcAra.TabIndex = 24;
            this.LblTcAra.Text = "TC Ara";
            this.LblTcAra.Click += new System.EventHandler(this.LblTcAra_Click);
            // 
            // FormMüşteriListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(876, 450);
            this.Controls.Add(this.LblTcAra);
            this.Controls.Add(this.TxtTcAra);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnGuncelle);
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
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormMüşteriListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Listeleme Sayfası";
            this.Load += new System.EventHandler(this.FormMüşteriListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtAdres;
        private System.Windows.Forms.TextBox TxtTelefon;
        private System.Windows.Forms.TextBox TxtAdSoyad;
        private System.Windows.Forms.TextBox TxtTc;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblAdres;
        private System.Windows.Forms.Label LblTelefon;
        private System.Windows.Forms.Label LblAdSoyad;
        private System.Windows.Forms.Label LblTc;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.TextBox TxtTcAra;
        private System.Windows.Forms.Label LblTcAra;
    }
}