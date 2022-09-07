namespace diziler
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //////////// DİZİ TANIMLAMA //////////////////
            string[] renkler = new string[5];   //1.yöntem

            string[] hayvanlar = { "Kedi", "Köpek", "Kuş", "Maymun" }; //2.Yöntem

            int[] dizi;
            dizi = new int[5]; //3.Yöntem

            //Değer Atama
            renkler[0] = "Sarı"; //hayvanlar dizisinin 1. elemanını sarı olarak ata
            dizi[3] = 10;


            //DÖNGÜLER// 
            foreach (var hayvan in hayvanlar)
            {
                Console.WriteLine(hayvan);
            }

            /////////////////Diziler Metodları /////////////
            
            int[] sayilar = {23,17,81,64,6,2,93,60};

            Array.Sort(sayilar);  //dizi elemanlarını küçükten büyüğe sıralar

            Array.Clear(sayilar,2,2);   //sayilar dizisinde 2. elemandan başlayarak 2 elemanı 0 olarak değişirir

            Array.Reverse(sayilar);  //elemanları ortada ayna varmış gibi ters çevirir

            Array.IndexOf(sayilar,81); //dizi içinde 81 varsa index numarasını döndürür yoksa yok der

            Array.Resize<int>(ref sayilar, 10); //int sayilar dizinin boyutunu 10 yaptı
        }
    }
} 