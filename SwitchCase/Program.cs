#region MyRegion
string plaka = "";
Console.WriteLine("plaka kodunu giriniz: ");
plaka = Console.ReadLine();
//if (plaka == "1" || plaka == "01")
//{
//    Console.WriteLine("adana");
//}
//else if (plaka == "2" || plaka == "02")
//{
//    Console.WriteLine("adıyaman");
//}
//else if (plaka == "3" || plaka == "03")
//{
//    Console.WriteLine("afyon");
//}
//else if (plaka == "4" || plaka == "04")
//{
//    Console.WriteLine("agri");
//}
//else if (plaka == "5" || plaka == "05")
//{
//    Console.WriteLine("amasya");
//}
//else if (plaka == "6" || plaka == "06")
//{
//    Console.WriteLine("ankara");
//}
#endregion
#region MyRegion
switch (plaka)
{
    case "1":
        Console.WriteLine("adana");
        break;
    case "2":
        Console.WriteLine("adıyaman");
        break;
    case "3":
        Console.WriteLine("afyon");
        break;
    case "4":
        Console.WriteLine("agrı");
        break;
    case "5":
        Console.WriteLine("amasya");
        break;
    case "6":
        Console.WriteLine("ankara");
        break;
    default:
        break;
}

#endregion
#region MyRegion
//Console.WriteLine("kullanıcı: ");
//string kullanici = Console.ReadLine();
//switch (kullanici)
//{

//    case "admin" or "ADMIN" or "admIn" or "Admin":
//    case "Moderatör" or "moderatör":
//    case "Yönetici" or "yönetici":
//    case "başkan" or "Başkan":
//    case "Ceo" or "ceo" or "CEO":
//        Console.WriteLine("Yönetim paneline yönlendiriliyorsunuz");
//        break;
//    case "Uye" or "Üye" or "üye":
//        Console.WriteLine("Uye paneline yönlendiriliyorsunuz");
//        break;
//    default:
//        Console.WriteLine("bu sayfayı görme yetkiniz yoktur");
//        break;
//} 
#endregion
#region MyRegion
//Console.WriteLine("Kullanıcı adını giriniz: ");
//string kullanici = Console.ReadLine();
//Console.WriteLine("Şifre giriniz: ");
//string sifre = Console.ReadLine();
//switch (kullanici)
//{
//    case "bilgeadam":
//        switch (sifre)
//        {
//            case "1234":
//                Console.WriteLine("Kullanıcı adı ve şifre doğrudur");
//                break;
//            default:
//                Console.WriteLine("kullanıcı adı doğru, parola yanlıştır");
//                break;
//        }
//        break;
//    default:
//        Console.WriteLine("kullanıcı adı yanlıştır");
//        break;
//} 
#endregion
