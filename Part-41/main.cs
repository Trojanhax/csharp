using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////
            /// method overriding in c#
            /// 

            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.Speak();
            cat.Speak();



            Console.ReadKey();
        }
       
    }
    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine(" the animal goes *brrr* ");
        }
    }
    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine(" the dog goes *woof* ");
        }
    }
    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine(" the cat goes *meow* ");
        }
    }

   
}
 
