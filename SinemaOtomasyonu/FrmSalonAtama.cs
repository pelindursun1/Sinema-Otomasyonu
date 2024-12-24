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
using System.Xml.Schema;

namespace SinemaOtomasyonu
{
    public partial class FrmSalonAtama : Form
    {
        public FrmSalonAtama()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=PELINCOMPUTER\\SQLEXPRESS;Initial Catalog=sinematixVT;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSalonAtama_Load(object sender, EventArgs e)
        {
            bugununTarihi();
            filmAdiGetir();
            salonAdiGetir();
            
        }
        void bugununTarihi()
        {
            nGun.Value = DateTime.Today.Day;
            nAy.Value = DateTime.Today.Month;
            nYil.Value = DateTime.Today.Year;

        }
        void filmAdiGetir()
        {
            string sorgu = "select * from Tbl_Filmler ORDER BY ADI ASC";
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu, connection);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                string gelenTarih = oku["TARIH"].ToString();

                DateTime fTarih = Convert.ToDateTime(gelenTarih);
                DateTime bugun = DateTime.Today;

                TimeSpan timeSpan = fTarih - bugun;
                if (timeSpan.TotalDays <= 0)
                {
                    cBFilmAdi.Items.Add(oku["ADI"].ToString());
                }

            }
            connection.Close();
        }
        void salonAdiGetir()
        {
            string sorgu = "select * from Tbl_Salonlar ORDER BY SALONADI ASC";
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu, connection);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cBSalon.Items.Add(oku["SALONADI"].ToString());
            }
            connection.Close();
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            if (btnOlustur.Text == "TAMAMLA")
            {
                string sorgu = "select distinct from Tbl_Kontrol Where TARIH=@tarih AND SALONADI=@salonadi";
                string tarih = nGun.Value + "-" + nAy.Value + "-" + nYil.Value;
                SqlCommand komut = new SqlCommand(sorgu, connection);
                komut.Parameters.AddWithValue("@tarih", tarih);
                komut.Parameters.AddWithValue("@salonadi", cBSalon.Text.ToString());
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    cbDoluSaatler.Items.Add(oku["SAAT"].ToString());
                }
                connection.Close();
                seansKontrol();

                btnOlustur.Text = "OLUŞTUR";
                btnOlustur.BackColor = Color.Salmon;

            }
            else
            {
                kaydet();
                temizle();
                btnOlustur.Text = "TAMAMLA";
                btnOlustur.BackColor = Color.DarkOrange;
            }
        }
        void kaydet()
        {
            string sorgu = "insert into Tbl_Kontrol (FILMADI,TARIH,SAAT,SALONADI) VALUES (@filmadi,@tarih,@saat,@salonadi)";
            string tarih = nGun.Value + "-" + nAy.Value + "-" + nYil.Value;
            connection.Open();
            SqlCommand ekle = new SqlCommand(sorgu,connection);
            ekle.Parameters.AddWithValue("@filmadi",cBFilmAdi.Text);
            ekle.Parameters.AddWithValue("@tarih",tarih);
            ekle.Parameters.AddWithValue("@saat",lblSecilen.Text);
            ekle.Parameters.AddWithValue("@salonadi",cBSalon.Text);
            ekle.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("SALON ATAMA İŞLEMİ BAŞARILI BİR ŞEKİLDE YAPILDI!");
        }
        private void SeansSaatler(object sender, EventArgs e)
        {
            foreach (RadioButton item in panelSEANS.Controls)
            {
                if (item.Checked)
                {
                    lblSecilen.Text = item.Text.ToString();
                }
                else
                {

                }
            }
        }
        void temizle()
        {
            cBFilmAdi.Items.Clear();
            cBSalon.Items.Clear();
            cbDoluSaatler.Items.Clear();
            lblSecilen.Text = "";
            bugununTarihi();
            filmAdiGetir();
            salonAdiGetir();
            panelSEANS.Controls.Clear();
            btnOlustur.Text = "TAMAMLA";
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
        void seansKontrol()
        {
            panelSEANS.Controls.Clear();
            for (int i = 10; i <= 22; i++)
            {
                for (int j = 0; j <= 30; j += 30)
                {
                    RadioButton rnd = new RadioButton();
                    rnd.ForeColor = Color.Tomato;
                    rnd.Width = 70;
                    rnd.FlatStyle = FlatStyle.Flat;
                    rnd.Font = new System.Drawing.Font("Segoe UI Semibold", 12);
                    rnd.CheckedChanged += new EventHandler(SeansSaatler);
                    if (j == 0)
                    {
                        rnd.Text = i.ToString() + ":" + j.ToString() + "0";
                    }
                    else
                    {
                        rnd.Text = i.ToString() + ":" + j.ToString();
                    }
                    if (cbDoluSaatler.Items.Contains(rnd.Text))
                    {
                        rnd.Visible = false;
                    }
                    panelSEANS.Controls.Add(rnd);
                }
            }
        }
    }
}


