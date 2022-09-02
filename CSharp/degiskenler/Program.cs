using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Değişkenler Alıştırmaları

            int sayi1 = 46;
            int sayi2 = 8;
            string sayi3 = "20";

            Console.WriteLine("Birinci Sayo:" + sayi1 + " İkinci Sayı:" + sayi2);
            Console.WriteLine("Sayıların Çarpımı:" + sayi1 * sayi2);


            string isim = "Mehmet Asaf";
            string soyisim = "ÖZTÜRK";
            string isimsoyisim = isim + " " + soyisim;

            Console.WriteLine("İsim Soyisim: " + isimsoyisim);


            string metinsayi = string.Empty;
            metinsayi = sayi1.ToString() + sayi2.ToString();
            Console.WriteLine("Sayılar metin olarak yazılırsa: " + metinsayi);
            Console.WriteLine("Metin halindeki sayı yazırma:" + Convert.ToInt32(sayi3));

            DateTime tarihsaat = DateTime.Now;
            Console.WriteLine("Tarih - Saat: " + tarihsaat);


            /*
            Tip dönüşümleri 2 şekilde yapılabilir:

            Implicit Conversion (Bilinçsiz ya da kapalı dönüşüm)
            Explicit Conversion (Bilinçli ya da açık dönüşüm)
            */


            ///////////////////////////// HATA YÖNETİMİ /////////////////////////////////

            try {
                int a = 4;
                int b = 5;
                int c = a+b;
                Console.WriteLine(c);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Bir Hata Oluştu: "+ ex.Message);
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı.");
            }

            //////////////////////////////////////////////////////////////////
        }
    }
}