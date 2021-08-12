
namespace StokTakipOtomasyonu
{
    partial class FormUrunListele
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
            this.TxtVarolanUrunSatisFiyati = new System.Windows.Forms.TextBox();
            this.BtnGüncelle = new System.Windows.Forms.Button();
            this.LblVarolanUrunSatisFiyati = new System.Windows.Forms.Label();
            this.LblVarolanUrunAlisFiyati = new System.Windows.Forms.Label();
            this.LblVarolanUrunMiktar = new System.Windows.Forms.Label();
            this.LblVarolanUrunUrunAdi = new System.Windows.Forms.Label();
            this.LblVarolanUrunMarka = new System.Windows.Forms.Label();
            this.LblVarolanUrunKategori = new System.Windows.Forms.Label();
            this.LblBarkodNoVarolanUrun = new System.Windows.Forms.Label();
            this.TxtVarolanUrunBarkodNo = new System.Windows.Forms.TextBox();
            this.TxtVarolanUrunMarka = new System.Windows.Forms.TextBox();
            this.TxtVarolanUrunKategori = new System.Windows.Forms.TextBox();
            this.TxtVarolanUrunUrunAdi = new System.Windows.Forms.TextBox();
            this.TxtVarolanUrunMiktari = new System.Windows.Forms.TextBox();
            this.TxtVarolanUrunAlisFiyati = new System.Windows.Forms.TextBox();
            this.BtnSil = new System.Windows.Forms.Button();
            this.lblBarkodNoyaGoreAra = new System.Windows.Forms.Label();
            this.TxtBarkodNoAra = new System.Windows.Forms.TextBox();
            this.cBKategori = new System.Windows.Forms.ComboBox();
            this.cBMarka = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnMarkaGüncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(203, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(514, 221);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // TxtVarolanUrunSatisFiyati
            // 
            this.TxtVarolanUrunSatisFiyati.Location = new System.Drawing.Point(82, 265);
            this.TxtVarolanUrunSatisFiyati.Name = "TxtVarolanUrunSatisFiyati";
            this.TxtVarolanUrunSatisFiyati.Size = new System.Drawing.Size(100, 20);
            this.TxtVarolanUrunSatisFiyati.TabIndex = 28;
            // 
            // BtnGüncelle
            // 
            this.BtnGüncelle.Location = new System.Drawing.Point(107, 298);
            this.BtnGüncelle.Name = "BtnGüncelle";
            this.BtnGüncelle.Size = new System.Drawing.Size(75, 23);
            this.BtnGüncelle.TabIndex = 16;
            this.BtnGüncelle.Text = "Güncelle";
            this.BtnGüncelle.UseVisualStyleBackColor = true;
            this.BtnGüncelle.Click += new System.EventHandler(this.BtnGüncelle_Click);
            // 
            // LblVarolanUrunSatisFiyati
            // 
            this.LblVarolanUrunSatisFiyati.AutoSize = true;
            this.LblVarolanUrunSatisFiyati.Location = new System.Drawing.Point(12, 271);
            this.LblVarolanUrunSatisFiyati.Name = "LblVarolanUrunSatisFiyati";
            this.LblVarolanUrunSatisFiyati.Size = new System.Drawing.Size(57, 13);
            this.LblVarolanUrunSatisFiyati.TabIndex = 27;
            this.LblVarolanUrunSatisFiyati.Text = "Satış Fiyatı";
            // 
            // LblVarolanUrunAlisFiyati
            // 
            this.LblVarolanUrunAlisFiyati.AutoSize = true;
            this.LblVarolanUrunAlisFiyati.Location = new System.Drawing.Point(12, 237);
            this.LblVarolanUrunAlisFiyati.Name = "LblVarolanUrunAlisFiyati";
            this.LblVarolanUrunAlisFiyati.Size = new System.Drawing.Size(50, 13);
            this.LblVarolanUrunAlisFiyati.TabIndex = 26;
            this.LblVarolanUrunAlisFiyati.Text = "Alış Fiyatı";
            // 
            // LblVarolanUrunMiktar
            // 
            this.LblVarolanUrunMiktar.AutoSize = true;
            this.LblVarolanUrunMiktar.Location = new System.Drawing.Point(12, 203);
            this.LblVarolanUrunMiktar.Name = "LblVarolanUrunMiktar";
            this.LblVarolanUrunMiktar.Size = new System.Drawing.Size(38, 13);
            this.LblVarolanUrunMiktar.TabIndex = 25;
            this.LblVarolanUrunMiktar.Text = "Miktarı";
            // 
            // LblVarolanUrunUrunAdi
            // 
            this.LblVarolanUrunUrunAdi.AutoSize = true;
            this.LblVarolanUrunUrunAdi.Location = new System.Drawing.Point(12, 169);
            this.LblVarolanUrunUrunAdi.Name = "LblVarolanUrunUrunAdi";
            this.LblVarolanUrunUrunAdi.Size = new System.Drawing.Size(48, 13);
            this.LblVarolanUrunUrunAdi.TabIndex = 24;
            this.LblVarolanUrunUrunAdi.Text = "Ürün Adı";
            // 
            // LblVarolanUrunMarka
            // 
            this.LblVarolanUrunMarka.AutoSize = true;
            this.LblVarolanUrunMarka.Location = new System.Drawing.Point(12, 129);
            this.LblVarolanUrunMarka.Name = "LblVarolanUrunMarka";
            this.LblVarolanUrunMarka.Size = new System.Drawing.Size(37, 13);
            this.LblVarolanUrunMarka.TabIndex = 23;
            this.LblVarolanUrunMarka.Text = "Marka";
            // 
            // LblVarolanUrunKategori
            // 
            this.LblVarolanUrunKategori.AutoSize = true;
            this.LblVarolanUrunKategori.Location = new System.Drawing.Point(12, 100);
            this.LblVarolanUrunKategori.Name = "LblVarolanUrunKategori";
            this.LblVarolanUrunKategori.Size = new System.Drawing.Size(46, 13);
            this.LblVarolanUrunKategori.TabIndex = 22;
            this.LblVarolanUrunKategori.Text = "Kategori";
            // 
            // LblBarkodNoVarolanUrun
            // 
            this.LblBarkodNoVarolanUrun.AutoSize = true;
            this.LblBarkodNoVarolanUrun.Location = new System.Drawing.Point(12, 67);
            this.LblBarkodNoVarolanUrun.Name = "LblBarkodNoVarolanUrun";
            this.LblBarkodNoVarolanUrun.Size = new System.Drawing.Size(58, 13);
            this.LblBarkodNoVarolanUrun.TabIndex = 21;
            this.LblBarkodNoVarolanUrun.Text = "Barkod No";
            // 
            // TxtVarolanUrunBarkodNo
            // 
            this.TxtVarolanUrunBarkodNo.Location = new System.Drawing.Point(82, 67);
            this.TxtVarolanUrunBarkodNo.Name = "TxtVarolanUrunBarkodNo";
            this.TxtVarolanUrunBarkodNo.Size = new System.Drawing.Size(100, 20);
            this.TxtVarolanUrunBarkodNo.TabIndex = 14;
            // 
            // TxtVarolanUrunMarka
            // 
            this.TxtVarolanUrunMarka.Location = new System.Drawing.Point(82, 133);
            this.TxtVarolanUrunMarka.Name = "TxtVarolanUrunMarka";
            this.TxtVarolanUrunMarka.ReadOnly = true;
            this.TxtVarolanUrunMarka.Size = new System.Drawing.Size(100, 20);
            this.TxtVarolanUrunMarka.TabIndex = 15;
            // 
            // TxtVarolanUrunKategori
            // 
            this.TxtVarolanUrunKategori.Location = new System.Drawing.Point(82, 100);
            this.TxtVarolanUrunKategori.Name = "TxtVarolanUrunKategori";
            this.TxtVarolanUrunKategori.ReadOnly = true;
            this.TxtVarolanUrunKategori.Size = new System.Drawing.Size(100, 20);
            this.TxtVarolanUrunKategori.TabIndex = 20;
            // 
            // TxtVarolanUrunUrunAdi
            // 
            this.TxtVarolanUrunUrunAdi.Location = new System.Drawing.Point(82, 166);
            this.TxtVarolanUrunUrunAdi.Name = "TxtVarolanUrunUrunAdi";
            this.TxtVarolanUrunUrunAdi.Size = new System.Drawing.Size(100, 20);
            this.TxtVarolanUrunUrunAdi.TabIndex = 17;
            // 
            // TxtVarolanUrunMiktari
            // 
            this.TxtVarolanUrunMiktari.Location = new System.Drawing.Point(82, 199);
            this.TxtVarolanUrunMiktari.Name = "TxtVarolanUrunMiktari";
            this.TxtVarolanUrunMiktari.Size = new System.Drawing.Size(100, 20);
            this.TxtVarolanUrunMiktari.TabIndex = 18;
            // 
            // TxtVarolanUrunAlisFiyati
            // 
            this.TxtVarolanUrunAlisFiyati.Location = new System.Drawing.Point(82, 232);
            this.TxtVarolanUrunAlisFiyati.Name = "TxtVarolanUrunAlisFiyati";
            this.TxtVarolanUrunAlisFiyati.Size = new System.Drawing.Size(100, 20);
            this.TxtVarolanUrunAlisFiyati.TabIndex = 19;
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(729, 64);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(75, 23);
            this.BtnSil.TabIndex = 29;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // lblBarkodNoyaGoreAra
            // 
            this.lblBarkodNoyaGoreAra.AutoSize = true;
            this.lblBarkodNoyaGoreAra.Location = new System.Drawing.Point(285, 27);
            this.lblBarkodNoyaGoreAra.Name = "lblBarkodNoyaGoreAra";
            this.lblBarkodNoyaGoreAra.Size = new System.Drawing.Size(116, 13);
            this.lblBarkodNoyaGoreAra.TabIndex = 30;
            this.lblBarkodNoyaGoreAra.Text = "Barkod No\'ya Göre Ara";
            // 
            // TxtBarkodNoAra
            // 
            this.TxtBarkodNoAra.Location = new System.Drawing.Point(424, 24);
            this.TxtBarkodNoAra.Name = "TxtBarkodNoAra";
            this.TxtBarkodNoAra.Size = new System.Drawing.Size(100, 20);
            this.TxtBarkodNoAra.TabIndex = 31;
            this.TxtBarkodNoAra.TextChanged += new System.EventHandler(this.TxtBarkodNoAra_TextChanged);
            // 
            // cBKategori
            // 
            this.cBKategori.FormattingEnabled = true;
            this.cBKategori.Location = new System.Drawing.Point(403, 301);
            this.cBKategori.Name = "cBKategori";
            this.cBKategori.Size = new System.Drawing.Size(121, 21);
            this.cBKategori.TabIndex = 32;
            this.cBKategori.SelectedIndexChanged += new System.EventHandler(this.cBKategori_SelectedIndexChanged);
            // 
            // cBMarka
            // 
            this.cBMarka.FormattingEnabled = true;
            this.cBMarka.Location = new System.Drawing.Point(403, 336);
            this.cBMarka.Name = "cBMarka";
            this.cBMarka.Size = new System.Drawing.Size(121, 21);
            this.cBMarka.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Marka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Kategori";
            // 
            // BtnMarkaGüncelle
            // 
            this.BtnMarkaGüncelle.Location = new System.Drawing.Point(449, 363);
            this.BtnMarkaGüncelle.Name = "BtnMarkaGüncelle";
            this.BtnMarkaGüncelle.Size = new System.Drawing.Size(75, 23);
            this.BtnMarkaGüncelle.TabIndex = 36;
            this.BtnMarkaGüncelle.Text = "Güncelle";
            this.BtnMarkaGüncelle.UseVisualStyleBackColor = true;
            this.BtnMarkaGüncelle.Click += new System.EventHandler(this.BtnMarkaGüncelle_Click);
            // 
            // FormÜrünListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(816, 450);
            this.Controls.Add(this.BtnMarkaGüncelle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBMarka);
            this.Controls.Add(this.cBKategori);
            this.Controls.Add(this.TxtBarkodNoAra);
            this.Controls.Add(this.lblBarkodNoyaGoreAra);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.TxtVarolanUrunSatisFiyati);
            this.Controls.Add(this.BtnGüncelle);
            this.Controls.Add(this.LblVarolanUrunSatisFiyati);
            this.Controls.Add(this.LblVarolanUrunAlisFiyati);
            this.Controls.Add(this.LblVarolanUrunMiktar);
            this.Controls.Add(this.LblVarolanUrunUrunAdi);
            this.Controls.Add(this.LblVarolanUrunMarka);
            this.Controls.Add(this.LblVarolanUrunKategori);
            this.Controls.Add(this.LblBarkodNoVarolanUrun);
            this.Controls.Add(this.TxtVarolanUrunBarkodNo);
            this.Controls.Add(this.TxtVarolanUrunMarka);
            this.Controls.Add(this.TxtVarolanUrunKategori);
            this.Controls.Add(this.TxtVarolanUrunUrunAdi);
            this.Controls.Add(this.TxtVarolanUrunMiktari);
            this.Controls.Add(this.TxtVarolanUrunAlisFiyati);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormÜrünListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Listeleme Sayfası";
            this.Load += new System.EventHandler(this.FormÜrünListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TxtVarolanUrunSatisFiyati;
        private System.Windows.Forms.Button BtnGüncelle;
        private System.Windows.Forms.Label LblVarolanUrunSatisFiyati;
        private System.Windows.Forms.Label LblVarolanUrunAlisFiyati;
        private System.Windows.Forms.Label LblVarolanUrunMiktar;
        private System.Windows.Forms.Label LblVarolanUrunUrunAdi;
        private System.Windows.Forms.Label LblVarolanUrunMarka;
        private System.Windows.Forms.Label LblVarolanUrunKategori;
        private System.Windows.Forms.Label LblBarkodNoVarolanUrun;
        private System.Windows.Forms.TextBox TxtVarolanUrunBarkodNo;
        private System.Windows.Forms.TextBox TxtVarolanUrunMarka;
        private System.Windows.Forms.TextBox TxtVarolanUrunKategori;
        private System.Windows.Forms.TextBox TxtVarolanUrunUrunAdi;
        private System.Windows.Forms.TextBox TxtVarolanUrunMiktari;
        private System.Windows.Forms.TextBox TxtVarolanUrunAlisFiyati;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Label lblBarkodNoyaGoreAra;
        private System.Windows.Forms.TextBox TxtBarkodNoAra;
        private System.Windows.Forms.ComboBox cBKategori;
        private System.Windows.Forms.ComboBox cBMarka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnMarkaGüncelle;
    }
}