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

            // gen Random num in c#
            Random random = new Random();

            int a = random.Next(1, 100);

            int num1 = random.Next(1, 7);
            int num2 = random.Next(1, 7);
            int num3 = random.Next(1, 7);

            double b = random.Next(1, 100);

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.ReadKey();



        }
    }
}
