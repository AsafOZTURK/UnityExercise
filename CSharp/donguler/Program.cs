Console.Write("Bir Sayı Giriniz: ");
int sayi = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Girdiğiniz sayıya kadar olan tek sayılar: ");
for (int a=0; a<=sayi; a++) {
    
    if ( a % 2 == 1) {
        Console.WriteLine(a);
    }
}


///////////////////1-1000 arası tek ve çift sayıların toplamı
int tek = 0;
int cift = 0;

for (int i = 1; i<=1000; i++) 
{
    if ( i % 2 == 0) 
    {
        cift += i;
    }
    else 
    {
        tek += i;
    }
}
Console.WriteLine("Tek Sayıların Toplamı: " + tek);
Console.WriteLine("Çift Sayıların Toplamı: " + cift);