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
    public partial class FrmAcilis : Form
    {
        public FrmAcilis()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=PELINCOMPUTER\\SQLEXPRESS;Initial Catalog=sinematixVT;Integrated Security=True");
        
 
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmAcilis_Load(object sender, EventArgs e)
        {

        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from Tbl_kullanicilar WHERE KADI=@p1 AND KSIFRE=@p2",connection);
            cmd.Parameters.AddWithValue("@p1",txtKullaniciAdi.Text);
            cmd.Parameters.AddWithValue("@p2", txtSifre.Text);
           SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Giriş Başarılı");
                FormAnaForm anaForm = new FormAnaForm();
                anaForm.kisiAdiSoyadi = reader["ADSOYAD"].ToString();
                anaForm.kisiYetki = reader["YETKI"].ToString();
                anaForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre hatalı !");
            }
            connection.Close();

            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";
            txtKullaniciAdi.Focus();
        }
    }
}
