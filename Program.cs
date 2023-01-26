using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayının_karesini_alma
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Lütfen Bir Sayı Girirniz");
            int sayi = Int32.Parse(Console.ReadLine());
            int karesi = sayi * sayi;
            int sonuc=(sayi*sayi);
            Console.WriteLine("Sayının Karesi Şudur{0}",sonuc);
            Console.ReadLine();


        }
    }
}
