using System;
using System.Collections;

internal class Program
{

    private static void Main(string[] args)
    {
        ArrayList liste = new ArrayList();

        //eleman ekleme
        liste.Add("Mehmet");
        liste.Add(46);
        liste.Add(5.3369);
        liste.Add('A');
        liste.Add(true);

        //elemanları görüntüleme
        Console.WriteLine(liste[0]);
        foreach (var item in liste)
        {
            Console.WriteLine(item);
        }

        //AddRange  - toplu eleman ekleme
        string[] renkler = {"sarı","yeşil","kırmızı","mavı"};
        List<int> sayilar = new List<int>(){6,52,46,1,9,86,44,250};
        liste.AddRange(renkler);
        liste.AddRange(sayilar);

        Console.WriteLine("//////////////////////////////////");
        foreach (var item in liste)
        {
            Console.WriteLine(item);
        }

        //Sort()  sıralama işlemini sadece aynı türden veri varsa yapar

        //BinarySearch
        Console.WriteLine(liste.BinarySearch("sarı"));  //sarının kaçıncı indexte olduğunu yazdırır

        //Reverse   ters çevirir
        //Clear  listedeki herşeyi siler
        Console.WriteLine(liste.Clear());
    }
}