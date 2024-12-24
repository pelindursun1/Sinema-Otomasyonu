namespace SinemaOtomasyonu
{
    partial class FrmBiletOlustur
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cBFilmAdi = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cBTarih = new System.Windows.Forms.ComboBox();
            this.lblYönetmenAra = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblSeansSec = new System.Windows.Forms.Label();
            this.panelSEANS = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblKoltukSayisi = new System.Windows.Forms.Label();
            this.cBSalon = new System.Windows.Forms.ComboBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.cBBiletTuru = new System.Windows.Forms.ComboBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txtKoltuklar = new System.Windows.Forms.TextBox();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.KoltukPaneli = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblGelenKoltuk = new System.Windows.Forms.Label();
            this.listeGelenKoltuk = new System.Windows.Forms.ListBox();
            this.lbBelirlenen = new System.Windows.Forms.ListBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(904, 40);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(864, 0);
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
            this.label1.Location = new System.Drawing.Point(9, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "BİLET OLUŞTURMA EKRANI";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBarkod);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.groupBox1.Location = new System.Drawing.Point(7, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.groupBox1.Size = new System.Drawing.Size(328, 60);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BİLET NUMARASI";
            // 
            // txtBarkod
            // 
            this.txtBarkod.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBarkod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBarkod.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtBarkod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.txtBarkod.Location = new System.Drawing.Point(10, 34);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(315, 23);
            this.txtBarkod.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAdSoyad);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.groupBox2.Location = new System.Drawing.Point(7, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.groupBox2.Size = new System.Drawing.Size(328, 60);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AD SOYAD ";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtAdSoyad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdSoyad.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtAdSoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.txtAdSoyad.Location = new System.Drawing.Point(10, 34);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(315, 23);
            this.txtAdSoyad.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTelNo);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.groupBox3.Location = new System.Drawing.Point(7, 197);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.groupBox3.Size = new System.Drawing.Size(328, 60);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TELEFON NUMARASI ";
            // 
            // txtTelNo
            // 
            this.txtTelNo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTelNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelNo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtTelNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.txtTelNo.Location = new System.Drawing.Point(10, 34);
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(315, 23);
            this.txtTelNo.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cBFilmAdi);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.groupBox4.Location = new System.Drawing.Point(7, 263);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.groupBox4.Size = new System.Drawing.Size(328, 60);
            this.groupBox4.TabIndex = 8;
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
            this.cBFilmAdi.SelectedIndexChanged += new System.EventHandler(this.cBFilmAdi_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cBTarih);
            this.groupBox5.Controls.Add(this.lblYönetmenAra);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.groupBox5.Location = new System.Drawing.Point(7, 329);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.groupBox5.Size = new System.Drawing.Size(328, 60);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "TARİH";
            // 
            // cBTarih
            // 
            this.cBTarih.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cBTarih.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBTarih.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBTarih.FormattingEnabled = true;
            this.cBTarih.Location = new System.Drawing.Point(10, 26);
            this.cBTarih.Name = "cBTarih";
            this.cBTarih.Size = new System.Drawing.Size(315, 31);
            this.cBTarih.TabIndex = 13;
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
            this.groupBox6.Controls.Add(this.lblSeansSec);
            this.groupBox6.Controls.Add(this.panelSEANS);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.groupBox6.Location = new System.Drawing.Point(7, 395);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.groupBox6.Size = new System.Drawing.Size(328, 125);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "SAAT/SEANS";
            // 
            // lblSeansSec
            // 
            this.lblSeansSec.AutoSize = true;
            this.lblSeansSec.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSeansSec.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblSeansSec.Location = new System.Drawing.Point(261, 4);
            this.lblSeansSec.Name = "lblSeansSec";
            this.lblSeansSec.Size = new System.Drawing.Size(61, 19);
            this.lblSeansSec.TabIndex = 17;
            this.lblSeansSec.Text = "lblSeans";
            this.lblSeansSec.Visible = false;
            // 
            // panelSEANS
            // 
            this.panelSEANS.AutoScroll = true;
            this.panelSEANS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSEANS.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panelSEANS.Location = new System.Drawing.Point(10, 26);
            this.panelSEANS.Name = "panelSEANS";
            this.panelSEANS.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.panelSEANS.Size = new System.Drawing.Size(315, 96);
            this.panelSEANS.TabIndex = 17;
            
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lblKoltukSayisi);
            this.groupBox7.Controls.Add(this.cBSalon);
            this.groupBox7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.groupBox7.Location = new System.Drawing.Point(7, 526);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.groupBox7.Size = new System.Drawing.Size(328, 60);
            this.groupBox7.TabIndex = 13;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "SALON ADI";
            // 
            // lblKoltukSayisi
            // 
            this.lblKoltukSayisi.AutoSize = true;
            this.lblKoltukSayisi.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKoltukSayisi.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblKoltukSayisi.Location = new System.Drawing.Point(220, 0);
            this.lblKoltukSayisi.Name = "lblKoltukSayisi";
            this.lblKoltukSayisi.Size = new System.Drawing.Size(102, 19);
            this.lblKoltukSayisi.TabIndex = 18;
            this.lblKoltukSayisi.Text = "lblKoltukSayisi";
            this.lblKoltukSayisi.Visible = false;
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
            this.cBSalon.SelectedIndexChanged += new System.EventHandler(this.cBSalon_SelectedIndexChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.cBBiletTuru);
            this.groupBox8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.groupBox8.Location = new System.Drawing.Point(7, 592);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.groupBox8.Size = new System.Drawing.Size(328, 60);
            this.groupBox8.TabIndex = 14;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "BİLET TÜRÜ";
            // 
            // cBBiletTuru
            // 
            this.cBBiletTuru.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cBBiletTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBBiletTuru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBBiletTuru.FormattingEnabled = true;
            this.cBBiletTuru.Items.AddRange(new object[] {
            "ÖĞRENCİ",
            "YETİŞKİN"});
            this.cBBiletTuru.Location = new System.Drawing.Point(10, 26);
            this.cBBiletTuru.Name = "cBBiletTuru";
            this.cBBiletTuru.Size = new System.Drawing.Size(315, 31);
            this.cBBiletTuru.TabIndex = 0;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.txtKoltuklar);
            this.groupBox9.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.groupBox9.Location = new System.Drawing.Point(7, 658);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.groupBox9.Size = new System.Drawing.Size(328, 60);
            this.groupBox9.TabIndex = 15;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "SEÇİLEN KOLTUKLAR";
            // 
            // txtKoltuklar
            // 
            this.txtKoltuklar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtKoltuklar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKoltuklar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtKoltuklar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.txtKoltuklar.Location = new System.Drawing.Point(10, 34);
            this.txtKoltuklar.Name = "txtKoltuklar";
            this.txtKoltuklar.Size = new System.Drawing.Size(315, 23);
            this.txtKoltuklar.TabIndex = 0;
            // 
            // btnOlustur
            // 
            this.btnOlustur.BackColor = System.Drawing.Color.DarkOrange;
            this.btnOlustur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOlustur.FlatAppearance.BorderSize = 0;
            this.btnOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOlustur.ForeColor = System.Drawing.Color.White;
            this.btnOlustur.Location = new System.Drawing.Point(7, 724);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(195, 67);
            this.btnOlustur.TabIndex = 16;
            this.btnOlustur.Text = "OLUŞTUR";
            this.btnOlustur.UseVisualStyleBackColor = false;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(588, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 31);
            this.label2.TabIndex = 18;
            this.label2.Text = "PERDE";
            // 
            // KoltukPaneli
            // 
            this.KoltukPaneli.AutoScroll = true;
            this.KoltukPaneli.Location = new System.Drawing.Point(366, 140);
            this.KoltukPaneli.Name = "KoltukPaneli";
            this.KoltukPaneli.Size = new System.Drawing.Size(526, 575);
            this.KoltukPaneli.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(543, 769);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "BOŞ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(602, 769);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 23;
            this.label4.Text = "DOLU";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(656, 769);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 19);
            this.label5.TabIndex = 25;
            this.label5.Text = "SEÇİLEN";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::SinemaOtomasyonu.Properties.Resources.private_cinema_chair__1_;
            this.pictureBox4.Location = new System.Drawing.Point(669, 724);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(36, 42);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SinemaOtomasyonu.Properties.Resources.private_cinema_chair_icons;
            this.pictureBox3.Location = new System.Drawing.Point(607, 724);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SinemaOtomasyonu.Properties.Resources.private_cinema_chair;
            this.pictureBox2.Location = new System.Drawing.Point(543, 724);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SinemaOtomasyonu.Properties.Resources.sinemaperdesi;
            this.pictureBox1.Location = new System.Drawing.Point(351, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(541, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // lblGelenKoltuk
            // 
            this.lblGelenKoltuk.AutoSize = true;
            this.lblGelenKoltuk.Location = new System.Drawing.Point(704, 140);
            this.lblGelenKoltuk.Name = "lblGelenKoltuk";
            this.lblGelenKoltuk.Size = new System.Drawing.Size(77, 31);
            this.lblGelenKoltuk.TabIndex = 26;
            this.lblGelenKoltuk.Text = "label6";
            // 
            // listeGelenKoltuk
            // 
            this.listeGelenKoltuk.FormattingEnabled = true;
            this.listeGelenKoltuk.ItemHeight = 31;
            this.listeGelenKoltuk.Location = new System.Drawing.Point(660, 174);
            this.listeGelenKoltuk.Name = "listeGelenKoltuk";
            this.listeGelenKoltuk.Size = new System.Drawing.Size(182, 128);
            this.listeGelenKoltuk.TabIndex = 27;
            // 
            // lbBelirlenen
            // 
            this.lbBelirlenen.FormattingEnabled = true;
            this.lbBelirlenen.ItemHeight = 31;
            this.lbBelirlenen.Location = new System.Drawing.Point(660, 329);
            this.lbBelirlenen.Name = "lbBelirlenen";
            this.lbBelirlenen.Size = new System.Drawing.Size(182, 128);
            this.lbBelirlenen.TabIndex = 28;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.btnTemizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTemizle.FlatAppearance.BorderSize = 0;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.Location = new System.Drawing.Point(208, 724);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(195, 67);
            this.btnTemizle.TabIndex = 29;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // FrmBiletOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(904, 815);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.KoltukPaneli);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbBelirlenen);
            this.Controls.Add(this.listeGelenKoltuk);
            this.Controls.Add(this.lblGelenKoltuk);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(400, 80);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FrmBiletOlustur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBiletOlustur";
            this.Load += new System.EventHandler(this.FrmBiletOlustur_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cBFilmAdi;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblYönetmenAra;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox cBSalon;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ComboBox cBBiletTuru;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox txtKoltuklar;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.ComboBox cBTarih;
        private System.Windows.Forms.FlowLayoutPanel panelSEANS;
        private System.Windows.Forms.Label lblSeansSec;
        private System.Windows.Forms.Label lblKoltukSayisi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel KoltukPaneli;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblGelenKoltuk;
        private System.Windows.Forms.ListBox listeGelenKoltuk;
        private System.Windows.Forms.ListBox lbBelirlenen;
        private System.Windows.Forms.Button btnTemizle;
    }
}