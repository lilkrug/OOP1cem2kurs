using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _6_laba_OOP
{
    public class TransportAgency
    {
        public List<Vehicle> TAgency;
        public TransportAgency()
        {
            TAgency = new List<Vehicle>();
        }
        public void Delete(int index)
        {
            TAgency.RemoveAt(index);
        }
        public void Add(Vehicle item)
        {
            TAgency.Add(item);
        }
        public void Display()
        {
            foreach (Vehicle item in TAgency)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
    public class TransportController : TransportAgency
    {

        public void SearchSpeed(TS ts)
        {
            int speedsc = 0;
            Console.WriteLine("\nПоиск транспортного средства {0}.{1}.{2}", ts.Skoda, ts.Mersedes, ts.Audi);
            for (int i = 0; i < TAgency.Count; i++)
            {
                if (TAgency[i].Speedscore < 165)  
                {
                    speedsc = TAgency[i].Speedscore;

                }
                else
                {
                    Console.WriteLine("Ваша скорость как у ракеты : 2529140");
                }
            }
            Console.WriteLine("Ваша скорость попала в диапазон : " + speedsc);


        }
        public void GetPrice()
        {
            int price = 0;
           
            for (int i = 0; i < TAgency.Count; i++)
            {

                price += TAgency[i].Price;
            }
            if (price < 200000 || price > 1000000)
                throw new SearchPowerException("Ошибка! Неверно введена стоимость  для поиска:", price);
            Console.WriteLine("\n Стоимость всех авто: " + price);
        }
        //public void SearchFuel()
        //{
        //    TAgency.Sort();
        //    for (int i = 0; i < TAgency.Count; i++)
        //    {
        //        Console.WriteLine(TAgency[i].Fuel);
        //    }
        //}
    }

    public struct TS
    {
        public string Skoda;
        public string Mersedes;
        public string Audi;


        public TS(string skoda, string mersedes, string audi)
        {
            this.Skoda = skoda;
            this.Mersedes = mersedes;
            this.Audi = audi;
        }
        enum Operation
        {
            Add = 1,
            Delete,
            Display,
            SearchFuel,
            SearchSpeed,
            GetPrice
        }




    }
}
