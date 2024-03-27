# Polymorphism in C#

In object-oriented programming, polymorphism allows objects of different classes to be treated as instances of a common superclass, enabling flexibility and extensibility in code design. In C#, polymorphism is achieved through method overriding and inheritance. Here's how you can work with polymorphism in C#:

## Example:

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        //////////////////////
        /// Polymorphism in C#
        /// 

        // Create instances of Car, Boat, and Bicycle
        Car car = new Car();
        Boat boat = new Boat();
        Bicycle bicycle = new Bicycle();

        // Create an array of vehicles and store instances of Car, Boat, and Bicycle
        vehicles[] vehicles = { car, boat, bicycle };

        // Iterate through the vehicles array and call the Go method on each object
        foreach (vehicles vehicle in vehicles)
        {
            vehicle.Go();
        }

        Console.ReadKey();
    }
}

// Base class vehicles with a virtual Go method
class vehicles
{
    public virtual void Go()
    {
        Console.WriteLine("Speed up");
    }
}

// Derived class Car with an overridden Go method
class Car : vehicles
{
    public override void Go()
    {
        Console.WriteLine("Speed up car");
    }
}

// Derived class Boat with an overridden Go method
class Boat : vehicles
{
    public override void Go()
    {
        Console.WriteLine("Speed up boat");
    }
}

// Derived class Bicycle with an overridden Go method
class Bicycle : vehicles
{
    public override void Go()
    {
        Console.WriteLine("Speed up bicycle");
    }
}
