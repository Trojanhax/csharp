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
            // Arithmetic Operators in C#
            int fr = 5;
            // fr = fr + 3;
            // fr += 3; 
            fr++;

            int fr1 = 5;
            // fr1 = fr - 3;
            // fr1 -= 3; 
            fr1--;

            int a = 10;
            int b = 4;

            int z = a + b; 
            int x = a - b; 
            int y = a * b; 
            int w = a / b; 
            int u = a % b; 
            int v = a + b;

            Console.WriteLine(fr);
            Console.WriteLine(fr1);
            Console.WriteLine(z);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(w);
            Console.WriteLine(u);
            Console.WriteLine(v);

            Console.ReadKey();



        }
    }
}
