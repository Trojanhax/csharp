using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////
            /// exception in c#

            int a;
            int b;
            int total;
            try
            {
                Console.WriteLine("Enter number 1 : ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter number 2 : ");
                b = Convert.ToInt32(Console.ReadLine());

                total = a / b;

                Console.WriteLine(" Total : " + total);
            }
            catch (FormatException e)
            {
                Console.WriteLine("your error is .... " + e);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("your error is .... " + e);
            }
            catch(Exception e)
            {
                Console.WriteLine("your error is .... " + e);
            }
            finally
            {
                Console.WriteLine("Thanks for visiting!");
            }
            
            Console.ReadKey();
        }

        
      


    }
}
