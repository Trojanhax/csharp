using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playagain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            string response;

            while (playagain == true)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(min, max + 1);

                while(guess != number)
                {
                    Console.WriteLine(" Guss a number between " + min + " - " + max + " :");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(" Guss : " + guess); 

                    if ( guess > number)
                    {
                        Console.WriteLine(guess + " id too high");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " id too low");
                    }
                    guesses++;


                }

                Console.WriteLine("Number : " + number);
                Console.WriteLine(" You Win !");
                Console.WriteLine("Gusses : " + guesses);

                Console.WriteLine(" Would you play agin (Y/N)!");
                response = Console.ReadLine();

                response = response.ToLower();

                if ( response == "y")
                {
                    playagain = true;
                }
                else
                {
                    playagain = false;
                }

            }

            Console.WriteLine(" Thanks for playing ! ...........................");

            Console.ReadKey();



        }
    }
}
  
