using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Program
    {
        static List<TNI> listTNI = new List<TNI>();
        static void Main(string[] args)
        {
            Console.Title = "Final Project Pemrograman";

            bool ulang = true;
            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahData();
                        break;

                    case 2:
                        HapusData();
                        break;

                    case 3:
                        TampilData();
                        break;

                    case 4:
                        ulang = false;
                        return;

                    default:
                        Console.Clear();
                        Console.WriteLine("Menu Tidak Ada");
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine("=================================================");
            Console.WriteLine("\tSistem Penghitungan Gaji TNI");
            Console.WriteLine("=================================================\n");
            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine();
            Console.WriteLine("1. Tambah Data");
            Console.WriteLine("2. Hapus Data");
            Console.WriteLine("3. Tampilkan Data");
            Console.WriteLine("4. Keluar");
        }

        static void TambahData()
        {
            Console.Clear();
            Console.WriteLine("=================================================");
            Console.WriteLine("\tTambah Data TNI");
            Console.WriteLine("=================================================\n");
            Console.Write("Jenis TNI [1. TNI-AL, 2. TNI-AD, 3. TNI-AU] : ");
            int pil = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            switch (pil)
            {
                case 1:
                    TNI_AL tni_al = new TNI_AL();
                    Console.Write("NIT : ");
                    tni_al.NIP = Console.ReadLine();
                    Console.Write("Nama : ");
                    tni_al.Nama = Console.ReadLine();
                    Console.Write("Gaji Pokok : ");
                    tni_al.GajiPokok = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Tunjangan : ");
                    tni_al.Tunjangan = Convert.ToDouble(Console.ReadLine());
                    listTNI.Add(tni_al);
                    break;
                case 2:
                    TNI_AD tni_ad = new TNI_AD();
                    Console.Write("NIT : ");
                    tni_ad.NIP = Console.ReadLine();
                    Console.Write("Nama : ");
                    tni_ad.Nama = Console.ReadLine();
                    Console.Write("Gaji Bulanan : ");
                    tni_ad.GajiBulanan = Convert.ToDouble(Console.ReadLine());
                    listTNI.Add(tni_ad);
                    break;
                case 3:
                    TNI_AU tni_au = new TNI_AU();
                    Console.Write("NIT : ");
                    tni_au.NIP = Console.ReadLine();
                    Console.Write("Nama : ");
                    tni_au.Nama = Console.ReadLine();
                    Console.Write("Jumlah Jam Kerja : ");
                    tni_au.JumlahJamKerja = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Upah Per Jam : ");
                    tni_au.UpahPerJam = Convert.ToDouble(Console.ReadLine());
                    listTNI.Add(tni_au);
                    break;
                default:
                    Console.WriteLine("Menu Yang Anda Masukkan Salah!!!");
                    break;
            }
        }

        static void HapusData()
        {
            Console.Clear();

            int nomor = -1, hapus = -1;
            Console.WriteLine("=================================================");
            Console.WriteLine("\tHapus Data");
            Console.WriteLine("=================================================\n");
            Console.Write("NIP : ");
            string code = Console.ReadLine();
            foreach (TNI Tni in listTNI)
            {
                nomor++;
                if (Tni.NIP == code)
                {
                    hapus = nomor;
                }
            }

            if (hapus != -1)
            {
                listTNI.RemoveAt(hapus);
                Console.WriteLine("\nData dapat dihapus");
            }

            else
            {
                Console.WriteLine("\nNIT tidak dapat ditemukan");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilData()
        {
            Console.Clear();

            int noUrut = 0;
            string jenis = " ";
            Console.WriteLine("=================================================");
            Console.WriteLine("\tData TNI");
            Console.WriteLine("=================================================\n");
            foreach (TNI Tni in listTNI)
            {
                if (Tni is TNI_AL)
                {
                    jenis = "Tentara Nasional Angkatan Laut";
                }
                else if (Tni is TNI_AD)
                {
                    jenis = "Tentara Nasional Angkatan Darat";
                }
                else
                {
                    jenis = "Tentara Nasional Angkatan Udara";
                }
                noUrut++;
                Console.WriteLine("{0}. NIT: {1}, Nama: {2}, Gaji: {3:}, {4}", noUrut, Tni.NIP, Tni.Nama, Tni.Gaji(), jenis);
            }
            if (noUrut < 1)
            {
                Console.WriteLine("Data TNI Kosong");
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}