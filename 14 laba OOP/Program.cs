using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading;
namespace _14_laba_OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("########################################## 1 задание ###################################################################");
            First();
            Console.WriteLine("########################################## 2 задание ###################################################################");
            Second();
            Console.WriteLine("########################################## 3 задание ###################################################################");
            Third();
            Console.WriteLine("########################################## 4 задание ###################################################################");
            Fourth();

        }
        

        public static void First()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            var allprocess = Process.GetProcesses();
            foreach (Process process in allprocess)
            {
                // выводим id и имя процесса
                Console.WriteLine($"ID: {process.Id}  Name: {process.ProcessName}  MachineName: {process.MachineName} ");
                Process proc = Process.GetProcessesByName("devenv")[0];
                ProcessThreadCollection processThreads = proc.Threads;

                foreach (ProcessThread thread in processThreads)
                {
                    Console.WriteLine($"ThreadId: {thread.Id}  StartTime: {thread.StartTime}");
                }
            }
        }
        public static void Second()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            AppDomain domain = AppDomain.CurrentDomain;
            Console.WriteLine($"Name: {domain.FriendlyName}");
            Console.WriteLine($"Base Directory: {domain.BaseDirectory}");
            Console.WriteLine();

            Assembly[] assemblies = domain.GetAssemblies();
            foreach (Assembly asm in assemblies)
            {
                Console.WriteLine(asm.GetName().Name);
            }

            
        }
        public static void Third()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            var first = new Thread(ShowSimpleNumbers);
            first.Start();
            first.Name = "Simplenumbers";
            first.Join();
            Console.WriteLine();

        }
        public static void ShowInfo(object thread)
        {
            var z = thread as Thread;
            Console.WriteLine($"Name: {z.Name}");
            Console.WriteLine($"ID: {z.ManagedThreadId}");
            Console.WriteLine($"Priority: {z.Priority}");
            Console.WriteLine($"Status: {z.ThreadState}");
        }
        public static void ShowSimpleNumbers()
        {
            var first = new Thread(ShowInfo);
            first.Start(Thread.CurrentThread);
            first.Join();

            Console.WriteLine("sssss");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var Simple = true;
                for (int j = 2; j  <= i / 2; j ++)
                {
                    if (i % j == 0)
                    {
                        Simple = false;
                        break;

                    }
                    if (Simple)
                    {
                        Console.WriteLine($"{i}");
                        Thread.Sleep(100);
                    }
                }
            }
        }

        public static void Fourth()
        {
            // создаем новый поток
            var first = new Thread(OddNumbers) {Priority = ThreadPriority.Highest };  
            var two = new Thread(EvenNumbers);
           
            first.Start();
            two.Start();
            FirstlyEvenSecondlyOdd();
            ShowOneByOne();
            
        }
        private static void ShowOneByOne()
        {
            var mutex = new Mutex();
            var even = new Thread(ShowEvenNumbers);
            var odd = new Thread(ShowOddNumbers);
            odd.Start();
            even.Start();
            even.Join();
            odd.Join();

            void ShowEvenNumbers()
            {
                for (var i = 0; i < 15; i++)
                {
                    mutex.WaitOne();
                    Console.ForegroundColor = ConsoleColor.Gray;
                    if (i % 2 == 0)
                        Console.Write(i + " ");
                    mutex.ReleaseMutex();
                }
            }

            void ShowOddNumbers()
            {
                for (var i = 0; i < 10; i++)
                {
                    mutex.WaitOne();
                    Thread.Sleep(200);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    if (i % 2 != 0)
                        Console.Write(i + " ");
                    mutex.ReleaseMutex();
                }
            }
        }
        private static void FirstlyEvenSecondlyOdd()
        {
            var objectToLock = new object();
            var even = new Thread(ShowEvenNumbers);
            var odd = new Thread(ShowOddNumbers);
            even.Start();
            odd.Start();
            even.Join();
            odd.Join();

            void ShowEvenNumbers()
            {
                lock (objectToLock)
                {
                    for (var i = 0; i < 15; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        if (i % 2 == 0)
                            Console.Write(i + " ");
                    }
                }
            }

            void ShowOddNumbers()
            {
                for (var i = 0; i < 10; i++)
                {
                    Thread.Sleep(200);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    if (i % 2 != 0)
                        Console.Write(i + " ");
                }
            }
        }
        public static void OddNumbers()
        {
           
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(200);
                Console.ForegroundColor = ConsoleColor.White;
                    if (i % 2 != 0)
                    {      

                         Console.WriteLine(i + " ");
                    }
                
            }
        }
        public static void EvenNumbers()
        {
            
            for (int i = 0; i < 15; i++)
            {
                Thread.Sleep(300);
                Console.ForegroundColor = ConsoleColor.Yellow;
                if (i % 2 == 0)
                {

                    Console.WriteLine(i + " ");
                }
               
            }
            
        }
    }
}
