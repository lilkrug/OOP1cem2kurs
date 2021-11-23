using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace _13_laba_OOP
{
    [Serializable]
    public class Person
    {

        public string Name { get; set; }
        
        public int Age { get; set; }
        public Person(string name, int age)
            {
            Name = name;
            Age = age;
            }
        public Person()
        { }


    }
    

}
