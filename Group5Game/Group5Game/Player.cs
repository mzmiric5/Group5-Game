using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Group5.Game
{
    public class Player : Actor
    {
    	private double xCoord, yCoord, height, width;
      
      public List<Item> inventory;

      public Player()
          : this(0.0d, 0.0d, 0.0d, 0.0d)
      {
      }

    	public Player (double xIn, double yIn, double hIn, double wIn)
    	                : base(xIn, yIn, hIn, wIn)
    	{	
    	}
    	
    }
}
