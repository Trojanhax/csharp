using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////
            /// Auto-Implemented properties in c#
            /// 

            Car car = new Car("honda");


            Console.WriteLine(car.Model);

            
            Console.ReadKey();
        }
       
    } 
    class Car
    {
        public string Model
        {
            get;
            set;
        }
      
        public Car(string model)
        {
            this.Model = model;
        }
    }
}
 
