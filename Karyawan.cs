using System;

namespace ResponsiPemrograman4316
{
    public class Karyawan
    {
        private int Nik;
        private string Nama;

        private double GajiBulanan;
     public Karyawan(int nik, string nama, double gajiBulanan)
     {
         this.Nik = nik;
         this.Nama = nama;
         this.GajiBulanan = gajiBulanan;
     }

     public void TampilGajiKaryawan(){
         if (GajiBulanan < 0)
         {
            GajiBulanan= 0;
             Console.WriteLine("{0} {1}\t{2}", Nik, Nama, GajiBulanan );
         } else {
             Console.WriteLine("{0} {1}\t{2}", Nik, Nama, GajiBulanan );
         }
     }
     public void BonusGajiKaryawan(){
         GajiBulanan = (GajiBulanan * 0.1) + GajiBulanan;
         
         Console.WriteLine("{0} {1}\t{2}", Nik, Nama, GajiBulanan );
     }
    }
}
