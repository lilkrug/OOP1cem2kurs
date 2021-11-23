using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace _12_laba_OOP
{
    class KAVLog
    {
        static public StreamWriter logfile;

        static KAVLog()
        {
            using (logfile = new StreamWriter("E:\\Education\\ООП 1 сем 2 курс\\12 laba OOP\\KAVlogfile.txt", true)) 
            logfile.WriteLine("#################################################");
        }
        static public void WriteToLog(string action, string fileName = "", string path = "")
        {
            using (logfile = new StreamWriter("E:\\Education\\ООП 1 сем 2 курс\\12 laba OOP\\KAVlogfile.txt", true))
            {
                DateTime time = new DateTime();
                time = DateTime.Now;
              
                logfile.WriteLine($"Действие: {action}");

                if (fileName.Length != 0)
                    logfile.WriteLine($"Имя файла: {fileName}");

                if (path.Length != 0)
                    logfile.WriteLine($"Путь: {path}");

                logfile.WriteLine($"Время: {time.ToLocalTime()}");
               
            }
        }
    }
}
  

