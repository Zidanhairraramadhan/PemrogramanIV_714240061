namespace P5_4_714240061
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbJenisKelamin = new System.Windows.Forms.ComboBox();
            this.dtpTanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.gbKelas = new System.Windows.Forms.GroupBox();
            this.gbJadwal = new System.Windows.Forms.GroupBox();
            this.chkSepakBola = new System.Windows.Forms.CheckBox();
            this.chkBasket = new System.Windows.Forms.CheckBox();
            this.chkRenang = new System.Windows.Forms.CheckBox();
            this.chkBuluTangkis = new System.Windows.Forms.CheckBox();
            this.chkTennis = new System.Windows.Forms.CheckBox();
            this.chkVoli = new System.Windows.Forms.CheckBox();
            this.chkYoga = new System.Windows.Forms.CheckBox();
            this.chkPanahan = new System.Windows.Forms.CheckBox();
            this.rbSeninRabu = new System.Windows.Forms.RadioButton();
            this.rbSelasaKamis = new System.Windows.Forms.RadioButton();
            this.rbMingguMalam = new System.Windows.Forms.RadioButton();
            this.rbSabtuMinggu = new System.Windows.Forms.RadioButton();
            this.btnTampilkan = new System.Windows.Forms.Button();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.gbKelas.SuspendLayout();
            this.gbJadwal.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tanggal Lahir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jenis Kelamin";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(503, 50);
            this.textBox1.MaxLength = 50;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 3;
            // 
            // cmbJenisKelamin
            // 
            this.cmbJenisKelamin.FormattingEnabled = true;
            this.cmbJenisKelamin.Items.AddRange(new object[] {
            "--Pilih Jenis Kelamin--- ",
            "",
            "",
            "Pria",
            "Wanita"});
            this.cmbJenisKelamin.Location = new System.Drawing.Point(503, 82);
            this.cmbJenisKelamin.Name = "cmbJenisKelamin";
            this.cmbJenisKelamin.Size = new System.Drawing.Size(121, 28);
            this.cmbJenisKelamin.TabIndex = 4;
            this.cmbJenisKelamin.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dtpTanggalLahir
            // 
            this.dtpTanggalLahir.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggalLahir.Location = new System.Drawing.Point(503, 132);
            this.dtpTanggalLahir.Name = "dtpTanggalLahir";
            this.dtpTanggalLahir.Size = new System.Drawing.Size(200, 26);
            this.dtpTanggalLahir.TabIndex = 5;
            // 
            // gbKelas
            // 
            this.gbKelas.Controls.Add(this.chkSepakBola);
            this.gbKelas.Controls.Add(this.chkBasket);
            this.gbKelas.Controls.Add(this.chkRenang);
            this.gbKelas.Controls.Add(this.chkBuluTangkis);
            this.gbKelas.Controls.Add(this.chkTennis);
            this.gbKelas.Controls.Add(this.chkVoli);
            this.gbKelas.Controls.Add(this.chkYoga);
            this.gbKelas.Controls.Add(this.chkPanahan);
            this.gbKelas.Location = new System.Drawing.Point(41, 191);
            this.gbKelas.Name = "gbKelas";
            this.gbKelas.Size = new System.Drawing.Size(332, 171);
            this.gbKelas.TabIndex = 6;
            this.gbKelas.TabStop = false;
            this.gbKelas.Text = "Pilihan Kelas";
            this.gbKelas.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // gbJadwal
            // 
            this.gbJadwal.Controls.Add(this.rbSeninRabu);
            this.gbJadwal.Controls.Add(this.rbSelasaKamis);
            this.gbJadwal.Controls.Add(this.rbSabtuMinggu);
            this.gbJadwal.Controls.Add(this.rbMingguMalam);
            this.gbJadwal.Location = new System.Drawing.Point(424, 191);
            this.gbJadwal.Name = "gbJadwal";
            this.gbJadwal.Size = new System.Drawing.Size(286, 171);
            this.gbJadwal.TabIndex = 7;
            this.gbJadwal.TabStop = false;
            this.gbJadwal.Text = "Pilihan Jadwal";
            this.gbJadwal.Enter += new System.EventHandler(this.gbJadwal_Enter);
            // 
            // chkSepakBola
            // 
            this.chkSepakBola.AutoSize = true;
            this.chkSepakBola.Location = new System.Drawing.Point(11, 25);
            this.chkSepakBola.Name = "chkSepakBola";
            this.chkSepakBola.Size = new System.Drawing.Size(117, 24);
            this.chkSepakBola.TabIndex = 8;
            this.chkSepakBola.Text = "Sepak Bola";
            this.chkSepakBola.UseVisualStyleBackColor = true;
            // 
            // chkBasket
            // 
            this.chkBasket.AutoSize = true;
            this.chkBasket.Location = new System.Drawing.Point(11, 55);
            this.chkBasket.Name = "chkBasket";
            this.chkBasket.Size = new System.Drawing.Size(85, 24);
            this.chkBasket.TabIndex = 9;
            this.chkBasket.Text = "Basket";
            this.chkBasket.UseVisualStyleBackColor = true;
            // 
            // chkRenang
            // 
            this.chkRenang.AutoSize = true;
            this.chkRenang.Location = new System.Drawing.Point(11, 96);
            this.chkRenang.Name = "chkRenang";
            this.chkRenang.Size = new System.Drawing.Size(92, 24);
            this.chkRenang.TabIndex = 10;
            this.chkRenang.Text = "Renang";
            this.chkRenang.UseVisualStyleBackColor = true;
            // 
            // chkBuluTangkis
            // 
            this.chkBuluTangkis.AutoSize = true;
            this.chkBuluTangkis.Location = new System.Drawing.Point(11, 136);
            this.chkBuluTangkis.Name = "chkBuluTangkis";
            this.chkBuluTangkis.Size = new System.Drawing.Size(126, 24);
            this.chkBuluTangkis.TabIndex = 11;
            this.chkBuluTangkis.Text = "Bulu Tangkis";
            this.chkBuluTangkis.UseVisualStyleBackColor = true;
            this.chkBuluTangkis.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // chkTennis
            // 
            this.chkTennis.AutoSize = true;
            this.chkTennis.Location = new System.Drawing.Point(196, 25);
            this.chkTennis.Name = "chkTennis";
            this.chkTennis.Size = new System.Drawing.Size(73, 24);
            this.chkTennis.TabIndex = 12;
            this.chkTennis.Text = "Tenis";
            this.chkTennis.UseVisualStyleBackColor = true;
            // 
            // chkVoli
            // 
            this.chkVoli.AutoSize = true;
            this.chkVoli.Location = new System.Drawing.Point(196, 55);
            this.chkVoli.Name = "chkVoli";
            this.chkVoli.Size = new System.Drawing.Size(61, 24);
            this.chkVoli.TabIndex = 13;
            this.chkVoli.Text = "Voli";
            this.chkVoli.UseVisualStyleBackColor = true;
            // 
            // chkYoga
            // 
            this.chkYoga.AutoSize = true;
            this.chkYoga.Location = new System.Drawing.Point(196, 96);
            this.chkYoga.Name = "chkYoga";
            this.chkYoga.Size = new System.Drawing.Size(73, 24);
            this.chkYoga.TabIndex = 14;
            this.chkYoga.Text = "Yoga";
            this.chkYoga.UseVisualStyleBackColor = true;
            // 
            // chkPanahan
            // 
            this.chkPanahan.AutoSize = true;
            this.chkPanahan.Location = new System.Drawing.Point(196, 136);
            this.chkPanahan.Name = "chkPanahan";
            this.chkPanahan.Size = new System.Drawing.Size(99, 24);
            this.chkPanahan.TabIndex = 15;
            this.chkPanahan.Text = "Panahan";
            this.chkPanahan.UseVisualStyleBackColor = true;
            // 
            // rbSeninRabu
            // 
            this.rbSeninRabu.AutoSize = true;
            this.rbSeninRabu.Location = new System.Drawing.Point(6, 24);
            this.rbSeninRabu.Name = "rbSeninRabu";
            this.rbSeninRabu.Size = new System.Drawing.Size(244, 24);
            this.rbSeninRabu.TabIndex = 16;
            this.rbSeninRabu.TabStop = true;
            this.rbSeninRabu.Text = "Senin s/d Rabu, 14.00 - 16.00";
            this.rbSeninRabu.UseVisualStyleBackColor = true;
            // 
            // rbSelasaKamis
            // 
            this.rbSelasaKamis.AutoSize = true;
            this.rbSelasaKamis.Location = new System.Drawing.Point(6, 66);
            this.rbSelasaKamis.Name = "rbSelasaKamis";
            this.rbSelasaKamis.Size = new System.Drawing.Size(256, 24);
            this.rbSelasaKamis.TabIndex = 17;
            this.rbSelasaKamis.TabStop = true;
            this.rbSelasaKamis.Text = "Selasa s/d Kamis, 14.00 - 16.00";
            this.rbSelasaKamis.UseVisualStyleBackColor = true;
            // 
            // rbMingguMalam
            // 
            this.rbMingguMalam.AutoSize = true;
            this.rbMingguMalam.Location = new System.Drawing.Point(6, 141);
            this.rbMingguMalam.Name = "rbMingguMalam";
            this.rbMingguMalam.Size = new System.Drawing.Size(187, 24);
            this.rbMingguMalam.TabIndex = 18;
            this.rbMingguMalam.TabStop = true;
            this.rbMingguMalam.Text = "Minggu, 13.00 - 20.00";
            this.rbMingguMalam.UseVisualStyleBackColor = true;
            // 
            // rbSabtuMinggu
            // 
            this.rbSabtuMinggu.AutoSize = true;
            this.rbSabtuMinggu.Location = new System.Drawing.Point(6, 105);
            this.rbSabtuMinggu.Name = "rbSabtuMinggu";
            this.rbSabtuMinggu.Size = new System.Drawing.Size(259, 24);
            this.rbSabtuMinggu.TabIndex = 19;
            this.rbSabtuMinggu.TabStop = true;
            this.rbSabtuMinggu.Text = "Sabtu s/d Minggu, 09.00 - 11.00";
            this.rbSabtuMinggu.UseVisualStyleBackColor = true;
            // 
            // btnTampilkan
            // 
            this.btnTampilkan.Location = new System.Drawing.Point(261, 387);
            this.btnTampilkan.Name = "btnTampilkan";
            this.btnTampilkan.Size = new System.Drawing.Size(112, 30);
            this.btnTampilkan.TabIndex = 20;
            this.btnTampilkan.Text = "Tampilkan";
            this.btnTampilkan.UseVisualStyleBackColor = true;
            this.btnTampilkan.Click += new System.EventHandler(this.btnTampilkan_Click);
            // 
            // btnSelesai
            // 
            this.btnSelesai.Location = new System.Drawing.Point(430, 387);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(94, 30);
            this.btnSelesai.TabIndex = 21;
            this.btnSelesai.Text = "Selesai";
            this.btnSelesai.UseVisualStyleBackColor = true;
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(296, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 26);
            this.label4.TabIndex = 22;
            this.label4.Text = "FORM PENDAFTARAN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSelesai);
            this.Controls.Add(this.btnTampilkan);
            this.Controls.Add(this.gbJadwal);
            this.Controls.Add(this.gbKelas);
            this.Controls.Add(this.dtpTanggalLahir);
            this.Controls.Add(this.cmbJenisKelamin);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ULBI SPORT SCHOOL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbKelas.ResumeLayout(false);
            this.gbKelas.PerformLayout();
            this.gbJadwal.ResumeLayout(false);
            this.gbJadwal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbJenisKelamin;
        private System.Windows.Forms.DateTimePicker dtpTanggalLahir;
        private System.Windows.Forms.GroupBox gbKelas;
        private System.Windows.Forms.GroupBox gbJadwal;
        private System.Windows.Forms.CheckBox chkSepakBola;
        private System.Windows.Forms.CheckBox chkBasket;
        private System.Windows.Forms.CheckBox chkRenang;
        private System.Windows.Forms.CheckBox chkBuluTangkis;
        private System.Windows.Forms.CheckBox chkTennis;
        private System.Windows.Forms.CheckBox chkVoli;
        private System.Windows.Forms.CheckBox chkYoga;
        private System.Windows.Forms.CheckBox chkPanahan;
        private System.Windows.Forms.RadioButton rbSeninRabu;
        private System.Windows.Forms.RadioButton rbSelasaKamis;
        private System.Windows.Forms.RadioButton rbMingguMalam;
        private System.Windows.Forms.RadioButton rbSabtuMinggu;
        private System.Windows.Forms.Button btnTampilkan;
        private System.Windows.Forms.Button btnSelesai;
        private System.Windows.Forms.Label label4;
    }
}

