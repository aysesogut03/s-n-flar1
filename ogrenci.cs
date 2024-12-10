using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    public class ogrenci
    {
        private int ogrenciNo;
        private string isim;
        private string soyisim;
        private int vize1;
        private int vize2;
        private int final;
        private string okulİsmi;

        public ogrenci(int ogrenciNo, string isim, string soyisim, int vize1, int vize2, int final, string okulİsmi)
        {
            this.ogrenciNo = ogrenciNo;
            this.isim = isim;
            this.soyisim = soyisim;
            this.vize1 = vize1;
            this.vize2 = vize2;
            this.final = final;
            this.okulİsmi = okulİsmi;
        }
    
        public void ogrenciBilgileriGoster()
        {
            Console.WriteLine("öğrenci no:"+ogrenciNo);
            Console.WriteLine("isim:"+isim);
            Console.WriteLine("soyisim:"+soyisim);
            Console.WriteLine("vize 1:"+vize1);
            Console.WriteLine("vize 2:"+vize2);
            Console.WriteLine("final:"+final);
            Console.WriteLine("okul isim:"+okulİsmi);
        }

        public double ogrenciOrtalamasiBul()
        {
            double ortalama = 0.2 * vize1 + 0.2 * vize2 + 0.6 * final;
            return ortalama;
        }

        public void okulGetir()
        {
            Console.WriteLine("Öğrenci okul ismi getir:" + okulİsmi);
        }

    }
}
