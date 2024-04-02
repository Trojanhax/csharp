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

            Console.ReadKey();
        }
      
    }

}
