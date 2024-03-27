# List<T> in C#

In C#, the `List<T>` class provides a dynamic array that can hold elements of a specified type `T`. It offers functionalities for adding, removing, accessing, and searching elements within the list. Here's how you can work with lists in C#:

## Example:

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //////////////////////
        /// List<T> in C#
        /// 

        // Create a list of integers
        List<int> numbers = new List<int>();

        // Add elements to the list
        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);

        // Access elements by index
        Console.WriteLine("Element at index 0: " + numbers[0]); // Output: 10

        // Iterate through the list using a foreach loop
        Console.WriteLine("List elements:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        // Remove elements from the list
        numbers.Remove(20);

        // Check if an element exists in the list
        bool contains30 = numbers.Contains(30); // Output: true

        // Get the index of an element in the list
        int index30 = numbers.IndexOf(30); // Output: 1

        // Get the number of elements in the list
        int count = numbers.Count; // Output: 2

        // Clear all elements from the list
        numbers.Clear();

        // Check if the list is empty
        bool isEmpty = (numbers.Count == 0); // Output: true

        Console.ReadKey();
    }
}
