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

            // Type casting in c#

            // double to integer
            double a = 3.13;
            int b = Convert.ToInt32(a);


            //  integer to double c

            int c = 45;
            double d = c;

            // integer to string

            int e = 344434;
            string f = Convert.ToString(c);


            // string to char

            string g = "$";
            char h = Convert.ToChar(g);

            // string to boolean
            string i = "true";
            bool j = Convert.ToBoolean(i);






            Console.WriteLine(a.GetType()); 
            Console.WriteLine(a);
            Console.WriteLine(b.GetType());
            Console.WriteLine(b);
            Console.WriteLine(c.GetType());           
            Console.WriteLine(c);
            Console.WriteLine(d.GetType());
            Console.WriteLine(d);
            Console.WriteLine(e.GetType());            
            Console.WriteLine(e);
            Console.WriteLine(f.GetType());
            Console.WriteLine(f);
            Console.WriteLine(g.GetType());
            Console.WriteLine(g);
            Console.WriteLine(h.GetType());
            Console.WriteLine(h);
            Console.WriteLine(i.GetType());
            Console.WriteLine(i);
            Console.WriteLine(j.GetType());
            Console.WriteLine(j);

            Console.ReadKey();



        }
    }
}
