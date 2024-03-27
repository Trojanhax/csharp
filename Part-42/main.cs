using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////
            /// tostring() to an object in c#
            /// 
            Car car = new Car("chery","corvette",2024, "blue");


            Console.WriteLine(car);


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
        public override string ToString()
        {
            string message = $"this is a {make} {model} {year} {color}";
            return message;
        }
    }
  

   
}
 
