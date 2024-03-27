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

            //food.Remove("water");

            //food.Insert(0, "sushi");

            //Console.WriteLine(food.Count);


            //Console.WriteLine(food.IndexOf("pizza"));

            //food.Add("water");
            //Console.WriteLine(food.LastIndexOf("water"));

            //Console.WriteLine(food.Contains("water"));

            // food.Sort();

            //food.Reverse();

            //food.Clear();

            string[] foodarray = food.ToArray();

            //foreach (string item in food)
            foreach (string item in foodarray)
            {
                Console.WriteLine(item);
            }
          
            Console.ReadKey();
        }
       
    }
    
}
 
