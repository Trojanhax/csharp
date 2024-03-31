# Enums in C#

In C#, enums (enumerations) provide a way to define a set of named integral constants, making your code more readable and maintainable. Enums are often used to represent a fixed set of related values. Here's how you can work with enums in C#:

## Example:

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        //////////////////////
        /// Enums in C#
        /// 

        // Access enum values and their corresponding integer values
        Console.WriteLine(Planets.Earth + " is a planet"); // Output: Earth is a planet
        Console.WriteLine(Planets.Earth + " is a planet $" + (int)Planets.Earth); // Output: Earth is a planet $3
        Console.WriteLine(Planets.Venus + " is a planet $" + (int)Planets.Venus); // Output: Venus is a planet $2

        // Convert enum to string and integer
        string name = PlanetRadius.Venus.ToString();
        int rds = (int)PlanetRadius.Venus;
        Console.WriteLine("Planet " + name); // Output: Planet Venus
        Console.WriteLine("PlanetRadius " + rds + "km"); // Output: PlanetRadius 112km

        // Calculate volume using enum values
        double volume = CalculateVolume(PlanetRadius.Earth);
        Console.WriteLine("Volume of Earth: " + volume + "km^3");

        Console.ReadKey();
    }

    // Method to calculate volume based on planet radius enum
    public static double CalculateVolume(PlanetRadius planetRadius)
    {
        double volume = (4.0 / 3.0) * Math.PI * Math.Pow((int)planetRadius, 3);
        return volume;
    }
} 

// Enum representing planets
enum Planets
{
    Mercury = 1, 
    Venus = 2,  
    Earth = 3, 
    Mars = 4, 
    Jupiter = 5, 
    Saturn = 6, 
    Uranus = 7, 
    Neptune = 8, 
    Pluto = 9
}

// Enum representing planet radii
enum PlanetRadius
{
    Mercury = 111,
    Venus = 112,
    Earth = 113,
    Mars = 114,
    Jupiter = 115,
    Saturn = 116,
    Uranus = 117,
    Neptune = 118,
    Pluto = 119
}
