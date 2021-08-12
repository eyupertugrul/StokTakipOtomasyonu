using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipOtomasyonu
{
    public partial class FormSatis : Form
    {
        public FormSatis()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Stok_Takip;Integrated Security=True");
        DataSet daSet = new DataSet();
        private void SepetListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from sepet ", baglanti);
            adtr.Fill(daSet,"sepet");
            dataGridView1.DataSource = daSet.Tables["sepet"];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            baglanti.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (TxtTc.Text=="")
            {
                TxtAdSoyad.Text = "";
                TxtTelefon.Text = "";
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from müşteri where tc like'"+TxtTc.Text+"'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                TxtAdSoyad.Text = read["adsoyad"].ToString();
                TxtTelefon.Text = read["telefon"].ToString();
            }
            baglanti.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BtnMusteri_Click(object sender, EventArgs e)
        {
            FormMusteriEkle ekle = new FormMusteriEkle();
            ekle.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void BtnMusList_Click(object sender, EventArgs e)
        {
            FormMüşteriListele listele = new FormMüşteriListele();
            listele.ShowDialog();
        }

        private void BtnUrunEkl_Click(object sender, EventArgs e)
        {
            FormUrunEkle ekle = new FormUrunEkle();
            ekle.ShowDialog();
        }

        private void BtnKategori_Click(object sender, EventArgs e)
        {
            FormKategori kategori = new FormKategori();
            kategori.ShowDialog();
        }

        private void BtnMarka_Click(object sender, EventArgs e)
        {
            FormMarka marka = new FormMarka();
            marka.ShowDialog();
        }

        private void BtnUrunList_Click(object sender, EventArgs e)
        {
            FormUrunListele listele = new FormUrunListele();
            listele.ShowDialog();
        }
        private void hesapla()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select sum(toplamfiyati) from sepet", baglanti);
                LblGenelToplam.Text = komut.ExecuteScalar() + " TL ";
                baglanti.Close();
            }
            catch (Exception)
            {

                ;
            }
            
        }

        private void FormSatis_Load(object sender, EventArgs e)
        {
            SepetListele();
        }

        private void TxtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            baglanti.Close();
            Temizle();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from urun where barkodno like'" + TxtBarkodNo.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                TxtUrunAdi.Text = read["urunadi"].ToString();
                TxtSatisFiyati.Text = read["satisfiyati"].ToString();
            }
            baglanti.Close();
            

        }

        private void Temizle()
        {
            if (TxtBarkodNo.Text == "")
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != TxtUrunMiktari)
                        {
                            item.Text = "";
                        }
                    }
                }
            }
        }
        bool durum;
        private void barkodKontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from sepet", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (TxtBarkodNo.Text==read["barkodno"].ToString())
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            barkodKontrol();
            if (durum==true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into sepet(tc,adsoyad,telefon,barkodno,urunadi,miktari,satisfiyati,toplamfiyati,tarih) " +
                    "values(@tc,@adsoyad,@telefon,@barkodno,@urunadi,@miktari,@satisfiyati,@toplamfiyati,@tarih)", baglanti);
                komut.Parameters.AddWithValue("@tc", TxtTc.Text);
                komut.Parameters.AddWithValue("@adsoyad", TxtAdSoyad.Text);
                komut.Parameters.AddWithValue("@telefon", TxtTelefon.Text);
                komut.Parameters.AddWithValue("@barkodno", TxtBarkodNo.Text);
                komut.Parameters.AddWithValue("@urunadi", TxtUrunAdi.Text);
                komut.Parameters.AddWithValue("@miktari", int.Parse(TxtUrunMiktari.Text));
                komut.Parameters.AddWithValue("@satisfiyati", double.Parse(TxtSatisFiyati.Text));
                komut.Parameters.AddWithValue("@toplamfiyati", double.Parse(TxtToplamFiyat.Text));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            else
            {
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update sepet miktari=miktari+'"+int.Parse(TxtUrunMiktari.Text)+ "'where barkodno='" + TxtBarkodNo.Text + "'", baglanti);
                komut2.ExecuteNonQuery();
                SqlCommand komut3 = new SqlCommand("update sepet toplamfiyat=miktari*satisfiyati where barkodno='"+TxtBarkodNo.Text+"'", baglanti);
                komut3.ExecuteNonQuery();
                baglanti.Close();
            }
            TxtUrunMiktari.Text = "1";
            daSet.Tables["sepet"].Clear();
            SepetListele();
            hesapla();
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    if (item != TxtUrunMiktari)
                    {
                        item.Text = "";
                    }
                }
            }


        }
        private void TxtUrunMiktari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TxtToplamFiyat.Text = (double.Parse(TxtUrunMiktari.Text) * double.Parse(TxtSatisFiyati.Text)).ToString();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void TxtSatisFiyati_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TxtToplamFiyat.Text = (double.Parse(TxtUrunMiktari.Text) * double.Parse(TxtSatisFiyati.Text)).ToString();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sepet where barkodno='"+dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString()+"'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün Sepetten Çıkarıldı");
            daSet.Tables["sepet"].Clear();
            SepetListele();
            hesapla();
        }

        private void BtnSatisİptal_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sepet", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürünler Sepetten Çıkarıldı");
            daSet.Tables["sepet"].Clear();
            SepetListele();
            hesapla();
        }

        private void BtnSatList_Click(object sender, EventArgs e)
        {
            FormSatisListele listele = new FormSatisListele();
            listele.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnSatisYap_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into satis(tc,adsoyad,telefon,barkodno,urunadi,miktari,satisfiyati,toplamfiyati,tarih) " +
                    "values(@tc,@adsoyad,@telefon,@barkodno,@urunadi,@miktari,@satisfiyati,@toplamfiyati,@tarih)", baglanti);
                komut.Parameters.AddWithValue("@tc", TxtTc.Text);
                komut.Parameters.AddWithValue("@adsoyad", TxtAdSoyad.Text);
                komut.Parameters.AddWithValue("@telefon", TxtTelefon.Text);
                komut.Parameters.AddWithValue("@barkodno", dataGridView1.Rows[i].Cells["barkodno"].Value.ToString());
                komut.Parameters.AddWithValue("@urunadi", dataGridView1.Rows[i].Cells["urunadi"].Value.ToString());
                komut.Parameters.AddWithValue("@miktari", int.Parse(dataGridView1.Rows[i].Cells["miktari"].Value.ToString()));
                komut.Parameters.AddWithValue("@satisfiyati", double.Parse(dataGridView1.Rows[i].Cells["satisfiyati"].Value.ToString()));
                komut.Parameters.AddWithValue("@toplamfiyati", double.Parse(dataGridView1.Rows[i].Cells["toplamfiyati"].Value.ToString()));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                SqlCommand komut2 = new SqlCommand("update urun set miktari=miktari-'" + int.Parse(dataGridView1.Rows[i].Cells["miktari"].Value.ToString()) + "' where barkodno='" + dataGridView1.Rows[i].Cells["barkodno"].Value.ToString() + "'", baglanti);
                komut2.ExecuteNonQuery();
                baglanti.Close();
            }
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("delete from sepet", baglanti);
            komut3.ExecuteNonQuery();
            baglanti.Close();
            daSet.Tables["sepet"].Clear();
            SepetListele();
            hesapla();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void LblGenelToplam_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void TxtToplamFiyat_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtUrunAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void TxtAdSoyad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
