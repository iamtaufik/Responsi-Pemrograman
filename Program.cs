using System;

namespace ResponsiPemrograman4316
{
    class Program
    {
        static void Main(string[] args)
        {
            var karyawan1 = new Karyawan(1928282,"Paijo", 3000000);
            var karyawan2 = new Karyawan(1934566,"Jono", 4000000);

            Console.WriteLine("Nik Nama\tGaji Bulanan");
            Console.WriteLine("-------------------------------");
            karyawan1.TampilGajiKaryawan();
            karyawan2.TampilGajiKaryawan();
            
            Console.WriteLine();
            Console.WriteLine("Asyik kenaikan gaji 10%!!");
            Console.WriteLine();

            Console.WriteLine("Nik Nama\tGaji Bulanan");
            Console.WriteLine("-------------------------------");
            karyawan1.BonusGajiKaryawan();
            karyawan2.BonusGajiKaryawan();

            Console.ReadKey();
        }
    }
}
