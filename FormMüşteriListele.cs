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
    public partial class FormMüşteriListele : Form
    {
        public FormMüşteriListele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Stok_Takip;Integrated Security=True");
        DataSet daSet = new DataSet();
        private void LblTcAra_Click(object sender, EventArgs e)
        {

        }

        private void FormMüşteriListele_Load(object sender, EventArgs e)
        {
            KayitGoster();
        }

        private void KayitGoster()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from müşteri", baglanti);
            adtr.Fill(daSet, "müşteri");
            dataGridView1.DataSource = daSet.Tables["müşteri"];
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtTc.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
            TxtAdSoyad.Text = dataGridView1.CurrentRow.Cells["adsoyad"].Value.ToString();
            TxtTelefon.Text = dataGridView1.CurrentRow.Cells["telefon"].Value.ToString();
            TxtAdres.Text = dataGridView1.CurrentRow.Cells["adres"].Value.ToString();
            TxtEmail.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();


        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update müşteri set adsoyad=@adsoyad,telefon=@telefon,adres=@adres,email=@email where tc=@tc", baglanti);
            komut.Parameters.AddWithValue("@tc", TxtTc.Text);
            komut.Parameters.AddWithValue("@adsoyad", TxtAdSoyad.Text);
            komut.Parameters.AddWithValue("@telefon", TxtTelefon.Text);
            komut.Parameters.AddWithValue("@adres", TxtAdres.Text);
            komut.Parameters.AddWithValue("@email", TxtEmail.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daSet.Tables["müşteri"].Clear();
            KayitGoster();
            MessageBox.Show("Müşteri Kaydı Güncellendi");

            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from müşteri where tc ='"+dataGridView1.CurrentRow.Cells["tc"].Value.ToString()+"'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daSet.Tables["müşteri"].Clear();
            KayitGoster();
            MessageBox.Show("Kayıt Silindi");
        }

        private void TxtTcAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from müşteri where tc like '%"+TxtTcAra.Text+"%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource=tablo;
            baglanti.Close();
        }
    }
}
