static void Main(string[] args)
{

}
#region while1
//int sayac = 0;
//while (sayac < 10)
//{
//    Console.WriteLine("aliveli");
//    sayac++;
//}

//{

//    int sayi;
//    int i = 1;

//    Console.Write("Bir Sayı Giriniz = ");
//    sayi = Convert.ToInt32(Console.ReadLine());

//    while (sayi > 9)
//    {

//        sayi = sayi / 10;
//        i++;

//    }

//    Console.Write("Sayı " + i + " basamaklı");
//    Console.ReadLine();

//}
#endregion
#region while2
//1 - 100 arası sayıları toplayalım
//int sayac = 0;
//int toplam = 0;
//while (sayac <= 100)
//{


//    toplam = toplam + sayac;
//    sayac++;

//}
//Console.WriteLine(toplam); 
#endregion
#region while3
//0-100 arasındaki çift ve tek sayıların toplamlarını bulalım.
//int sayac = 0;
//int tekToplam = 0, ciftToplam = 0;
//while (sayac <= 100)
//{
//    if (sayac % 2 == 0)
//    {
//    ciftToplam += sayac;
//    }
//    else
//    {
//    tekToplam += sayac;
//    }
//    sayac++;

//}
//Console.WriteLine("sonuc: " + tekToplam);
//Console.WriteLine("sonuc: " + ciftToplam); 
#endregion
#region doWhile1
//int sayac = 0;
//do
//{
//    Console.WriteLine("aliveli");
//    sayac++;
//} while (sayac<=10);
#endregion
#region doWhile2
//0 - 100 arasındaki çift ve tek sayıların toplamlarını bulalım.
//int sayac = 0, tekToplam = 0, ciftToplam = 0;
//do
//{
//    if (sayac % 2 == 0)
//    {
//        ciftToplam += sayac;
//    }
//    else
//    {
//        tekToplam += sayac;
//    }
//    sayac++;
//} while (sayac <= 100);

//Console.WriteLine("sonuc: " + tekToplam);
//Console.WriteLine("sonuc: " + ciftToplam); 
#endregion
#region doWhile3
////5! (faktöriyel alma)
//int a, b = 5;
//a = 1;
//do
//{
//    a = a * b;
//    b--;
//} while (b > 0);
//Console.WriteLine("Sonuc: " + a);
#endregion
#region for1
////int sayi = 0;
////for(baslangıcDegeri; bitisKosulu; artıs-azalısMiktarı)
//for (int i = 1; i <= 1000; i++)
//{
//    Console.WriteLine(i);
//}

#endregion
#region for2

////1'le 10 arasındaki çift sayıları ekrana mod almadan basınız

//for (int i = 0; i <= 10; i=i+2)
//{
//    Console.WriteLine(i);
//}

#endregion
#region for3
//azalma ornegi
//1-10 arasındaki tek sayilari tersten sıralı şekilde basınız
//for (int i = 9; i > 0; i=i-2)
//{
//    Console.WriteLine(i);
//}
#endregion
#region for4
//ayın ilk günü ptesi olarak kabul edildiğinde, 30 günlük takvimde haftasonlarını ekrana basın
//for (int i = 0; i < 30; i=i+7)
//{
//    if (i == 0)
//    {
//        continue;
//    }
//    else
//    {
//    Console.WriteLine(i);
//    }
//}
#endregion
#region for5
//for (char c = 'a'; c <= 'z'; c++)
//{
//    Console.WriteLine(c+ "-"+Convert.ToInt32(c));
//}
#endregion
#region for6
//Console.WriteLine(DateTime.Now);
//Console.WriteLine(DateTime.Now.Day);
//Console.WriteLine(DateTime.Now.Month);
//Console.WriteLine(DateTime.Now.Year);
//Console.WriteLine(DateTime.Now.DayOfWeek);
//Console.WriteLine(DateTime.Now.DayOfYear);

//for (int i = 2000; i <= DateTime.Now.Year; i++)
//{
//    if (i == 2007 || i == 2011)
//    {
//        continue;
//    }
//        Console.WriteLine(i);
//}
#endregion
#region for7
//1-100 arasındaki sayıların 3'le 4'ün katlarını bulunuz /okek/
//for (int i = 0; i < 100; i++)
//{
//    if (i % 12 != 0)
//        continue;
//    else Console.WriteLine(i);
//}
#endregion
#region for8
//break, continue ve return kullanımı
//for (int i = 0; i < 10; i++)
//{
//    if (i == 3)
//        break;
//        //return;
//        //continue;
//    Console.WriteLine(i);
//} 
#endregion