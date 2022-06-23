using System;

namespace TarihMetodlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime baslangic = DateTime.Now;
            //günün tarih ve zamanı almak
            Console.WriteLine(DateTime.Now);
            //sadece gün.ay. yıll verir
            Console.WriteLine(  DateTime.Now.ToShortTimeString());
            //tarih ve saat ile beraber gün isminide verir
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            //tarih formatlama
            Console.WriteLine(DateTime.Now.Month+"/"+DateTime.Now.Day+"/"+DateTime.Now.Year);
            //artık yıl kontrolü
            bool artikYilmi = DateTime.IsLeapYear(2022);

            //son 10 yilin artik yillarini hangileridir?
            for (int year = 1995; year <= DateTime.Now.Year; year++)
            {
                if (DateTime.IsLeapYear(year))
                {
                    Console.WriteLine("{0} artık yıldır", year);
                    DateTime leapDay = new DateTime(year, 2, 29);
                    DateTime nextYear = leapDay.AddYears(1);
                    Console.WriteLine(" {0} 'dan 1 yıl sonrası {1}.",
                                      leapDay.ToString("y"),
                                      nextYear.ToString("MMMM"));
                }
            }

            //haftanın günü
            Console.WriteLine(DateTime.Now.DayOfWeek);
            //yılın günü
            Console.WriteLine(DateTime.Now.DayOfYear);
            DateTime trh = DateTime.Now.AddDays(10);
            Console.WriteLine(trh);

            //timespan
            DateTime arif = new DateTime(1997, 2, 7);
            DateTime simdi = DateTime.Now;

            TimeSpan tarihFarki = simdi - arif;
            Console.WriteLine("arif "+tarihFarki.Days +" gündür hayatta");
            Console.WriteLine("arif " + tarihFarki.TotalHours + " saattir hayatta");

            DateTime bitis = DateTime.Now;
            tarihFarki = bitis - baslangic;
            Console.WriteLine("program "+tarihFarki.TotalMilliseconds+"ms calismistir");
        }
    }
}
