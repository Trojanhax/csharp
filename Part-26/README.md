# Exception Handling in C#

Exception handling in C# allows you to gracefully handle errors or exceptional conditions that may occur during the execution of a program. It helps prevent application crashes and provides mechanisms to recover from unexpected situations.

## Example:

```csharp
class Program
{
    static void Main(string[] args)
    {
        double a, b, total;

        try
        {
            Console.WriteLine("Enter number 1:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter number 2:");
            b = Convert.ToDouble(Console.ReadLine());

            total = a / b;

            Console.WriteLine("Total: " + total);
        }
        catch (FormatException e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }

        Console.ReadKey();
    }
}
