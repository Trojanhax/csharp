using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////
            /// conditional operator in c#
            /// 

            double temp = 3;
            string mag;

            if (temp >= 16)
            {
                mag = " worm";
                Console.WriteLine(mag);
            }
            else 
            {
                mag = " cold";
                Console.WriteLine(mag);
            }
            

            mag = (temp >= 15) ? " worm" : " cold";
            Console.WriteLine(mag);
            Console.ReadKey();
        }

        
      


    }
}
