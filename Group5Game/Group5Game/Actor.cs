using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Group5.Game
{
    public class Actor : PhysicsObject
    {
    	private double xCoord, yCoord, height, width;
    	
    	public Actor (double xIn, double yIn, double hIn, double wIn)
    	               : base(xIn, yIn, hIn, wIn)
    	{	
    	}
    	
    }
}
