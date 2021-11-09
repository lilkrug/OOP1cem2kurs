using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _10_laba_OOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            // ==========================Задание1==================================
            var teams = new List<string>
            { "June", "July", "August", "September", "October", "November",
                "December", "January", "February", "March", "April", "May" };

            ///запрос выбирающий последовательность месяцев с длиной строки равной n.
            Console.WriteLine("###################################################################");
            IEnumerable<string> s = teams.Where(i => i.Length > 6);
            foreach (string i in s)
            {
                Console.WriteLine(i);
            }
            ///запрос возвращающий только летние и зимние месяцы
            Console.WriteLine("###################################################################");
            IEnumerable<string> v = teams.Take(3);
            foreach (var i in v)
            {
                Console.WriteLine(i);
            }
            IEnumerable<string> r = teams.Skip(6).Take(3);
            foreach (var i in r)
            {
                Console.WriteLine(i);
            }
            ///запрос вывода месяцев в алфавитном порядке
            Console.WriteLine("###################################################################");
            IEnumerable<string> b = teams.OrderBy(i => i);
            foreach (var i in b)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("###################################################################");
            IEnumerable<string> c = teams.Where(i => i.Contains("e"));
            foreach (var i in c)
            {
                Console.WriteLine(i);
            }
            // ==========================Задание2==================================
            Console.WriteLine("\n\t\t       Список товаров:\n");
            Product product1 = new Product("Skoda Octavia", "Чехия", "Škoda Auto a.s.", 2000, 40000);
            Product product2 = new Product("Asus TufGaming", "Тайвань", "ASUSTeK Computer", 15, 2000);
            Product product3 = new Product("Apple Iphone xr", "США", "Apple", 1, 1400);
            Product product4 = new Product("Apple Watch 2", "США", "Apple", 1, 1200);
            Product product5 = new Product("Whiskey", "Ирландия", "Proper Twelve", 2, 500);
            Product product6 = new Product("Samsung Galaxy s21", "Южная Корея", "Samsung Electronics", 1, 2500);
            Product product7 = new Product("kawasaki", "Япония", "Kawasaki Heavy Industries", 100, 15000);
            Product product8 = new Product("BMW", "Германия", "Bayerische Motoren Werke AG", 2200, 50000);


            List<Product> listPropucts = new List<Product>() { product1, product2, product3, product4, product5, product6, product7, product8 };
            foreach (Product m in listPropucts)
            {
                Console.WriteLine(m.ToString());
            }
            ///список товаров для заданного наименования;
            Console.WriteLine("===========================================");
            var nameproduct = from m in listPropucts
                              where m.Name == "Asus TufGaming"
                              select m;
            foreach (Product m in nameproduct)
                Console.WriteLine(m.ToString() + "Наименование продукта: " + m.Name);
            ///список товаров для заданного наименования, цена которых не превосходит заданную;
            Console.WriteLine("===========================================");
            var pricename = from m in listPropucts
                            where m.Manufactured == "Apple" && m.price < 5000
                            select m;
            foreach (Product m in pricename)
                Console.WriteLine(m.ToString() + "Цена : " + m.price);
            ///количество наименований цена которых больше 100
            Console.WriteLine("===========================================");
            var pricerising = from m in listPropucts
                              where m.price > 100
                              select m;
            foreach (Product m in pricerising)
                Console.WriteLine(m.ToString() + "Цена : " + m.price);
            ///максимальный товар (ваш критерий максимальности)
            Console.WriteLine("===========================================");
            int maxweigth = listPropucts.Max(i => i.weight);
            var result = listPropucts.FirstOrDefault(i => i.weight == maxweigth);
            Console.WriteLine("Самый тяжёлый товар : " + result + "Масса : " + result.weight);
            ///упорядоченный набор товаров по производителю, а потом пo количеству
            Console.WriteLine("===========================================");
            var SortManufactured = from m in listPropucts
                                   orderby m.Manufactured
                                   select m;
            foreach (Product m in SortManufactured)
                Console.WriteLine(m + "Производитель : " + m.Manufactured);
            Console.WriteLine("====================");
            var SortCountry = from m in listPropucts
                              orderby m.Country ascending
                              select m;
            foreach (Product m in SortCountry)
                Console.WriteLine(m + "Страна : " + m.Country);
            ///4 задание с кастомным запросом (сам придумываешь запрос)
            ///Запрос на цену которая меньше средней цены товаров , но больше 1000$
            Console.WriteLine("===========================================");
            var PriceAverage = from m in listPropucts
                               where m.price < listPropucts.Average(i => i.price) && m.price > 1000
                               select m;
            foreach (Product m in PriceAverage)
                Console.WriteLine(m + "Цена : " + m.price);
            ///5 задание  Придумайте запрос с оператором Join(сам придумаваешь запрос)
            Console.WriteLine("===========================================");

            Console.WriteLine("\n\t Товары определённого издетальства:\n");

          

        }
    }   
}
