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


            Console.WriteLine("Lütfen 1. Sayıyı Girirniz");
            int sayi = Int32.Parse(Console.ReadLine());
            int karesi = sayi * sayi;
            Console.WriteLine("Lütfen 2. Sayıyı Giriniz");
            int sayi = Int32.Parse(Console.ReadLine());
            int karesi = sayi * sayi;
            Console.ReadLine();


        }
    }
}
