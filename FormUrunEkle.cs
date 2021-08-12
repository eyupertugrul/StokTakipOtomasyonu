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
    public partial class FormUrunEkle : Form
    {
        public FormUrunEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Stok_Takip;Integrated Security=True");

        bool durum;

        private void barkodKontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from urun", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (TxtBarkodNo.Text==read["barkodno"].ToString() || TxtBarkodNo.Text == "")
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }
        private void kategoriGetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kategoribilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                CbKategori.Items.Add(read["kategori"].ToString());
            }
            baglanti.Close();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void BtnVarolanaEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update urun set miktari=miktari+'"+int.Parse(TxtVarolanUrunMiktari.Text)+"' where barkodno='"+TxtVarolanUrunBarkodNo.Text+"'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            foreach (Control item in GrpBoxVarOlanUrun.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            MessageBox.Show("Var Olan Ürüne Ekleme Yapıldı");
        }

        private void FormUrunEkle_Load(object sender, EventArgs e)
        {
            kategoriGetir();
        }

        private void CbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbMarka.Items.Clear();
            CbMarka.Text = "";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from markabilgileri where kategori='"+CbKategori.SelectedItem+"'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                CbMarka.Items.Add(read["marka"].ToString());
            }
            baglanti.Close();
        }

        private void BtnYeniUrunEkle_Click(object sender, EventArgs e)
        {
            barkodKontrol();
            if (durum==true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into urun(barkodno,kategori,marka,urunadi,miktari,alisfiyati,satisfiyati,tarih) values(@barkodno,@kategori,@marka,@urunadi,@miktari,@alisfiyati,@satisfiyati,@tarih)", baglanti);
                komut.Parameters.AddWithValue("@barkodno", TxtBarkodNo.Text);
                komut.Parameters.AddWithValue("@kategori", CbKategori.Text);
                komut.Parameters.AddWithValue("@marka", CbMarka.Text);
                komut.Parameters.AddWithValue("@urunadi", TxtUrunAdi.Text);
                komut.Parameters.AddWithValue("@miktari", int.Parse(TxtMiktari.Text));
                komut.Parameters.AddWithValue("@alisfiyati", double.Parse(TxtAlisFiyati.Text));
                komut.Parameters.AddWithValue("@satisfiyati", double.Parse(TxtSatisFiyati.Text));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Ürün Eklendi");
            }
            else
            {
                MessageBox.Show("Böyle Bir Barkod No Var","Uyarı");
            }
           
            CbMarka.Items.Clear();

            foreach (Control item in GrpBoxYeniUrun.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        private void TxtVarolanUrunBarkodNo_TextChanged(object sender, EventArgs e)
        {
            if (TxtVarolanUrunBarkodNo.Text=="")
            {
                LblVarolanUrunMiktarGosterge.Text="";
                foreach (Control item in GrpBoxVarOlanUrun.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from urun where barkodno like '"+TxtVarolanUrunBarkodNo.Text+"'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                TxtVarolanUrunKategori.Text = read["kategori"].ToString();
                TxtVarolanUrunMarka.Text = read["marka"].ToString();
                TxtVarolanUrunUrunAdi.Text = read["urunadi"].ToString();
                LblVarolanUrunMiktarGosterge.Text = read["miktari"].ToString();
                TxtVarolanUrunAlisFiyati.Text = read["alisfiyati"].ToString();
                TxtVarolanUrunSatisFiyati.Text = read["satisfiyati"].ToString();

            }
            baglanti.Close();
        }

        private void GrpBoxVarOlanUrun_Enter(object sender, EventArgs e)
        {

        }
    }
}
