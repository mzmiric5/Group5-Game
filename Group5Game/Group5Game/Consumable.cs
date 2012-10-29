using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Group5Game
{
    class Consumable : Item
    {
    	private double xCoord, yCoord, height, width;
    	
    	public Consumable (double xIn, double yIn, double hIn, double wIn)
    	                    : base(xIn, yIn, hIn, wIn)
    	{	
    	}
    }
}
