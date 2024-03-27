using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////
            /// interface in c#
            /// 

            Rabbit rabbit = new Rabbit();
            Hawk hawk = new Hawk();
            Fish fish = new Fish();

            rabbit.Flee();
            hawk.hunt();
            fish.Flee();
            fish.hunt();
            Console.ReadKey();
        }
       
    }
    interface Iprey
    {
        void Flee();
    }
    interface IPridator
    {
        void hunt();
    }
    class Rabbit : Iprey
    {
        public void Flee()
        {
            Console.WriteLine("The rabbit Swim away!");
        }
    }
    class Hawk : IPridator
    {
        public void hunt()
        {
            Console.WriteLine("hawk hunted .......!");
        }
    }
    class Fish : IPridator, Iprey
    {
        public void Flee()
        {
            Console.WriteLine("The Fish runs away!");
        }
        public void hunt()
        {
            Console.WriteLine("fish hunted .......!");
        }
    }
}
 
