using System;
using System.Collections.Generic;
using System.Text;

namespace _8_laba_OOP
{
    
        public static class String
        {
            public static string Upper(string str)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    str = str.Replace(str[i], char.ToUpper(str[i]));
                }
                return str;
            }

             public static string Lower(string str)
             {
                 for (int i = 0; i < str.Length; i++)
                 {
                     str = str.Replace(str[i], char.ToLower(str[i]));
                 }
                 return str;
             }
               
             public static string AddToString(string str)
             {   
                 return str += "!";
             }
                
             public static string RemoveSpace(string str)
             {
                  return str.Replace(" ", string.Empty);
             }
    }
    
}
