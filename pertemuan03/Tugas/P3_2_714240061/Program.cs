using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_2_714240061
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variabel untuk mengontrol perulangan menu
            char repeat = 'Y';

            // Loop do-while agar menu tampil setidaknya satu kali
            do
            {
                // 1. Menampilkan Menu
                Console.Clear(); // Membersihkan konsol setiap kali menu diulang
                Console.WriteLine("=== MENU PERSEGI PANJANG ===");
                Console.WriteLine("1. Hitung Luas");
                Console.WriteLine("2. Hitung Keliling");
                Console.WriteLine("3. Keluar");
                Console.Write("Pilih menu (1-3): ");

                // 2. Membaca pilihan menu user
                int choice;
                // Menggunakan int.TryParse untuk error handling jika input bukan angka
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    choice = -1; // Set ke nilai invalid jika input bukan angka
                }

                // Deklarasi variabel untuk panjang dan lebar
                double panjang, lebar;

                // 3. Proses pemilihan menu menggunakan switch
                switch (choice)
                {
                    case 1:
                        // --- Menu 1: Hitung Luas ---
                        Console.Write("Masukkan panjang: ");
                        panjang = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Masukkan lebar: ");
                        lebar = Convert.ToDouble(Console.ReadLine());

                        // Rumus Luas
                        double luas = panjang * lebar;
                        Console.WriteLine("Luas Persegi Panjang: " + luas);
                        break;

                    case 2:
                        // --- Menu 2: Hitung Keliling ---
                        Console.Write("Masukkan panjang: ");
                        panjang = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Masukkan lebar: ");
                        lebar = Convert.ToDouble(Console.ReadLine());

                        // Rumus Keliling
                        double keliling = 2 * (panjang + lebar);
                        Console.WriteLine("Keliling Persegi Panjang: " + keliling);
                        break;

                    case 3:
                        // --- Menu 3: Keluar ---
                        Console.WriteLine("Program selesai.");
                        repeat = 'T'; // Set 'repeat' ke 'T' untuk keluar dari loop
                        break;

                    default:
                        // --- Pilihan tidak valid ---
                        Console.WriteLine("Menu tidak tersedia. Silakan pilih menu yang valid.");
                        break;
                }

                // 4. Konfirmasi pengulangan program
                // Hanya bertanya jika user tidak memilih '3. Keluar'
                if (choice != 3)
                {
                    Console.Write("\nIngin mengulang kembali (Y/T)? ");
                    repeat = Convert.ToChar(Console.ReadLine());
                }

                // Loop akan terus berjalan selama 'repeat' adalah 'Y' atau 'y'
            } while (repeat == 'Y' || repeat == 'y');

            // 5. Pesan penutup
            // Tampil setelah loop selesai (baik karena memilih '3' atau 'T')
            Console.WriteLine("Terima kasih!");
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey(); // Menahan konsol agar tidak langsung tertutup
        }
    }
}

