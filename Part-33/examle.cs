using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////
            /// constructor in c#
            /// 
            Car cat1 = new Car( "ford", "mustang", 2222, "red");


            cat1.Drive();
            Console.ReadKey();
        }
    }
    class Car
    {
        string make;
        string model;
        int year;
        string color;

        public Car(string make, string model, int year, string color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }

        public void Drive()
        {
            Console.WriteLine($"you are the {make} {model}");
        }
    }


}
