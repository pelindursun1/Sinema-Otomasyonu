﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtomasyonu
{
    public partial class SalonListesi : UserControl
    {
        public SalonListesi()
        {
            InitializeComponent();
        }

        private void gel(object sender, MouseEventArgs e)
        {
            lblSalonAdi.ForeColor = Color.CadetBlue;
            this.BackColor = Color.DarkGray;

        }

        private void ayrıl(object sender, EventArgs e)
        {
            lblSalonAdi.ForeColor = Color.FromArgb(84, 110, 122);
            this.BackColor = Color.LightGray;

        }

        private void SalonListesi_Load(object sender, EventArgs e)
        {

        }
    }
}
