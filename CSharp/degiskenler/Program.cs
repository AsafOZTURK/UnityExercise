// Değişkenler Alıştırmaları

int sayi1 = 46;
int sayi2 = 8;
string sayi3 = "20";
float ondalıklı = 12;

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