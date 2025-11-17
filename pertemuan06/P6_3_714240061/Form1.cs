using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace P6_5_714240061
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
            private void SetErrorMessages(TextBox textBox, string warningMessage, string wrongMessage, string correctMessage)
        {
            epWarning.SetError(textBox, warningMessage); // Parameter 2: Pesan Peringatan
            epWrong.SetError(textBox, wrongMessage);     // Parameter 3: Pesan Kesalahan
            epCorrect.SetError(textBox, correctMessage); // Parameter 4: Pesan Sukses
        }
        private void CheckAngka1GreaterThanAngka2()
        {
            // Cek apakah kedua textbox tidak kosong dan hanya berisi angka
            if (!string.IsNullOrEmpty(txtAngka1.Text) && txtAngka1.Text.All(Char.IsNumber) &&
                !string.IsNullOrEmpty(txtAngka2.Text) && txtAngka2.Text.All(Char.IsNumber))
            {
                // Lakukan konversi string ke integer
                int angka1 = Convert.ToInt32(txtAngka1.Text);
                int angka2 = Convert.ToInt32(txtAngka2.Text);

                // Lakukan perbandingan
                if (angka1 > angka2)
                {
                    // Angka 1 > Angka 2: Tampilkan ikon "correct" (hijau)
                    SetErrorMessages(txtAngka1, "", "", "Betul!");
                    SetErrorMessages(txtAngka2, "", "", "Betul!");
                }
                else
                {
                    // Angka 1 <= Angka 2: Tampilkan ikon "wrong" (merah)
                    string errorMessage = "Angka 1 harus lebih besar dari Angka 2";
                    SetErrorMessages(txtAngka1, "", errorMessage, "");
                    SetErrorMessages(txtAngka2, "", errorMessage, "");
                }
            }
        }

        private void txtHuruf_Leave(object sender, EventArgs e)
        {
            if (txtHuruf.Text == "")
            {
                // Peringatan: Input kosong (isi parameter 2)
                SetErrorMessages(txtHuruf, "Textbox Huruf tidak boleh kosong!", "", "");
            }
            else if (txtHuruf.Text.All(Char.IsLetter))
            {
                // Sukses: Semua adalah huruf (isi parameter 4)
                SetErrorMessages(txtHuruf, "", "", "Betul!");
            }
            else
            {
                // Salah: Input bukan hanya huruf (isi parameter 3)
                SetErrorMessages(txtHuruf, "", "Inputan hanya boleh huruf!", "");
            }
        }

        private void txtAngka_TextChanged(object sender, EventArgs e)
        {
            if (txtAngka.Text == "")
            {
                // Peringatan: Input kosong
                SetErrorMessages(txtAngka, "Textbox Angka tidak boleh kosong!", "", "");
            }
            else if (txtAngka.Text.All(Char.IsNumber))
            {
                // Sukses: Semua adalah angka
                SetErrorMessages(txtAngka, "", "", "Betul!");
            }
            else
            {
                // Salah: Input bukan hanya angka
                SetErrorMessages(txtAngka, "", "Inputan hanya boleh angka!", "");
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                // Peringatan: Input kosong
                SetErrorMessages(txtEmail, "Textbox Email tidak boleh kosong!", "", "");
            }
            else if (Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+(\.[^@\s]+)+$")) // Regex email yang disederhanakan
            {
                // Sukses: Format email benar
                SetErrorMessages(txtEmail, "", "", "Betul!");
            }
            else
            {
                // Salah: Format email salah
                SetErrorMessages(txtEmail, "", "Format email salah!\nContoh: a@b.c", "");
            }
        }

        private void txtAngka1_Leave(object sender, EventArgs e)
        {
            if (txtAngka1.Text == "")
            {
                SetErrorMessages(txtAngka1, "Textbox Angka 1 tidak boleh kosong!", "", "");
            }
            else if (!txtAngka1.Text.All(Char.IsNumber))
            {
                SetErrorMessages(txtAngka1, "", "Inputan Angka 1 hanya boleh angka!", "");
            }
            else
            {
                SetErrorMessages(txtAngka1, "", "", "Betul!");

                // 2. Jika Angka 2 sudah terisi, lakukan pengecekan pada Angka 2 (Bagian c)
                if (!string.IsNullOrEmpty(txtAngka2.Text))
                {
                    CheckAngka1GreaterThanAngka2();
                }
            }
        }

        private void txtAngka2_Leave(object sender, EventArgs e)
        {
            if (txtAngka2.Text == "")
            {
                SetErrorMessages(txtAngka2, "Textbox Angka 2 tidak boleh kosong!", "", "");
            }
            else if (!txtAngka2.Text.All(Char.IsNumber))
            {
                SetErrorMessages(txtAngka2, "", "Inputan Angka 2 hanya boleh angka!", "");
            }
            else
            {
                SetErrorMessages(txtAngka2, "", "", "Betul!");

                // 2. Setelah Angka 2 terisi, lakukan pengecekan perbandingan (Bagian c)
                CheckAngka1GreaterThanAngka2();
            }
        }
    }
}
