using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ogrenci ogrenci1 = new ogrenci(1, "Ayse", "Sogut", 56, 64, 47, "BANÜ");

            Console.WriteLine("UYGULAMAYA HOŞGELDİNİZ...");
            Console.WriteLine("Yapılmak istenen işlemi seçiniz:");

            islemleriGoster();

            while (true)
            {
                string secim = Console.ReadLine();
                switch (secim)
                {
                    case "1":
                        ogrenci1.ogrenciBilgileriGoster();
                        break;
                   case "2":
                        double ogrenciOrtalama=ogrenci1.ogrenciOrtalamasiBul();
                        Console.WriteLine("Öğrencinin ortalaması:" + ogrenciOrtalama);
                        break;
                   case "3":
                        ogrenci1.okulGetir();
                        break;
                   case "4":
                        Console.WriteLine("Çıkış yap");
                        break;

                    default:
                        Console.WriteLine("Böyle bir işlem yapamazsınız...");
                        break;



                }
            }
        }
        static void islemleriGoster()
        {
            Console.WriteLine("1- öğrenci bilgileri göster.");
            Console.WriteLine("2-öğrenci ortalaması göster.");
            Console.WriteLine("3-öğrenci okulunu göster.");
            Console.WriteLine("Çıkış yap");
        }
    }
}
