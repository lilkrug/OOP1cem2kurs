using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace _12_laba_OOP
{
    static public class KAVDirInfo
    {
         public static string GetDir(string dir)
         {
            static DirectoryInfo GetParentDirs(DirectoryInfo dirInfo)
            {
                if (dirInfo == null)
                    return dirInfo;

                Console.WriteLine($"{dirInfo.Name}");
                return GetParentDirs(dirInfo.Parent);
            }

            Console.WriteLine("######################");
            DirectoryInfo dirinfo = new DirectoryInfo(dir);
            if (!dirinfo.Exists)
            {
                Console.WriteLine("fail ne naiden");
                return ".";
            }
            Console.WriteLine($"Колличество файлов : {dirinfo.GetDirectories().Length}");
            Console.WriteLine($"Колличество поддиректориев : {dirinfo.GetFiles().Length}");
            Console.WriteLine($"Время создания директории: {dirinfo.CreationTime}");
            Console.WriteLine("\n Родительские директории : ");
            GetParentDirs(dirinfo.Parent);
            Console.WriteLine("####################");
            return Convert.ToString(dirinfo.GetDirectories());
         }
    }
}
