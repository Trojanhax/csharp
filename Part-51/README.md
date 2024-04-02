# Threads in C#

Threads in C# allow you to execute multiple tasks concurrently, enabling parallelism and improving performance in applications. Here's how you can work with threads in C#:

## Example:

```csharp
using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        //////////////////////
        /// Thread in C#
        ///

        // Create two threads for counting up and down
        Thread mainThread1 = new Thread(() => CountUp("Timer #1"));
        Thread mainThread2 = new Thread(() => CountDown("Timer #2"));
        mainThread1.Start();
        mainThread2.Start();

        Console.ReadKey();
    }

    // Method for counting down
    public static void CountDown(string name)
    {
        for (int i = 100; i >= 0; i--)
        {
            Console.WriteLine($"{name}: {i} seconds.");
            Thread.Sleep(1000); // Simulate work
        }
        Console.WriteLine($"{name} is complete.");
    }

    // Method for counting up
    public static void CountUp(string name)
    {
        for (int i = 0; i <= 110; i++)
        {
            Console.WriteLine($"{name}: {i} seconds.");
            Thread.Sleep(1500); // Simulate work
            if (i == 110)
            {
                Console.WriteLine($"{name} is complete.");
                break;
            }
        }
    }
}
