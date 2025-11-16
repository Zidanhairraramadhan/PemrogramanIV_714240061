using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_4_714240061
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // Validasi Pilihan Kelas (Harus minimal 1 terpilih)
            bool isKelasSelected = false;
            foreach (Control control in gbKelas.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    isKelasSelected = true;
                    break;
                }
            }

            if (!isKelasSelected)
            {
                MessageBox.Show("Harus memilih salah satu dari pilihan kelas",
                                "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbJenisKelamin.SelectedIndex = 0;
            // 1. Mengatur Format ke Custom
            dtpTanggalLahir.Format = DateTimePickerFormat.Custom;

            // 2. Mengatur CustomFormat ke 'dd MMMM yyyy'
            dtpTanggalLahir.CustomFormat = "dd MMMM yyyy";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            // Variabel-variabel yang perlu diinisialisasi di awal
            string pilihanJadwal = "gbJadwal";
            bool isKelasSelected = false;
            bool isJadwalSelected = false;

            // --- A. Validasi Pilihan Kelas (CheckBoxes) ---
            // (PENTING: Ganti 'gbKelas' dengan nama GroupBox yang sebenarnya)
            foreach (Control control in gbKelas.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    isKelasSelected = true;
                    break;
                }
            }

            if (!isKelasSelected)
            {
                MessageBox.Show("Harus memilih salah satu dari pilihan kelas",
                                "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // --- B. Validasi Pilihan Jadwal (RadioButtons) ---
            // (PENTING: Ganti 'gbJadwal' dengan nama GroupBox yang sebenarnya)
            foreach (Control control in gbJadwal.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    isJadwalSelected = true;
                    pilihanJadwal = radioButton.Text; // Pilihan Jadwal DIISI DI SINI
                    break;
                }
            }

            if (!isJadwalSelected)
            {
                MessageBox.Show("Harus memilih salah satu dari pilihan jadwal",
                                "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // =======================================================================
            // --- C. Pengumpulan Data & Tampilan Output ---
            // =======================================================================

            // 1. Kumpulkan Pilihan Kelas
            string pilihanKelas = "gbKelas";
            // (PENTING: Ganti 'gbKelas' dengan nama GroupBox yang sebenarnya)
            foreach (Control control in gbKelas.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    pilihanKelas += checkBox.Text + ", ";
                }
            }
            // Hapus koma dan spasi terakhir
            if (pilihanKelas.Length > 2)
            {
                pilihanKelas = pilihanKelas.Substring(0, pilihanKelas.Length - 2);
            }

            // 2. Buat pesan output (pilihanJadwal sudah terisi di Bagian B)
            string message = $"Nama: {textBox1.Text}\n" +
                             $"Jenis Kelamin: {cmbJenisKelamin.SelectedItem.ToString()}\n" +
                             $"Tanggal Lahir: {dtpTanggalLahir.Text}\n" +
                             $"Pilihan Kelas: {pilihanKelas}\n" +
                             $"Pilihan Jadwal: {pilihanJadwal}";

            // 3. Tampilkan informasi pendaftaran
            MessageBox.Show(message, "Informasi Pendaftaran",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gbJadwal_Enter(object sender, EventArgs e)
        {
            // Validasi Pilihan Jadwal (Harus 1 terpilih)
            bool isJadwalSelected = false;
            string pilihanJadwal = "";

            foreach (Control control in gbJadwal.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    isJadwalSelected = true;
                    pilihanJadwal = radioButton.Text; // Ambil teks jadwal
                    break;
                }
            }

            if (!isJadwalSelected)
            {
                MessageBox.Show("Harus memilih salah satu dari pilihan jadwal",
                                "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
