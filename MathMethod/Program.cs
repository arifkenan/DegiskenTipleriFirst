using System;

namespace MathMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pi sayisi
            Console.WriteLine(Math.PI);

            //mutlak değer Abs absolute
            Console.WriteLine(Math.Abs(-27));

            //yuvarlama : floor => verilen ifadeyi/sayıyı bir alt tam değere yuvarlar.
            Console.WriteLine(Math.Floor(3.14));

            //ceiling => verilen sayiyi bir ust tam sayiya yuvarlar
            Console.WriteLine(Math.Ceiling(3.14));

            //round => verilen sayiyi en yakın değere yuvarlar
            Console.WriteLine(Math.Round(3.49));

            //not: sayi .50 ise tek mi çift mi olduğuna bakar.
            //tek ise yukarı, çift ise aşağı yuvarlama yapılır.
            Console.WriteLine(Math.Round(12.55));
            Console.WriteLine(Math.Round(12.45));
            Console.WriteLine(Math.Round(12.50));
            Console.WriteLine(Math.Round(12.50));

            //truncate => sayinin tam kismini alır. virgulden sonrasına bakmaz.
            Console.WriteLine(Math.Truncate(3.14));

            //max value
            Console.WriteLine(Math.Max(12,88));

            //3lü max value
            Console.WriteLine(Math.Max(Math.Max(12, 45),88));

            //min value
            Console.WriteLine(Math.Min(12, 88));
        }
    }
}
