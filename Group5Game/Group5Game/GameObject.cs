using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Group5.Game
{
    public class GameObject
    {
    	protected double xCoord, yCoord;
    	
    	public GameObject(double xIn, double yIn)
    	{
    		xCoord = xIn;
    		yCoord = yIn;
    	}
    	
    	public double returnX()
    	{
    		return xCoord;
    	}
    	
    	public double returnY()
    	{
    		return yCoord;
    	}

        public void draw()
        {
        }

    }
}
