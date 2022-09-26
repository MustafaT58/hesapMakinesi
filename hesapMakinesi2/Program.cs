using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hesapMakinesi2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            decimal birinciSayi = cevir("Birinci sayıyı giriniz = ");
            decimal ikinciSayi = cevir("İkinci sayıyı giriniz = ");
            decimal snc = islemYap(birinciSayi, ikinciSayi);
            Console.WriteLine("Sonuc = " + snc);
            Console.ReadLine();
        }
        public static decimal cevir(string deger)
        {
            Console.Write(deger);
            return Convert.ToDecimal(Console.ReadLine());
        }
        public static decimal islemYap(decimal x, decimal y)
        {
            decimal sonuc = 0;
            string isKod = kodAl();
            switch (isKod)
            {
                case "+": sonuc = x + y; break;
                case "-": sonuc = x - y; break;
                case "*": sonuc = x * y; break;
                case "/": sonuc = x / y; break;
                default: Console.WriteLine("Yanlış İşlem Kodu"); return islemYap(x, y); break;
            }
            return sonuc;
        }
        public static string kodAl()
        {
            Console.WriteLine("İşlem Kodu= ");
            return Console.ReadLine();
        }

    }
}
