namespace SinemaOtomasyonu
{
    partial class FrmSalonAtama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cBFilmAdi = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblYönetmenAra = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.panelSEANS = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblSecilen = new System.Windows.Forms.Label();
            this.cBSalon = new System.Windows.Forms.ComboBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.nYil = new System.Windows.Forms.NumericUpDown();
            this.nAy = new System.Windows.Forms.NumericUpDown();
            this.nGun = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbDoluSaatler = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nYil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGun)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 40);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(753, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "SALON ATAMA EKRANI";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cBFilmAdi);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.groupBox4.Location = new System.Drawing.Point(12, 59);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.groupBox4.Size = new System.Drawing.Size(328, 60);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "FİLM ADI";
            // 
            // cBFilmAdi
            // 
            this.cBFilmAdi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cBFilmAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBFilmAdi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBFilmAdi.FormattingEnabled = true;
            this.cBFilmAdi.Location = new System.Drawing.Point(10, 26);
            this.cBFilmAdi.Name = "cBFilmAdi";
            this.cBFilmAdi.Size = new System.Drawing.Size(315, 31);
            this.cBFilmAdi.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.nYil);
            this.groupBox5.Controls.Add(this.nAy);
            this.groupBox5.Controls.Add(this.nGun);
            this.groupBox5.Controls.Add(this.lblYönetmenAra);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.groupBox5.Location = new System.Drawing.Point(12, 200);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.groupBox5.Size = new System.Drawing.Size(328, 60);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "TARİH";
            // 
            // lblYönetmenAra
            // 
            this.lblYönetmenAra.AutoSize = true;
            this.lblYönetmenAra.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYönetmenAra.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblYönetmenAra.Location = new System.Drawing.Point(243, 0);
            this.lblYönetmenAra.Name = "lblYönetmenAra";
            this.lblYönetmenAra.Size = new System.Drawing.Size(79, 19);
            this.lblYönetmenAra.TabIndex = 12;
            this.lblYönetmenAra.Text = "gg/aa/yyyy";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.panelSEANS);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.groupBox6.Location = new System.Drawing.Point(346, 59);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.groupBox6.Size = new System.Drawing.Size(438, 293);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "SAAT/SEANS";
            // 
            // panelSEANS
            // 
            this.panelSEANS.AutoScroll = true;
            this.panelSEANS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSEANS.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panelSEANS.Location = new System.Drawing.Point(10, 26);
            this.panelSEANS.Name = "panelSEANS";
            this.panelSEANS.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.panelSEANS.Size = new System.Drawing.Size(425, 264);
            this.panelSEANS.TabIndex = 17;
            this.panelSEANS.WrapContents = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cBSalon);
            this.groupBox7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.groupBox7.Location = new System.Drawing.Point(12, 131);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.groupBox7.Size = new System.Drawing.Size(328, 60);
            this.groupBox7.TabIndex = 14;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "SALON ADI";
            // 
            // lblSecilen
            // 
            this.lblSecilen.AutoSize = true;
            this.lblSecilen.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSecilen.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblSecilen.Location = new System.Drawing.Point(367, 391);
            this.lblSecilen.Name = "lblSecilen";
            this.lblSecilen.Size = new System.Drawing.Size(166, 31);
            this.lblSecilen.TabIndex = 18;
            this.lblSecilen.Text = "lblKoltukSayisi";
            this.lblSecilen.Visible = false;
            // 
            // cBSalon
            // 
            this.cBSalon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cBSalon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBSalon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBSalon.FormattingEnabled = true;
            this.cBSalon.Location = new System.Drawing.Point(10, 26);
            this.cBSalon.Name = "cBSalon";
            this.cBSalon.Size = new System.Drawing.Size(315, 31);
            this.cBSalon.TabIndex = 0;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.btnTemizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTemizle.FlatAppearance.BorderSize = 0;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.Location = new System.Drawing.Point(12, 311);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(328, 41);
            this.btnTemizle.TabIndex = 31;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnOlustur
            // 
            this.btnOlustur.BackColor = System.Drawing.Color.DarkOrange;
            this.btnOlustur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOlustur.FlatAppearance.BorderSize = 0;
            this.btnOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOlustur.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOlustur.ForeColor = System.Drawing.Color.White;
            this.btnOlustur.Location = new System.Drawing.Point(12, 266);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(328, 39);
            this.btnOlustur.TabIndex = 30;
            this.btnOlustur.Text = "TAMAMLA";
            this.btnOlustur.UseVisualStyleBackColor = false;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // nYil
            // 
            this.nYil.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nYil.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nYil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.nYil.Location = new System.Drawing.Point(213, 24);
            this.nYil.Maximum = new decimal(new int[] {
            2300,
            0,
            0,
            0});
            this.nYil.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nYil.Name = "nYil";
            this.nYil.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nYil.Size = new System.Drawing.Size(65, 26);
            this.nYil.TabIndex = 19;
            this.nYil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nYil.Value = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            // 
            // nAy
            // 
            this.nAy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nAy.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nAy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.nAy.Location = new System.Drawing.Point(126, 24);
            this.nAy.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nAy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nAy.Name = "nAy";
            this.nAy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nAy.Size = new System.Drawing.Size(65, 26);
            this.nAy.TabIndex = 18;
            this.nAy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nAy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nGun
            // 
            this.nGun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nGun.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nGun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.nGun.Location = new System.Drawing.Point(38, 24);
            this.nGun.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nGun.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nGun.Name = "nGun";
            this.nGun.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nGun.Size = new System.Drawing.Size(65, 26);
            this.nGun.TabIndex = 17;
            this.nGun.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nGun.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbDoluSaatler);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 369);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.groupBox1.Size = new System.Drawing.Size(328, 60);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DOLU SAATLER";
            this.groupBox1.Visible = false;
            // 
            // cbDoluSaatler
            // 
            this.cbDoluSaatler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbDoluSaatler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDoluSaatler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDoluSaatler.FormattingEnabled = true;
            this.cbDoluSaatler.Location = new System.Drawing.Point(10, 26);
            this.cbDoluSaatler.Name = "cbDoluSaatler";
            this.cbDoluSaatler.Size = new System.Drawing.Size(315, 31);
            this.cbDoluSaatler.TabIndex = 0;
            // 
            // FrmSalonAtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(793, 361);
            this.Controls.Add(this.lblSecilen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(450, 210);
            this.Name = "FrmSalonAtama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSalonAtama";
            this.Load += new System.EventHandler(this.FrmSalonAtama_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nYil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGun)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cBFilmAdi;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblYönetmenAra;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.FlowLayoutPanel panelSEANS;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lblSecilen;
        private System.Windows.Forms.ComboBox cBSalon;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.NumericUpDown nYil;
        private System.Windows.Forms.NumericUpDown nAy;
        private System.Windows.Forms.NumericUpDown nGun;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbDoluSaatler;
    }
}