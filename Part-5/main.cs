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
            // input in c#


            Console.WriteLine("what is yout name ? \n ");
            string name = Console.ReadLine();

            Console.WriteLine("what is yout age ? \n ");
            int age = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("hello "+ name);
            Console.WriteLine("your age " + age);

            Console.ReadKey();



        }
    }
}
