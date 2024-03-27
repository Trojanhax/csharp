# Method Overriding in C#

In C#, method overriding allows a subclass to provide a specific implementation for a method that is already defined in its superclass. This enables polymorphism, where objects of the subclass can be treated as objects of the superclass. Here's how you can work with method overriding in C#:

## Example:

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        //////////////////////
        /// Method Overriding in C#
        /// 

        // Create instances of Dog and Cat
        Dog dog = new Dog();
        Cat cat = new Cat();

        // Call the Speak method on Dog and Cat objects
        dog.Speak(); // Output: "The dog goes *woof*"
        cat.Speak(); // Output: "The cat goes *meow*"

        Console.ReadKey();
    }
}

class Animal
{
    // Define a virtual method Speak in the base class
    public virtual void Speak()
    {
        Console.WriteLine("The animal goes *brrr*");
    }
}

class Dog : Animal
{
    // Override the Speak method in the derived class
    public override void Speak()
    {
        Console.WriteLine("The dog goes *woof*");
    }
}

class Cat : Animal
{
    // Override the Speak method in the derived class
    public override void Speak()
    {
        Console.WriteLine("The cat goes *meow*");
    }
}
