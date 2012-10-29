using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Group5Game
{
    class Enemy : Actor
    {
    	private double xCoord, yCoord, height, width;
    	
    	public Enemy (double xIn, double yIn, double hIn, double wIn)
    	               : base(xIn, yIn, hIn, wIn)
    	{	
    	}
    	
    }
}
