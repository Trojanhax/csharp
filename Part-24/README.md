# Method Overloading in C#

Method overloading in C# allows you to define multiple methods with the same name but with different parameter lists. This enables you to create methods that perform similar tasks but with different sets of input parameters.

## Example:

```csharp
class Program
{
    static void Main(string[] args)
    {
        double x, y, z, result;

        Console.WriteLine("Enter number 1:");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter number 2:");
        y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter number 3:");
        z = Convert.ToDouble(Console.ReadLine());

        // Call the appropriate overload based on the number of arguments provided
        if (args.Length == 2)
        {
            result = Multiply(x, y);
        }
        else if (args.Length == 3)
        {
            result = Multiply(x, y, z);
        }
        else
        {
            Console.WriteLine("Invalid number of arguments.");
            return;
        }

        Console.WriteLine("Your answer is:");
        Console.WriteLine(result);

        Console.ReadKey();
    }

    // Method overload for multiplying two numbers
    static double Multiply(double x, double y)
    {
        double result = x * y;
        return result;
    }

    // Method overload for multiplying three numbers
    static double Multiply(double x, double y, double z)
    {
        double result = x * y * z;
        return result;
    }
}
