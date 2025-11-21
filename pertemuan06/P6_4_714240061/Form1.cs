using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace P6_4_714240061
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void ClearAllErrors(Control control)
        {
            epWarning.SetError(control, "");
            epWrong.SetError(control, "");
            epCorrect.SetError(control, "");
        }

        

        // A. NUMERIC VALIDATOR (Event KeyPress)
        private void txtNumeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // B. CHAR VALIDATOR (Event KeyPress)
        private void txtChar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Form_Load (Untuk penataan, seperti yang sudah kita buat)
        private void Form1_Load(object sender, EventArgs e)
        {
            // ... (Kode penataan Form1_Load yang rapi diletakkan di sini) ...
            // Jika Anda sudah menaruhnya di Designer, Anda bisa mengosongkan ini.
        }

       
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // --- 1. Bersihkan semua ErrorProvider sebelum memulai pengecekan ---
            ClearAllErrors(txtNumeric);
            ClearAllErrors(txtChar);
            ClearAllErrors(txtRequired);
            ClearAllErrors(txtRegex);
            ClearAllErrors(txtCompare1);
            ClearAllErrors(txtCompare2);
            ClearAllErrors(txtLength);
            ClearAllErrors(txtUpper);
            ClearAllErrors(txtLower);

            bool isFormValid = true;

           
            if (this.txtNumeric.Text.Length != 5) // Contoh Length: harus 5 digit
            {
                epWrong.SetError(this.txtNumeric, "ID Anggota harus 5 digit!");
                isFormValid = false;
            }
            // Karena KeyPress sudah membatasi input, kita asumsikan jika panjang benar, inputnya valid
            else
            {
                epCorrect.SetError(this.txtNumeric, "ID sudah benar.");
            }

            if (string.IsNullOrWhiteSpace(this.txtChar.Text))
            {
                epWrong.SetError(this.txtChar, "Nama wajib diisi.");
                isFormValid = false;
            }
            else
            {
                epCorrect.SetError(this.txtChar, "Nama sudah valid.");
            }

            
            if (string.IsNullOrWhiteSpace(this.txtRequired.Text))
            {
                epWrong.SetError(this.txtRequired, "Alamat wajib diisi!");
                isFormValid = false;
            }
            else
            {
                epCorrect.SetError(this.txtRequired, "Alamat sudah terisi.");
            }

            
            if (!Regex.IsMatch(this.txtRegex.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                epWrong.SetError(this.txtRegex, "Format Email tidak valid!");
                isFormValid = false;
            }
            else if (this.txtRegex.Text.EndsWith(".co") || this.txtRegex.Text.EndsWith(".biz"))
            {
                // Contoh penggunaan epWarning
                epWarning.SetError(this.txtRegex, "Domain non-standar terdeteksi.");
            }
            else
            {
                epCorrect.SetError(this.txtRegex, "Email valid.");
            }

            
            if (string.IsNullOrWhiteSpace(this.txtCompare1.Text) || string.IsNullOrWhiteSpace(this.txtCompare2.Text))
            {
                epWrong.SetError(this.txtCompare1, "Password wajib diisi!");
                epWrong.SetError(this.txtCompare2, "Konfirmasi wajib diisi!");
                isFormValid = false;
            }
            else if (this.txtCompare1.Text != this.txtCompare2.Text)
            {
                epWrong.SetError(this.txtCompare1, "Password tidak cocok!");
                epWrong.SetError(this.txtCompare2, "Password tidak cocok!");
                isFormValid = false;
            }
            else
            {
                epCorrect.SetError(this.txtCompare1, "Password cocok.");
                epCorrect.SetError(this.txtCompare2, "Password cocok.");
            }

           
            if (this.txtLength.Text.Length < 5 || this.txtLength.Text.Length > 10)
            {
                epWrong.SetError(this.txtLength, "Panjang harus 5-10 karakter!");
                isFormValid = false;
            }
            else
            {
                epCorrect.SetError(this.txtLength, "Panjang sesuai.");
            }

            if (!string.IsNullOrWhiteSpace(this.txtUpper.Text))
                epCorrect.SetError(this.txtUpper, "Otomatis Upper Case.");

            if (!string.IsNullOrWhiteSpace(this.txtLower.Text))
                epCorrect.SetError(this.txtLower, "Otomatis Lower Case.");

           
            if (isFormValid)
            {
                string hasil =
                    "--- HASIL ISIAN FORM ---" + "\n" +
                    "ID Anggota (a, f) : " + this.txtNumeric.Text + "\n" +
                    "Nama (b, g)       : " + this.txtChar.Text + "\n" +
                    "Alamat (c)        : " + this.txtRequired.Text + "\n" +
                    "Email (d)         : " + this.txtRegex.Text + "\n" +
                    "Password (e)      : ******" + "\n" +
                    "Kode Promo (f)    : " + this.txtLength.Text + "\n" +
                    "Nama Ibu (g)      : " + this.txtUpper.Text + "\n" +
                    "Catatan (h)       : " + this.txtLower.Text;

                MessageBox.Show(hasil, "HASIL VALIDASI SUKSES");
            }
            else
            {
                MessageBox.Show("Terdapat kesalahan dalam pengisian form. Silakan periksa ikon merah.", "Validasi Gagal");
            }
        }
    }
}