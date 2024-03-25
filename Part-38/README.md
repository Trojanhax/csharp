# Arrays of Objects in C#

In C#, arrays of objects are used to store collections of objects of the same type. This allows for efficient management and manipulation of multiple instances of a class. Here's how you can work with arrays of objects in C#:

## Example:

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        //////////////////////
        /// Array of Objects in C#
        /// 

        // Create an array to store Car objects
        Car[] garage = new Car[3];

        // Create instances of the Car class and store them in the array
        Car car1 = new Car("Mustang");
        Car car2 = new Car("Corvette");
        Car car3 = new Car("Lambo");

        garage[0] = car1;
        garage[1] = car2;
        garage[2] = car3;

        // Access and print the model of each car in the garage
        Console.WriteLine(garage[0].Model);
        Console.WriteLine(garage[1].Model);
        Console.WriteLine(garage[2].Model);

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
