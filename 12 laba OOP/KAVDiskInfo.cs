using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace _12_laba_OOP
{
    static public class KAVDiskInfo
    {
        static public void GetDrives()
        {
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
        }
    }
}
