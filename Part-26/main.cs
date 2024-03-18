using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////
            /// exception in c#

            double a;
            double b;
            double total;
            try
            {
                Console.WriteLine("Enter number 1 : ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter number 2 : ");
                b = Convert.ToDouble(Console.ReadLine());

                total = a / b;

                Console.WriteLine(" Total : " + total);
            }
            catch (FormatException e)
            {
                Console.WriteLine("your error is .... " + e);
            }
            
            Console.ReadKey();
        }

        
      


    }
}
