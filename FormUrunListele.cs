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
    public partial class FormUrunListele : Form
    {
        public FormUrunListele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Stok_Takip;Integrated Security=True");
        DataSet daSet = new DataSet();
        private void kategoriGetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kategoribilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                cBKategori.Items.Add(read["kategori"].ToString());
            }
            baglanti.Close();
        }
        private void FormÜrünListele_Load(object sender, EventArgs e)
        {
            UrunListele();
            kategoriGetir();
        }

        private void UrunListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from urun", baglanti);
            adtr.Fill(daSet, "urun");
            dataGridView1.DataSource = daSet.Tables["urun"];
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtVarolanUrunBarkodNo.Text = dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString();
            TxtVarolanUrunKategori.Text = dataGridView1.CurrentRow.Cells["kategori"].Value.ToString();
            TxtVarolanUrunMarka.Text = dataGridView1.CurrentRow.Cells["marka"].Value.ToString();
            TxtVarolanUrunUrunAdi.Text = dataGridView1.CurrentRow.Cells["urunadi"].Value.ToString();
            TxtVarolanUrunMiktari.Text = dataGridView1.CurrentRow.Cells["miktari"].Value.ToString();
            TxtVarolanUrunAlisFiyati.Text = dataGridView1.CurrentRow.Cells["alisfiyati"].Value.ToString();
            TxtVarolanUrunSatisFiyati.Text = dataGridView1.CurrentRow.Cells["satisfiyati"].Value.ToString();

        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update urun set urunadi=@urunadi, miktari=@miktari,alisfiyati=@alisfiyati,satisfiyati=@satisfiyati where barkodno=@barkodno", baglanti);
            komut.Parameters.AddWithValue("@barkodno", TxtVarolanUrunBarkodNo.Text);
            komut.Parameters.AddWithValue("@urunadi", TxtVarolanUrunUrunAdi.Text);
            komut.Parameters.AddWithValue("@miktari", int.Parse(TxtVarolanUrunMiktari.Text));
            komut.Parameters.AddWithValue("@alisfiyati", double.Parse(TxtVarolanUrunAlisFiyati.Text));
            komut.Parameters.AddWithValue("@satisfiyati", double.Parse(TxtVarolanUrunSatisFiyati.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            daSet.Tables["urun"].Clear();
            UrunListele();
            MessageBox.Show("Güncelleme Yapıldı");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

        }

        private void BtnMarkaGüncelle_Click(object sender, EventArgs e)
        {
            if (TxtVarolanUrunBarkodNo.Text!="")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update urun set kategori=@kategori, marka=@marka, where barkodno=@barkodno", baglanti);
                komut.Parameters.AddWithValue("@barkodno", TxtVarolanUrunBarkodNo.Text);
                komut.Parameters.AddWithValue("@kategori", cBKategori.Text);
                komut.Parameters.AddWithValue("@marka", cBMarka.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Güncelleme Yapıldı");
                daSet.Tables["urun"].Clear();
                UrunListele();
            }
            else
            {
                MessageBox.Show("Barkod No Yazılı Değil");
            }
           
            foreach (Control item in this.Controls)
            {
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        private void cBKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            cBMarka.Items.Clear();
            cBMarka.Text = "";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from markabilgileri where kategori='" + cBKategori.SelectedItem + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                cBMarka.Items.Add(read["marka"].ToString());
            }
            baglanti.Close();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from urun where barkodno ='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daSet.Tables["urun"].Clear();
            UrunListele();
            MessageBox.Show("Kayıt Silindi");
        }

        private void TxtBarkodNoAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from urun where barkodno like '%" + TxtBarkodNoAra.Text + "%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
    }
}
