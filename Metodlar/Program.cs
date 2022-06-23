// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//TekCift();
//NotHesaplama();
//alanHesabi();
//Asal();
//Random();


static void TekCift()
{ 

    int tekToplam = 0, ciftToplam = 0;
    for (int i = 0; i < 100; i++)
    {
        if (i%2==0)
        {
            ciftToplam += i;

        }
        else
        {
            tekToplam += i;

        }
    }
    Console.WriteLine("tektoplam: "+tekToplam);
    Console.WriteLine("çiftoplam: "+ciftToplam);
}
static void alanHesabi() 
{
    int kisa=0,uzun=0;
    Console.WriteLine("Kısa Kenar:");
    kisa = int.Parse(Console.ReadLine());
    Console.WriteLine("Uzun Kenar:");
    uzun = int.Parse(Console.ReadLine());
    Console.WriteLine("Alan:"+(kisa*uzun));
    Console.WriteLine("Çevre:"+(2*(kisa+uzun)));

}
static void NotHesaplama()
{
    int vize1, vize2, final;
    float ortalama = 0;
    Console.WriteLine("1. Vize: ");
    vize1 = int.Parse(Console.ReadLine());
    Console.WriteLine("2. Vize :");
    vize2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("final: ");
    final = int.Parse(Console.ReadLine());

    ortalama = (vize1 + vize2) / 2 * 0.3f + final * 0.7f;

    Console.WriteLine("Not Ortalamaniz:" + ortalama);
}


// 1- Rastgele Sifre üreten metod yaziniz. 
// En az 1 tane buyuk harf , en az 1 sayi olacak 
// en az 8 karakter uzunlugunda olacak

static void Random()
{ 
var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
var stringChars = new char[8];
var random = new Random();

for (int i = 0; i < stringChars.Length; i++)
{
    stringChars[i] = chars[random.Next(chars.Length)];
}

var finalString = new String(stringChars);

    Console.WriteLine("Şifre: "+finalString);
}

// Verilen sayinin asal sayi olup olmadigini belirleyen metod 

static void Asal()
{
    Console.Write("Sayı Girin : ");
    int sayi = Convert.ToInt32(Console.ReadLine());
    int sonuc = Asalmi(sayi);
    if (sonuc == 0)
    {
        Console.WriteLine("{0} Asal Sayı Değildir.", sayi);
    }
    else
    {
        Console.WriteLine("{0} Asal Sayıdır.", sayi);
    }
    Console.ReadKey();
}

 static int Asalmi(int sayi)
{
    int i;
    for (i = 2; i <= sayi - 1; i++)
    {
        if (sayi % i == 0)
        {
            return 0;
        }
    }
    if (i == sayi)
    {
        return 1;
    }
    return 0;
}