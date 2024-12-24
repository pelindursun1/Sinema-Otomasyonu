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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SinemaOtomasyonu
{
    public partial class FrmFilmKayıt : Form
    {
        public FrmFilmKayıt()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=PELINCOMPUTER\\SQLEXPRESS;Initial Catalog=sinematixVT;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            verileriSil();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }
        void verileriSil()
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("delete from Tbl_Secilenler", connection);
            komut.ExecuteNonQuery();
            connection.Close();
        }
        private void rB1_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "1";
        }

        private void rB2_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "2";
        }

        private void rB3_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "3";
        }

        private void rB4_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "4";
        }

        private void rB5_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "5";
        }

        private void rB6_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "6";
        }

        private void rB7_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "7";
        }

        private void rB8_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "8";
        }

        private void rB9_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "9";
        }

        private void rB10_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "10";
        }
        public string resimYolu = "";
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "RESİM SEÇME EKRANI";
            ofd.Filter = "PNG | *.png | JPG-JPEG | *.jpg;*.jpeg | All Files| *.*";
            ofd.FilterIndex = 3;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(ofd.FileName);
                resimYolu = ofd.FileName.ToString();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int count = txtFilmDetay.Text.Length;
            int backdown = 300 - count;
            label8.Text = backdown.ToString();
        }

        private void FrmFilmKayıt_Load(object sender, EventArgs e)
        {
            yListesiGetir();
            oListesiGetir();
            bugununTarihi();
        }
        void bugununTarihi()
        {
            nGun.Value = DateTime.Today.Day;
            nAy.Value = DateTime.Today.Month;
            nYil.Value = DateTime.Today.Year;

        }
        void yListesiGetir()
        {
            string sorgu = "select * from Tbl_Yonetmenler ORDER BY ADSOYAD ASC";
            fYönetmenPaneli.Controls.Clear();
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu, connection);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                yListeAracı arac = new yListeAracı();
                arac.lblAdi.Text = oku["ADSOYAD"].ToString();
                fYönetmenPaneli.Controls.Add(arac);


            }
            connection.Close();
        }
        void oListesiGetir()
        {
            string sorgu = "select * from Tbl_Oyuncular ORDER BY ADSOYAD ASC";
            fOyuncuPaneli.Controls.Clear();
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu, connection);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                oListeAracı arac = new oListeAracı();
                arac.lblAdi.Text = oku["ADSOYAD"].ToString();
                fOyuncuPaneli.Controls.Add(arac);


            }
            connection.Close();
        }

        private void fYönetmenPaneli_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtOyuncuAra_MouseMove(object sender, MouseEventArgs e)
        {
            lblOyuncuAra.Visible = true;
        }

        private void txtOyuncuAra_MouseLeave(object sender, EventArgs e)
        {
            lblOyuncuAra.Visible = false;
        }

        private void lblYönetmenAra_Click(object sender, EventArgs e)
        {

        }

        private void txtOyuncuAra_TextChanged(object sender, EventArgs e)
        {
            oyuncuAra();
        }
        void oyuncuAra()
        {
            string sorgu = "select * from Tbl_Oyuncular Where ADSOYAD LIKE '%" + txtOyuncuAra.Text + "%' ORDER BY ADSOYAD ASC";
            fOyuncuPaneli.Controls.Clear();
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu, connection);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                oListeAracı arac = new oListeAracı();
                arac.lblAdi.Text = oku["ADSOYAD"].ToString();
                fOyuncuPaneli.Controls.Add(arac);

            }
            connection.Close();
        }
        private void txtYönetmenAra_MouseMove(object sender, MouseEventArgs e)
        {
            lblYönetmenAra.Visible = true;
        }

        private void txtYönetmenAra_MouseLeave(object sender, EventArgs e)
        {
            lblYönetmenAra.Visible = false;
        }

        private void txtYönetmenAra_TextChanged(object sender, EventArgs e)
        {
            yonetmenAra();
        }

        void yonetmenAra()
        {
            string sorgu = "select * from Tbl_Yonetmenler Where ADSOYAD LIKE '%" + txtYönetmenAra.Text + "%' ORDER BY ADSOYAD ASC";
            fYönetmenPaneli.Controls.Clear();
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu, connection);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                yListeAracı arac = new yListeAracı();
                arac.lblAdi.Text = oku["ADSOYAD"].ToString();
                fYönetmenPaneli.Controls.Add(arac);

            }
            connection.Close();
        }

        private void lblAksiyon_Click(object sender, EventArgs e)
        {
            if (lblAksiyon.ForeColor == Color.FromArgb(84, 110, 122))
            {
                lblAksiyon.ForeColor = Color.DarkOrange;
            }
            else
            {
                lblAksiyon.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        private void lblKorku_Click(object sender, EventArgs e)
        {
            if (lblKorku.ForeColor == Color.FromArgb(84, 110, 122))
            {
                lblKorku.ForeColor = Color.DarkOrange;
            }
            else
            {
                lblKorku.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (label3.ForeColor == Color.FromArgb(84, 110, 122))
            {
                label3.ForeColor = Color.DarkOrange;
            }
            else
            {
                label3.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (label4.ForeColor == Color.FromArgb(84, 110, 122))
            {
                label4.ForeColor = Color.DarkOrange;
            }
            else
            {
                label4.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        private void lblFantastik_Click(object sender, EventArgs e)
        {
            if (lblFantastik.ForeColor == Color.FromArgb(84, 110, 122))
            {
                lblFantastik.ForeColor = Color.DarkOrange;
            }
            else
            {
                lblFantastik.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void lbl_Turkce_Click(object sender, EventArgs e)
        {
            if (lbl_Turkce.ForeColor == Color.FromArgb(84, 110, 122))
            {
                lbl_Turkce.ForeColor = Color.DarkOrange;
            }
            else
            {
                lbl_Turkce.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        private void lbl_Ingılızce_Click(object sender, EventArgs e)
        {
            if (lbl_Ingılızce.ForeColor == Color.FromArgb(84, 110, 122))
            {
                lbl_Ingılızce.ForeColor = Color.DarkOrange;
            }
            else
            {
                lbl_Ingılızce.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        private void lbl_Altyazı_Click(object sender, EventArgs e)
        {
            if (lbl_Altyazı.ForeColor == Color.FromArgb(84, 110, 122))
            {
                lbl_Altyazı.ForeColor = Color.DarkOrange;
            }
            else
            {
                lbl_Altyazı.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        private void lblKorkuSiddet_Click(object sender, EventArgs e)
        {
            if (lblKorkuSiddet.ForeColor == Color.FromArgb(84, 110, 122))
            {
                lblKorkuSiddet.ForeColor = Color.DarkOrange;
                pb1.ImageLocation = @"C:\Users\Melike\Desktop\Icon\unlocked.png";
            }
            else
            {
                lblKorkuSiddet.ForeColor = Color.FromArgb(84, 110, 122);
                pb1.ImageLocation = @"C:\Users\Melike\Desktop\Icon\lock.png";
            }
        }

        private void lblOlumsuz_Click(object sender, EventArgs e)
        {
            if (lblOlumsuz.ForeColor == Color.FromArgb(84, 110, 122))
            {
                lblOlumsuz.ForeColor = Color.DarkOrange;
                pb2.ImageLocation = @"C:\Users\Melike\Desktop\Icon\unlocked.png";
            }
            else
            {
                lblOlumsuz.ForeColor = Color.FromArgb(84, 110, 122);
                pb2.ImageLocation = @"C:\Users\Melike\Desktop\Icon\lock.png";
            }
        }

        private void lblCinsellik_Click(object sender, EventArgs e)
        {
            if (lblCinsellik.ForeColor == Color.FromArgb(84, 110, 122))
            {
                lblCinsellik.ForeColor = Color.DarkOrange;
                pb3.ImageLocation = @"C:\Users\Melike\Desktop\Icon\unlocked.png";
            }
            else
            {
                lblCinsellik.ForeColor = Color.FromArgb(84, 110, 122);
                pb3.ImageLocation = @"C:\Users\Melike\Desktop\Icon\lock.png";
            }
        }

        private void lblGenelIzleyici_Click(object sender, EventArgs e)
        {
            if (lblGenelIzleyici.ForeColor == Color.FromArgb(84, 110, 122))
            {
                lblGenelIzleyici.ForeColor = Color.DarkOrange;
                pb4.ImageLocation = @"C:\Users\Melike\Desktop\Icon\unlocked.png";
            }
            else
            {
                lblGenelIzleyici.ForeColor = Color.FromArgb(84, 110, 122);
                pb4.ImageLocation = @"C:\Users\Melike\Desktop\Icon\lock.png";
            }
        }

        private void lblArtıYedi_Click(object sender, EventArgs e)
        {
            if (lblArtıYedi.ForeColor == Color.FromArgb(84, 110, 122))
            {
                lblArtıYedi.ForeColor = Color.DarkOrange;
                pb5.ImageLocation = @"C:\Users\Melike\Desktop\Icon\unlocked.png";
            }
            else
            {
                lblArtıYedi.ForeColor = Color.FromArgb(84, 110, 122);
                pb5.ImageLocation = @"C:\Users\Melike\Desktop\Icon\lock.png";
            }
        }

        private void lblArtıOnUc_Click(object sender, EventArgs e)
        {
            if (lblArtıOnUc.ForeColor == Color.FromArgb(84, 110, 122))
            {
                lblArtıOnUc.ForeColor = Color.DarkOrange;
                pb6.ImageLocation = @"C:\Users\Melike\Desktop\Icon\unlocked.png";
            }
            else
            {
                lblArtıOnUc.ForeColor = Color.FromArgb(84, 110, 122);
                pb6.ImageLocation = @"C:\Users\Melike\Desktop\Icon\lock.png";
            }
        }

        private void pb1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            vizyonTarihiHesapla();
        }
        string vTarih = "";
        string durum = "0";
        void vizyonTarihiHesapla()
        {
            vTarih = nGun.Value + "-" + nAy.Value + "-" + nYil.Value;
            DateTime dVTarih = Convert.ToDateTime(vTarih);
            DateTime bugunTarihi = DateTime.Today;

            TimeSpan tSpan = dVTarih - bugunTarihi;

            if (tSpan.TotalDays < 0)
            {
                MessageBox.Show("Geçmiş Tarihlere Ait Film Eklenmesi Yapılamaz ! ");
                bugununTarihi();
            }
            else if (tSpan.TotalDays == 0)
            {
                durum = "1";
                MessageBox.Show(txtFilmAdi.Text.ToUpper() + " Filmi Bugün Vizyonda !");

            }
            else
            {
                durum = "0";
                MessageBox.Show(txtFilmAdi.Text.ToUpper() + " " + tSpan.TotalDays.ToString() + " Gün Sonra Vizyona Girecektir !"); ;

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToShortDateString();
            lblSaat.Text = DateTime.Now.ToShortTimeString();
        }

        string yonetmen = "";
        string oyuncu = "";

        void secilenYonetmen()
        {
            yonetmen = "";
            string sorgu = "select * from Tbl_Secilenler Where TUR='YÖNETMEN'";
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu, connection);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                yonetmen += " ," + oku["KISI"].ToString();
            }
            connection.Close();
        }

        void secilenOyuncu()
        {
            oyuncu = "";
            string sorgu = "select * from Tbl_Secilenler Where TUR='OYUNCU'";
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu, connection);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                oyuncu += " ," + oku["KISI"].ToString();
            }
            connection.Close();
        }
        void temizlemeMetodu()
        {
            this.Controls.Clear();
            this.InitializeComponent();

            txtFilmAdi.Focus();
            verileriSil();
            yListesiGetir();
            oListesiGetir();
            bugununTarihi();
        }


        string secilenTur = "";
        string secilenOzellik = "";
        string secilenBicim = "";
        private void button3_Click(object sender, EventArgs e)
        {
            secilenOyuncu();
            secilenYonetmen();
            
            
            if (txtFilmAdi.Text != "" && txtFilmDetay.Text != "" && yonetmen != "" && oyuncu != "" && resimYolu != "" && vTarih != "" && secilenBicim != "" && secilenOzellik != "" && secilenTur != "")
            {
                string sorgu = "insert into Tbl_Filmler (ADI,TURU,OZELLIKLERI,BICIMI,YONETMEN,OYUNCU,DETAY,PUAN,AFIS,TARIH,DURUM) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)";
                connection.Open();
                SqlCommand komut = new SqlCommand(sorgu, connection);
                komut.Parameters.AddWithValue("@p1", txtFilmAdi.Text.ToUpper());
                if (secilenTur.Length > 2)
                {
                    komut.Parameters.AddWithValue("@p2", secilenTur.Substring(2));
                }
                else
                {
                    komut.Parameters.AddWithValue("@p2", secilenTur);
                }
                if (secilenOzellik.Length > 2)
                {
                    komut.Parameters.AddWithValue("@p3", secilenOzellik.Substring(2));
                }
                else
                {
                    komut.Parameters.AddWithValue("@p3", secilenOzellik);
                }
                if (secilenBicim.Length > 2)
                {
                    komut.Parameters.AddWithValue("@p4", secilenBicim.Substring(2));
                }
                else
                {
                    komut.Parameters.AddWithValue("@p4", secilenBicim);
                }
                if (yonetmen.Length > 2)
                {
                    komut.Parameters.AddWithValue("@p5", yonetmen.Substring(2));
                }
                else
                {
                    komut.Parameters.AddWithValue("@p5", yonetmen);
                }
                if (oyuncu.Length > 2)
                {
                    komut.Parameters.AddWithValue("@p6", oyuncu.Substring(2));
                }
                else
                {
                    komut.Parameters.AddWithValue("@p6", oyuncu);
                }
                komut.Parameters.AddWithValue("@p7", txtFilmDetay.Text.ToUpper());
                komut.Parameters.AddWithValue("@p8", lblRating.Text);
                komut.Parameters.AddWithValue("@p9", resimYolu);
                komut.Parameters.AddWithValue("@p10", vTarih);
                komut.Parameters.AddWithValue("@p11", durum);
                connection.Close();
                MessageBox.Show("Film Kaydı Başarılı Bir Şekilde Yapılmıştır !");
                temizlemeMetodu();
            }
            else
            {
                MessageBox.Show("Lütfen Seçimleri Yapınız!");

            }
            tur();
            ozellik();
            bicim();
            void tur()
            {

                foreach (Control arac in grBTur.Controls)
                {
                    if (arac is Label)
                    {
                        if (arac.ForeColor == Color.FromArgb(84, 110, 122))
                        {

                        }
                        else
                        {
                            secilenTur += " , " + arac.Text.ToString();
                        }
                    }
                }

            }

            void ozellik()
            {
                foreach (Control arac in grBOzellikler.Controls)
                {
                    if (arac is Label)
                    {
                        if (arac.ForeColor == Color.FromArgb(84, 110, 122))
                        {

                        }
                        else
                        {
                            secilenOzellik += " , " + arac.Text.ToString();
                        }
                    }
                }
            }

            void bicim()
            {
                foreach (Control arac in grBicim.Controls)
                {
                    if (arac is Label)
                    {
                        if (arac.ForeColor == Color.FromArgb(84, 110, 122))
                        {

                        }
                        else
                        {
                            secilenBicim += " , " + arac.Text.ToString();
                        }
                    }
                }
            }
        }

        private void lblKomedi_Click(object sender, EventArgs e)
        {
            if (lblKomedi.ForeColor == Color.FromArgb(84, 110, 122))
            {
                lblKomedi.ForeColor = Color.DarkOrange;
            }
            else
            {
                lblKomedi.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        private void groupBox10_Enter(object sender, EventArgs e)
        {

        }
    }
}
    


