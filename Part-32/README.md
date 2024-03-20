# Objects in C#

In C#, objects are instances of classes that encapsulate data (attributes) and behavior (methods). They allow you to model real-world entities and interact with them in your program.

## Example:

```csharp
using System;

// Define a class named Human
class Human
{
    // Declare attributes (fields) of the class
    public string name;
    public int age;

    // Define methods within the class
    public void Eat()
    {
        Console.WriteLine($"{name} is eating.");
    }

    public void Sleep()
    {
        Console.WriteLine($"{name} is sleeping.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        //////////////////////
        /// Object in C#
        /// 

        // Create instances (objects) of the Human class
        Human human1 = new Human();
        Human human2 = new Human();

        // Set attributes and call methods on the first object
        human1.name = "Gray";
        human1.age = 78;
        human1.Eat();
        human1.Sleep();

        // Set attributes and call methods on the second object
        human2.name = "White";
        human2.age = 48;
        human2.Eat();
        human2.Sleep();

        Console.ReadKey();
    }
}
