# Generics in C#

In C#, generics provide a way to create classes, interfaces, and methods that can work with any data type. Generics improve code reusability and type safety by allowing you to define types and methods that are parameterized by one or more types. Here's how you can work with generics in C#:

## Example:

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        //////////////////////
        /// Generics in C#
        ///

        // Define arrays of different data types
        int[] intArray = { 1, 2, 3, 4 };
        double[] doubleArray = { 1.0, 2.0, 3.0 };
        string[] stringArray = { "1", "2", "3" };

        // Call the displayElement method with arrays of different data types
        DisplayElements(intArray); // Output: 1 2 3 4
        DisplayElements(doubleArray); // Output: 1 2 3
        DisplayElements(stringArray); // Output: 1 2 3

        Console.ReadKey();
    }

    // Generic method to display elements of an array of any data type
    public static void DisplayElements<T>(T[] array)
    {
        foreach (T item in array)
        {
            Console.WriteLine(item + " ");
        }
    }
}
