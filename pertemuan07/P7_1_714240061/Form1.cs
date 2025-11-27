using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P7_1_714240061
{
    public partial class Form1 : Form
    {
        // Ukuran Form Penuh (Estimasi Size)
        private readonly Size FULL_SIZE = new Size(327, 508);

        // Ukuran Form Awal/Kecil (Estimasi Size agar hanya input terlihat)
        private readonly Size INITIAL_SIZE = new Size(327, 220);

        // Offset untuk menyesuaikan posisi kontrol KEGIATAN
        private const int Y_OFFSET = 70;

        // Constructor Form1
        public Form1()
        {
            InitializeComponent();

            // Mengisi item ComboBox (PENTING)
            comboBoxAngkatan.Items.Add("2022");
            comboBoxAngkatan.Items.Add("2023");
            comboBoxAngkatan.Items.Add("2024");

            // Pindahkan Kontrol KEGIATAN ke bawah (dynamic layout adjustment)
            AdjustControlPositions();

            // Mengatur ukuran form ke ukuran awal (kecil)
            this.Size = INITIAL_SIZE;
        }

        // Method untuk menyesuaikan posisi kontrol KEGIATAN secara dinamis
        private void AdjustControlPositions()
        {
            // label4 (KEGIATAN) 
            label4.Location = new Point(label4.Location.X, label4.Location.Y + Y_OFFSET);

            // RadioButton
            radioButtonWeekday.Location = new Point(radioButtonWeekday.Location.X, radioButtonWeekday.Location.Y + Y_OFFSET);
            radioButtonWeekend.Location = new Point(radioButtonWeekend.Location.X, radioButtonWeekend.Location.Y + Y_OFFSET);

            // CheckBoxes
            checkBoxKuliah.Location = new Point(checkBoxKuliah.Location.X, checkBoxKuliah.Location.Y + Y_OFFSET);
            checkBoxTidur.Location = new Point(checkBoxTidur.Location.X, checkBoxTidur.Location.Y + Y_OFFSET);
            checkBoxLiburan.Location = new Point(checkBoxLiburan.Location.X, checkBoxLiburan.Location.Y + Y_OFFSET);

            // Buttons Print dan Reset
            buttonPrint.Location = new Point(buttonPrint.Location.X, buttonPrint.Location.Y + Y_OFFSET);
            buttonReset.Location = new Point(buttonReset.Location.X, buttonReset.Location.Y + Y_OFFSET);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Kosong
        }

        // 5. Event Handler Tombol TUTUP
        private void buttonTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 6. & 7. Event Handler Tombol CEK (Validasi dan Resize)
        private void buttonCek_Click(object sender, EventArgs e)
        {
            StringBuilder errorMessage = new StringBuilder();

            if (string.IsNullOrWhiteSpace(textBoxNama.Text))
            {
                errorMessage.AppendLine("Nama harus diisi!");
            }
            // Validasi Angkatan
            if (comboBoxAngkatan.SelectedIndex == -1)
            {
                errorMessage.AppendLine("Angkatan harus diisi!");
            }
            if (string.IsNullOrWhiteSpace(textBoxKelas.Text))
            {
                errorMessage.AppendLine("Kelas harus diisi!");
            }

            string errorString = errorMessage.ToString();

            if (string.IsNullOrEmpty(errorString))
            {
                MessageBox.Show(
                    "Lengkap",
                    "Informasi Data Submit",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Ubah ukuran form ke ukuran penuh (Besar)
                this.Size = FULL_SIZE;
            }
            else
            {
                MessageBox.Show(
                    errorString.Trim(),
                    "Informasi Data Submit",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // 8. Event Handler RadioButton Weekday (Senin-Jum'at)
        private void radioButtonWeekday_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonWeekday.Checked)
            {
                checkBoxKuliah.Enabled = true; checkBoxKuliah.Checked = false;
                checkBoxTidur.Enabled = true; checkBoxTidur.Checked = false;
                checkBoxLiburan.Enabled = false; checkBoxLiburan.Checked = false;
            }
        }

        // 8. Event Handler RadioButton Weekend (Sabtu-Minggu)
        private void radioButtonWeekend_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonWeekend.Checked)
            {
                checkBoxKuliah.Enabled = false; checkBoxKuliah.Checked = false;
                checkBoxTidur.Enabled = true; checkBoxTidur.Checked = false;
                checkBoxLiburan.Enabled = true; checkBoxLiburan.Checked = false;
            }
        }

        // 9. Event Handler Tombol PRINT
        private void buttonPrint_Click(object sender, EventArgs e)
        {
            string hari = Controls.OfType<RadioButton>()
                .FirstOrDefault(rb => rb.Checked)?.Text;

            string kegiatan = string.Join(", ",
                Controls.OfType<CheckBox>()
                .Where(cb => cb.Checked)
                .Select(cb => cb.Text));

            MessageBox.Show(
                "Nama: " + textBoxNama.Text + "\n" +
                "Angkatan: " + comboBoxAngkatan.Text + "\n" +
                "Kelas: " + textBoxKelas.Text + "\n" +
                "Hari: " + hari + "\n" +
                "Kegiatan: " + kegiatan,
                "Informasi Data Submit",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 10. Event Handler Tombol RESET
        private void buttonReset_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                }
                else if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
                else if (control is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }
            }

            MessageBox.Show(
                "Form Berhasil Direset!!",
                "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Kembalikan ukuran form ke ukuran awal (kecil)
            this.Size = INITIAL_SIZE;
        }

        private void buttonPrint_Click_1(object sender, EventArgs e)
        {

        }
    }
}