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
    public partial class FrmBiletOlustur : Form
    {
        public FrmBiletOlustur()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=PELINCOMPUTER\\SQLEXPRESS;Initial Catalog=sinematixVT;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmBiletOlustur_Load(object sender, EventArgs e)
        {
            filmAdiGetir();
            biletNolustur();
        }
        void biletNolustur()
        {
            Random rastgele = new Random();
            string karakterler = "123456789987654321012345678901234567890987654321";
            string kod = "";

            for (int i = 0; i < 11; i++)
            {
                kod += karakterler[rastgele.Next(karakterler.Length)];
            }
            txtBarkod.Text = kod.ToString();
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

        private void cBFilmAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cBTarih.Items.Clear();
            string sorgu = "select distinct TARIH from Tbl_Kontrol Where FILMADI=@filmadi ASC";
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@filmadi", cBFilmAdi.Text);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cBTarih.Items.Add(oku["TARIH"].ToString());

            }
            connection.Close();
        }
        void biletNoSorgula()
        {
            string sorgu = "select * from Tbl_Biletler where BKOD=@no";
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu,connection);
            komut.Parameters.AddWithValue("@no",txtBarkod.Text.ToString());
            SqlDataReader oku = komut.ExecuteReader();
            if (!oku.Read())
            {
                MessageBox.Show("YOK!");
            }
            else
            {
                MessageBox.Show("VAR!");
            }
            connection.Close();
        }
        void kaydetMETODU()
        {
            string sorgu = "insert into Tbl_Biletler (BKOD, ADSOYAD, TELNO, KOLTUKNO, FILMADI, TARIH, SAAT, SALON, TUR, ISLEMSAATI) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)";
            connection.Open();
            SqlCommand kayit = new SqlCommand(sorgu,connection);
            kayit.Parameters.AddWithValue("@p1", txtBarkod.Text.ToString());
            kayit.Parameters.AddWithValue("@p2", txtAdSoyad.Text.ToUpper().ToString());
            kayit.Parameters.AddWithValue("@p3", txtTelNo.Text.ToString());
            kayit.Parameters.AddWithValue("@p4", txtKoltuklar.Text.ToString());
            kayit.Parameters.AddWithValue("@p5", cBFilmAdi.Text.ToString());
            kayit.Parameters.AddWithValue("@p6", cBTarih.Text.ToString());
            kayit.Parameters.AddWithValue("@p7", lblSeansSec.Text.ToString());
            kayit.Parameters.AddWithValue("@p8", cBSalon.Text.ToString());
            kayit.Parameters.AddWithValue("@p9", cBBiletTuru.Text.ToString());
            kayit.Parameters.AddWithValue("@p10",DateTime.Now.ToString());
            kayit.ExecuteNonQuery();
            connection.Close();

            string sorgu2 = "UPDATE Tbl_Kontrol SET KOLTUKLAR=@numara WHERE FILMADI=@filmadi AND TARIH=@tarih AND SAAT=@saat AND SALONADI=@salonadi";
            connection.Open();
            SqlCommand guncelle = new SqlCommand(sorgu2,connection);
            if (lblGelenKoltuk.Text.ToString() == "")
            {
                guncelle.Parameters.AddWithValue("@numara",txtKoltuklar.Text.ToString());
            }
            else
            {
                guncelle.Parameters.AddWithValue("@numara", lblGelenKoltuk.Text.ToString() + " ," + txtKoltuklar.Text.ToString());
            }
            guncelle.Parameters.AddWithValue("@filmadi",cBFilmAdi.Text.ToString());
            guncelle.Parameters.AddWithValue("@tarih",cBTarih.Text.ToString());
            guncelle.Parameters.AddWithValue("@saat",lblSeansSec.Text.ToString());
            guncelle.Parameters.AddWithValue("@salonadi",cBSalon.Text.ToString());
            guncelle.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("BİLET SATIŞI BİR ŞEKİLDE GERÇEKLEŞTİRİLDİ!");
            salonDurumGeldi();

            lblGelenKoltuk.Text = "";
            listeGelenKoltuk.Items.Clear();
            lbBelirlenen.Items.Clear();
            txtKoltuklar.Text = "";

        }
        private void btnOlustur_Click(object sender, EventArgs e)
        {
            if (txtAdSoyad.Text != "" && txtBarkod.Text != "" && txtTelNo.Text != "" && txtBarkod.Text != "" && cBBiletTuru.Text != "" && cBFilmAdi.Text != "" && cBSalon.Text != "" && cBTarih.Text != "")
            {
                biletNoSorgula();
                
            }
            else
            {
                MessageBox.Show("LÜTFEN TÜM ALANLARI EKSİKSİZ DOLDURUNUZ!");
            }

        }
        void secTiklerimiz()
        {
            txtKoltuklar.Text = "";
            foreach (string item in lbBelirlenen.Items)
            {
                txtKoltuklar.Text += "," + item;
            }
            if (txtKoltuklar.Text.Length > 1)
            {
                txtKoltuklar.Text = txtKoltuklar.Text.Substring(1);

            }
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.ForeColor==Color.Black)
            {
                MessageBox.Show("BU KOLTUK DOLUDUR!");
            }
            else
            {
                if (btn.ForeColor==Color.White)
                {
                    btn.Image=(System.Drawing.Image)(Properties.Resources.private_cinema_chair__1_);
                    btn.ForeColor = Color.Black;
                    lbBelirlenen.Items.Add(btn.Text);
                    secTiklerimiz();
                }
                else
                {
                    btn.Image = (System.Drawing.Image)(Properties.Resources.private_cinema_chair);
                    btn.ForeColor= Color.White;
                    lbBelirlenen.Items.Remove(btn.Text);
                    secTiklerimiz();
                }
            }
        }

        private void cBTarih_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelSEANS.Controls.Clear();
            string saatler = "";

            string sorgu = "select distinct SAAT from Tbl_Kontrol Where FILMADI=@filmadi AND TARIH=@tarih";
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@filmadi", cBFilmAdi.Text.ToString());
            komut.Parameters.AddWithValue("@tarih", cBTarih.Text.ToString());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                saatler = oku["SAAT"].ToString();
                RadioButton rnd = new RadioButton();
                rnd.Text = saatler;
                rnd.ForeColor = Color.Tomato;
                rnd.Width = 70;
                rnd.FlatStyle = FlatStyle.Flat;
                rnd.Font = new System.Drawing.Font("Segoe UI Semibold", 12);
                rnd.CheckedChanged += new EventHandler(SeansSaatler);
                panelSEANS.Controls.Add(rnd);

            }
            connection.Close();
        }
        private void SeansSaatler(object sender, EventArgs e)
        {
            foreach (RadioButton item in panelSEANS.Controls)
            {
                if (item.Checked)
                {
                    lblSeansSec.Text = item.Text;
                    cBSalon.Items.Clear();

                    string sorgu = "select distinct SALONADI from Tbl_Kontrol Where FILMADI=@filmadi AND TARIH=@tarih AND SAAT=@saat";
                    connection.Open();
                    SqlCommand komut = new SqlCommand(sorgu, connection);
                    komut.Parameters.AddWithValue("@filmadi", cBFilmAdi.Text.ToString());
                    komut.Parameters.AddWithValue("@tarih", cBTarih.Text.ToString());
                    komut.Parameters.AddWithValue("@saat", lblSeansSec.Text.ToString());
                    SqlDataReader oku = komut.ExecuteReader();
                    while (oku.Read())
                    {
                        cBSalon.Items.Add(oku["SALONADI"].ToString());
                    }
                    connection.Close();

                }
            }

        }
        void koltukAyirma()
        {
            listeGelenKoltuk.Items.Clear();
            string no = "";
            string[] sec;
            no = lblGelenKoltuk.Text.ToString();
            sec = no.Split(',');
            foreach (string bulunan in sec)
            {
                listeGelenKoltuk.Items.Add(bulunan);
            }
        }
        void koltukGetir()
        {
            lblGelenKoltuk.Text = "";
            string sorgu = "select * from Tbl_Kontrol Where FILMADI=@filmadi AND TARIH=@tarih AND SAAT=@saat AND SALONADI=@salonadi";
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@filmadi", cBFilmAdi.Text.ToString());
            komut.Parameters.AddWithValue("@tarih", cBTarih.Text.ToString());
            komut.Parameters.AddWithValue("@saat", lblSeansSec.Text.ToString());
            komut.Parameters.AddWithValue("@salonadi", cBSalon.Text.ToString());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblGelenKoltuk.Text += " ," + oku["KOLTUKSAYISI"].ToString();
                if (lblGelenKoltuk.Text.Length > 2)
                {
                    lblGelenKoltuk.Text = lblGelenKoltuk.Text.Substring(2);
                }
                else
                {
                    lblGelenKoltuk.Text = "";
                }
            }
            connection.Close();

            koltukAyirma();
        }
        private void cBSalon_SelectedIndexChanged(object sender, EventArgs e)
        {
            salonDurumGeldi();
        }
         void salonDurumGeldi()
         {
            string sorgu = "select * from Tbl_Salonlar Where SALONADI=@salonadi";
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@salonadi", cBSalon.Text.ToString());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblKoltukSayisi.Text = (oku["KOLTUKSAYISI"].ToString());
            }
            connection.Close();
            koltukGetir();
            DOLDUR();
        }
        void DOLDUR()
        {
            KoltukPaneli.Controls.Clear();
            int sayi = Convert.ToInt16(lblKoltukSayisi.Text);
            for (int i = 0; i <= sayi; i++)
            {
                Button btn = new Button();
                if (i <= 20)
                {
                    btn.Text = "A" + i.ToString();
                    btn.Name = "A" + i.ToString();
                }
                else if (i <= 40)
                {
                    btn.Text = "B" + i.ToString();
                    btn.Name = "B" + i.ToString();
                }
                if (i <= 60)
                {
                    btn.Text = "C" + i.ToString();
                    btn.Name = "C" + i.ToString();
                }
                if (i <= 80)
                {
                    btn.Text = "D" + i.ToString();
                    btn.Name = "D" + i.ToString();
                }
                if (i <= 100)
                {
                    btn.Text = "E" + i.ToString();
                    btn.Name = "E" + i.ToString();
                }
                btn.Width = 50;
                btn.Height = 50;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Font = new System.Drawing.Font("Segoe UI SemiBold", 12);
                btn.BackColor = Color.White;
                btn.ForeColor = Color.OrangeRed;
                btn.Click += Btn_Click;
                if (listeGelenKoltuk.Items.Contains(btn.Text))
                {
                    btn.Image = (System.Drawing.Image)(Properties.Resources.private_cinema_chair_icons);
                    btn.ForeColor = Color.Black;
                    
                }
                else
                {
                    btn.Image = (System.Drawing.Image)(Properties.Resources.private_cinema_chair);
                    btn.ForeColor = Color.White;
                    
                }
                KoltukPaneli.Controls.Add(btn);
            }
           
           
            
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAdSoyad.Text = "";
            txtTelNo.Text = "";
            txtKoltuklar.Text = "";
            cBBiletTuru.Text = "";
            cBSalon.Text = "";
            cBTarih.Text = "";
            txtBarkod.Text = "";
            lblGelenKoltuk.Text = "";
            lblKoltukSayisi.Text = "";
            lblSeansSec.Text = "";
            cBSalon.Items.Clear();
            cBTarih.Items.Clear();
            cBBiletTuru.Items.Clear();
            cBBiletTuru.Items.Add("YETİŞKİN");
            cBBiletTuru.Items.Add("ÖĞRENCİ");
            biletNolustur();
            panelSEANS.Controls.Clear();
            KoltukPaneli.Controls.Clear();
            lbBelirlenen.Items.Clear();
            cBFilmAdi.Items.Clear();
            listeGelenKoltuk.Items.Clear();
            filmAdiGetir();
            txtAdSoyad.Focus();
            
            
            

        }

    }
}
