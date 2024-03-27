using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////
            /// polymorphism in c#
            /// 
            Car car = new Car();
            Boat boat = new Boat();
            Bicycle bicycle = new Bicycle();

            vehicles[] vehicles = { car, bicycle, boat };

            foreach(vehicles vehicles1 in vehicles)
            {
                vehicles1.Go();
            }
            


            Console.ReadKey();
        }
       
    }
    class vehicles
    {
        public virtual void Go()
        {
            Console.WriteLine("speedup ");
        }
    }
    class Car : vehicles
    {
        public override void Go()
        {
            Console.WriteLine("speedup car");
        }
    }
    class Boat : vehicles
    {
        public override void Go()
        {
            Console.WriteLine("speedup baot");
        }
    }
    class Bicycle : vehicles
    {
        public override void Go()
        {
            Console.WriteLine("speedup bicycle");
        }
    }



}
 
