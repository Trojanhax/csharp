using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////
            /// object as arguments in c#
            /// 

            Car car1 = new Car("mustang", "red");
            Car car2 = Copy(car1);
            ChangeColor(car1, "gray");

            Console.WriteLine(car1.color + " " + car1.model);
            Console.WriteLine(car2.color + " " + car2.model);




            Console.ReadKey();
        }
        public static void ChangeColor(Car car, String color)
        {
            car.color = color;

        }

        public static Car Copy(Car car)
        {
            return new Car(car.model, car.color);
        }
    }
    class Car
    {
        public string model;
        public string color;
        public Car(string model, string color)
        {
            this.model = model;
            this.color = color;
        }
    }

   
}
