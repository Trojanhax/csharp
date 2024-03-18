using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////
            /// array in c#
            string[] car = new string[4];
            //string[] car = { "BMW" , "Mustang", "corvette"};

            // upadate array

            car[0] = "Tesla";
            car[1] = "Tesla";
            car[2] = "Tesla";

            for (int i = 0; i < car.Length; i++)
            {
                Console.WriteLine(car[i]);

            }

            // Console.WriteLine(car);
            Console.WriteLine(car[0]);
            Console.WriteLine(car[1]);
            Console.WriteLine(car[2]);



            Console.ReadKey();
        }
    }
}
