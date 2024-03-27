# Overriding ToString() Method in C#

In C#, the `ToString` method is inherited from the `Object` class and is used to return a string that represents the current object. By overriding the `ToString` method in your classes, you can provide a custom string representation for your objects. Here's how you can override the `ToString` method in C#:

## Example:

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        //////////////////////
        /// Overriding ToString() Method in C#
        /// 

        // Create a Car object
        Car car = new Car("Chery", "Corvette", 2024, "Blue");

        // Call the ToString method to get the string representation of the Car object
        Console.WriteLine(car); // Output: "This is a Chery Corvette 2024 Blue"

        Console.ReadKey();
    }
}

class Car
{
    // Properties to store car details
    string make;
    string model;
    int year;
    string color;

    // Constructor to initialize car details
    public Car(string make, string model, int year, string color)
    {
        this.make = make;
        this.model = model;
        this.year = year;
        this.color = color;
    }

    // Override the ToString method to provide a custom string representation
    public override string ToString()
    {
        return $"This is a {make} {model} {year} {color}";
    }
}
