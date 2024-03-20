using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////
            /// multidimensional array in c#
            /// 

            string[] ford = { "Mustang", "F-150", "Explorer" };
            string[] chevy = { "corvette", "camaro", "silverado" };


            string[,] parkingLot = {
                { "Mustang", "F-150", "Explorer" },
                { "corvette", "camaro", "silverado" }
            };

            parkingLot[0, 1] = "Fusion";
            parkingLot[1, 0] = "Tacoma";

            // Accessing elements using nested loops
            for (int i = 0; i < parkingLot.GetLength(0); i++)
            {
                for (int j = 0; j < parkingLot.GetLength(1); j++)
                {
                    Console.WriteLine($"Parking space [{i}, {j}]: {parkingLot[i, j]}");
                }
            }

            /*
            foreach (string car in parkinglot)
            {
                Console.WriteLine(car);
            }
            */

            Console.ReadKey();
        }
    }
}
