//#region Ornek
//try

//{
//    int sayi1, sayi2;
//    float sonuc;
//    Console.Write("1. sayıyı giriniz: ");
//    sayi1 = int.Parse(Console.ReadLine());

//    Console.Write("2. sayıyı giriniz: ");
//    sayi2 = int.Parse(Console.ReadLine());

//    sonuc = sayi1 / (float)sayi2;
//    Console.WriteLine("Sonuc:" + sonuc);
//}
//catch (DivideByZeroException ex)
//{

//    Console.WriteLine("sıfıra bölünme hatası");

//}
//catch (FormatException ex)
//{
//    Console.WriteLine("düzgün veri giriniz.. girdiğiniz veri sayısla değil");


//}
//catch (OverflowException ex)
//{
//    Console.WriteLine("girilen sayı int tipine sığmıyor");


//}

//catch (Exception ex)


//{

//    Console.WriteLine("Hata oluştu:" + ex.Message);
//}
//#endregion


#region ornek 2
DateTime dogumtarihi;
string input;
try

{
    Console.Write("dogum tarihi giriniz:");
    input = Console.ReadLine();
    dogumtarihi = DateTime.Parse(input);
    Console.WriteLine("dogum tarihiniz: " + dogumtarihi.ToString());

}
catch (FormatException ex)
{ 
    Console.WriteLine("girilen deger doğru formatta değil"); 
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);

}

#endregion