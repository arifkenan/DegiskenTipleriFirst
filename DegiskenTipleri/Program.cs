using System;

namespace FirstConsole
{

    public class Program
    {

        public static void Main()
        {
            #region Degisken Tanimlama
            ////Sayisal Veri Tipleri :  int,long,short,float,decimal,double
            //int yas = 25;
            //bool cinsiyet = true;
            //int kilo = 80;
            //string ad = "Arif";
            //DateTime dogumtarihi = new DateTime(1997,2,7);
            //string takim = "Galatasaray";
            //string favfood = "NY Steak";
            //string dreams = "Yazılımcı olmak";
            //string tc = "16298317850";
            //string gsm = "5324164841";
            //string mail = "arif_kenan@hotmail.com";



            //Console.WriteLine("Adınız: " + ad);
            //Console.WriteLine("Yaşınız: " + yas);
            //if (cinsiyet == true) { Console.WriteLine("Cinsiyetiniz: Erkek"); }
            //else { Console.WriteLine("Cinsiyetiniz: Kadın"); };
            //Console.WriteLine("Kilonuz: " + kilo);
            //Console.WriteLine("Doğum tarihiniz: " + dogumtarihi);
            //Console.WriteLine("Tuttuğunuz takım: " + takim);
            //Console.WriteLine("En sevdiğiniz yiyecek: " + favfood);
            //Console.WriteLine("Hayaliniz: " + dreams);
            //Console.WriteLine("Kimlik numaranız: " + tc);
            //Console.WriteLine("Telefon numaranız: " + gsm);
            //Console.WriteLine("e-mail adresiniz: " + mail);

            ////string isminiz;
            ////Console.Write("adınızı giriniz: ");
            ////isminiz = Console.ReadLine();
            ////Console.WriteLine("hoşgeldin :" + isminiz);
            ////Console.ReadKey();

            //Console.WriteLine("--------------Aritmetik--------------");

            ////int sayi2 = 3;
            ////float bolme = sayi1 / Convert.ToSingle(sayi2);
            ////Console.WriteLine("Fark : " + bolme);
            ////Console.WriteLine("Fark : " + (sayi1 / sayi2));
            ////0'a bölme hatası

            //int sayi1 = 50;
            //int sayi2 = 0;
            //int bolme;
            //if (sayi2 == 0) { Console.WriteLine("Sıfıra bölünme hatası var."); }
            //else
            //{
            //    bolme = sayi1 / sayi2;
            //    Console.WriteLine(bolme);
            //}

            //    Console.WriteLine("-----------ARTTIRMA----------");
            //    #endregion
            //    int sayi1 = 5;
            //    Console.WriteLine(sayi1);
            //    sayi1 = sayi1 * 2;
            //    Console.WriteLine(sayi1);
            //    sayi1 += 1;
            //    Console.WriteLine(sayi1);
            //    sayi1++;
            //    Console.WriteLine(sayi1);
            //    Console.ReadLine();

            //}


            //string isminiz;
            //Console.Write("adınızı giriniz: ");
            //isminiz = Console.ReadLine();
            //Console.WriteLine("hoşgeldin :" + isminiz);
            //Console.ReadKey();
            #endregion
            #region Çevirme İşlemi
            //int sayi1;
            //int sayi2;
            //string input, input2;
            //Console.Clear();

            //Console.WriteLine("birşeyler giriniz");
            //input = Console.ReadLine();
            //sayi1 = Convert.ToInt32(input);

            //Console.WriteLine("Başka birşeyler giriniz");
            //input2 = Console.ReadLine();
            //sayi2 = Convert.ToInt32(input2);

            //Console.WriteLine("girilen deger: " + input + input2);
            //Console.WriteLine("girilenlerin toplamı " + (sayi1 + sayi2));
            #endregion
            #region Sorular
            ////soru1: dışarıdan alınan 2 sayının toplamıyla,farkının  birbirlerine bölümünden kalanın sonucu?
            //float sayi1;
            //float sayi2;
            //float sayi3;
            //string input, input2;
            //Console.WriteLine("1. sayıyı giriniz: ");
            //input = Console.ReadLine();
            //sayi1 = Convert.ToInt32(input);
            //Console.WriteLine("2. sayıyı giriniz: ");
            //input2 = Console.ReadLine();
            //sayi2 = Convert.ToInt32(input2);
            //////Console.WriteLine((sayi3 = (sayi1 + sayi2) % (sayi1-sayi2)));
            //float toplam = sayi1 + sayi2;
            //float fark = sayi1 - sayi2;
            //float bolumkalan = toplam % fark;
            //Console.WriteLine(bolumkalan);

            //soru2: farkın toplama bölümünden kalan kaçtır? 
            //float toplam = sayi1 + sayi2;
            //float fark = sayi1 - sayi2;

            //float bolumkalan = fark % toplam;
            //Console.WriteLine(bolumkalan);
            #region MyRegion
            /*dışarıdan girilen bir sayının 10 eksiğinin 20 fazlasının 2'ye 
                   bölümünden kalanın karesi kaçtır*/

            //int sayi1;
            //int sonuc;
            //int sonuc2;
            //string input;
            //Console.WriteLine("1. sayıyı giriniz: ");
            //input = Console.ReadLine();
            //sayi1 = Convert.ToInt32(input);
            //Console.WriteLine(sonuc=(sayi1+10)+20);
            //Console.WriteLine(sonuc2=(sonuc % 2));
            //Console.WriteLine(sonuc2 * sonuc2);

            /* soru: girilen 2 sayının kareleri toplamı ile kareleri farkı kaçtır?
            // */
            //int sayi1, sayi2;
            //string input,input2;
            //Console.Write("1. sayıyı giriniz: ");
            //input = Console.ReadLine();
            //sayi1 = Convert.ToInt32(input);
            //Console.Write("2. sayıyı giriniz: ");
            //input2 = Console.ReadLine();
            //sayi2 = Convert.ToInt32(input2);
            //int karetoplam, karefark;
            //karetoplam=((sayi1*sayi1)+(sayi2*sayi2));
            //karefark=((sayi1 * sayi1) - (sayi2 * sayi2));
            //Console.WriteLine("Kare farkı: "+karefark);
            //Console.WriteLine("Kara toplam " + karetoplam);

            //double sonucdbl = Math.Pow(sayi1, 2) + Math.Pow(sayi2, 2);
            //Console.WriteLine(sonucdbl);


            /* soru: 2 vize %30 1 final %70 ile öğrencinin not ort bul. dikkat notlar ondalıklı olabilir.
            */

            //  float vize1, vize2, final, ortalama;
            //  string input, input2, input3;
            //  Console.Write("Vizeyi giriniz: ");
            //  input = Console.ReadLine();
            //  vize1 = float.Parse(input);
            //  Console.Write("2. Vizeyi giriniz: ");
            //  input2 = Console.ReadLine();
            //  vize2 = float.Parse(input2);
            //Console.Write("Finali giriniz: ");
            // input3 = Console.ReadLine();
            //final = float.Parse(input3);


            // ortalama=(vize1 + vize2) / 2 * 0.3f + final * 0.7f;
            // Console.WriteLine(ortalama);



            /* soru: dışarıdan girilen ad ve soyad bilgileri ayrı ayrı alınarak ad.soyad@gmail.com adresi oluştur.
             */
            //string ad, soyad, email;
            //Console.Write("Adınız: ");
            //ad= Console.ReadLine();

            //Console.Write("soyadınız: ");
            //soyad= Console.ReadLine();
            //email = ad + "." + soyad + "@gmail.com";
            //Console.WriteLine("email adresiniz: "+email);


            /* soru: dışarıdan girilen 2 sayının bölümünü ondalıklı olarak ekrana basınız. dikkat: bölen 0 olmayacak . bu kontrol yapınız.
            */

            //float sayi1, sayi2;
            //Console.Write("1. sayi giriniz:");
            //string input = Console.ReadLine();
            //sayi1 = int.Parse(input);
            //Console.Write("2. sayi giriniz: ");
            //input = Console.ReadLine();
            //sayi2 = int.Parse(input);

            //if (sayi2 != 0)
            //{ float bolum = sayi1 / (float)sayi2;
            //Console.WriteLine   ("sonuc: "+bolum);}
            
            
            
            
           





            #endregion



            #endregion

        }

    }







}