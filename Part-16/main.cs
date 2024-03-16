using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // nested loop in C#

            Console.Write("How many rows?");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("How many columns?");
            int columns = Convert.ToInt32(Console.ReadLine());

            Console.Write("Which symbol to print?");
            string symbol = Console.ReadLine();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(symbol); // Use Write instead of WriteLine to keep symbols on the same line
                }
                Console.WriteLine(); // Move this outside of the inner loop to create new lines for each row
            }

            Console.ReadKey();



        }
    }
}
  
