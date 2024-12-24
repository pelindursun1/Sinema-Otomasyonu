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
    public partial class FrmFilmDetay : Form
    {
        public FrmFilmDetay()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=PELINCOMPUTER\\SQLEXPRESS;Initial Catalog=sinematixVT;Integrated Security=True");
        public string idNo = "";
        private void FrmFilmDetay_Load(object sender, EventArgs e)
        {
            string sorgu = "select * from Tbl_Filmler Where ID=@p1";
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu,connection);
            komut.Parameters.AddWithValue("@p1", idNo);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {

                pBResim.ImageLocation = oku["AFIS"].ToString();
                lblFilmAdi.Text = oku["ADI"].ToString();
                lblBicim.Text = oku["BICIMI"].ToString();
                lblOzellik.Text = oku["OZELLIKLERI"].ToString();
                lblTur.Text = oku["TURU"].ToString();
                lblOyuncu.Text = oku["OYUNCU"].ToString();
                lblYonetmen.Text = oku["YONETMEN"].ToString();
                lblTarih.Text = oku["TARIH"].ToString();
                lblDurum.Text = oku["DURUM"].ToString();
                lblDetay.Text = oku["DETAY"].ToString();
                lblPuan.Text = oku["PUAN"].ToString();

            }
            connection.Close();
            if (lblDurum.Text=="0")
            {
                lblDurum.Text= "Film Vizyonda!";
            }
            else
            {
                lblDurum.Text = "Film Vizyona Girmedi!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
