using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////
            /// constructor in c#
            /// 


            Human human1 = new Human("gray", 78);
            Human human2 = new Human("white" , 89);

            
            human1.Eat();
            human1.Sleep();

            human2.Eat();
            human2.Sleep();


            Console.ReadKey();
        }
    }
    class Human
    {
        public string name;
        public int age;

        public Human(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

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
