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
            //////////////////////
            ///

            Random random = new Random();
            bool playagain = true;
            string rock = "rock";
            string paper = "paper";
            string scissors = "scissors";
            string palyer;
            string computer;


            while (playagain)
            {
                palyer = "";
                computer = "";

                while (palyer != rock && palyer != paper && palyer != scissors )
                {
  
                    Console.WriteLine(" Enter ROCK PAPER SCISSORS :");
                    palyer = Console.ReadLine();
                    palyer = palyer.ToLower();
                }
                int randomnum = random.Next(1, 4);
                switch (randomnum)
                {
                    case 1:
                        computer = rock;
                        break;

                    case 2:
                        computer = paper;
                        break;

                    case 3:
                        computer = scissors;
                        break;

                    

                }
                Console.WriteLine("Player : " + palyer);


                Console.WriteLine("Computer : " + computer);

                if (palyer == computer)
                {
                    Console.WriteLine("It's a tie!");
                }
                else if ((palyer == rock && computer == scissors) ||
                         (palyer == paper && computer == rock) ||
                         (palyer == scissors && computer == paper))
                {
                    Console.WriteLine("You win!");
                }
                else
                {
                    Console.WriteLine("Computer wins!");
                }

                Console.WriteLine("Do you want to play again? (Y/N)");
                string response = Console.ReadLine();
                response = response.ToLower();

                if (response == "y")
                {
                    playagain = true;
                }
                else if (response == "n")
                {
                    playagain = false; // Use assignment operator here
                }


            }

            Console.WriteLine(" Thanks for playing ....");

            Console.ReadKey();
        }
    }
}
  
