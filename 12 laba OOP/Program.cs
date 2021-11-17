using System;
using System.IO;

namespace _12_laba_OOP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("###################################################");
            string path = @"E:\Education\ООП 1 сем 2 курс\12 laba OOP\xxxlogfile.txt";
            FileInfo fileInf = new FileInfo(path);
            if (fileInf.Exists) 
            {
                Console.WriteLine("Имя файла: {0}", fileInf.Name);
                Console.WriteLine("Время создания: {0}", fileInf.CreationTime);
                Console.WriteLine("Размер: {0}", fileInf.Length);
            }

            Console.WriteLine("###################################################");

            DriveInfo[] infs = DriveInfo.GetDrives();
            foreach (DriveInfo inff in infs)
            {
                Console.WriteLine($"свободное место на диске : {inff.AvailableFreeSpace}");
                Console.WriteLine($"Файловая система : {inff.DriveFormat}");
                if (inff.IsReady)
                {
                    Console.WriteLine($"Имя диска : {inff.Name}");
                    Console.WriteLine($"Объем диска: {inff.TotalSize}");
                    Console.WriteLine($"Свободное пространство: {inff.TotalFreeSpace}");
                    Console.WriteLine($"Метка: {inff.VolumeLabel}");
                }
            }
            Console.WriteLine("###################################################");
            FileInfo fileinf = new FileInfo(path);
            if (fileinf.Exists)
            {
                Console.WriteLine("Полный путь: {0}", fileInf.DirectoryName);
                Console.WriteLine("Имя файла: {0}", fileInf.Name);
                Console.WriteLine("Размер: {0} ", fileInf.Length);
                Console.WriteLine("Расширение: {0}", fileInf.Extension);
                Console.WriteLine("Время создания: {0}", fileInf.CreationTime);
            }
            Console.WriteLine("###################################################");

            DirectoryInfo dir = DirectoryInfo.;

        }
        
            
        
        
    }
}
