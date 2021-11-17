using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _11_laba_OOP
{
    public static class Reflector<T>
    {
        public static string Assembly(string ClassName)
        {
            return Type.GetType(ClassName).Assembly.FullName;
        }
        public static bool IsPublicConstructors(string ClassName)
        {
            if (Type.GetType(ClassName).GetConstructors().Length != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static IEnumerable<string> GetPublicMethods(string ClassName)
        {
            return Type.GetType(ClassName).GetMethods().Select(t => t.Name);
        }
        public static IEnumerable<string> GetFields(string ClassName)
        {
            return Type.GetType(ClassName).GetFields().Select(t => t.Name).Union(Type.GetType(ClassName).GetProperties().Select(t => t.Name));
        }
        public static IEnumerable<string> GetInterfaces(string ClassName)
        {
            return Type.GetType(ClassName).GetInterfaces().Select(n => n.FullName);
        }
        public static IEnumerable<string> GetMethodsParamType(string ClassName, Type paramtype)
        {
            return Type.GetType(ClassName).GetMethods().Where(a => (a.GetParameters().Where(b => b.ParameterType == paramtype)).Count() != 0).Select(p => p.Name);
        }
        internal static void Invoke(T t, string methodName)
        {
            Type type = t.GetType();
            try
            {

                string[] _params = File.ReadAllLines(@"E:\Education\ООП 1 сем 2 курс\11 laba OOP\Reflection.txt");
                string[] pr = { "asdfg" };

                MethodInfo method = type.GetMethod(methodName);
                Console.WriteLine("Результат выполнения метода : ");
                Console.WriteLine(method.Invoke(t, _params));
            }
            catch (Exception er)
            {
                Console.WriteLine(er.Message);
            }
        }

        internal static T Create(Type t)
        {
            T obj = (T)Activator.CreateInstance(t);
            return obj;
        }

    } 
}
