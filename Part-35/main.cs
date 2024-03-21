using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////
            /// Static modifier in c#
            /// 
            Car cat1 = new Car( "ford", "mustang", 2222, "red");
            Car cat2 = new Car( "ford", "mustang", 2222, "red");
            Car cat3 = new Car( "ford", "mustang", 2222, "red");

            Console.WriteLine(Car.numofcar);
            //Console.WriteLine(cat2.numofcar);


            cat1.Drive();
            cat2.Drive();
            cat3.Drive();
            Console.ReadKey();
        }
    }
    class Car
    {
        string make;
        string model;
        int year;
        string color;
        public static int numofcar;

        public Car(string make, string model, int year, string color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
            numofcar++;
        }

        public void Drive()
        {
            Console.WriteLine($"you are the {make} {model}");
            Console.WriteLine($"more info {year} {color}");
        }
    }


}
