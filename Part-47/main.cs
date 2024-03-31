using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////
            /// GETTERS and SETTERS in c#
            ///  properties 
            ///  get accessor
            ///  set accessor
            ///  value keyword

            Car car = new Car(90);

            car.Speed = 1010101;
            Console.WriteLine(car.Speed);




            
            Console.ReadKey();
        }
       
    } 
    class Car
    {
        private int speed;
        public Car(int speed)
        {
            Speed = speed;
        }
        public int Speed
        {
            get 
            {
                return speed; 
            } // read
            set
            {
                if (value > 500)
                {
                    speed = 500;
                }
                speed = value;
            }
        }
    }
}
 
