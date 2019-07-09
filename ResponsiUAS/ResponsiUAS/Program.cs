using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiUAS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS 18.11.2269";
            List<Produk> listProduk = new List<Produk>();

            int pil;
            do
            {
                Console.Clear();

                Console.WriteLine("Pilih Menu Aplikasi\n");
                Console.WriteLine("1. Tambah Produk");
                Console.WriteLine("2. Hapus Produk");
                Console.WriteLine("3. Tampilkan Produk");
                Console.WriteLine("4. Keluar");

                Console.Write("\nNomor Menu [1..4] : ");
                pil = Convert.ToInt32(Console.ReadLine());

                switch(pil)
                {
                    case 1:
                        Tambah();
                        break;
                    case 2:
                        Hapus();
                        break;
                    case 3:
                        Tampil();
                        break;
                    default:
                        Console.WriteLine("\nMaaf, angka tidak valid!");
                        break;
                }
            } while (pil != 4);

            void Tambah()
            {
                Console.Clear();
                Produk produk = new Produk();

                Console.WriteLine("Tambah Data Produk\n");
                Console.Write("Kode Produk  : ");
                produk.KodeProduk = Console.ReadLine();

                Console.Write("Nama Produk  : ");
                produk.NamaProduk = Console.ReadLine();

                Console.Write("Harga Beli   : ");
                produk.HargaBeli = Convert.ToInt32(Console.ReadLine());

                Console.Write("Harga Jual   : ");
                produk.HargaJual = Convert.ToInt32(Console.ReadLine());

                listProduk.Add(produk);

                Bersih();
            }

            void Tampil()
            {
                Console.Clear();
                Console.WriteLine("Data Produk\n");

                int noUrut = 1;
                foreach (Produk produk in listProduk)
                {
                    Console.WriteLine("{0}. {1}, {2}, {3}, {4}", noUrut, produk.KodeProduk, produk.NamaProduk, produk.HargaBeli, produk.HargaJual);
                    noUrut++;
                }

                Bersih();
            }

            void Hapus()
            {
                Console.Clear();
                Console.WriteLine("Hapus Data Produk\n");

                Console.Write("Kode Produk : ");
                string kode = Console.ReadLine();

                Produk produk = new Produk();
                produk = listProduk.SingleOrDefault(f => f.KodeProduk == kode);

                if(produk != null)
                {
                    listProduk.Remove(produk);
                    Console.WriteLine("\nData produk berhasil dihapus");
                }
                else
                {
                    Console.WriteLine("\nKode produk tidak ditemukan");
                }

                Bersih();
            }

            void Bersih()
            {
                Console.Write("\nTekan ENTER untuk kembali ke menu");
                Console.ReadKey();
            }
        }
    }
}
