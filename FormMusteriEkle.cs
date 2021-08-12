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
    public partial class FormMusteriEkle : Form
    {
        public FormMusteriEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Stok_Takip;Integrated Security=True");

        private void FormMusteriEkle_Load(object sender, EventArgs e)
        {

        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into müşteri(tc, adsoyad, telefon, adres, email) values(@tc, @adsoyad, @telefon, @adres, @email)", baglanti);
            komut.Parameters.AddWithValue("@tc", TxtTc.Text);
            komut.Parameters.AddWithValue("@adsoyad", TxtAdSoyad.Text);
            komut.Parameters.AddWithValue("@telefon", TxtTelefon.Text);
            komut.Parameters.AddWithValue("@adres", TxtAdres.Text);
            komut.Parameters.AddWithValue("@email", TxtEmail.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Kaydı Eklendi");

            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
    }
}
