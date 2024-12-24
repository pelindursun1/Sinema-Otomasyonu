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
    public partial class FrmBiletDetay : Form
    {
        public FrmBiletDetay()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=PELINCOMPUTER\\SQLEXPRESS;Initial Catalog=sinematixVT;Integrated Security=True");
        
        public string biletNo = "";
        private void FrmBiletDetay_Load(object sender, EventArgs e)
        {
            lblBiletNo.Text = biletNo;
            lblBiletNo2.Text = biletNo;
            barkodNolustur();
            bilgiGetir();
        }
        void barkodNolustur()
        {
            Random rastgele = new Random();
            string karakterler = "123456789987654321012345678901234567890987654321";
            string kod = "";

            for (int i = 0; i < 11; i++)
            {
                kod += karakterler[rastgele.Next(karakterler.Length)];
            }
            lblBarkod1.Text = kod.ToString();
            lblBarkod2.Text = kod.ToString();
        }
        void bilgiGetir()
        {
            string sorgu = "select * from Tbl_Biletler where BKOD=@kod";
            connection.Open();
            SqlCommand getir = new SqlCommand(sorgu, connection);
            getir.Parameters.AddWithValue("@kod",biletNo);
            SqlDataReader oku = getir.ExecuteReader();
            if (oku.Read())
            {
                lblFilmAd.Text = oku["FILMADI"].ToString();
                lblFilmAdi2.Text = oku["FILMADI"].ToString();
                lblTelNo.Text = oku["TELNO"].ToString();
                lblAdSoyad.Text = oku["ADSOYAD"].ToString();
                lblBiletTuru.Text = oku["TUR"].ToString();
                lblSalonAdi.Text = oku["SALONADI"].ToString();
                lblSalon2.Text = oku["SALONADI"].ToString();
                lblTarih2.Text = oku["TARIH"].ToString() + " " + oku["SAAT"].ToString();
                lblTarihSaat.Text = oku["TARIH"].ToString() + " " + oku["SAAT"].ToString(); ;
                lblIslemTarih.Text = oku["ISLEMSAATI"].ToString();
                lblKoltuklar.Text = oku["KOLTUKNO"].ToString();
                lblKoltuk2.Text = oku["KOLTUKNO"].ToString();
            }
            connection.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTarihSaat_Click(object sender, EventArgs e)
        {

        }

        
    }
}
