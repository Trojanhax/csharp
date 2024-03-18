using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////
            /// params keyword in c#

            double total = ChackOut(3,4,6,5);

            Console.WriteLine(total);


            Console.ReadKey();
        }

        static double ChackOut(params double[] prices )
        {
            double total = 0;
            foreach( double price in prices)
            {
                total += price;
            }
            return total;
        }
      


    }
}
