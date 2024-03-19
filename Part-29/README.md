# String Interpolation in C#

String interpolation in C# is a feature that allows you to embed expressions and variables directly within a string literal. It provides a more readable and convenient way to format strings compared to traditional string concatenation.

## Example:

```csharp
class Program
{
    static void Main(string[] args)
    {
        string firstName = "Gray";
        string lastName = "Gray";
        int age = 21;

        // Using traditional string concatenation
        Console.WriteLine("Hello " + firstName + " " + lastName + ".");
        Console.WriteLine("You are " + age + " years old.");

        // Using string interpolation
        Console.WriteLine($"Hello {firstName} {lastName}.");
        Console.WriteLine($"You are {age, 10} years old."); // Right-aligned
        Console.WriteLine($"You are {age, -10} years old."); // Left-aligned

        Console.ReadKey();
    }
}
