/* SORU-1
Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın. */

Console.WriteLine("Kaç sayı girmek istediğinizi yazınız: ");
int adet = Convert.ToInt32(Console.ReadLine());

if (adet < 0) 
{
    Console.WriteLine("Hatalı Sayı Girdiniz Lütfen Tekrar Başlayıp Pozitif Bi Sayı Giriniz");
}
else 
{
    int[] sayilar = new int[adet];

    Console.WriteLine("{0} tane sayıyı sırayla giriniz.",adet);

    for (int i = 0; i < adet; i++)
    {
        sayilar[i] = Convert.ToInt32(Console.ReadLine());
    }

    Console.WriteLine("Girdiğiniz Sayıların Çift Olanları: ");

    foreach (var sayi in sayilar)
    {
        if (sayi % 2 == 0)
            Console.WriteLine(sayi);
    }

}

/* SORU-2
Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın. */

Console.WriteLine("İki tane sayı giriniz (İlk girdiğniz sayı kaç tane sayı gireceğinizi, ikinci sayı bölüm yapılacak sayı): ");
int adet = Convert.ToInt32(Console.ReadLine());
int katsayi = Convert.ToInt32(Console.ReadLine());

if (adet < 0 || katsayi < 0) 
{
    Console.WriteLine("Hatalı Sayı Girdiniz Lütfen Tekrar Başlayıp Pozitif Bi Sayı Giriniz");
}
else 
{
    int[] sayilar = new int[adet];

    Console.WriteLine("{0} tane sayıyı sırayla giriniz.",adet);

    for (int i = 0; i < adet; i++)
    {
        sayilar[i] = Convert.ToInt32(Console.ReadLine());
    }

    Console.WriteLine("Girdiğiniz Sayıların {0} Katsayısına Bölünenleri: ",katsayi);

    foreach (var sayi in sayilar)
    {
        if (sayi % katsayi == 0)
            Console.WriteLine(sayi);
    }

}

/* SORU-3
Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın. */

Console.WriteLine("Kaç kelime girmek istediğinizi yazınız: ");
int adet = Convert.ToInt32(Console.ReadLine());

if (adet < 0) 
{
    Console.WriteLine("Hatalı Sayı Girdiniz Lütfen Tekrar Başlayıp Pozitif Bi Sayı Giriniz");
}
else 
{
    string[] kelimeler = new string[adet];

    Console.WriteLine("{0} tane kelimeyi sırayla giriniz.",adet);

    for (int i = 0; i < adet; i++)
    {
        kelimeler[i] = Console.ReadLine();
    }

    Array.Reverse(kelimeler);
    Console.WriteLine("Girdiğiniz kelimeler sondan başa: ");

    foreach (var kelime in kelimeler)
    {
        Console.WriteLine(kelime);
    }
}

/*SORU-4
Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.*/

Console.WriteLine("Bir cümle giriniz:");
string cumle = Console.ReadLine();

string[] kelimeler = cumle.Split(" ");

int harfSayisi = cumle.Length;
int kelimeSayisi = kelimeler.Count();

Console.WriteLine("Girdiğiniz cümlenin kelime sayısı: " + kelimeSayisi);
Console.WriteLine("Girdiğiniz cümlenin harf sayısı: " + harfSayisi);