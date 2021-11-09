 using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;

namespace _9_laba_OOP
{
    class Program
    {


        static void Main(string[] args)
        {
            
            /// ===============  Инициализация экземпляров Car =================
            Game FarCry  = new Game("Primal", 50000);
            Game Diablo = new Game("Maltael", 100000);
            Game Borderlands = new Game("The Pre-Sequel", 150000);
            Game Warcraft = new Game("Frozen Throne", 200000);

            /// =========  Методы для работы с коллекцией  ==========
            GameDictionary showgame = new GameDictionary();
            showgame.Add(1, FarCry);
            showgame.Add(2, Diablo);
            showgame.Add(3, Borderlands);
            showgame.Add(4, Warcraft);
            showgame.Delete(3);
            Console.WriteLine(new String('=', 60));
            Console.WriteLine("\n\t\t     Создание объектов:\n");
            showgame.Print();

            /// ================  Создание обобщённого словаря  ================\
            Dictionary<int, int> genDictionary = new Dictionary<int, int>();
            for (int i = 0; i < 8; i++)
                genDictionary.Add(i, i);
            Console.WriteLine(new String('=', 60));
            Console.WriteLine("\n\t\tРабота с обощённым словарём:\n");
            Console.WriteLine("Коллекция int в словаре:");
            foreach (KeyValuePair<int, int> item in genDictionary)
                Console.WriteLine("{0}. {1}", item.Key, item.Value);

            Console.WriteLine("\nУдалить n элементов:");
            for (int i = 3; i < 6; i++)
                genDictionary.Remove(i);
            foreach (KeyValuePair<int, int> item in genDictionary)
                Console.WriteLine("{0}. {1}", item.Key, item.Value);

            Console.WriteLine("\nСловарь, преобразованный в список:");
            List<int> listOfDic = genDictionary.Values.ToList();
            foreach (int item in listOfDic)
                Console.WriteLine(item);


            Console.WriteLine("\nНайти в списке элемент 2:");
            foreach (int item in listOfDic)
                if (item == 2)
                    Console.WriteLine("В списке есть элемент 2\n");

            /// ==============  Создание наблюдаемой коллекции  ================
            ObservableCollection<Game> obsGames = new ObservableCollection<Game>
            {
                new Game("TheWitcher", 400000),
                new Game("GTA", 600000),
                new Game("Rage", 200000),

            };
            Console.WriteLine(new String('=', 60));
            Console.WriteLine("\n\t\tСобытия обозреваемой коллекции:\n");
            obsGames.Add(new Game("Minecraft", 700000));
            obsGames.RemoveAt(1);
            obsGames[2] = new Game("CallofDuty", 550000);

            Console.WriteLine("\nИтоговый список:");
            foreach (Game user in obsGames)
                Console.WriteLine(user.Name);

            Console.WriteLine();
            Console.WriteLine(new String('=', 60));
            Console.WriteLine();
        }
    }
}
