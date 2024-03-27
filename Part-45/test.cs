using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////
            /// list in c#
            /// 

            string[] food = new string[3];

            food[0] = "pizza";
            food[1] = "burger";
            food[2] = "pips";
            foreach (string item in food)
            {
                Console.WriteLine(item);
            }
          
            Console.ReadKey();
        }
       
    }
    
}
 
