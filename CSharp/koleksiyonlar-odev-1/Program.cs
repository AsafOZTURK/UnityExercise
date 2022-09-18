/*
Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

Negatif ve numeric olmayan girişleri engelleyin.
Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
*/
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("20 tane sayı giriniz...");
        
        ArrayList asalSayi = new ArrayList();
        ArrayList digerSayi = new ArrayList();
        
        for (int i = 0; i < 20; i++)
        {
            int sayi = int.Parse(Console.ReadLine());

            if (sayi < 0) {
                Console.WriteLine("Yanlış Karekter Girişi Yaptınız Lütfen Tekrar Başlayın");
                break;
            }
            else {
                int sayac = 0;

                for(int a = 1; a <= sayi; a++) {

                    if (sayi % a == 0) {
                        sayac++;
                    }
                }
                if (sayac == 2) {

                    asalSayi.Add(sayi);
                }
                else {

                    digerSayi.Add(sayi);
                }
            }
        }
        asalSayi.Sort();
        digerSayi.Sort();

        int asaltoplam = 0;
        int digertoplam = 0;

        foreach (var sayi in asalSayi)
        {
            Console.WriteLine(sayi);
            asaltoplam += Convert.ToInt32(sayi);
        }
        foreach (var sayi in digerSayi)
        {
            Console.WriteLine(sayi);
            digertoplam += Convert.ToInt32(sayi);
        }

        int asaladet = asalSayi.Count; 
        int digeradet = digerSayi.Count; 
        
        Console.WriteLine("Asal sayılar {0} tanedir.",asaladet);
        Console.WriteLine("Asal olmayan sayılar {0} tanedir.",digeradet);

        Console.WriteLine("Asal sayıların ortalaması: {0}",(asaltoplam/asaladet));
        Console.WriteLine("Asal olmayan sayıların ortalaması: {0}",(digertoplam/digeradet));
    }
}