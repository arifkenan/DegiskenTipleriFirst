//#region Ornek1
//string kod;
//Console.Write("İçecek kodunu giriniz:");
//kod = Console.ReadLine();

//if (kod == "Ç" || kod == "ç")
//{

//    Console.WriteLine("çay");

//}
//else if (kod == "M" || kod == "m")
//{

//    Console.WriteLine("MEyve suyu");


//}

//else if (kod == "L" || kod == "l")
//{
//    Console.WriteLine("limonata");


//}
//else
//{
//    Console.WriteLine("geçersiz kod");

//}
//#endregion

#region Ornek2
/*ekrandan kulanıcı adı ve parola alınacak
 * dogru girmiş ise hoşgeldiniz diyecek
 * diğer türlü hangisinin hatalı olduğunu ekrana yazsın
 * kullaniciAdi: admin, parola: qwerty
 */
#endregion

//string kullaniciAdi,parola;
//Console.Write("Kullanıcı adını giriniz:" );
//kullaniciAdi = Console.ReadLine();
//Console.Write("Parola giriniz: ");
//parola=Console.ReadLine();


//if (kullaniciAdi == "admin" && parola=="qwerty")
//{
//    Console.WriteLine("Hoşgeldin sahip");
//}
//else
//{
//    Console.WriteLine("kullanıcı kodunuz yada şifre hatalı");
//}
#region if not

////girilen not 0-30 aralıgı ise ff
//30-50 dd
//    50-70 bb
//    70-100 aa şeklinde kllanıcıyı uyarınız 


//int not;
//Console.Write("notunuzu giriniz: ");
//not = Convert.ToInt32(Console.ReadLine());
//if (not < 100 && not > 70)
//    Console.WriteLine("AA");
//else if (not < 70 && not > 50)
//    Console.WriteLine("BB");
//else if (not < 50 && not > 30)
//    Console.WriteLine("DD");
//else if (not < 30 && not > 0)
//    Console.WriteLine("FF");

#endregion

/* dışarıdan ürün adı girilecek,kasiyer bize ürünün hangi reyonda olduğunu söyleyece..
 * domates,biber patlıcan = sebze reyonu
 * diş macunu , parfüm , şampuan = kozmetik reyonu
 * cep telefonu, bilgisayar, ses sistemi = teknoloji reyonu
 * başka bir ürüün girilirse "bu ürün bizde yok" uyarısı versi*/

//string urun;
//Console.Write("ürünü giriniz: ");
//urun = Console.ReadLine();
//if (urun == "domates")
//    Console.WriteLine("Sebze reyonu");
//else if (urun == "biber")
//    Console.WriteLine("Sebze reyonu");
//else if (urun == "patlıcan")
//    Console.WriteLine("Sebze reyonu");
//else if (urun == "diş macunu")
//    Console.WriteLine("kozmetik reyonu");
//else if (urun == "parfüm")
//    Console.WriteLine("kozmetik reyonu");
//else if (urun == "şampuan")
//    Console.WriteLine("kozmetik reyonu");
//else if (urun == "cep telefonu")
//    Console.WriteLine("elektronik reyonu");
//else if (urun == "bilgisayar")
//    Console.WriteLine("elektronik reyonu");
//else if (urun == "ses sistemi")
//    Console.WriteLine("elektronik reyonu");
//else
//    Console.WriteLine("bu ürün bizde yok");


/* dışarıdan sipariş alıancak olan kitap miktarı girilsin
 * sipariş sayısı 20'den azsa toplam ücretten %5,
 * 20-50 aralığında ise %10, 50-100 aralığı ise %15,
 * 100'den fazla ise %25 indirim yapılsın.
 * kitabın birim fiyatı => 5 tl'dir.
 * amac => ödenecek tutarı kullanıcıya göstermek...*/

//int siparis, ucret, toplam_ucret;
//ucret = 5;
//Console.Write("Sipariş adedini giriniz: ");
//siparis = Convert.ToInt32(Console.ReadLine());
//toplam_ucret = (siparis * ucret);

//if (siparis < 20)
//    Console.WriteLine(toplam_ucret - (toplam_ucret * 0.05));
//else if (siparis < 50 && siparis >= 20)
//    Console.WriteLine(toplam_ucret - (toplam_ucret * 0.10));
//else if (siparis <= 100 && siparis > 50)
//    Console.WriteLine(toplam_ucret - (toplam_ucret * 0.15));
//else if (siparis > 100)
//    Console.WriteLine(toplam_ucret - (toplam_ucret * 0.25));


/* kullanıcıdan 2 sayı alın 
 birde ekrana [+,-,/,*]
bunlardan hangisini girdi ise ona göre işlem yapın
 */

int num1 = 0; int num2 = 0;
Console.Write("1. Sayıyı giriniz: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("2. Sayıyı giriniz: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("İşlemi seçiniz: ");
Console.WriteLine("\t+ : Topla");
Console.WriteLine("\t- : Çıkar");
Console.WriteLine("\t* : Çarp");
Console.WriteLine("\t/ : Böl");
Console.Write("Seçiminiz?: ");

//switch (Console.ReadLine())
//{
//    case "+":
//        Console.WriteLine($"Sonucunuz: {num1} + {num2} = " + (num1 + num2));
//        break;
//    case "-":
//        Console.WriteLine($"Sonucunuz: {num1} - {num2} = " + (num1 - num2));
//        break;
//    case "*":
//        Console.WriteLine($"Sonucunuz: {num1} * {num2} = " + (num1 * num2));
//        break;
//    case "/":
//        Console.WriteLine($"Sonucunuz: {num1} / {num2} = " + (num1 / num2));
//        break;
//}
//Console.Write("Kapatmak için herhangi bir tuşa basın");
//Console.ReadKey();


/* girilen mevsime göre ayları bastırın
 */

//Console.Write("Bir ay girin : ");
//int ay = Convert.ToInt32(Console.ReadLine());

//if (ay < 1 || ay > 12)
//{
//    Console.WriteLine("Girdiğiniz doğru bir tarih değil");
//}
//else if (ay <= 2 || ay == 12)
//{
//    Console.WriteLine("Kış mevsimi");
//}
//else if (ay < 6)
//{
//    Console.WriteLine("İlkbahar mevsimi");
//}
//else if (ay < 9)
//{
//    Console.WriteLine("Yaz mevsimi");
//}
//else
//{
//    Console.WriteLine("Sonbahar mevsimi");
//}

/* suyun sıcaklığını alın . katı,sıvı , gaz halini belirleyin
 */
//double derece = 0;
//Console.Write("Sıcaklık değerini giriniz:");
//derece = Convert.ToDouble(Console.ReadLine());

//if (derece <= 0)
//{
//    Console.Write("KATI");
//}
//else if (derece > 0 && derece < 100)
//{
//    Console.Write("SIVI");
//}
//else
//{
//    Console.Write("GAZ");
//}

//Console.ReadKey();


/* girilen bir tamsayının kaç basamaklı olduğunu ekrana yazınız.
 */

{

    int sayi;
    int i = 1;

    Console.Write("Bir Sayı Giriniz = ");
    sayi = Convert.ToInt32(Console.ReadLine());

    while (sayi > 9)
    {

        sayi = sayi / 10;
        i++;

    }

    Console.Write("Sayı " + i + " basamaklı");
    Console.ReadLine();

}