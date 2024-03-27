using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////
            /// list of objects in c#
            /// 
            List<Player> players = new List<Player>();

            Player player1 = new Player("chad");
            Player player2 = new Player("abc");
            Player player3 = new Player("cxyz");

            players.Add(player1);
            /*players.Add(player1);
            players.Add(player1);
            players.Add(player1);*/
            players.Add(player2);
            players.Add(player3);

            foreach(Player player in players)
            {
                Console.WriteLine(player);
            }



            Console.ReadKey();
        }
       
    }
    class Player
    {
        public string username;
        public Player(string username)
        {
            this.username = username;
        }
        public override string ToString()
        {
            return $"{username}";
        }
    }
    
}
 
