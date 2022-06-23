//stringKiyas();

static void stringKiyas()
{
    string ornekMetin = Console.ReadLine();
    int sonuc = ornekMetin.CompareTo("bilgeadam");

    string mesaj = "";
    switch (sonuc)
    {
        case -1:
            mesaj = "kelime diğer kelime eşleşmektedir. " + "eksik karakter var";
            break;
        case 0:
            mesaj = "tebrikler. kelimeler eşleşmektedir.";
            break;
        case 1:
            mesaj = "kelime diğer kelime eşleşmemektedir. fazla karakter var.";
            break;
        default:
            break;
    }
    Console.WriteLine(mesaj);
}

//startwith();

static void startwith()
{
    string ornekMetin = Console.ReadLine();
    bool result = ornekMetin.StartsWith("bil");
    if (result)
    {
        Console.WriteLine("cümle bil ile başlamaktadır.");
    }
    else
    {
        Console.WriteLine("cümle bil ile başlamamaktadır");

    }
    Console.WriteLine(result ? "cümle bille başlar" : "cümle bille başlamaz");
}

//OrnekIndexOf();


static void OrnekIndexOf()
{
    string ornekMetin = "bugün hava çok güzel";
    int index = ornekMetin.IndexOf('ç');
    Console.WriteLine("index numarasi: "+index);
    index = ornekMetin.LastIndexOf('b');
    Console.WriteLine("lastindex: "+index);
}


//OrnekReplace();

 static void Replace()
{
    string ornekMetin = "bugün hava çok güzel";
    string yeniMetin = ornekMetin.Replace("güzel", "berbat");
    Console.WriteLine(ornekMetin);
    Console.WriteLine(yeniMetin);


}


//OrnekSplit();
static void OrnekSplit()
{

    string ornekMetin = "Nitelik, bir haberin olmazsa olmazıdır; haberi haber yapan temel taştır. Bir haberin değerini anlamak için öncelikle haber kavramı üzerinde durmak gerekir. Toplumda veya doğada meydana gelen çeşitli olay, durum ve görünümle ilgili bilgi ve duyurulara haber denir. Bu haberlerin halka duyurulması amacıyla belirli kurallar gözetilerek hazırlananlarına da haber yazıları denir.";
    string[] cumleler = ornekMetin.Split(".");
    foreach (string cumle in cumleler)
    {
        string[] kelimeler = cumle.Split(" ");
        Console.WriteLine(cumle);
        foreach (string kelime in kelimeler)
        {
            Console.WriteLine(kelime);

        }

    }

}
OrnekSubstring();

static void OrnekSubstring()
{
    string ornekMetin = "Bugün hava çok güzel";
    string yenimetin = ornekMetin.Substring(6);
    Console.WriteLine(yenimetin);
    Console.WriteLine(ornekMetin.Substring(6,4));

}