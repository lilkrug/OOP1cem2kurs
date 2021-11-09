using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _9_laba_OOP
{
    public class Game : IComparable<Game>
    {
        public string Name { get; set; }
        public int Price{ get; set; }
        public Game(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public int CompareTo(Game obj)
        {
            return Price.CompareTo(obj);
        }
    }

    public class GameDictionary
    {
        public Dictionary<int, Game> list { get; set; }
        public GameDictionary()
        {
            list = new Dictionary<int, Game>();
        }

        public void Print()
        {
            foreach (KeyValuePair<int, Game> item in list)
                Console.WriteLine("{0}. {1} – {2}$", item.Key, item.Value.Name, item.Value.Price);
        }

        public void Add(int key, Game value)
        {
            list.Add(key, value);
        }
        public void Delete(int key)
        {
            list.Remove(key);
        }
    }
}

