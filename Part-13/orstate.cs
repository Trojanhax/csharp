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
            // logical Operators in c#

            Console.WriteLine("what is tempersture outside ?");
            double temp = Convert.ToDouble( Console.ReadLine());


            if ( temp >= 10 && temp <= 26)
            {
                Console.WriteLine(" It's worm outside");
            }
            else if(temp <= 50 || temp >= 50)
            {
                Console.WriteLine("do not go outside");
            }
            else
            {
                Console.WriteLine(" Not good");
            }


            
            Console.ReadKey();
            


        }
    }
}
  
