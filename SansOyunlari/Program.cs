/*ekrandan deneme sayisi alınacak
     * deneme sayisi kadar bir dizioluşturalacak
     * dizinin içerine 0 yada 1 değeri atanacak
     * gelen degerler toplanıp olasılık hesabı yapılacak*/

//int deneme = 0;
//Console.WriteLine("deneme sayısı giriniz: ");
//deneme = int.Parse(Console.ReadLine());
//Random rnd = new Random();
//int[] yaziTura = new int[deneme];
//for (int i = 0; i < deneme; i++)
//{
//    yaziTura[i] = rnd.Next(2);
//}
//int yazi = 0, tura = 0;

//for (int i = 0; i < deneme; i++)
//{
//    if (yaziTura[i] == 0)
//        yazi = yazi + 1;
//    else
//        tura = tura + 1;
//}
//Console.WriteLine("yazi: " + yazi);
//Console.WriteLine("tura: " + tura);

//sayısal loto programı yap



//    private static Random random = new Random();

//    public static void Main(string[] args)
//    {
//        int[] cekilen = new int[6], tahminler = new int[6];
//        int gelen, sayac, sayac2;

//        for (sayac = 0; sayac <= 5; sayac++)
//        {
//            tahminler[sayac] = 0;
//        }
//        for (sayac = 0; sayac <= 5; sayac++)
//        {
//            Console.WriteLine("Cekilen " + (sayac + 1) + "sayi giriniz: ");
//            cekilen[sayac] = (int)readValue();
//        }
//        for (sayac = 0; sayac <= 5; sayac++)
//        {
//            gelen = random.Next(49);
//            for (sayac2 = 0; sayac2 <= 5; sayac2++)
//            {
//                if (tahminler[sayac2] == gelen)
//                {
//                    sayac = sayac - 1;
//                }
//                else
//                {
//                    tahminler[sayac] = gelen;
//                }
//            }
//        }
//        for (sayac = 0; sayac <= 5; sayac++)
//        {
//            Console.WriteLine("cekilen " + cekilen[sayac] + " tahmin edilen " + tahminler[sayac]);
//        }
//    }

//    // .NET can only read single characters or entire lines from the console.
//    // The following function safely reads a double value.
//    private static double readValue()
//    {
//        double result;
//        while (!double.TryParse(Console.ReadLine(), out result)) ;
//        return result;
//    }


////deneme sayisi ekrandan alıncak
//    her atılan basket sonucu bir dizie tutualacak.

//    iki takımın müsabakasının yapınız.
//    sonucu ekrana yazınız.

//    int denemeSayisi = 150;
//    byte[] fenerbahce = new byte[denemeSayisi];
//    byte[] galatasaray = new byte[denemeSayisi];
//    Random random = new Random();
//    for (int i = 0; i < denemeSayisi; i++)
//    {
//    if (i%15 ==0)
//    {
//        fenerbahce[i] = (byte)random.Next(4);
//        galatasaray[i] = (byte)random.Next(1,4);
//    }
//        fenerbahce[i] = (byte)random.Next(4);
//        galatasaray[i] = (byte)random.Next(4);

//}
//    int bos = 0, serbestAtis = 0, ikiliAtis = 0, uclukAtis = 0;
//    int gsBos = 0, gsSerbest = 0, gsikili = 0, gsucluk = 0;
//    for (int i = 0; i < denemeSayisi; i++)
//    {
//        switch (fenerbahce[i])
//        {
//            case 0:
//                bos = bos + 1;
//                break;
//            case 1:
//                serbestAtis = serbestAtis + 1;
//                break;
//            case 2:
//                ikiliAtis = ikiliAtis + 1;
//                break;
//            case 3:
//                uclukAtis = uclukAtis + 1;
//                break;
//            default:
//                break;
//        }
//        switch (galatasaray[i])
//        {
//            case 0:
//                gsBos = gsBos + 1;
//                break;
//            case 1:
//                gsSerbest = gsSerbest + 1;
//                break;
//            case 2:
//                gsikili = gsikili + 1;
//                break;
//            case 3:
//                gsucluk = gsucluk + 1;
//                break;
//            default:
//                break;
//        }
//    }
//    Console.WriteLine("Çekilen şut     Femerbahçe     Galatasaray");
//    Console.WriteLine("-----------     ----------     -----------");
//    Console.WriteLine($"Boş             {bos}             {gsBos}");
//    Console.WriteLine($"Serbest         {serbestAtis}             {gsSerbest}");
//    Console.WriteLine($"ikilik          {ikiliAtis}             {gsikili}");
//    Console.WriteLine($"üçlük           {uclukAtis}             {gsucluk}");
//    Console.WriteLine($"Maç Sonucu      {serbestAtis+ikiliAtis+uclukAtis}            {gsSerbest+gsikili+gsucluk}");
static void Main(string[] args)
{

}

