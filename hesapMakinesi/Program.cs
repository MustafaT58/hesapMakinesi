using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hesapMakinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal birinciSayi = cevir("Birinci sayıyı giriniz = ");
            decimal ikinciSayi = cevir("İkinci sayıyı giriniz = ");
            Console.Write("İşlem Giriniz'toplama(+),çıkarma(-),çarpma(*),bölme(/)' = ");
            string islem = Console.ReadLine();
            decimal snc;
            if(islem=="+")
            {
                snc= topla(birinciSayi, ikinciSayi);
                Sonuc(snc);

            }
            else if(islem=="-")
            {
                snc = cikar(birinciSayi, ikinciSayi);
                Sonuc(snc);
            }
            else if (islem == "*")
            {
                snc = carp(birinciSayi, ikinciSayi);
                Sonuc(snc);
            }
            else if (islem == "/")
            {
                snc = bol(birinciSayi, ikinciSayi);
                Sonuc(snc);
            }
            else
            {
                Console.WriteLine("Hatalı Giriş!");
            }
            Console.ReadLine();
        }
        static decimal cevir(string deger)
        {
                Console.Write(deger);
                return Convert.ToDecimal(Console.ReadLine());
        }
        static decimal topla(decimal x, decimal y)
        {
            return x+y;
        }
        static decimal cikar(decimal x, decimal y)
        {
            return x - y;
        }
        static decimal carp(decimal x, decimal y)
        {
            return x * y;
        }
        static decimal bol(decimal x, decimal y)
        {
            return x / y;
        }
        static void Sonuc(decimal sonuc)
        {
            Console.Write("Toplam Değer = " + sonuc);
        }
    }
}
