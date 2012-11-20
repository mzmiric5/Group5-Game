using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Group5.Game
{
    public class Item : PhysicsObject
    {
    	private double xCoord, yCoord, height, width;
    	
    	public Item (double xIn, double yIn, double hIn, double wIn)
    	              : base(xIn, yIn, hIn, wIn)
    	{	
    	}
    }
}
