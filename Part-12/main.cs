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
            // switch statement in c#

            Console.WriteLine("what is today? ");
            string day = Console.ReadLine();

            switch (day)
            {
                case "Monday":
                    Console.WriteLine("Monday");
                    break;

                case "Tuesday":
                    Console.WriteLine("Tusday");
                    break;

                case "Wednesday":
                    Console.WriteLine("Wednesday");
                    break;

                case "Thursday":
                    Console.WriteLine("Thursday");
                    break;

                case "Friday":
                    Console.WriteLine("Friday");
                    break;

                case "Saturday":
                    Console.WriteLine("Saturday");
                    break;

                case "Sunday":
                    Console.WriteLine("Sunday");
                    break;

                default:
                    Console.WriteLine(day + " is not a day name");
                    break;
            }


            
            Console.ReadKey();
            


        }
    }
}
  
