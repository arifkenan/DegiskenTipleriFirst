//ilk deger atamasi şeklinde dizi tanımı
//string[] sinif = { "Ali", "Veli", "Ayse", "Fatma" };
//int[] vize1 = { 30, 40, 50, 35 };
//int[] vize2 = { 50, 40, 45, 50 };
//int[] final = { 50, 55, 60, 50 };

//ayseyi ekrana print etmek istiyorum
//Console.WriteLine(sinif[2]);
//aysenin birinci vizesi kactır?
//vize1 dizisinin 2. elemanı aysenin vize notudur.
//Console.WriteLine(vize1[2]);
//ayşenin vize2 notunu değiştirmek için
//vize[2]=30;

//foreach (var ogrenci in sinif)
//{
//    Console.WriteLine(ogrenci);
//}

//for (int i = 0; i < sinif.Length; i++)
//{
//    Console.WriteLine(sinif[i]);
//}

//int sayac = 0;
//while (sayac < sinif.Length)
//{
//    Console.WriteLine(sinif[sayac]);
//    sayac++;
//}
//sayac = 0;
//do
//{
//    Console.WriteLine(sinif[sayac]);
//    sayac++;
//} while (sayac < sinif.Length);

//sinif dizisinin son elemanının ekrana yazın
//    Console.WriteLine(sinif[sinif.Length-1]);
////sınıftakilerin vize ortalamaları nedir?
////1,yol
//float ortalama1=0,ortalama2=0;
//foreach (int not in vize1)
//{
//    ortalama1 = ortalama1 + not;

//}
//ortalama1 = ortalama1 / 4;

//foreach (int not in vize2)
//{ 
//ortalama2= ortalama2 + not;


//}
//ortalama2=ortalama2 / 4;

//Console.WriteLine(ortalama1);
//Console.WriteLine(ortalama2);

//2.yol
//ortalama1 = 0;
//ortalama2 = 0;
//for (int i = 0; i < 4; i++)
//{
//    ortalama1 = ortalama1 + vize1[i];
//    ortalama2 = ortalama2 + vize2[i];
//    ortalama1 = ortalama1 / 4;
//    ortalama2 = ortalama2 / 4;
//}
//Console.WriteLine(ortalama1);
//Console.WriteLine(ortalama2);

//average metodu
//double?average = vize1.Average();
//Console.WriteLine(average);

//sınıftakilerin tek tek not ortalamaları nedir?
//float ortalama;
//for (int i = 0; i < sinif.Length; i++)
//{
//    ortalama = ((vize1[i]+vize2[i])/2*30/(float)100+final[i]*70/(float)100);
//    Console.WriteLine(sinif[i]+": "+ortalama);
//}
 static void Main(string[] args)
{

}
