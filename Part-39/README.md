# Anonymous Objects in C#

In C#, anonymous objects are instances of classes that are created without explicitly declaring a variable name for each instance. Instead, they are created inline within an array initialization expression or other contexts where object creation syntax is supported. Here's how you can work with anonymous objects in C#:

## Example:

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        //////////////////////
        /// Anonymous Objects in C#
        /// 

        // Create an array of Car objects using anonymous object initialization
        Car[] garage = { new Car("Mustang"), new Car("Corvette"), new Car("Lambo") };

        // Iterate through the garage array and print the model of each car
        foreach (Car car in garage)
        {
            Console.WriteLine(car.Model);
        }

        Console.ReadKey();
    }
}

class Car
{
    // Define a property to store the model of the car
    public string Model { get; }

    // Constructor to initialize the model of the car
    public Car(string model)
    {
        Model = model;
    }
}
