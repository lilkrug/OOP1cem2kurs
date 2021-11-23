using System;
using System.IO;

namespace _12_laba_OOP
{
    class Program
    { 
        static void Main(string[] args)
        {
            try
            {
                KAVDiskInfo.GetDrives();
                KAVLog.WriteToLog("KAVDiskInfo.getDrives()");
                Console.WriteLine("#######################################");

                KAVFileInfo.GetFile("E:\\Education\\ООП 1 сем 2 курс\\12 laba OOP\\KAVlogfile.txt");
                KAVLog.WriteToLog("KAVFileInfo.getFile()", "KAVlogfile" , "E:\\Education\\ООП 1 сем 2 курс\\12 laba OOP\\KAVlogfile.txt");
                Console.WriteLine("#######################################");

                KAVDirInfo.GetDir("E:\\Education\\ООП 1 сем 2 курс\\12 laba OOP");
                KAVLog.WriteToLog("KAVDirInfo.GetDir()","", "E:\\Education\\ООП 1 сем 2 курс\\12 laba OOP\\KAVlogfile.txt");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        
            
        
        
    }
}
