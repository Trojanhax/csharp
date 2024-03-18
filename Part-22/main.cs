using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////
            /// method in c#
            string name = "gray";
            int are = 66;

            singbithday(name ,are);
            
            Console.ReadKey();
        }

        static void singbithday(string name,int are)
        {
            Console.WriteLine("Happy Birthday. ..");
            Console.WriteLine("Happy Birthday. ..");
            Console.WriteLine("Happy Birthday. .. " + name);
            Console.WriteLine($" now you are {are} year old ");
            Console.WriteLine("Happy Birthday. ..");
        }
    }
}
