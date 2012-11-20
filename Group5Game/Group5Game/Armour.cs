using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Group5.Game
{
    class Armour : Item
    {
    	private double xCoord, yCoord, height, width;
    	
    	public Armour (double xIn, double yIn, double hIn, double wIn)
    	                : base(xIn, yIn, hIn, wIn)
    	{	
    	}
    }
}
