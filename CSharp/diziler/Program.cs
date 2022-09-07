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


            ///////////////////////////////// DÖNGÜLER 
            foreach (var hayvan in hayvanlar)
            {
                Console.WriteLine(hayvan);
            }
        }
    }
} 