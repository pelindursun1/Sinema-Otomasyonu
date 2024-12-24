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
    public partial class FrmBiletSorgula : Form
    {
        public FrmBiletSorgula()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            FrmBiletDetay frm = new FrmBiletDetay();
            frm.biletNo=txtBiletNo.Text.ToString();
            txtBiletNo.Text = "";
            frm.ShowDialog();
        }
    }
}
