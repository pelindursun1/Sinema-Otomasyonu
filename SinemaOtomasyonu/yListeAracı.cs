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
    public partial class yListeAracı : UserControl
    {
        public yListeAracı()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=PELINCOMPUTER\\SQLEXPRESS;Initial Catalog=sinematixVT;Integrated Security=True");
        private void lblAdi_Click(object sender, EventArgs e)
        {
            if (lblAdi.ForeColor ==Color.FromArgb(17, 29, 43))
            {
                lblAdi.ForeColor = Color.DarkOrange;
                pictureBox1.ImageLocation = @"C:\Users\Melike\Desktop\Icon\plus.png";

                connection.Open();
                SqlCommand komut = new SqlCommand("insert into Tbl_Secilenler (KISI,TUR) values (@kisi,@tur)",connection);
                komut.Parameters.AddWithValue("@kisi", lblAdi.Text);
                komut.Parameters.AddWithValue("@tur", "YÖNETMEN");
                komut.ExecuteNonQuery();
                connection.Close();
            }
            else
            {
                lblAdi.ForeColor = Color.FromArgb(17, 29, 43);
                pictureBox1.ImageLocation = @"C:\Users\Melike\Desktop\Icon\plus.png";

                connection.Open();
                SqlCommand komut = new SqlCommand("delete from Tbl_Secilenler where KISI=@kisi AND TUR=@tur", connection);
                komut.Parameters.AddWithValue("@kisi", lblAdi.Text);
                komut.Parameters.AddWithValue("@tur", "YÖNETMEN");
                komut.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void lblAdi_MouseMove(object sender, MouseEventArgs e)
        {
            lblAdi.Font = new Font(lblAdi.Font.Name, 12, FontStyle.Underline);
        }

        private void lblAdi_MouseLeave(object sender, EventArgs e)
        {
            lblAdi.Font = new Font(lblAdi.Font.Name, 12, FontStyle.Regular);
        }

        private void yListeAracı_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("select * from Tbl_Secilenler where KISI=@kisi AND TUR=@tur", connection);
            komut.Parameters.AddWithValue("@kisi", lblAdi.Text);
            komut.Parameters.AddWithValue("@tur", "YÖNETMEN");
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                lblAdi.ForeColor = Color.DarkOrange;
                pictureBox1.ImageLocation = @"C:\Users\Melike\Desktop\Icon\plus.png";
            }
            else
            {
                lblAdi.ForeColor = Color.FromArgb(17, 29, 43);
                pictureBox1.ImageLocation = @"C:\Users\Melike\Desktop\Icon\plus.png";
            }
            connection.Close();
        }
    }
}
