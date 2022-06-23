using System;
using System.IO;
using System.Text;
namespace System_IO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //driveinfo => bilgisayarınızdaki surucu bilgilerine erişim imkanı verir
            DriveInfo[] driveInfos = DriveInfo.GetDrives();

            foreach (var drive in driveInfos)
            {
                Console.WriteLine(drive.Name);
                Console.WriteLine(drive.TotalSize);
                Console.WriteLine(drive.DriveType);
                Console.WriteLine(drive.TotalFreeSpace);
                Console.WriteLine(drive.DriveFormat);
                Console.WriteLine(drive.IsReady);

            }

            //DirectoryInfo => suruculerdeki klasör'leri verir
            if (!Directory.Exists(@"c:\BenimKlasorum"))
            {
                Directory.CreateDirectory(@"c:\BenimKlasorum");
            }
            string[] dirs = Directory.GetDirectories(@"c:\");

            foreach (var item in dirs)
            {
                Console.WriteLine(item);
            }

            DosyaOlustur();

        }
        
        private static void DosyaOlustur()
        {
            FileStream fi = File.Create(@"c:\BenimKlasorum\test.txt");
            Byte[] buffer = new UTF8Encoding(true).GetBytes(@"File: Statik bir dosya kontrol sistemidir.");
            fi.Write(buffer);
            fi.Close();
        }
    }
}