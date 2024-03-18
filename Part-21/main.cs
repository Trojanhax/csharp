using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////
            /// foreach loop in c#

            string[] car = { "BMW", "Mustang", "corvette" };

            foreach (string cars in car)
            {
                Console.WriteLine(cars);
            }


            Console.ReadKey();
        }
    }
}
