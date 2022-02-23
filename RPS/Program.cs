using System;
using System.Collections.Generic;
using System.Linq;
using RPS;

namespace RPS
{
  public class Program
  {
    
    
    public static void Main()
    {
      while (true)
      {
        Console.WriteLine("Hey you, Player 1, Pick a Rock or a Paper or Scissors... Do it now! Or type Quit to Quit");
        string input = Console.ReadLine().ToUpper();
        if (input != "ROCK" && input != "PAPER" && input != "SCISSORS")
        {
          Main();
        }
        Player player1 = new Player(input);
        Console.WriteLine("Player 2, Pick a Rock or a Paper or Scissors... Do it now!");
        string input2 = Console.ReadLine().ToUpper();
        Player player2 = new Player(input2);

        if ((player1.Hand == "ROCK" && player2.Hand == "SCISSORS") || (player1.Hand == "PAPER" && player2.Hand == "ROCK") || (player1.Hand == "SCISSORS" && player2.Hand == "PAPER")) 
        {
          Console.WriteLine("Player One Winssssssss!");
        }
        
        else if ((player2.Hand == "ROCK" && player1.Hand == "SCISSORS") || (player2.Hand == "PAPER" && player1.Hand == "ROCK") || (player2.Hand == "SCISSORS" && player1.Hand == "PAPER"))
        {
          Console.WriteLine("Player Two Winssssssss!");
        } 
        else if ((player2.Hand == "ROCK" && player1.Hand == "ROCK") || (player2.Hand == "PAPER" && player1.Hand == "PAPER") || (player2.Hand == "SCISSORS" && player1.Hand == "SCISSORS"))
        {
          Console.WriteLine("It's a GD drawwww");
        }
        else 
        {
          Console.WriteLine("Hey dumb dumb, pick a valid response");
        }
      }
    }
  }
}