using System;
using System.Collections.Generic;
using System.Text;

namespace _10_laba_OOP
{
    public class Product
    {
        //Поля
        public readonly int id;
        string name;
        string country;
        string manufactured;
        public short weight;
        public int price;
        public static short numberOfProduct = 0;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (!String.IsNullOrEmpty(name))
                    name = value;
                else Console.WriteLine("Ошибка! Неверное название товара.");
            }
        }
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                if (!String.IsNullOrEmpty(country))
                    country = value;
                else Console.WriteLine("Ошибка! Неверно задана страна изготовитель.");
            }
        }
        public string Manufactured
        {
            get
            {
                return manufactured;
            }
            set
            {
                if (!String.IsNullOrEmpty(manufactured))
                    manufactured = value;
                else Console.WriteLine("Ошибка! Неверная дата изготовления.");
            }
        }
        //Конструктор
        public Product(string aName, string aCountry, string amanufactured, short aWeigth, int aPrice)
        {
            name = aName;
            country = aCountry;
            price = aPrice;
            weight = aWeigth;
            manufactured = amanufactured;
            id = GetHashCode();
            numberOfProduct++;
        }
        // Метод вывода полей
        //public void PrintInfo()
        //{
        //    Console.WriteLine("===========================================\n\tid: {0}\n\tНазвание: {1}\n\tСтрана: {2}\n\t" +
        //        "Изготовление: {3}\n\tЦена: {4}\n\tВес: {5}\n\t р.\n" +
        //        "===========================================", id, name, country, price, weight, manufactured);
        //}
        public override string ToString()
        {
            return $"Название: {Name}; Страна: {country}; ";
        }
      

    }
    
}
