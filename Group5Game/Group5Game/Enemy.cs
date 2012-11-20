using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Group5.Game
{
    class Enemy : NPC
    {
    	private double xCoord, yCoord, height, width;
      
      public Enemy (double xIn, double yIn, double hIn, double wIn)
    	               : base(xIn, yIn, hIn, wIn)
    	{	
    	}
    	
    }
}
