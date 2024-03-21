using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////
            /// inhertance in c#
            /// 
            Car car = new Car();
            bicycle bicycle1 = new bicycle();
            boat boat1 = new boat();
            Console.WriteLine("speed: " + car.speed);
            Console.WriteLine("speed: " + bicycle1.speed);
            Console.WriteLine("speed: " + boat1.speed);
            Console.WriteLine("wheels: " + car.wheel);
            Console.WriteLine("wheels: " + bicycle1.wheel);
            Console.WriteLine("wheels: " + boat1.wheel);
            car.go();
            boat1.go();
            car.go();


            Console.ReadKey();
        }
    }

    class Vehicle
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
    }

    class bicycle : Vehicle
    {
        public int wheel = 2;
    }

    class boat : Vehicle
    {
        public int wheel = 0;
    }

}
