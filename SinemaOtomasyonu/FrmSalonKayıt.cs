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
    public partial class FrmSalonKayıt : Form
    {
        public FrmSalonKayıt()
        {
            InitializeComponent();
            kOlustur();
        }
        SqlConnection connection = new SqlConnection("Data Source=PELINCOMPUTER\\SQLEXPRESS;Initial Catalog=sinematixVT;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtSalonAdi.Text != "" && cBKoltukSayisi.Text != "")
            {
                connection.Open();
                SqlCommand kaydet = new SqlCommand("insert into Tbl_Salonlar (SALONADI,KOLTUKSAYISI) Values (@p1,@p2)", connection);
                kaydet.Parameters.AddWithValue("@p1", txtSalonAdi.Text.ToUpper());
                kaydet.Parameters.AddWithValue("@p2", cBKoltukSayisi.Text);
                kaydet.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Salon Kaydetme İşlemi Başarılı Bir Şekilde Kaydedilmiştir !");
                txtSalonAdi.Text = "";
                cBKoltukSayisi.Text = "";
                txtSalonAdi.Focus();
                listeGetir();
               
            }
            else
            {
                MessageBox.Show("Lütfen bir değer giriniz !");
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmSalonKayıt_Load(object sender, EventArgs e)
        {
            listeGetir();
        }
        void kOlustur()
        {
            for (int i = 1; i <= 200; i++)
            {
                cBKoltukSayisi.Items.Add(i);
            }
        }
        void listeGetir()
        {
            panelSalon.Controls.Clear();
            connection.Open();
            SqlCommand komut = new SqlCommand("select * from Tbl_Salonlar ORDER BY SALONADI ASC", connection);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                SalonListesi arac = new SalonListesi();
                arac.lblSalonAdi.Text = reader["SALONADI"].ToString();
                arac.lblKoltukSayisi.Text = reader["KOLTUKSAYISI"].ToString();
                panelSalon.Controls.Add(arac);
            }
            connection.Close();
        }

        private void cBKoltukSayisi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
