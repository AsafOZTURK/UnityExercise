/////////////// DATETİME FONKSİYONLARI ///////////////
Console.WriteLine(DateTime.Now);
Console.WriteLine(DateTime.Now.Date);  
Console.WriteLine(DateTime.Now.Day);
Console.WriteLine(DateTime.Now.Month);
Console.WriteLine(DateTime.Now.Year);
Console.WriteLine(DateTime.Now.Hour);
Console.WriteLine(DateTime.Now.Minute);
Console.WriteLine(DateTime.Now.Second);

Console.WriteLine(DateTime.Now.DayOfYear); //yılın kaçıncı gününde olduğunu döndürü
Console.WriteLine(DateTime.Now.DayOfWeek);  //haftanın hangi günü olduğunu yazar

Console.WriteLine(DateTime.Now.ToLongDateString());
Console.WriteLine(DateTime.Now.ToShortDateString());

Console.WriteLine(DateTime.Now.AddDays(2));  //şuanki tarihe ekleme yapıyor diğer türlere de yapılabilir

//DateTime Format
Console.WriteLine(DateTime.Now.ToString("dd")); //12
Console.WriteLine(DateTime.Now.ToString("ddd")); //Sat
Console.WriteLine(DateTime.Now.ToString("dddd")); //Saturday

Console.WriteLine(DateTime.Now.ToString("MM")); //09
Console.WriteLine(DateTime.Now.ToString("MMM")); //Sep
Console.WriteLine(DateTime.Now.ToString("MMMM")); //September


/////////////// MATH FONKSİYONLARI ///////////////
Console.WriteLine(Math.Ceiling(56.4));  //57
Console.WriteLine(Math.Round(56.4));  // <5 56   <5 57
Console.WriteLine(Math.Floor(56.4));  //56

Console.WriteLine(Math.Abs(-56));  //mutlak değer alma

Console.WriteLine(Math.Min(1,9));  //mutlak değer alma
Console.WriteLine(Math.Max(1,9));  //mutlak değer alma

Console.WriteLine(Math.Pow(3,4));  //3^4=81  üst alma   
Console.WriteLine(Math.Sqrt(25));  //karekök alma=5




