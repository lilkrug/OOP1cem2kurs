using System;
using System.Text;
using System.Linq;
namespace _2_лаба_ООПс
{
    public partial class Train
    {

        public readonly int id;
        public static int count = 0;
        string city;
        int numbertrain;
        int gotime;
        int numbersitdown;
        int common;
        int compartment;    
        int plackart;
        int lux;
        public string _City
        {
            get
            {
                return city;
            }
            set
            {
                if (value.Length > 2)
                {
                    Console.WriteLine("Город выбран правильно");
                }
                else
                {
                    city = value;
                }
            }
        }

        public int _Numbertrain { get { return numbertrain; } set { numbertrain = value; } }
        public int _Gotime { get { return gotime; } set { gotime = value; } }
        public int _Numbersitdown { get { return numbersitdown; } set { numbersitdown = value; } }
        public int _Common { get { return common; } set { common = value; } }
        public int _Compartment { get { return compartment; } set { compartment = value; } }
        public int _Plackart { get { return plackart; } set { plackart = value; } }
        public int _Lux { get { return lux; } set { lux = value; } }
        public void TIME(ref int gotime)
        {
            gotime += 15;
        }
        static Train()
        {
            count++;
            Console.WriteLine("Статический конструктор вызван");
        }
        public Train()
        {
            this.city = "Столбцы";
            this.numbertrain = 777;
            this.gotime = 12;
            this.numbersitdown = 100;
            this.common = 20;
            this.compartment = 30;
            this.plackart = 25;
            this.lux = 25;
            count++;
        }

        private Train(int x)
        {
            Console.WriteLine("Приватный конструктор");
            count++;
        }
        public static string about = "Класс для представления инф. об Электричке";
        public static string GetInfo()
        {
            return about;
        }

        public Train(string city, int numbertrain, int numbersitdown, int gotime, int common, int plackart, int compartment, int lux)
        {
            this.city = city;
            this.numbertrain = numbertrain;
            this.gotime = gotime;
            this.numbersitdown = numbersitdown;
            this.common = common;
            this.plackart = plackart;
            this.compartment = compartment;
            this.lux = lux;
            
            count++;
        }
        public void Sitdown()
        {
            Console.WriteLine("Число общих мест в поезде");
        }
       
          
        
        class Program
        {

            static void Main(string[] args)
            {
                int kaa; string stolbcy;
                string kkkk = "Несвиж";
                Train Vasya = new Train();
                Console.WriteLine(Vasya);
                Console.WriteLine(Train.GetInfo());
                Train Petya = new Train("Столбцы", 1, 12, 120, 20, 50, 30, 20);
                Console.WriteLine(Petya);
                Train Petya1 = new Train("Дзержинск", 2, 15, 150, 75, 50, 15, 10);
                Console.WriteLine(Petya1);
                Console.WriteLine(Petya1._Gotime);
                Console.WriteLine(Petya == Petya1);
                Console.WriteLine(Train.Equals(Petya, Petya1));
                Console.WriteLine(Train.count);
                Train Petya2 = new Train("Барановичи", 3, 18, 300, 150, 100, 25, 25);
                Console.WriteLine(Petya2);


                var array = new Train[3];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = new Train();
                    Console.WriteLine();
                    Console.WriteLine("Информация  о названии города");
                    array[i]._City = Console.ReadLine();
                    Console.WriteLine("Номер поезда");
                    //array[i]._Numbertrain = int.Parse(Console.ReadLine());
                    //Console.WriteLine("Время отправления");
                    //array[i]._Gotime = int.Parse(Console.ReadLine());
                    //Console.WriteLine("Число мест");
                    //array[i]._Numbersitdown = int.Parse(Console.ReadLine());
                    //Console.WriteLine("Число общих мест");
                    //array[i]._Common = int.Parse(Console.ReadLine());
                    //Console.WriteLine("Число мест купе");
                    //array[i]._Compartment = int.Parse(Console.ReadLine());
                    //Console.WriteLine("Число мест плацкарт");
                    //array[i]._Plackart = int.Parse(Console.ReadLine());
                    //Console.WriteLine("Число Люкс мест");
                    //array[i]._Lux = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Введите пункт назначния : ");
                stolbcy = Console.ReadLine();
                for (int i = 0; i < array.Length; i++)
                {

                    if (array[i]._City == stolbcy)
                    {
                        Console.WriteLine(array[i]);

                    }
                  
                }
                




                Console.WriteLine("Введите срок");
                kaa = int.Parse(Console.ReadLine());
                for (int i = 0; i < array.Length; i++)
                {
                    if (DateTime.Now.Year - array[i]._Gotime > kaa)
                    {
                        Console.WriteLine(array[i]);
                    }
                }


            }
        }
    }
}

