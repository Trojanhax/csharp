using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////
            /// string inetpolation in c#
            /// 

            string fname = "gray";
            string lname = "gray";
            int age = 21;

            Console.WriteLine("hello " + fname + " " + lname + ".");
            Console.WriteLine("you are " + age + "years old .");
            /// best way to
            Console.WriteLine($" hello {fname} {lname} .");
            Console.WriteLine($"you are {age, 10} years old .");
            Console.WriteLine($"you are {age, -10} years old .");


            Console.ReadKey();
        }

        
      


    }
}
