using System;
using System.Collections;

internal class Program
{

    private static void Main(string[] args)
    {
        ////////////////////////////////////// ARRAY YLİST //////////////////////////////////////
        /*
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
        Console.WriteLine(liste.Clear();
        */

        ////////////////////////////////////// SÖZLÜKLER - DİCTİONARY //////////////////////////////////////

        Dictionary<int, string> kullanicilar = new Dictionary<int, string>();

        //eleman ekleme
        kullanicilar.Add(0,"Mehmet Asaf ÖZTÜRK");
        kullanicilar.Add(20,"Mehmet");
        kullanicilar.Add(13,"Asaf ÖZTÜRK");

        //içindekileri görünütleme
        Console.WriteLine(kullanicilar[13]); //13 keyine sahip value getir

        foreach (var item in kullanicilar)
        {
            Console.WriteLine(item);
        }

        //Count  eleman sayısını gösterir
        Console.WriteLine(kullanicilar.Count);

        //Contains   verdiğimiz anahtara sahip eleman var mı
        Console.WriteLine(kullanicilar.ContainsKey(0));
        Console.WriteLine(kullanicilar.ContainsValue("Mehmet"));

        //Remove 
        kullanicilar.Remove(13); //13 key nuamralı elemanı sözlükten sil    

        //Keys -Values
        foreach (var item in kullanicilar)
        {
            Console.WriteLine(item.Value);
            Console.WriteLine(item.Key);
        }
        foreach (var item in kullanicilar.Keys)
        {
            Console.WriteLine(item);

        }
        foreach (var item in kullanicilar.Values)
        {
            Console.WriteLine(item);

        }
    }
}