using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace _6_laba_OOP
{
    public class MyException : System.Exception
    {
        public string ErrorClass { get; set; }
        public MyException(string message, string errorClass)
            : base(message)  // наследуем message от System.Exception
        {
            this.ErrorClass = errorClass;
        }
    }

    public class TSException : MyException
    {
        public int Skoda { get; set; }
        public int Mersedes { get; set; }
        public int Audi { get; set; }
        public TSException(string message, int errorSkoda, int errorMersedes, int errorAudi)
            : base(message, "Error code 1: Uncorrect date.\n")  // наследуем message и errorClass от MyException
        {
            this.Skoda = errorSkoda;
            this.Mersedes = errorMersedes;
            this.Audi = errorAudi;
        }
    }

    public class PowerException : MyException
    {
        public int Power { get; set; }
        public PowerException(string message, int errorPower)
            : base(message, "Error code 2: Uncorrect power.\n")
        {
            this.Power = errorPower;
        }
    }

    public class SearchPowerException : MyException
    {
        public int Power { get; set; }
        public SearchPowerException(string message, int errorPower)
            : base(message, "Error code 3: Uncorrect power input for search.\n")
        {
            this.Power = errorPower;
        }
    }

    public class NameException : MyException
    {
        public string Name { get; set; }
        public NameException(string message, string errorName)
            : base(message, "Error code 4: Uncorrect name.\n")
        {
            this.Name = errorName;
        }
    }
    public class FileLogger
    {
        public FileLogger() { }
        public void WriteLog(MyException exception)
        {
            TSException DateEx = exception as TSException;
            PowerException PowerEx = exception as PowerException;
            SearchPowerException SearchEx = exception as SearchPowerException;
            NameException NameEx = exception as NameException;

            string filePath = @"E:\Education\ООП 1 сем 2 курс\6 laba OOP\LOG.txt";
            using StreamWriter streamWriter = new StreamWriter(filePath, true, System.Text.Encoding.Default);
            streamWriter.WriteLine(DateTime.Now);
            if (DateEx != null)
            {
                streamWriter.WriteLine("{ 0}{1} {2}.{3}.{4}", DateEx.ErrorClass, DateEx.Message, DateEx.Skoda, DateEx.Mersedes, DateEx.Audi); 
            }
            if (PowerEx != null)
            {
                streamWriter.WriteLine("{0}{1} {2}", PowerEx.ErrorClass, PowerEx.Message, PowerEx.Power);
            }
            if (SearchEx != null)
            {
                streamWriter.WriteLine("{0}{1} {2}", SearchEx.ErrorClass, SearchEx.Message, SearchEx.Power);
            }
            if (NameEx != null)
            {
                streamWriter.WriteLine("{0}{1} {2}", NameEx.ErrorClass, NameEx.Message, NameEx.Name);
            }
        }
    }

    public class ConsoleLogger
    {
        public ConsoleLogger() { }
        public void WriteLog(MyException exception)
        {
            TSException DateEx = exception as TSException;
            PowerException PowerEx = exception as PowerException;
            SearchPowerException SearchEx = exception as SearchPowerException;
            NameException NameEx = exception as NameException;

            Console.WriteLine("\n" + DateTime.Now);
            if (DateEx != null)
            {
                Console.WriteLine("{0}{1} {2}.{3}.{4}", DateEx.ErrorClass, DateEx.Message, DateEx.Skoda, DateEx.Mersedes, DateEx.Audi); ;
            }
            if (PowerEx != null)
            {
                Console.WriteLine("{0}{1} {2}", PowerEx.ErrorClass, PowerEx.Message, PowerEx.Power);
            }
            if (SearchEx != null)
            {
                Console.WriteLine("{0}{1} {2}", SearchEx.ErrorClass, SearchEx.Message, SearchEx.Power);
            }
            if (NameEx != null)
            {
                Console.WriteLine("{0}{1} {2}", NameEx.ErrorClass, NameEx.Message, NameEx.Name);
            }
        }
    }


}