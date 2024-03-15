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

            // math class in c#

            double a = 3;
            double b = 4;

            double z = Math.Pow(b, 3);
            double y = Math.Pow(a, 3);

            double c = Math.Sqrt(a);
            double d = Math.Sqrt(b);

            double e = Math.Abs(a);
            double f = Math.Abs(b);

            double g = 3.14;
            double h = Math.Round(g);

            double i = Math.Ceiling(g);

            double j = Math.Floor(g);

            double k = Math.Max(a , b);
            double n = Math.Min(a , b);

            Console.WriteLine(z);
            Console.WriteLine(y);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(h);
            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(k);
            Console.WriteLine(n);


            Console.ReadKey();



        }
    }
}
