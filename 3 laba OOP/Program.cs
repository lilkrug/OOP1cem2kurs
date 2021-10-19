using System;

namespace OOP_Lab4
{
    class List
    {
        public int[] a = new int[100];
        public string str;
        public Owner owner;
        public List() { }
        public List(int ownerId, string ownerName, string ownerCompany)
        {
            this.owner = new Owner(ownerId, ownerName, ownerCompany);
        }



        // ================= МЕТОДЫ ====================
        public void enterData(params int[] ArrayData)
        {
            this.a = ArrayData;
        }
        public void printInfo()
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != 0)
                    Console.Write(a[i] + "\t");
            }
            Console.WriteLine();
        }




        // ==================== ПЕРЕГРУЗКА =====================
        public static List operator *(List arr1, List arr2)
        {
            List arrP = new List();
            for (int i = 0; i < arr2.a.Length; i++)
            {
                arrP.a[i] = arr1.a[i] * arr2.a[i];
            }
            return arrP;
        }
        public static bool operator true(List arr)
        {
            for (short i = 0; i < arr.a.Length; i++)
            {
                if (arr.a[i] < 0)
                    return false;
            }
            return true;
        }
        public static bool operator false(List arr)
        {
            for (short i = 0; i < arr.a.Length; i++)
            {
                if (arr.a[i] < 0)
                    return true;
            }
            return false;
        }
        public static explicit operator int(List arr)
        {
            return arr.a.Length;
        }
        public static bool operator ==(List arr1, List arr2)
        {
            for (int i = 0; i < arr1.a.Length; i++)
            {
                if (arr1.a[i] != arr2.a[i])
                    return false;
            }
            return true;
        }
        public static bool operator !=(List arr1, List arr2)
        {
            for (int i = 0; i < arr1.a.Length; i++)
            {
                if (arr1.a[i] != arr2.a[i])
                    return true;
            }
            return false;
        }
        public static bool operator <(List arr1, List arr2)
        {
            if (StatisticOperations.sum(arr1) < StatisticOperations.sum(arr2))
                return true;
            else return false;
        }
        public static bool operator >(List arr1, List arr2)
        {
            if (StatisticOperations.sum(arr1) > StatisticOperations.sum(arr2))
                return true;
            else return false;
        }




        // ==================== ВЛОЖЕННЫЙ КЛАСС =======================
        public class Date
        {
            public DateTime time;
            public Date()
            {
                this.time = new DateTime(2021, 9, 27, 20, 47, 0);
            }
            public void showDate()
            {
                Console.WriteLine("Дата создания: " + time);
            }
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            List arr1 = new List();
            List arr2 = new List();
            List arr3 = new List();
            List arr4 = new List();

            arr1.enterData(1, 2, 3, 4, 5, 6, 7);
            arr1.printInfo();

            arr2.enterData(1, 2, 3, 4, 5, 6, 7);
            arr2.printInfo();

            Console.WriteLine("------------  Перегрузка оператора *  ------------");
            List arrP = arr1 * arr2;
            arrP.printInfo();

            Console.WriteLine("----------  Перегрузка оператора true  -----------");
            if (arr1)
                Console.WriteLine("arr1 вернул значение true");
            else Console.WriteLine("arr1 вернул значение false");

            Console.WriteLine("----------  Перегрузка оператора int()  ----------");
            Console.WriteLine((int)arr2);

            Console.WriteLine("-----------  Перегрузка оператора ==  ------------");
            if (arr1 == arr2)
                Console.WriteLine("arr1 == arr2");
            else Console.WriteLine("arr1 != arr2");


            Console.WriteLine("-----------  Перегрузка оператора >  ------------");
            Console.WriteLine("arr3:");
            arr3.enterData(1, 3, 32, 6, 17, 22);
            arr3.printInfo();
            Console.WriteLine("arr3.sum() = " + arr3.sum());

            Console.WriteLine("\narr4:");
            arr4.enterData(9, 11, 32, 54, 21, 12);
            arr4.printInfo();
            Console.WriteLine("arr4.sum() = " + arr4.sum() + '\n');

            if (arr3 > arr4)
                Console.WriteLine("arr3 > arr4");
            else Console.WriteLine("arr3 < arr4");

            
            List ownerArr = new List(1, "Alexei", "ItechArt ");
            ownerArr.owner.printInfo();
            List.Date date = new List.Date();
            date.showDate();

            
            Console.WriteLine("Max in arrP: " + arrP.max());
            Console.WriteLine("Min in arr4: " + arr4.min());
            Console.WriteLine("Delta in arr3: " + arr3.delta());
            Console.WriteLine("Size of arr2: " + arr2.size());


            List arrNega = new List();
            arrNega.enterData(1, 2, 3, -1, 4, -2, 5);
            List arrOut = arrNega.nega();
         
            arrOut.printInfo();

            List arrStr = new List();
            arrStr.str = "Hello World!";
           
            Console.WriteLine("\nВведите символ, который хотите найти в строке:");
            string symbol = Console.ReadLine();
            arrStr.hasSymbol(symbol);
        }
    }
}
