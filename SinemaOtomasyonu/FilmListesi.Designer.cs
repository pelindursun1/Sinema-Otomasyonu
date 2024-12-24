namespace SinemaOtomasyonu
{
    partial class FilmListesi
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
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.lblIdNo = new System.Windows.Forms.Label();
            this.lblFilmAdi = new System.Windows.Forms.Label();
            this.btnFilm = new System.Windows.Forms.Button();
            this.pBResim = new System.Windows.Forms.PictureBox();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBResim)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.lblIdNo);
            this.groupBox9.Controls.Add(this.lblFilmAdi);
            this.groupBox9.Controls.Add(this.btnFilm);
            this.groupBox9.Controls.Add(this.pBResim);
            this.groupBox9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.groupBox9.Location = new System.Drawing.Point(5, 0);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.groupBox9.Size = new System.Drawing.Size(185, 273);
            this.groupBox9.TabIndex = 13;
            this.groupBox9.TabStop = false;
            // 
            // lblIdNo
            // 
            this.lblIdNo.AutoSize = true;
            this.lblIdNo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIdNo.Location = new System.Drawing.Point(13, 198);
            this.lblIdNo.Name = "lblIdNo";
            this.lblIdNo.Size = new System.Drawing.Size(53, 23);
            this.lblIdNo.TabIndex = 12;
            this.lblIdNo.Text = "label1";
            this.lblIdNo.Visible = false;
            // 
            // lblFilmAdi
            // 
            this.lblFilmAdi.AutoSize = true;
            this.lblFilmAdi.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFilmAdi.Location = new System.Drawing.Point(9, 7);
            this.lblFilmAdi.Name = "lblFilmAdi";
            this.lblFilmAdi.Size = new System.Drawing.Size(53, 23);
            this.lblFilmAdi.TabIndex = 11;
            this.lblFilmAdi.Text = "label1";
            // 
            // btnFilm
            // 
            this.btnFilm.BackColor = System.Drawing.Color.DarkOrange;
            this.btnFilm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilm.ForeColor = System.Drawing.Color.White;
            this.btnFilm.Location = new System.Drawing.Point(13, 224);
            this.btnFilm.Name = "btnFilm";
            this.btnFilm.Size = new System.Drawing.Size(146, 39);
            this.btnFilm.TabIndex = 10;
            this.btnFilm.Text = "DETAY";
            this.btnFilm.UseVisualStyleBackColor = false;
            this.btnFilm.Click += new System.EventHandler(this.btnFilm_Click);
            // 
            // pBResim
            // 
            this.pBResim.Image = global::SinemaOtomasyonu.Properties.Resources.İCON;
            this.pBResim.Location = new System.Drawing.Point(13, 33);
            this.pBResim.Name = "pBResim";
            this.pBResim.Size = new System.Drawing.Size(146, 185);
            this.pBResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBResim.TabIndex = 9;
            this.pBResim.TabStop = false;
            // 
            // FilmListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.groupBox9);
            this.Name = "FilmListesi";
            this.Size = new System.Drawing.Size(197, 279);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBResim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.PictureBox pBResim;
        public System.Windows.Forms.Label lblFilmAdi;
        public System.Windows.Forms.Label lblIdNo;
        public System.Windows.Forms.GroupBox groupBox9;
        public System.Windows.Forms.Button btnFilm;
    }
}
