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

            //
            // if else and else if 
            //

            Console.WriteLine("Enter your age :  ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("you are now sign up !");

            }
            else
            {
                Console.WriteLine("you must be 18 to sign up");
            }


            Console.ReadKey();
            


        }
    }
}
  
