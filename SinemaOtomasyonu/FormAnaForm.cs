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
    public partial class FormAnaForm : Form
    {
        
        public FormAnaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }
        public string kisiAdiSoyadi = "";
        public string kisiYetki = "";
        private void FormAnaForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show(kisiAdiSoyadi);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmYonetmenKayit frm = new FrmYonetmenKayit();
            if(kisiYetki == "1")
            {
                frm.ShowDialog();
            } else
            {
                MessageBox.Show("Bu ekran için yetkiniz bulunmamaktadır.");
            }
            
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmYonetmenListesi frm = new FrmYonetmenListesi();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmOyuncuKayıt frm = new FrmOyuncuKayıt();
            if (kisiYetki == "1")
            {
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bu ekran için yetkiniz bulunmamaktadır.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmOyuncuListesi frm = new FrmOyuncuListesi();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmSalonKayıt frm = new FrmSalonKayıt();
            if (kisiYetki == "1")
            {
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bu ekran için yetkiniz bulunmamaktadır.");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmFilmKayıt frm = new FrmFilmKayıt();
            if (kisiYetki == "1")
            {
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bu ekran için yetkiniz bulunmamaktadır.");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmFilmListe frm = new FrmFilmListe();
            frm.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmBiletOlustur frm = new FrmBiletOlustur();
            frm.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmBiletSorgula frm = new FrmBiletSorgula();
            frm.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FrmSalonAtama frm = new FrmSalonAtama();
            frm.ShowDialog();
        }
    }
}
