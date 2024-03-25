using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////
            /// abstract classes modifier in c#
            /// 
            Car car = new Car();
            bicycle bicycle = new bicycle();
            boat boat = new boat();
            // Vehicle vehicle = new Vehicle();
         


            Console.ReadKey();
        }
    }

    abstract class Vehicle
    {
        public int speed = 0;


        public void go()
        {
            Console.WriteLine("This vehicle is moving");
        }
    }

    class Car : Vehicle
    {
        public int wheel = 4;
        int maxspeed = 500;
    }

    class bicycle : Vehicle
    {
        public int wheel = 2;
        int maxspeed = 50;
    }

    class boat : Vehicle
    {
        public int wheel = 0;
        int maxspeed = 100;
    }

}
