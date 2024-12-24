namespace SinemaOtomasyonu
{
    partial class SalonListesi
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSalonAdi = new System.Windows.Forms.Label();
            this.lblKoltukSayisi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(7, 83);
            this.panel1.TabIndex = 0;
            this.panel1.MouseLeave += new System.EventHandler(this.ayrıl);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gel);
            // 
            // lblSalonAdi
            // 
            this.lblSalonAdi.AutoSize = true;
            this.lblSalonAdi.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSalonAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.lblSalonAdi.Location = new System.Drawing.Point(103, 0);
            this.lblSalonAdi.Name = "lblSalonAdi";
            this.lblSalonAdi.Size = new System.Drawing.Size(73, 31);
            this.lblSalonAdi.TabIndex = 2;
            this.lblSalonAdi.Text = "label1";
            this.lblSalonAdi.MouseLeave += new System.EventHandler(this.ayrıl);
            this.lblSalonAdi.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gel);
            // 
            // lblKoltukSayisi
            // 
            this.lblKoltukSayisi.AutoSize = true;
            this.lblKoltukSayisi.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKoltukSayisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblKoltukSayisi.Location = new System.Drawing.Point(212, 41);
            this.lblKoltukSayisi.Name = "lblKoltukSayisi";
            this.lblKoltukSayisi.Size = new System.Drawing.Size(66, 28);
            this.lblKoltukSayisi.TabIndex = 3;
            this.lblKoltukSayisi.Text = "label2";
            this.lblKoltukSayisi.MouseLeave += new System.EventHandler(this.ayrıl);
            this.lblKoltukSayisi.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(103, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Koltuk Sayısı :";
            this.label1.MouseLeave += new System.EventHandler(this.ayrıl);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SinemaOtomasyonu.Properties.Resources.koltukicon;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseLeave += new System.EventHandler(this.ayrıl);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gel);
            // 
            // SalonListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKoltukSayisi);
            this.Controls.Add(this.lblSalonAdi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "SalonListesi";
            this.Size = new System.Drawing.Size(281, 83);
            this.Load += new System.EventHandler(this.SalonListesi_Load);
            this.MouseLeave += new System.EventHandler(this.ayrıl);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gel);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblSalonAdi;
        public System.Windows.Forms.Label lblKoltukSayisi;
        public System.Windows.Forms.Label label1;
    }
}
