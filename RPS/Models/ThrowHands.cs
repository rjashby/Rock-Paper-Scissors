using System;
using System.Collections.Generic;
using System.Linq;

namespace RPS
{
  public class Player
  {
    public string Hand { get; set; }

    //Constructor
    public Player(string hand)
    {
      Hand = hand;
    }
  }
}