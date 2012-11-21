using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Group5.Game
{
    class Milk : Item
    {
    	public Milk (double xIn, double yIn, double hIn, double wIn)
    	              : base(xIn, yIn, hIn, wIn)
    	{	
    	}
      
      public void pick_up(Player player)
      {
        player.inventory.Add(this);
      }
    }
}
