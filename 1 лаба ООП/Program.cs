using System;
using System.Text;
using System.Linq;
namespace _1_лаба_ООП
{
    class Program
    {
        static void Main(string[] args)
        {
            ////1.1
            //bool zz1 = true;
            //byte zz2 = 242;
            //sbyte zz3 = 62;
            //char l1 = 'a';
            //decimal d2 = 42;
            //double dd2 = 1.7;
            //float df1 = 30.6f;
            //int il2 = 4;
            //uint ui2 = 323;
            //long ul2 = 0xFF;
            //ulong ll3 = 0b101;
            //string ss3 = "1lab";
            //object b = 3.14;
            //Console.WriteLine(zz1);
            //Console.WriteLine(zz2);
            //Console.WriteLine(zz3);
            //Console.WriteLine(l1);
            //Console.WriteLine(d2);
            //Console.WriteLine(dd2);
            //Console.WriteLine(df1);
            //Console.WriteLine(il2);
            //Console.WriteLine(ui2);
            //Console.WriteLine(ul2);
            //Console.WriteLine(ll3);
            //Console.WriteLine(ss3);
            //Console.WriteLine(b);
            ////1.2
            //int num = 2147483647;
            //long bigNum = num;
            //float num1 = 5.4f;
            //double bigNum1 = num1;
            //byte a = 4;
            //ushort b11 = a;
            //sbyte a1 = 4;
            //short b1 = a1;
            //sbyte a11 = -4;
            //short b12 = a11;

            //int a2 = 4;
            //byte c2 = (byte)a2;
            //double a12 = 4.0;
            //decimal b21 = (decimal)a12;
            //int x = 50;
            //byte y = (byte)x;
            //uint x2 = 32323232;
            //ulong y2 = x2;
            //char z4 = '3';
            //int z3 = (int)z4;
            ////1.3
            //int zk2 = 123;
            //object obj1 = zk2;
            //int zk1 = (int)obj1;
            ////1.4
            //var name = "Kruglik Alexei";
            //var age = 18;
            //var isProgrammer = true;
            //Type nameType = name.GetType();
            //Type ageType = age.GetType();
            //Type isProgrammerType = isProgrammer.GetType();
            //Console.WriteLine("Тип name: {0} Тип age {1} Тип isProgrammer {2}", nameType, ageType, isProgrammerType);
            ////1.5
            //int? zf1 = 9;
            //Console.WriteLine(zf1.Value);
            //Console.WriteLine(zf1.HasValue);
            //double? ff1 = null;
            //if (ff1.HasValue)
            //    Console.WriteLine(ff1.Value);
            //else
            //    Console.WriteLine("ff1 is equal to null");
            ////1.6
            //var dj1 = 5;
            //dj1 = 55;
            //т.к тип dj1 - int;

            ////2.1
            //string str1 = "Hello";
            //string str2 = "hello";
            //Console.WriteLine("== :" + (str1 == str2));
            ////2.2
            //string app1 = "hello";
            //string app2 = "world";
            //string app3 = "Nax";
            //string ap = String.Concat(app1, app2, "!!!");
            //string ap1 = String.Concat(ap, app3);
            //Console.Write(ap);
            //Console.WriteLine(ap1);
            //string ap2 = String.Copy(app2);
            //Console.WriteLine(ap2);

            //string apsun = ap.Substring(2, 3);
            //Console.WriteLine(apsun);

            //string text = "И поэтому все так произошло";
            //string[] words = text.Split(new char[] { ' ' });
            //foreach (string s in words)
            //{
            //    Console.WriteLine(s);
            //}

            //string text1 = "Nice git";
            //string text2 = "bad";
            //text1 = text1.Insert(5, text2);
            //Console.WriteLine(text1);

            //string log = "Хороший день";
            //int ind = log.Length - 4;
            //log = log.Remove(ind);
            //Console.WriteLine(log);

            //long number = +375297680991;
            //Console.WriteLine($"{number:+### ## #######}");
            ////2.3
            //string s1 = "";
            //string s2 = null;
            //string s3 = "     ";
            //Console.WriteLine(String.IsNullOrEmpty(s1));
            //Console.WriteLine(String.IsNullOrEmpty(s2));
            //Console.WriteLine(String.IsNullOrWhiteSpace(s3));
            ////2.4
            //StringBuilder sb = new StringBuilder("Привет мир");
            //sb.Remove(7, 3);
            //sb.Append("!");
            //sb.Insert(7, "компьютер");
            //Console.WriteLine(sb);
            ////3.1
            //int[,] array = new int[3, 3];
            //Random rnd = new Random();
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(0); j++)
            //    {
            //        array[i, j] = rnd.Next(0, 10);
            //        Console.Write("{0} ", array[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            //int[] MyArray = { 4, 4, 23, 235, 12315, 123125 };
            //Console.WriteLine("Длина массива" + "\n" + MyArray.Length);
            //MyArray[2] = 355;
            //Console.WriteLine(MyArray[2]);
            //double[][] myArr = new double[3][];
            //myArr[0] = new double[2];
            //myArr[1] = new double[3];
            //myArr[2] = new double[4];
            //for (int i = 0; i < myArr.Length; i++)
            //{
            //    for (int j = 0; j < myArr[i].GetLength(0); j++)
            //    {
            //        Console.Write($"Введите значение элемента {i} {j}: ");
            //        myArr[i][j] = Convert.ToDouble(Console.ReadLine());
            //    }
            //    Console.WriteLine("");
            //}
            //for (int i = 0; i < myArr.Length; i++)
            //{
            //    for (int j = 0; j < myArr[i].GetLength(0); j++)
            //    {
            //        Console.Write($"{myArr[i][j]} ");
            //    }
            //    Console.WriteLine("");
            //}
            //var array22 = new object[0];
            //var str31 = "";

            //4.1
            //(int, string, char, string, ulong) xx = (5, "tom", 'q', "besedkin", 12345);
            //Console.WriteLine(xx);
            //Console.WriteLine(xx.Item1);
            //Console.WriteLine(xx.Item3);
            //Console.WriteLine(xx.Item5);

            //(int aaa, string bbb, char ccc, string ddd, ulong eee) = xx;

            //int qe = xx.Item1;

            //(int aaaa, _, char cccc, string dddd, ulong eeee) = xx;

            //5.1
            //int[] ik = { 1, 23, 13, 123, 1234 };
            //string mic = "Alexei";


            //(int, int, int, char) Func(int[] ik, string mic)
            //{
            //    (int, int, int, char) qw;
            //    qw.Item1 = ik.Max();
            //    qw.Item2 = ik.Min();
            //    qw.Item3 = ik.Sum();
            //    qw.Item4 = mic.First();

            //    return qw;
            //}
            //(int, int, int, char) qw = Func(ik, mic);
            //Console.WriteLine(qw);
            //6.1
            //int zzz = 20;
            //int Func1()
            //{
            //    int m = int.MaxValue;
            //    checked
            //    {
            //        m = m + zzz;
            //        Console.WriteLine(m);
            //    }
            //    return m;
            //}
            //int Func2()
            //{
            //    int m = int.MaxValue;
            //    unchecked
            //    {
            //        m = m + zzz;
            //        Console.WriteLine(m);
            //    }
            //    return m;
            //}
            //Console.WriteLine(Func2());
            //Console.WriteLine(Func1());





        }
    }
    

}



