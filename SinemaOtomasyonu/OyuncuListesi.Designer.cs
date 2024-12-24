namespace SinemaOtomasyonu
{
    partial class OyuncuListesi
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
            this.pBResimDetay = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pBCinsiyet = new System.Windows.Forms.PictureBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBResimDetay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCinsiyet)).BeginInit();
            this.SuspendLayout();
            // 
            // pBResimDetay
            // 
            this.pBResimDetay.Image = global::SinemaOtomasyonu.Properties.Resources.İCON;
            this.pBResimDetay.Location = new System.Drawing.Point(4, 1);
            this.pBResimDetay.Name = "pBResimDetay";
            this.pBResimDetay.Size = new System.Drawing.Size(99, 75);
            this.pBResimDetay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBResimDetay.TabIndex = 4;
            this.pBResimDetay.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 79);
            this.panel1.TabIndex = 5;
            // 
            // pBCinsiyet
            // 
            this.pBCinsiyet.Image = global::SinemaOtomasyonu.Properties.Resources.erkek;
            this.pBCinsiyet.Location = new System.Drawing.Point(109, 0);
            this.pBCinsiyet.Name = "pBCinsiyet";
            this.pBCinsiyet.Size = new System.Drawing.Size(39, 31);
            this.pBCinsiyet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBCinsiyet.TabIndex = 8;
            this.pBCinsiyet.TabStop = false;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.lblAdSoyad.Location = new System.Drawing.Point(153, 0);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(79, 31);
            this.lblAdSoyad.TabIndex = 9;
            this.lblAdSoyad.Text = "label1";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.lblID.Location = new System.Drawing.Point(108, 42);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(79, 31);
            this.lblID.TabIndex = 10;
            this.lblID.Text = "label1";
            this.lblID.Visible = false;
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCinsiyet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.lblCinsiyet.Location = new System.Drawing.Point(193, 42);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(79, 31);
            this.lblCinsiyet.TabIndex = 11;
            this.lblCinsiyet.Text = "label1";
            this.lblCinsiyet.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Tomato;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(348, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 36);
            this.button2.TabIndex = 12;
            this.button2.Text = "DETAY";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(489, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 36);
            this.button1.TabIndex = 13;
            this.button1.Text = "SİL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OyuncuListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblCinsiyet);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.pBCinsiyet);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pBResimDetay);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "OyuncuListesi";
            this.Size = new System.Drawing.Size(553, 79);
            this.Load += new System.EventHandler(this.OyuncuListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBResimDetay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCinsiyet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pBResimDetay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pBCinsiyet;
        public System.Windows.Forms.Label lblAdSoyad;
        public System.Windows.Forms.Label lblID;
        public System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
