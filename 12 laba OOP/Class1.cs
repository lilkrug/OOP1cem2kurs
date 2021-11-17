using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace _12_laba_OOP
{
    public class XXXLog
    {
        /*1.Создать класс XXXLog. Он должен отвечать за работу с текстовым файломxxxlogfile.txt.в который записываются все действия пользователя и соответственно методами записи в текстовый файл, чтения, поиска нужной информации.a.Используя данный класс выполните запись всех последующих действиях пользователя с указанием действия, детальной информации (имя файла, путь) и времени (дата/время)*/
        public static void WriteInTXT(string message)
        {
            using var stream = new StreamWriter(@"E:\Education\ООП 1 сем 2 курс\12 laba OOP\xxxlogfile.txt", true, Encoding.Default);
            stream.WriteLine(DateTime.Now.ToString(message));
        }

    }
}
  

