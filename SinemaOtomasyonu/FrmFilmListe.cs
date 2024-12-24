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
    public partial class FrmFilmListe : Form
    {
        public FrmFilmListe()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=PELINCOMPUTER\\SQLEXPRESS;Initial Catalog=sinematixVT;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmFilmListe_Load(object sender, EventArgs e)
        {
            ListePaneli.Controls.Clear();
            connection.Open();
            string sorgu = "select * from Tbl_Filmler ORDER BY ADI ASC";
            SqlCommand komut = new SqlCommand(sorgu, connection);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                FilmListesi arac = new FilmListesi();
                arac.lblFilmAdi.Text = oku["ADI"].ToString();
                arac.pBResim.ImageLocation = oku["AFIS"].ToString();
                arac.lblIdNo.Text = oku["ID"].ToString();
                ListePaneli.Controls.Add(arac);
            }
            connection.Close();
        }


        private void txtAramaYap_TextChanged(object sender, EventArgs e)
        {
            ListePaneli.Controls.Clear();
            connection.Open();
            SqlCommand ara = new SqlCommand("select * from Tbl_Filmler WHERE ADI LIKE '%" + txtAramaYap.Text + "%' ORDER BY ADI ASC ", connection);
            SqlDataReader oku = ara.ExecuteReader();
            while (oku.Read())
            {
                FilmListesi arac = new FilmListesi();
                arac.lblFilmAdi.Text = oku["ADI"].ToString();
                arac.pBResim.ImageLocation = oku["AFIS"].ToString();
                arac.lblIdNo.Text = oku["ID"].ToString();
                ListePaneli.Controls.Add(arac);
            }
            connection.Close(); 
        }
    }
}
