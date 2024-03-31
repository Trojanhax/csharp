# Auto-Implemented Properties in C#

In C#, auto-implemented properties provide a concise syntax for declaring properties without explicitly specifying the backing field. The compiler automatically generates a private, anonymous backing field for the property. Here's how you can work with auto-implemented properties in C#:

## Example:

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        //////////////////////
        /// Auto-Implemented Properties in C#
        /// 

        // Create a Car object with an auto-implemented property
        Car car = new Car("Honda");

        // Access the Model property and print its value
        Console.WriteLine(car.Model); // Output: Honda

        Console.ReadKey();
    }
} 

class Car
{
    // Define an auto-implemented property Model
    public string Model
    {
        get;
        set;
    }

    // Constructor to initialize the Model property
    public Car(string model)
    {
        this.Model = model; // Use the Model property to set the value
    }
}
