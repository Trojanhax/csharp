using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////
            /// Thread in C#
            ///

            Thread mainThread1 = new Thread(() => CountUp("Timer #1"));
            Thread mainThread2 = new Thread(() => CountDown("Timer #2"));
            mainThread1.Start();
            mainThread2.Start();

            Console.ReadKey();
        }

        public static void CountDown(string name)
        {
            for (int i = 100; i >= 0; i--)
            {
                Console.WriteLine($"{name}: {i} seconds.");
                Thread.Sleep(1000);
            }
            Console.WriteLine($"{name} is complete.");
        }

        public static void CountUp(string name)
        {
            for (int i = 0; i <= 110; i++)
            {
                Console.WriteLine($"{name}: {i} seconds.");
                Thread.Sleep(1500);
                if (i == 110)
                {
                    Console.WriteLine($"{name} is complete.");
                    break;
                }
            }
        }
    }
}
