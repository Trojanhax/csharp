using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////
            /// return keyword in c#
            double x;
            double y;
            double result;

            Console.WriteLine(" Enter number 1 : ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Enter number 2 : ");
            y = Convert.ToDouble(Console.ReadLine());

            result = multiply(x, y);
            Console.WriteLine("your answer is....");
            Console.WriteLine(result);


            Console.ReadKey();
        }

        static double multiply(double x, double y)
        {
            double z = x * y;
            return z;
        }

        
    }
}
