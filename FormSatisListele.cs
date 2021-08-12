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
    public partial class FormSatisListele : Form
    {
        public FormSatisListele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Stok_Takip;Integrated Security=True");
        DataSet daSet = new DataSet();
        private void SatisListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from satis", baglanti);
            adtr.Fill(daSet, "satis");
            dataGridView1.DataSource = daSet.Tables["satis"];

            baglanti.Close();

        }
        private void FormSatisListele_Load(object sender, EventArgs e)
        {
            SatisListele();
        }
    }
}
