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

        static double ChackOut(double a, double b)
        {
            double z = a * b;
            return z;
        }
        static double ChackOut(double a, double b , double c)
        {
            double z = a * b * c;
            return z;
        }
        static double ChackOut(double a, double b, double c, double d)
        {
            double z = a * b * c * d;
            return z;
        }
        static double ChackOut(double a, double b, double c, double d, double e)
        {
            double z = a * b * c * d *e;
            return z;
        }


    }
}
