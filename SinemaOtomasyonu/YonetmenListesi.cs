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
    public partial class YonetmenListesi : UserControl
    {
        public YonetmenListesi()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=PELINCOMPUTER\\SQLEXPRESS;Initial Catalog=sinematixVT;Integrated Security=True");
        private void YonetmenListesi_Load(object sender, EventArgs e)
        {
            connection.Open();
            string sorgu = "select * from Tbl_Yonetmenler WHERE ID=@p1";
            SqlCommand komut = new SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@p1",lblID.Text);
            SqlDataReader reader = komut.ExecuteReader();
            if (reader.Read())
            {
                lblCinsiyet.Text = reader["CİNSİYET"].ToString();
                
            }
            connection.Close();
            if (lblCinsiyet.Text == "0")
            {
                //erkek
                pBCinsiyet.ImageLocation = @"C:\Users\Melike\Desktop\Melike\foto\erkek.jpg";
            }
            else
            {
                //kadın
                pBCinsiyet.ImageLocation = @"C:\Users\Melike\Desktop\Melike\foto\kadın.jpg";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();
            string sorgu = "select * from Tbl_Yonetmenler WHERE ID=@p1";
            SqlCommand komut = new SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@p1", lblID.Text);
            SqlDataReader reader = komut.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("BIYOGRAFI: " + reader["BIYOGRAFI"].ToString(), reader["ADSOYAD"].ToString());
            }
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand sil = new SqlCommand("delete from Tbl_Yonetmenler WHERE ID=@p1",connection);
            sil.Parameters.AddWithValue("@p1", lblID.Text);
            sil.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show(lblAdSoyad.Text + " Kişisine Ait Kayıt Başarıyla Silinmiştir !");
            this.Hide();
        }

    }
}
