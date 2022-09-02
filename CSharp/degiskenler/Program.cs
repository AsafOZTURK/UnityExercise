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

            /////////////////////////////KARAR YAPILARI/////////////////////////////////////

            int time = DateTime.Now.Hour;

            if (time >= 6){
                Console.WriteLine("Günaydın");
            }
            else if (time>=6 && time<11) {
                Console.WriteLine("İyi Günler");
            }
            else {
                Console.WriteLine("İyi Geceler");
            }

            //Koşuş kısayolu
            string sonuc = time<=18 ? "İyi günler" : time<10 ? "else if eklenmesi böyle" : "İyi geceler";
            //zaman 18 den küçükse iyi günler yaz değilse iyi geceler


            /////////////////////SWİTCH- CASE///////////////////////////

            int ay = DateTime.Now.Month;

            switch (ay)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Mevsim Kış");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Mevsim İlkBahar");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Mevsim Yaz");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Mevsim Sonbahar");
                    break;
                default:
                    Console.WriteLine("Yanlış veri girdiniz");
                    break;
            }
        }
    }
}