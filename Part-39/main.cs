using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////
            /// anomoyous object in c#
            /// 

            Car[] garage = { new Car("mustang"), new Car("corvett"), new Car("lambo") };


            foreach (Car car in garage)
            {
                Console.WriteLine(car.model);
            }

            Console.ReadKey();
        }
    }
    class Car
    {
        public string model;
        public Car(string model)
        {
            this.model = model;
        }
    }

   
}
