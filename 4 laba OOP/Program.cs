using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_laba_OOP
{
    public interface IName
    {
        string Name { get { return Name; } set { this.Name = value; } }
    }
   

    public abstract class Vehicle : IName
         {

            public abstract void Speed();
            public abstract void Tires();
            public abstract void Nazvanie();
            public void ShowInfo()
            {
                Console.WriteLine(GetType().Name);
            }
             public int Drive { get; set; }
             public int Power { get; set; }
               
    }   

        public class Person
        {
            public void Speed(Vehicle vehicle)
            {
                vehicle.Speed();
            }
            public void CheckInfo(Vehicle vehicle)
            {
                vehicle.ShowInfo();
            }
            public void Tires(Vehicle vehicle)
            {
                vehicle.Tires();
            }
            public void Nazvanie(Vehicle vehicle)
            {
                vehicle.Nazvanie();
            }
            public string Name { get; set; }
             public override string ToString()
                {
                    if (String.IsNullOrEmpty(Name))
                    return base.ToString();
                    return Name;
                }


    }
         public class Car : Vehicle, IName
            {
        public string Name { get; set; }
        public override void Speed()
            {
                Console.WriteLine(180);
            }

            public override void Tires()
            {
                Console.WriteLine(20);
            }

            public override void Nazvanie()
            {
                Console.WriteLine("Жигули");
            }
        public Car(string Namesystem, int drive, int power)
        {
            this.Name = Namesystem;
            this.Drive = drive;
            this.Power = power;
        }

        public Car()
                {
                }
         }
        public class Vagon : Vehicle, IName
        {
        public string Name { get; set; }
        public override void Speed()
            {
                Console.WriteLine(80);
            }

            public override void Tires()
            {
                Console.WriteLine(18);
            }

            public override void Nazvanie()
            {
                Console.WriteLine("2Вагон");
            }

        public Vagon(string Namesystem, int drive, int power)
        {
            this.Name = Namesystem;
            this.Drive = drive;
            this.Power = power;
        }

        public Vagon()
        {
        }
    }
        public class Exspress : Vehicle, IName
        {
        public string Name { get; set; }
        public override void Speed()
            {
                Console.WriteLine(100);
            }

            public override void Tires()
            {
                Console.WriteLine(16);
            }

            public override void Nazvanie()
            {
                Console.WriteLine("Минск-Столбцы");
            }
        public Exspress(string Namesystem, int drive, int power)
        {
            this.Name = Namesystem;
            this.Drive = drive;
            this.Power = power;
        }
        public Exspress()
        {
        }

    }
        public class Poezd : Vehicle, IName
        {
        public string Name { get; set; }
        public override void Speed()
            {
                Console.WriteLine(90);
            }

            public override void Tires()
            {
                Console.WriteLine(25);
            }

            public override void Nazvanie()
            {
                Console.WriteLine("ФМВАЦ-382834");
            }
        public Poezd(string Namesystem, int drive, int power)
        {
            this.Name = Namesystem;
            this.Drive = drive;
            this.Power = power;
        }

        public Poezd()
        {
        }
    }
        
        public class Dvigatel : Vehicle, IName
        {
        public string Name { get; set; }
        public override void Speed()
            {
                Console.WriteLine(20);
            }

            public override void Tires()
            {
                Console.WriteLine(10);
            }

            public override void Nazvanie()
            {
                Console.WriteLine("30287-fkegj");
            }
        public Dvigatel(string Namesystem, int drive, int power)
        {
            this.Name = Namesystem;
            this.Drive = drive;
            this.Power = power;
        }

        public Dvigatel()
        {
        }

        public override string ToString()
        {
            return "Тип объекта: " + GetType().Name + "\nНазвание танка: " + Name + "\nМощность двигателя: " + Power + "\nКол-во колёс: " + Drive + "\n" + new String('-', 50);
        }
    }

    public class Printer
    {
        public string IAmPrinting(Vehicle obj)
        {
            if (obj is Car c)
            {
                return "Тип объекта: " + c.GetType().Name + "\nНазвание машины: " + c.Name + "\nМощность двигателя: " + c.Power + "\nКол-во колёс: " + c.Drive + "\n" + new String('-', 50);
            }
            if (obj is Poezd t)
            {
                return "Тип объекта: " + t.GetType().Name + "\nНазвание поезда: " + t.Name + "\nМощность двигателя: " + t.Power + "\nКол-во колёс: " + t.Drive + "\n" + new String('-', 50);
            }
            if (obj is Dvigatel b)
            {
                return "Тип объекта: " + b.GetType().Name + "\nНазвание двигателя: " + b.Name + "\nМощность двигателя: " + b.Power + "\nКол-во колёс: " + b.Drive + "\n" + new String('-', 50);
            }
            return "qq";
        }
    }

    public class Program
        {
            static void Main(string[] args)
            {
                Person person = new Person { Name ="Alexei" };
                Console.WriteLine(person.ToString());
                Vehicle[] inventory = { new Car(), new Vagon(), new Poezd(), new Dvigatel(), new Exspress() };
                Console.WriteLine(inventory.ToString());
            Car car = new Car("МАЗДА", 20,153);
            Poezd poezd = new Poezd("wghuw24898312", 10, 214);
            Dvigatel dvigatel = new Dvigatel("fkn372764383-32746shqdjbq", 30, 1245);
            foreach (var item in inventory)
                {
                    person.CheckInfo(item);
                    person.Speed(item);
                    person.Tires(item);
                    person.Nazvanie(item);
                    person.ToString();
                }
            Printer printer = new Printer();
            Console.WriteLine(printer.IAmPrinting(car));
            Console.WriteLine(printer.IAmPrinting(poezd));
            Console.WriteLine(printer.IAmPrinting(dvigatel));
            Console.WriteLine();

            User user = new User();
            Console.WriteLine(user.DoClone());
        }
        }
     








}
