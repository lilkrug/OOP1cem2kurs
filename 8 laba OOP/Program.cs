using System;
using System.Collections.Generic;
using System.Text;

namespace _8_laba_OOP
{
    public delegate void Game(string message);
    public class Warrior
    {
        
        public event Game Attack;
        public event Game Heals;
        public Warrior(int point)
        {
            Point = point;
        }
        public int Point { get; set; }

        public void Help(int point)
        {
            Point += point;
            Heals?.Invoke($"Воин восстановил hp: {point}");
        }
        public void Boom(int point)
        {
            if (Point >= point)
            {
                Point -= (point / 2);
                Attack?.Invoke($"Воин потерял {point / 2} hp");
            }
            else
            {
                Point = 0;
                Attack?.Invoke($"У война закончились hp. Текущиe hp Война {Point}, Воин погиб.");
            }

        }

    }
    
    public class Druid
    {

        public event Game Attack;
        public event Game Heals;
        public Druid(int point)
        {
            Point = point;
        }
        public int Point { get; set; }

        public void Help(int point)
        {
            Point += (point *2);
            Heals?.Invoke($"Друид восстановил hp: {point * 2}");
        }
        public void Boom(int point)
        {
            if (Point >= point)
            {
                Point -= point;
                Attack?.Invoke($"Друид потерял {point} hp, ");
            }
            else
            {
                Point = 0;
                Attack?.Invoke($"У Друида закончились hp. Текущиe hp Друида {Point}, Друид погиб");
            }

        }

    }


        static class Program
        {
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior(300);
            warrior.Attack += GameAttack;
            warrior.Boom(100);
            Console.WriteLine($" hp Воина: {warrior.Point}");
            warrior.Heals += GameHeals;
            warrior.Help(50);
            Console.WriteLine($" hp Воина: {warrior.Point}");
            warrior.Boom(150);
            Console.WriteLine($" hp Воина: {warrior.Point}");
            warrior.Help(100);
            Console.WriteLine($" hp Воина: {warrior.Point}");
            warrior.Boom(250);
            Console.WriteLine($" hp Воина: {warrior.Point}");
            warrior.Boom(300);
            Console.WriteLine($" hp Воина: {warrior.Point}");


            Console.WriteLine("###########################################################################");


            Druid druid = new Druid(200);
            druid.Attack += GameAttack;
            druid.Boom(50);
            Console.WriteLine($" hp Друида: {druid.Point}");
            druid.Help(20);
            Console.WriteLine($" hp Друида: {druid.Point}");
            druid.Boom(75);
            Console.WriteLine($" hp Друида: {druid.Point}");
            druid.Boom(50);
            Console.WriteLine($" hp Друида: {druid.Point}");
            druid.Help(100);
            Console.WriteLine($" hp Друида: {druid.Point}");
            druid.Boom(400);
            Console.WriteLine($" hp Друида: {druid.Point}");


            Console.WriteLine("##########################################################################");


            Console.WriteLine("Обработка методов строк");
            Func<string, string> funcStr;
            string str = "A  . l!  ,  e,  ,x  . i, z!";
            Console.WriteLine($"Исходная строка:        {str}");
            funcStr = String.RemoveSpace;
            Console.WriteLine($"Без пробелов:           {str = funcStr(str)}");
            funcStr = String.Upper;
            Console.WriteLine($"Заглавными буквами:     {str = funcStr(str)}");
            funcStr = String.Lower;
            Console.WriteLine($"Строчными буквами:      {str = funcStr(str)}");
            funcStr = String.AddToString;
            Console.WriteLine($"С добавлением символа:  {str = funcStr(str)}");


            Console.Read();
        }
        public static void GameHeals(string message) => Console.WriteLine(message);
        public static void GameAttack(string message) => Console.WriteLine(message);
    }


  
}

