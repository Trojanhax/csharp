# Params Keyword in C#

The `params` keyword in C# allows you to specify a variable number of arguments for a method. It simplifies method calls by allowing you to pass a variable number of parameters of the same type to the method without explicitly creating an array.

## Example:

```csharp
class Program
{
    static void Main(string[] args)
    {
        double total = Checkout(3, 4, 6, 5);

        Console.WriteLine("Total amount: " + total);

        Console.ReadKey();
    }

    static double Checkout(params double[] prices)
    {
        double total = 0;

        foreach (double price in prices)
        {
            total += price;
        }

        return total;
    }
}
