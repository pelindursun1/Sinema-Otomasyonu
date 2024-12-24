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
    public partial class FrmOyuncuKayıt : Form
    {
        public FrmOyuncuKayıt()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=PELINCOMPUTER\\SQLEXPRESS;Initial Catalog=sinematixVT;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();   
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
        public string cinsiyet = "0";
        private void rBErkek_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "0";
        }

        private void rBKadın_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            yasHesaplama();

            if (textBox1.Text != "" && textBox2.Text != "" && textBox4.Text != "" && resimYolu != "")
            {

                string adSoyad = textBox1.Text.ToUpper() + " " + textBox2.Text.ToUpper();


                connection.Open();
                SqlCommand kayit = new SqlCommand("insert into Tbl_Oyuncular (ADSOYAD,CINSIYET,YAS,BIYOGRAFI,RESIM) VALUES (@p1,@p2,@p3,@p4,@p5) ", connection);
                kayit.Parameters.AddWithValue("@p1", adSoyad);
                kayit.Parameters.AddWithValue("@p2", cinsiyet);
                kayit.Parameters.AddWithValue("@p3", bYas);
                kayit.Parameters.AddWithValue("@p4", textBox4.Text.ToString().ToUpper());
                kayit.Parameters.AddWithValue("@p5", resimYolu);
                kayit.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Oyuncu kayıt işlemi başarılı bir şekilde gerçekleştirildi !");
                aracTemizle();
            }
            else
            {
                MessageBox.Show("Lütfen Alanları Doldurunuz !");


            }
        }
        void aracTemizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            numericUpDown1.Value = 1;
            numericUpDown2.Value = 1;
            numericUpDown3.Value = 2024;
            rBErkek.Checked = true;
            rBKadın.Checked = false;
            label8.Text = "300";
            cinsiyet = "0";
            bYas = "00";
            pictureBox1.ImageLocation = @"C:\Users\Melike\İCON.png";
            textBox1.Focus();
        }

        public string bYas = "00";
        void yasHesaplama()
        {
            string dogum = numericUpDown1.Value.ToString() + "-" + numericUpDown2.Value.ToString() + "-" + numericUpDown3.Value.ToString();
            DateTime dogumTarihi = Convert.ToDateTime(dogum);
            DateTime bugun = DateTime.Today;
            int yas = bugun.Year - dogumTarihi.Year;
            bYas = yas.ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            int count = textBox4.Text.Length;
            int backdown = 300 - count;
            label8.Text = backdown.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmOyuncuKayıt_Load(object sender, EventArgs e)
        {

        }
    }
}
