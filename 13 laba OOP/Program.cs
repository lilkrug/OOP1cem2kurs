using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
namespace _13_laba_OOP
{
    public class Program
    {

        public static async Task Main(string[] args)
        {
            Console.WriteLine("################### 1 exercise ###################");
            Person person1 = new Person("Andei", 20);
            Person person2 = new Person("Alexiz", 19);
            Person[] people = new Person[] { person1, person2 };
            Console.WriteLine("Класс Объявлен");

            BinaryFormatter binary = new BinaryFormatter();
            using (FileStream fs = new FileStream("E:\\Education\\ООП 1 сем 2 курс\\13 laba OOP\\Binary.dat", FileMode.OpenOrCreate))
            {
                binary.Serialize(fs, people);
                Console.WriteLine("Объект сериализован");
            }
            using (FileStream fs = new FileStream("E:\\Education\\ООП 1 сем 2 курс\\13 laba OOP\\Binary.dat", FileMode.OpenOrCreate))
            {
                Person[] deserilizePeople = (Person[])binary.Deserialize(fs);
                foreach (Person p in deserilizePeople)
                {
                    Console.WriteLine($"Name: {p.Name} --- Age: {p.Age}");
                }
            }

            Console.WriteLine("################### 2 exercise ###################");
            using (FileStream fs = new FileStream("E:\\Education\\ООП 1 сем 2 курс\\13 laba OOP\\JSON.json", FileMode.OpenOrCreate))
            {
                Person person3 = new Person("Volodya", 30);
                await JsonSerializer.SerializeAsync<Person>(fs, person3);
                Console.WriteLine("Data has been saved to file");
            }



            Console.WriteLine("################### 3 exercise ###################");
            
            Person person4 = new Person("Gans", 25);
            Console.WriteLine("Объект создан");
            
            XmlSerializer formatter = new XmlSerializer(typeof(Person));
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream gs = new FileStream("E:\\Education\\ООП 1 сем 2 курс\\13 laba OOP\\People.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(gs, person4);
                Console.WriteLine("Объект сериализован");
            }

            // десериализация
            using (FileStream gs = new FileStream("E:\\Education\\ООП 1 сем 2 курс\\13 laba OOP\\People.xml", FileMode.OpenOrCreate))
            {
                Person newPeople = (Person)formatter.Deserialize(gs);

                Console.WriteLine("Объект десериализован");
                Console.WriteLine($"Имя: {newPeople.Name} --- Возраст: {newPeople.Age} ");
                
            }
          

            Console.WriteLine("################### 4 exercise ###################");
            //выберем все узлы корневого элемента, то есть все элементы Person:
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("E:\\Education\\ООП 1 сем 2 курс\\13 laba OOP\\People.xml");
            XmlElement xRoot = xDoc.DocumentElement;

            XmlNodeList childnodes = xRoot.SelectNodes("*");
            foreach (XmlNode n in childnodes)
                Console.WriteLine(n.OuterXml);

            //Выведем на консоль значения атрибутов Name у элементов Person:
            XmlNodeList childnode = xRoot.SelectNodes("Name");
            Console.WriteLine(childnode);


           //Допустим, нам надо получить только Возраст.Для этого надо осуществить выборку вниз по иерархии элементов:
            XmlNodeList childnod = xRoot.SelectNodes("//Person/Age");
            foreach (XmlNode n in childnod)
                Console.WriteLine(n.InnerText);


            Console.WriteLine("################### 5 exercise ###################");
            XDocument xdoc = new XDocument();
            // создаем первый элемент
            XElement Car = new XElement("Car");
            // создаем атрибут
            XAttribute CarName = new XAttribute("name", "Mersedes");
            XElement CarCompany = new XElement("company", "TasAuto");
            XElement CarPrice = new XElement("price", "40000");
            Car.Add(CarName);
            Car.Add(CarCompany);
            Car.Add(CarPrice);

            XElement Moto = new XElement("Motobike");
            XAttribute MotoName = new XAttribute("name", "Kawasaki");
            XElement MotoCompany = new XElement("company", "Tangomoto");
            XElement MotoPrice = new XElement("price", "15000");
            Moto.Add(MotoName);
            Moto.Add(MotoCompany);
            Moto.Add(MotoPrice);

            XElement Auto = new XElement("Transport");
            Auto.Add(Car);
            Auto.Add(Moto);
            // добавляем корневой элемент в документ
            xdoc.Add(Auto);
            //сохраняем документ
            xdoc.Save("E:\\Education\\ООП 1 сем 2 курс\\13 laba OOP\\Auto.xml");

            Console.ReadLine();
        }
    }
}
