# Object Passing and Returning in C#

In C#, you can pass objects as arguments to methods and return objects from methods, allowing for manipulation and transformation of object state. Here's how you can work with object passing and returning in C#:

## Example:

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        //////////////////////
        /// Object Passing and Returning in C#
        /// 

        // Create a Car object
        Car car1 = new Car("Mustang", "Red");

        // Pass the Car object as an argument to the ChangeColor method
        ChangeColor(car1, "Gray");

        // Create a copy of the Car object using the Copy method
        Car car2 = Copy(car1);

        // Print the model and color of both cars
        Console.WriteLine(car1.Color + " " + car1.Model);
        Console.WriteLine(car2.Color + " " + car2.Model);

        Console.ReadKey();
    }

    // Method to change the color of a Car object
    public static void ChangeColor(Car car, string color)
    {
        car.Color = color;
    }

    // Method to create a copy of a Car object
    public static Car Copy(Car car)
    {
        return new Car(car.Model, car.Color);
    }
}

class Car
{
    // Properties to store the model and color of the car
    public string Model { get; }
    public string Color { get; set; }

    // Constructor to initialize the model and color of the car
    public Car(string model, string color)
    {
        Model = model;
        Color = color;
    }
}
