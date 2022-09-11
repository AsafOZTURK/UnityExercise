public static class Program
{
    private static void Main(string[] args)
    {
        //String Metotları
        string cumlem1 = "Merhabe benim adım mehmet asaf öztürk";
        string cumle2 = "bu ikinci cumle ornek olsun diye";

        //Length()    karakter sayısını hesaplar boşluklar dahil
        int karekterSayisi = cumlem1.Length;
        Console.WriteLine("Cümlede {0} adet karakter var",karekterSayisi);

        //ToUpper(), ToLower()   harflerin hepsini büyük yada küçük yazmaya yarar
        string buyukHarf = cumlem1.ToUpper();
        string kucukHarf = cumlem1.ToLower();

        //Concat() cümleye kelime eklemeye yarıyor
        string kelimeEkleme = String.Concat(cumlem1, "01"); 

        //Compare, CompareTo  iki değişken aynı karekter sayısı 0: ilk değikne daha fazlaysa, ikinci daha fazlaysa -1
        int karsilastirma = cumlem1.CompareTo(cumle2);
        Console.WriteLine(karsilastirma);

        //Contains değişken birin içinde değişken iki var mı 
        var icindeVArmi = cumlem1.Contains(cumle2); 
        Console.WriteLine(icindeVArmi);

        //EndsWith
        Console.WriteLine(cumlem1.EndsWith("öztürk"));  //cümle öztürk ile bitiyorsa true döndürüyor

        ///StartsWith
        Console.WriteLine(cumlem1.StartsWith("öztürk"));  //cümle öztürk ile başlıyorsa true döndürüyor

        //IndexOf
        Console.WriteLine(cumlem1.IndexOf("be")); //cumle içinde "be" varsa ilk olduğu index döner 

        //Insert 
        string kelimeEkle = cumle2.Insert(0, "Ekelencek kelime");

        //Padleft PadRight   ekleme yapılınca 50ye tamamlamak için boşluk yada istediğniz karekteri ekleme
        string birlestir = cumlem1 + cumle2.PadLeft(50,'*');
        string birlestir2 = cumlem1 + cumle2.PadRight(50);
        Console.WriteLine(birlestir);

        //Remove veridğin indexten sonrasını sil
        //cumlem1.remove(5,3) beşten başla 3 karekter sil
        //cumlem1.remove(0,1) ilk karekteri siler

        //Replace
        string degistirilmis = cumlem1.Replace("adım", "ismim");
        Console.WriteLine(degistirilmis);
        Console.WriteLine(cumle2.Replace(' ', '*')); // boşlukları yıldıza çevirme

        //Split
        string[] ayirilmis = cumle2.Split(" "); //cumle2 yi boşluklardan ayır ve kelime kelime diziye ata

        //Substring   verdiğimiz indexten sonraki karekterleri geitiri
        Console.WriteLine(cumle2.Substring(0, 10)); // baştan 10. karektere kadar göster
        Console.WriteLine(cumle2.Substring(4)); // 4. karakterden sonuna kadar göster
    }
}