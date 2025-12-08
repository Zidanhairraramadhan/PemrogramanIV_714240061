using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P9_714240061
{

    public partial class Form1 : Form
    {
        Koneksi koneksi = new Koneksi();

        public Form1()
        {
            InitializeComponent();
        }
        public void Tampil()
        {
            // Query SELECT untuk mengambil semua data mahasiswa
            string query = "SELECT * FROM t_mahasiswa";

            // Memanggil method ShowData() dari class Koneksi
            DataMahasiswa.DataSource = koneksi.ShowData(query);

            // Mengubah nama header kolom (opsional, tetapi dianjurkan)
            DataMahasiswa.Columns[0].HeaderText = "NPM";
            DataMahasiswa.Columns[1].HeaderText = "Nama";
            DataMahasiswa.Columns[2].HeaderText = "Angkatan";
            DataMahasiswa.Columns[3].HeaderText = "Alamat";
            DataMahasiswa.Columns[4].HeaderText = "Email";
            DataMahasiswa.Columns[5].HeaderText = "No HP";
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            Tampil();
        }
    }
}
