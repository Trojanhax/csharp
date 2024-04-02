using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////
            /// thread in c#
            ///

            Thread mainthread = Thread.CurrentThread;
            mainthread.Name = " main thread";
            Console.WriteLine(mainthread.Name);

            Countdown();
            Countup();

            Console.ReadKey();
        }

        public static void Countdown()
        {
            for( int i = 100; i >= 0; i--)
            {
                Console.WriteLine($"Timer #1 : {i} seconds . ");
                Thread.Sleep(3000);
            }
            Console.WriteLine("timer is complete ");
        }

        public static void Countup()
        {
            for (int i = 0; i >= 110; i++)
            {
                Console.WriteLine($"Timer #2 : {i} seconds . ");
                Thread.Sleep(3000);
            }
            Console.WriteLine("timer is complete ");
        }

    }

}
