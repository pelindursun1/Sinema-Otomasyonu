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

namespace SinemaOtomasyonu
{
    public partial class FrmOyuncuListesi : Form
    {
        public FrmOyuncuListesi()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=PELINCOMPUTER\\SQLEXPRESS;Initial Catalog=sinematixVT;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmOyuncuListesi_Load(object sender, EventArgs e)
        {
            ListePaneli.Controls.Clear();
            connection.Open();
            string sorgu = "select * from Tbl_Oyuncular ORDER BY ADSOYAD ASC";
            SqlCommand komut = new SqlCommand(sorgu, connection);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                OyuncuListesi arac = new OyuncuListesi();
                arac.lblID.Text = reader["ID"].ToString();
                arac.lblAdSoyad.Text = reader["ADSOYAD"].ToString();
                arac.pBResimDetay.ImageLocation = reader["RESIM"].ToString();
                ListePaneli.Controls.Add(arac);
            }
            connection.Close();

        }

        private void txtAramaYap_TextChanged(object sender, EventArgs e)
        {

            ListePaneli.Controls.Clear();
            connection.Open();
            SqlCommand ara = new SqlCommand("select * from Tbl_Oyuncular WHERE ADSOYAD LIKE '%" + txtAramaYap.Text + "%' ORDER BY ADSOYAD ASC ", connection);
            SqlDataReader reader = ara.ExecuteReader();
            while (reader.Read())
            {
                OyuncuListesi arac = new OyuncuListesi();
                arac.lblID.Text = reader["ID"].ToString();
                arac.lblAdSoyad.Text = reader["ADSOYAD"].ToString();
                arac.pBResimDetay.ImageLocation = reader["RESIM"].ToString();
                ListePaneli.Controls.Add(arac);
            }
            connection.Close();
        }

        private void ListePaneli_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

