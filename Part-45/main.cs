using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////
            /// list in c#
            /// 
            List<string> food = new List<string>();

            food.Add("pizza");
            food.Add("botka");
            food.Add("burger");
            food.Add("hotdog");
            food.Add("soda");
            food.Add("water");
            foreach (string item in food)
            {
                Console.WriteLine(item);
            }
          
            Console.ReadKey();
        }
       
    }
    
}
 
