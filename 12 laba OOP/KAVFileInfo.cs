using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace _12_laba_OOP
{
    static public class KAVFileInfo
    {
        static public void GetFile(string path)
        {
            FileInfo fileinf = new FileInfo(path);
            if (!fileinf.Exists)
            {
                Console.WriteLine("Файл не найден");
                return;
            }
                Console.WriteLine("Полный путь: {0}", fileinf.DirectoryName);
                Console.WriteLine("Имя файла: {0}", fileinf.Name);
                Console.WriteLine("Размер: {0} ", fileinf.Length);
                Console.WriteLine("Расширение: {0}", fileinf.Extension);
                Console.WriteLine("Время создания: {0}", fileinf.CreationTime);
            
        }
    }
}
