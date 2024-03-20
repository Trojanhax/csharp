using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////
            /// object in c#
            /// 


            Human human1 = new Human();
            Human human2 = new Human();

            human1.name = "gray";
            human1.age = 78;
            human1.Eat();
            human1.Sleep();

            human2.name = "white";
            human2.age = 48;
            human2.Eat();
            human2.Sleep();


            Console.ReadKey();
        }
    }
    class Human
    {
        public string name;
        public int age;

        public void Eat()
        {
            Console.WriteLine($" {name} is eating .");
        }

        public void Sleep()
        {
            Console.WriteLine($" {name} is sleeping");
        }
    }


}
