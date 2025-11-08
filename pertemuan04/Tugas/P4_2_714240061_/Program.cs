using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714240061_
{
    public class Mahasiswa
    {
        // Field private
        private string _nama;
        private string _kelas;
        private string _npm;

        // Property public untuk akses yang terkontrol (Encapsulation)
        public string Nama
        {
            get { return _nama; }
            // Set private agar hanya bisa diubah melalui constructor atau method di dalam class
            private set { _nama = value; }
        }

        public string Kelas
        {
            get { return _kelas; }
            private set { _kelas = value; }
        }

        public string Npm
        {
            get { return _npm; }
            private set { _npm = value; }
        }

        // Constructor (Menginisialisasi objek saat dibuat)
        public Mahasiswa(string nama, string kelas, string npm)
        {
            // Menggunakan set method dari Property
            Nama = nama;
            Kelas = kelas;
            Npm = npm;
        }

        // Method untuk menampilkan data mahasiswa
        public void TampilkanData()
        {
            Console.WriteLine($"- Nama: {Nama}");
            Console.WriteLine($"  Kelas: {Kelas}");
            Console.WriteLine($"  NPM: {Npm}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Data Mahasiswa Kelas 2C ===");
            Console.WriteLine("-------------------------------\n");

            // Membuat objek Mahasiswa (Menggunakan Constructor)
            Mahasiswa mhs1 = new Mahasiswa("Zidan Hairra Ramadhan", "2C", "714240061");
            Mahasiswa mhs2 = new Mahasiswa("Malik", "2C", "714240062");
            Mahasiswa mhs3 = new Mahasiswa("Bagus Tri Atmaza", "2C", "714240060");

            // Menggunakan List untuk menyimpan dan mengelola data
            List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa> { mhs1, mhs2, mhs3 };

            // Menampilkan output untuk setiap mahasiswa
            foreach (var mhs in daftarMahasiswa)
            {
                mhs.TampilkanData();
                Console.WriteLine(); // Baris kosong antar mahasiswa
            }

            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Mahasiswa Kelas 2C : {daftarMahasiswa.Count} Mahasiswa.");
            Console.ReadKey();
        }
    }
}
