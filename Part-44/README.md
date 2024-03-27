# Interfaces in C#

In C#, an interface defines a contract that classes can implement, specifying a set of methods or properties that the implementing classes must provide. Interfaces enable polymorphism and code reusability by allowing objects of different classes to be treated uniformly through a common interface. Here's how you can work with interfaces in C#:

## Example:

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        //////////////////////
        /// Interfaces in C#
        /// 

        // Create instances of Rabbit, Hawk, and Fish
        Rabbit rabbit = new Rabbit();
        Hawk hawk = new Hawk();
        Fish fish = new Fish();

        // Call the Flee method on Rabbit and Fish objects
        rabbit.Flee(); // Output: "The rabbit swims away!"
        fish.Flee();   // Output: "The fish runs away!"

        // Call the hunt method on Hawk and Fish objects
        hawk.Hunt();   // Output: "Hawk hunted!"
        fish.Hunt();   // Output: "Fish hunted!"

        Console.ReadKey();
    }
}

// Define the IPrey interface with a Flee method
interface IPrey
{
    void Flee();
}

// Define the IPredator interface with a Hunt method
interface IPredator
{
    void Hunt();
}

// Implement the IPrey interface in the Rabbit class
class Rabbit : IPrey
{
    public void Flee()
    {
        Console.WriteLine("The rabbit swims away!");
    }
}

// Implement the IPredator interface in the Hawk class
class Hawk : IPredator
{
    public void Hunt()
    {
        Console.WriteLine("Hawk hunted!");
    }
}

// Implement both IPrey and IPredator interfaces in the Fish class
class Fish : IPrey, IPredator
{
    public void Flee()
    {
        Console.WriteLine("The fish runs away!");
    }

    public void Hunt()
    {
        Console.WriteLine("Fish hunted!");
    }
}
