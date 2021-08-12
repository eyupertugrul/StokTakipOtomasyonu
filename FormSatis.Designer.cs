
namespace StokTakipOtomasyonu
{
    partial class FormSatis
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.LblTelefon = new System.Windows.Forms.Label();
            this.LblAdSoyad = new System.Windows.Forms.Label();
            this.LblTc = new System.Windows.Forms.Label();
            this.TxtTelefon = new System.Windows.Forms.TextBox();
            this.TxtAdSoyad = new System.Windows.Forms.TextBox();
            this.TxtTc = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LblToplamFiyat = new System.Windows.Forms.Label();
            this.LblSatisFiyati = new System.Windows.Forms.Label();
            this.LblUrunMiktarı = new System.Windows.Forms.Label();
            this.LblUrunAdı = new System.Windows.Forms.Label();
            this.LblBarkodNo = new System.Windows.Forms.Label();
            this.TxtToplamFiyat = new System.Windows.Forms.TextBox();
            this.TxtSatisFiyati = new System.Windows.Forms.TextBox();
            this.TxtUrunMiktari = new System.Windows.Forms.TextBox();
            this.TxtUrunAdi = new System.Windows.Forms.TextBox();
            this.TxtBarkodNo = new System.Windows.Forms.TextBox();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnSatisİptal = new System.Windows.Forms.Button();
            this.BtnSatisYap = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.LblGenelToplam = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnMarka = new System.Windows.Forms.Button();
            this.BtnKategori = new System.Windows.Forms.Button();
            this.BtnSatList = new System.Windows.Forms.Button();
            this.BtnUrunList = new System.Windows.Forms.Button();
            this.BtnUrunEkl = new System.Windows.Forms.Button();
            this.BtnMusList = new System.Windows.Forms.Button();
            this.BtnMusteri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(292, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(594, 271);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.LblTelefon);
            this.groupBox1.Controls.Add(this.LblAdSoyad);
            this.groupBox1.Controls.Add(this.LblTc);
            this.groupBox1.Controls.Add(this.TxtTelefon);
            this.groupBox1.Controls.Add(this.TxtAdSoyad);
            this.groupBox1.Controls.Add(this.TxtTc);
            this.groupBox1.Location = new System.Drawing.Point(15, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 107);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri İşlemleri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(139, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 6;
            // 
            // LblTelefon
            // 
            this.LblTelefon.AutoSize = true;
            this.LblTelefon.Location = new System.Drawing.Point(19, 68);
            this.LblTelefon.Name = "LblTelefon";
            this.LblTelefon.Size = new System.Drawing.Size(43, 13);
            this.LblTelefon.TabIndex = 5;
            this.LblTelefon.Text = "Telefon";
            // 
            // LblAdSoyad
            // 
            this.LblAdSoyad.AutoSize = true;
            this.LblAdSoyad.Location = new System.Drawing.Point(19, 42);
            this.LblAdSoyad.Name = "LblAdSoyad";
            this.LblAdSoyad.Size = new System.Drawing.Size(53, 13);
            this.LblAdSoyad.TabIndex = 4;
            this.LblAdSoyad.Text = "Ad Soyad";
            // 
            // LblTc
            // 
            this.LblTc.AutoSize = true;
            this.LblTc.Location = new System.Drawing.Point(19, 16);
            this.LblTc.Name = "LblTc";
            this.LblTc.Size = new System.Drawing.Size(21, 13);
            this.LblTc.TabIndex = 3;
            this.LblTc.Text = "TC";
            // 
            // TxtTelefon
            // 
            this.TxtTelefon.Location = new System.Drawing.Point(104, 65);
            this.TxtTelefon.Name = "TxtTelefon";
            this.TxtTelefon.Size = new System.Drawing.Size(100, 20);
            this.TxtTelefon.TabIndex = 2;
            this.TxtTelefon.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // TxtAdSoyad
            // 
            this.TxtAdSoyad.Location = new System.Drawing.Point(104, 39);
            this.TxtAdSoyad.Name = "TxtAdSoyad";
            this.TxtAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.TxtAdSoyad.TabIndex = 1;
            this.TxtAdSoyad.TextChanged += new System.EventHandler(this.TxtAdSoyad_TextChanged);
            // 
            // TxtTc
            // 
            this.TxtTc.Location = new System.Drawing.Point(104, 13);
            this.TxtTc.Name = "TxtTc";
            this.TxtTc.Size = new System.Drawing.Size(100, 20);
            this.TxtTc.TabIndex = 0;
            this.TxtTc.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LblToplamFiyat);
            this.groupBox2.Controls.Add(this.LblSatisFiyati);
            this.groupBox2.Controls.Add(this.LblUrunMiktarı);
            this.groupBox2.Controls.Add(this.LblUrunAdı);
            this.groupBox2.Controls.Add(this.LblBarkodNo);
            this.groupBox2.Controls.Add(this.TxtToplamFiyat);
            this.groupBox2.Controls.Add(this.TxtSatisFiyati);
            this.groupBox2.Controls.Add(this.TxtUrunMiktari);
            this.groupBox2.Controls.Add(this.TxtUrunAdi);
            this.groupBox2.Controls.Add(this.TxtBarkodNo);
            this.groupBox2.Location = new System.Drawing.Point(15, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 151);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün İşlemleri";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // LblToplamFiyat
            // 
            this.LblToplamFiyat.AutoSize = true;
            this.LblToplamFiyat.Location = new System.Drawing.Point(19, 127);
            this.LblToplamFiyat.Name = "LblToplamFiyat";
            this.LblToplamFiyat.Size = new System.Drawing.Size(67, 13);
            this.LblToplamFiyat.TabIndex = 9;
            this.LblToplamFiyat.Text = "Toplam Fiyat";
            this.LblToplamFiyat.Click += new System.EventHandler(this.label8_Click);
            // 
            // LblSatisFiyati
            // 
            this.LblSatisFiyati.AutoSize = true;
            this.LblSatisFiyati.Location = new System.Drawing.Point(19, 100);
            this.LblSatisFiyati.Name = "LblSatisFiyati";
            this.LblSatisFiyati.Size = new System.Drawing.Size(57, 13);
            this.LblSatisFiyati.TabIndex = 8;
            this.LblSatisFiyati.Text = "Satış Fiyatı";
            // 
            // LblUrunMiktarı
            // 
            this.LblUrunMiktarı.AutoSize = true;
            this.LblUrunMiktarı.Location = new System.Drawing.Point(19, 74);
            this.LblUrunMiktarı.Name = "LblUrunMiktarı";
            this.LblUrunMiktarı.Size = new System.Drawing.Size(38, 13);
            this.LblUrunMiktarı.TabIndex = 7;
            this.LblUrunMiktarı.Text = "Miktarı";
            // 
            // LblUrunAdı
            // 
            this.LblUrunAdı.AutoSize = true;
            this.LblUrunAdı.Location = new System.Drawing.Point(19, 49);
            this.LblUrunAdı.Name = "LblUrunAdı";
            this.LblUrunAdı.Size = new System.Drawing.Size(48, 13);
            this.LblUrunAdı.TabIndex = 6;
            this.LblUrunAdı.Text = "Ürün Adı";
            // 
            // LblBarkodNo
            // 
            this.LblBarkodNo.AutoSize = true;
            this.LblBarkodNo.Location = new System.Drawing.Point(19, 22);
            this.LblBarkodNo.Name = "LblBarkodNo";
            this.LblBarkodNo.Size = new System.Drawing.Size(58, 13);
            this.LblBarkodNo.TabIndex = 5;
            this.LblBarkodNo.Text = "Barkod No";
            this.LblBarkodNo.Click += new System.EventHandler(this.label4_Click);
            // 
            // TxtToplamFiyat
            // 
            this.TxtToplamFiyat.Location = new System.Drawing.Point(104, 124);
            this.TxtToplamFiyat.Name = "TxtToplamFiyat";
            this.TxtToplamFiyat.Size = new System.Drawing.Size(100, 20);
            this.TxtToplamFiyat.TabIndex = 4;
            this.TxtToplamFiyat.TextChanged += new System.EventHandler(this.TxtToplamFiyat_TextChanged);
            // 
            // TxtSatisFiyati
            // 
            this.TxtSatisFiyati.Location = new System.Drawing.Point(104, 97);
            this.TxtSatisFiyati.Name = "TxtSatisFiyati";
            this.TxtSatisFiyati.Size = new System.Drawing.Size(100, 20);
            this.TxtSatisFiyati.TabIndex = 3;
            this.TxtSatisFiyati.TextChanged += new System.EventHandler(this.TxtSatisFiyati_TextChanged);
            // 
            // TxtUrunMiktari
            // 
            this.TxtUrunMiktari.Location = new System.Drawing.Point(104, 71);
            this.TxtUrunMiktari.Name = "TxtUrunMiktari";
            this.TxtUrunMiktari.Size = new System.Drawing.Size(100, 20);
            this.TxtUrunMiktari.TabIndex = 2;
            this.TxtUrunMiktari.Text = "1";
            this.TxtUrunMiktari.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtUrunMiktari.TextChanged += new System.EventHandler(this.TxtUrunMiktari_TextChanged);
            // 
            // TxtUrunAdi
            // 
            this.TxtUrunAdi.Location = new System.Drawing.Point(104, 46);
            this.TxtUrunAdi.Name = "TxtUrunAdi";
            this.TxtUrunAdi.Size = new System.Drawing.Size(100, 20);
            this.TxtUrunAdi.TabIndex = 1;
            this.TxtUrunAdi.TextChanged += new System.EventHandler(this.TxtUrunAdi_TextChanged);
            // 
            // TxtBarkodNo
            // 
            this.TxtBarkodNo.Location = new System.Drawing.Point(104, 19);
            this.TxtBarkodNo.Name = "TxtBarkodNo";
            this.TxtBarkodNo.Size = new System.Drawing.Size(100, 20);
            this.TxtBarkodNo.TabIndex = 0;
            this.TxtBarkodNo.TextChanged += new System.EventHandler(this.TxtBarkodNo_TextChanged);
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(292, 409);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(75, 23);
            this.BtnEkle.TabIndex = 3;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(912, 120);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(75, 23);
            this.BtnSil.TabIndex = 4;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnSatisİptal
            // 
            this.BtnSatisİptal.Location = new System.Drawing.Point(912, 162);
            this.BtnSatisİptal.Name = "BtnSatisİptal";
            this.BtnSatisİptal.Size = new System.Drawing.Size(75, 23);
            this.BtnSatisİptal.TabIndex = 5;
            this.BtnSatisİptal.Text = "Satış İptal";
            this.BtnSatisİptal.UseVisualStyleBackColor = true;
            this.BtnSatisİptal.Click += new System.EventHandler(this.BtnSatisİptal_Click);
            // 
            // BtnSatisYap
            // 
            this.BtnSatisYap.Location = new System.Drawing.Point(811, 409);
            this.BtnSatisYap.Name = "BtnSatisYap";
            this.BtnSatisYap.Size = new System.Drawing.Size(75, 23);
            this.BtnSatisYap.TabIndex = 6;
            this.BtnSatisYap.Text = "Satış Yap";
            this.BtnSatisYap.UseVisualStyleBackColor = true;
            this.BtnSatisYap.Click += new System.EventHandler(this.BtnSatisYap_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(580, 419);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Genel Toplam";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // LblGenelToplam
            // 
            this.LblGenelToplam.AutoSize = true;
            this.LblGenelToplam.Location = new System.Drawing.Point(673, 419);
            this.LblGenelToplam.Name = "LblGenelToplam";
            this.LblGenelToplam.Size = new System.Drawing.Size(0, 13);
            this.LblGenelToplam.TabIndex = 8;
            this.LblGenelToplam.Click += new System.EventHandler(this.LblGenelToplam_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnMarka);
            this.panel1.Controls.Add(this.BtnKategori);
            this.panel1.Controls.Add(this.BtnSatList);
            this.panel1.Controls.Add(this.BtnUrunList);
            this.panel1.Controls.Add(this.BtnUrunEkl);
            this.panel1.Controls.Add(this.BtnMusList);
            this.panel1.Controls.Add(this.BtnMusteri);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 81);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BtnMarka
            // 
            this.BtnMarka.Location = new System.Drawing.Point(882, 22);
            this.BtnMarka.Name = "BtnMarka";
            this.BtnMarka.Size = new System.Drawing.Size(88, 42);
            this.BtnMarka.TabIndex = 6;
            this.BtnMarka.Text = "Marka";
            this.BtnMarka.UseVisualStyleBackColor = true;
            this.BtnMarka.Click += new System.EventHandler(this.BtnMarka_Click);
            // 
            // BtnKategori
            // 
            this.BtnKategori.Location = new System.Drawing.Point(745, 22);
            this.BtnKategori.Name = "BtnKategori";
            this.BtnKategori.Size = new System.Drawing.Size(88, 42);
            this.BtnKategori.TabIndex = 5;
            this.BtnKategori.Text = "Kategori";
            this.BtnKategori.UseVisualStyleBackColor = true;
            this.BtnKategori.Click += new System.EventHandler(this.BtnKategori_Click);
            // 
            // BtnSatList
            // 
            this.BtnSatList.Location = new System.Drawing.Point(603, 22);
            this.BtnSatList.Name = "BtnSatList";
            this.BtnSatList.Size = new System.Drawing.Size(88, 42);
            this.BtnSatList.TabIndex = 4;
            this.BtnSatList.Text = "Satışları Listele";
            this.BtnSatList.UseVisualStyleBackColor = true;
            this.BtnSatList.Click += new System.EventHandler(this.BtnSatList_Click);
            // 
            // BtnUrunList
            // 
            this.BtnUrunList.Location = new System.Drawing.Point(458, 22);
            this.BtnUrunList.Name = "BtnUrunList";
            this.BtnUrunList.Size = new System.Drawing.Size(88, 42);
            this.BtnUrunList.TabIndex = 3;
            this.BtnUrunList.Text = "Ürün Listeleme";
            this.BtnUrunList.UseVisualStyleBackColor = true;
            this.BtnUrunList.Click += new System.EventHandler(this.BtnUrunList_Click);
            // 
            // BtnUrunEkl
            // 
            this.BtnUrunEkl.Location = new System.Drawing.Point(307, 22);
            this.BtnUrunEkl.Name = "BtnUrunEkl";
            this.BtnUrunEkl.Size = new System.Drawing.Size(88, 42);
            this.BtnUrunEkl.TabIndex = 2;
            this.BtnUrunEkl.Text = "Ürün Ekleme";
            this.BtnUrunEkl.UseVisualStyleBackColor = true;
            this.BtnUrunEkl.Click += new System.EventHandler(this.BtnUrunEkl_Click);
            // 
            // BtnMusList
            // 
            this.BtnMusList.Location = new System.Drawing.Point(157, 22);
            this.BtnMusList.Name = "BtnMusList";
            this.BtnMusList.Size = new System.Drawing.Size(88, 42);
            this.BtnMusList.TabIndex = 1;
            this.BtnMusList.Text = "Müşteri Listeleme";
            this.BtnMusList.UseVisualStyleBackColor = true;
            this.BtnMusList.Click += new System.EventHandler(this.BtnMusList_Click);
            // 
            // BtnMusteri
            // 
            this.BtnMusteri.Location = new System.Drawing.Point(15, 22);
            this.BtnMusteri.Name = "BtnMusteri";
            this.BtnMusteri.Size = new System.Drawing.Size(88, 42);
            this.BtnMusteri.TabIndex = 0;
            this.BtnMusteri.Text = "Müşteri Ekleme";
            this.BtnMusteri.UseVisualStyleBackColor = true;
            this.BtnMusteri.Click += new System.EventHandler(this.BtnMusteri_Click);
            // 
            // FormSatis
            // 
            this.AcceptButton = this.BtnEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(997, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblGenelToplam);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BtnSatisYap);
            this.Controls.Add(this.BtnSatisİptal);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Sayfası";
            this.Load += new System.EventHandler(this.FormSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblTelefon;
        private System.Windows.Forms.Label LblAdSoyad;
        private System.Windows.Forms.Label LblTc;
        private System.Windows.Forms.TextBox TxtTelefon;
        private System.Windows.Forms.TextBox TxtAdSoyad;
        private System.Windows.Forms.TextBox TxtTc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LblToplamFiyat;
        private System.Windows.Forms.Label LblSatisFiyati;
        private System.Windows.Forms.Label LblUrunMiktarı;
        private System.Windows.Forms.Label LblUrunAdı;
        private System.Windows.Forms.Label LblBarkodNo;
        private System.Windows.Forms.TextBox TxtToplamFiyat;
        private System.Windows.Forms.TextBox TxtSatisFiyati;
        private System.Windows.Forms.TextBox TxtUrunMiktari;
        private System.Windows.Forms.TextBox TxtUrunAdi;
        private System.Windows.Forms.TextBox TxtBarkodNo;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnSatisİptal;
        private System.Windows.Forms.Button BtnSatisYap;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LblGenelToplam;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnSatList;
        private System.Windows.Forms.Button BtnUrunList;
        private System.Windows.Forms.Button BtnUrunEkl;
        private System.Windows.Forms.Button BtnMusList;
        private System.Windows.Forms.Button BtnMusteri;
        private System.Windows.Forms.Button BtnMarka;
        private System.Windows.Forms.Button BtnKategori;
    }
}

