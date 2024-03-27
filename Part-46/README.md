# List of Objects in C#

In C#, you can create lists to store objects of custom classes, allowing you to manage collections of complex data efficiently. Here's how you can work with a list of objects in C#:

## Example:

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //////////////////////
        /// List of Objects in C#
        /// 

        // Create a list of Player objects
        List<Player> players = new List<Player>();

        // Create Player objects
        Player player1 = new Player("Chad");
        Player player2 = new Player("ABC");
        Player player3 = new Player("CXYZ");

        // Add Player objects to the list
        players.Add(player1);
        players.Add(player2);
        players.Add(player3);

        // Iterate through the list and print player usernames
        foreach (Player player in players)
        {
            Console.WriteLine(player);
        }

        Console.ReadKey();
    }
}

// Define the Player class
class Player
{
    public string username;

    // Constructor to initialize player username
    public Player(string username)
    {
        this.username = username;
    }

    // Override the ToString method to return the player username
    public override string ToString()
    {
        return $"{username}";
    }
}
