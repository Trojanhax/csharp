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

            Console.WriteLine("Enter your Name :  ");
            string name = Console.ReadLine();


            if (name == "")
            {
                Console.WriteLine("you did not enter your name:");
            }
            else
            {
                Console.WriteLine("hello " + name);
            }
            

            
            Console.ReadKey();
            


        }
    }
}
  
