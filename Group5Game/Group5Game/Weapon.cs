using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Group5Game
{
    class Weapon : Item
    {
    	private double xCoord, yCoord, height, width;
    	
    	public Weapon (double xIn, double yIn, double hIn, double wIn)
    	                : base(xIn, yIn, hIn, wIn)
    	{	
    	}
    }
}
