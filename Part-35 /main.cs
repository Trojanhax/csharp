using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////
            /// overloaded constructors in c#
            /// 
            pizza pizza1 = new pizza("stuffed crust", "red soc", "mozzarella", "pepperoni");


        
            Console.ReadKey();
        }
    }
    class pizza
    {
        string bread;
        string saoce;
        string cheese;
        string topping;


        public pizza(string bread)
        {
            this.bread = bread;
           
        }

        public pizza(string bread, string saoce)
        {
            this.bread = bread;
            this.saoce = saoce;
            
        }

        public pizza(string bread, string saoce, string cheese)
        {
            this.bread = bread;
            this.saoce = saoce;
            this.cheese = cheese;
            
        }

        public pizza(string bread, string saoce ,string cheese, string topping)
        {
            this.bread = bread;
            this.saoce = saoce;
            this.cheese = cheese;
            this.topping = topping;
        }
    }
    

}
