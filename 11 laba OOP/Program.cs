using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
namespace _11_laba_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Test1 test1 = new Test1("qwerty");
            Console.WriteLine(Reflector<Test1>.Assembly(test1.GetType().FullName));

            Test2 test2 = new Test2("ward", 222, "IIS");
            Console.WriteLine(Reflector<Test2>.IsPublicConstructors(test2.GetType().FullName));

            var met = Reflector<Test2>.GetPublicMethods(test2.GetType().FullName);
            foreach (string s in met)
            {
                Console.WriteLine(s);
            }
            var fields = Reflector<Test2>.GetFields(test2.GetType().FullName);
            foreach (string s in fields)
            {
                Console.WriteLine(s);
            }
            var infaces = Reflector<Test2>.GetInterfaces(test2.GetType().FullName);


            Reflector<Test1>.Invoke(test1, "Add");
           

            Test1 newTest1 = Reflector<Test1>.Create(typeof(Test1));
        }

   }
       
}

