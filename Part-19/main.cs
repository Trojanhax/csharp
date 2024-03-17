using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////
            ///

            double num1 = 0;
            double num2 = 0;
            double result = 0;


            Console.WriteLine("Enter number 1 : ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter number 2 : ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Option : ");
            switch (Console.ReadLine())
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine($"Your answer is {num1} + {num2} : " + result);
                    break;

                case "-":
                    result = num1 - num2;
                    Console.WriteLine($"Your answer is {num1} - {num2} : " + result);
                    break;

                case "*":
                    result = num1 * num2;
                    Console.WriteLine($"Your answer is {num1} * {num2} : " + result);
                    break;

                case "/":
                    result = num1 / num2;
                    Console.WriteLine($"Your answer is {num1} / {num2} : " + result);
                    break;

                default:
                    Console.WriteLine(" wrong operater");
                    break;
            }

            Console.ReadKey();
        }
    }
}
