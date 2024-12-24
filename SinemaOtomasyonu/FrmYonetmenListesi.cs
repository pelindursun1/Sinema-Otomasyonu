using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SinemaOtomasyonu
{
    public partial class FrmYonetmenListesi : Form
    {
        public FrmYonetmenListesi()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=PELINCOMPUTER\\SQLEXPRESS;Initial Catalog=sinematixVT;Integrated Security=True");
        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void FrmYonetmenListesi_Load(object sender, EventArgs e)
        {
            ListePaneli.Controls.Clear();
            connection.Open();
            string sorgu = "select * from Tbl_Yonetmenler ORDER BY ADSOYAD ASC";
            SqlCommand komut = new SqlCommand(sorgu, connection);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read()) 
            {
                YonetmenListesi arac = new YonetmenListesi();
                arac.lblID.Text = reader["ID"].ToString();
                arac.lblAdSoyad.Text = reader["ADSOYAD"].ToString();
                arac.pBResimDetay.ImageLocation = reader["RESİM"].ToString();
                ListePaneli.Controls.Add(arac);

            }
            connection.Close();
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ListePaneli_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtAramaYap_TextChanged(object sender, EventArgs e)
        {
            ListePaneli.Controls.Clear();
            connection.Open();
            SqlCommand ara = new SqlCommand("select * from Tbl_Yonetmenler WHERE ADSOYAD LIKE '%"+txtAramaYap.Text+"%' ORDER BY ADSOYAD ASC ", connection);
            SqlDataReader reader = ara.ExecuteReader();
            while (reader.Read())
            {
                YonetmenListesi arac = new YonetmenListesi();
                arac.lblID.Text = reader["ID"].ToString();
                arac.lblAdSoyad.Text = reader["ADSOYAD"].ToString();
                arac.pBResimDetay.ImageLocation = reader["RESİM"].ToString() ;
                ListePaneli .Controls.Add(arac);                                    
            }
            connection.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
