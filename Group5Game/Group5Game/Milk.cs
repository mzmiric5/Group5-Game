using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Group5Game
{
    class Milk : Item
    {
    	private double xCoord, yCoord, height, width;
    	
    	public Milk (double xIn, double yIn, double hIn, double wIn)
    	              : base(xIn, yIn, hIn, wIn)
    	{	
    	}
      
      public pick_up(Player player)
      {
        player.inventory.Add(this);
      }
    }
}
