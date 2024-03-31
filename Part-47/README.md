# Getters and Setters (Properties) in C#

In C#, properties provide a way to encapsulate data within a class and control access to it using getters and setters. Getters retrieve the value of a property, while setters modify the value of a property. Here's how you can work with getters and setters (properties) in C#:

## Example:

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        //////////////////////
        /// Getters and Setters (Properties) in C#
        /// 

        // Create a Car object with an initial speed
        Car car = new Car(90);

        // Set the speed property using the setter
        car.Speed = 1010101;

        // Get the speed property using the getter and print it
        Console.WriteLine(car.Speed); // Output: 500 (limited by setter logic)

        Console.ReadKey();
    }
} 

class Car
{
    private int speed; // Private field to store speed data

    // Constructor to initialize the Car object with a speed
    public Car(int speed)
    {
        Speed = speed; // Call the Speed property setter to set the initial speed
    }

    // Public property Speed with both getter and setter
    public int Speed
    {
        get 
        {
            return speed; // Getter returns the value of speed
        }
        set
        {
            // Setter validates the value and limits it to 500 if it exceeds the limit
            if (value > 500)
            {
                speed = 500;
            }
            else
            {
                speed = value;
            }
        }
    }
}
