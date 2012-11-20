using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Group5.Game
{
    public class PhysicsObject : GameObject
    {
    	private double xCoord, yCoord, height, width;
    	
    	public PhysicsObject (double hIn, double wIn, double xIn,
    	                        double yIn) : base(xIn, yIn)
    	{
    		height = hIn;
    		width = wIn;
    	}
    	
    	public double returnH()
    	{
		return height;
	}
	
	public double returnW()
	{
        return width;
	}	
    }
}
