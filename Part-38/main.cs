using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////
            /// array of objects in c#
            /// 

            Car[] garage = new Car[3];

            Car car1 = new Car("mustang");
            Car car2 = new Car("corvett");
            Car car3 = new Car("lambo");

            garage[0] = car1;
            garage[1] = car2;
            garage[2] = car3;

            Console.WriteLine(garage[0].model);
            Console.WriteLine(garage[1].model);
            Console.WriteLine(garage[2].model);

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
