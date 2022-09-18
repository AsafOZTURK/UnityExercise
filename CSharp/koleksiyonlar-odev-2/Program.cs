/*
Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)
*/
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("20 tane sayı giriniz...");

        ArrayList sayilar = new ArrayList();
        ArrayList enkucuk = new ArrayList();
        ArrayList enbuyuk = new ArrayList();

        for (int i = 0; i < 20; i++)
        {
            int sayi = int.Parse(Console.ReadLine());
            sayilar.Add(sayi);
        }

        sayilar.Sort();
        for (int i = 0; i < 3; i++)
        {
            enkucuk.Add(sayilar[i]);
        }

        sayilar.Reverse();
        for (int i = 0; i < 3; i++)
        {
            enbuyuk.Add(sayilar[i]);
        }

        int enbuyuktoplam = 0;
        int enkucuktoplam = 0;

        foreach (var sayi in enkucuk)
        {
            enkucuktoplam += Convert.ToInt32(sayi);
        }
        foreach (var sayi in enbuyuk)
        {
            enbuyuktoplam += Convert.ToInt32(sayi);
        }
        Console.WriteLine("Girdiğiniz sayılardan en küçük 3 sayının ortalaması: {0}",(enkucuktoplam/3));
        Console.WriteLine("Girdiğiniz sayılardan en büyük 3 sayının ortalaması: {0}",(enbuyuktoplam/3));
    }
}