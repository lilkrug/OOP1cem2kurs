using System;

namespace KR_po_OOP
{

    public class Date
    {
        private readonly int yy = 1998;
        private int dd;
        private int mm;

        public int day { get => dd; set { dd = value; } }
        public int month { get => mm; set { mm = value; } }
        public int year { get => yy; }

        public override bool Equals(Object obj)
        {
            if (obj == null)
                return false;
            Date d = obj as Date;
            if (d as Date == null)
                return false;

            return (d.dd == this.dd && d.mm == this.mm);
        }


    }
    class Counter
    {
        public int Value { get; set; }
        public static Counter operator +(Counter c1, Counter c2)
        {
            return new Counter { Value = c1.Value + c2.Value };
        }
        public static bool operator >(Counter c1, Counter c2)
        {
            return c1.Value > c2.Value;
        }
        public static bool operator <(Counter c1, Counter c2)
        {
            return c1.Value < c2.Value;
        }
        public static Counter operator %(Counter d1, Counter d2)
        {
            return d1 % d2;
        }


    }

    interface IGood
    {
        void plus();
    }
    interface IBad
    {
        void minus();
    }
    abstract class People { }
    class Student : People, IGood, IBad
    {
        public void plus() =>
            Console.WriteLine("Ученик складывает.");
        public void minus() =>
            Console.WriteLine("Ученик вычитает.");
    }
    class Prepod : People, IGood
    {
        public void plus() =>
            Console.WriteLine("Преподаватель складывает.");
    }



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n##################### 1 zadanie ####################");
            

            string str = "Круглик1231";
            string sub_str = "123";
            int index = str.IndexOf(sub_str);
            if (index == -1)
                Console.WriteLine("Подстроки нет в строке");
            else
                Console.WriteLine("Подстрока содержится в строке");

            double[,] arr = new double[2, 2];
            Random rand = new Random();

            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                {
                    arr[i, j] = rand.Next(1, 99);
                    Console.Write(arr[i, j] + "  ");
                }

            Console.WriteLine("\n##################### 2 zadanie ####################");

            Date d1 = new Date();
            Date d2 = new Date();
            d1.day = 1; d1.month = 7;
            d2.day = 8; d2.month = 6;
            Console.WriteLine("\nd1 эквивалентно d2? - " + d1.Equals(d2));

            Counter c1 = new Counter { Value = 23 };
            Counter c2 = new Counter { Value = 45 };

            bool result = c1 > c2;
            Console.WriteLine(result); // false
            
            Counter c3 = c1 + c2;
            Console.WriteLine(c3.Value);
          

            Console.WriteLine("\n##################### 3 zadanie ####################");
            Student st = new Student();
            Prepod pr = new Prepod();
            st.minus();
            st.plus();
            pr.plus();
            Console.ReadLine();
        }
    }
}




