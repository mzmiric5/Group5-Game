<<<<<<< HEAD
<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Group5Game
{
    class GameObject
    {
    	private double xCoord, yCoord;
    	
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
=======
=======
>>>>>>> origin/dev
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
<<<<<<< HEAD

namespace Group5Game
{
    class GameObject
    {
    	private double xCoord, yCoord;
=======
using Microsoft.Xna.Framework;

namespace Group5.Game
{
    public class GameObject
    {
    	protected double xCoord, yCoord;
>>>>>>> origin/dev
    	
    	public GameObject(double xIn, double yIn)
    	{
    		xCoord = xIn;
    		yCoord = yIn;
    	}
    	
    	public double returnX()
    	{
    		return xCoord;
    	}
<<<<<<< HEAD
    	
    	public double returnY()
    	{
    		return yCoord;
    	}
	
	public void draw()
	{
	}
    	
    }
}
>>>>>>> rollback to before dev branch was created
=======

        public double returnY()
        {
            return yCoord;
        }
    }
}
>>>>>>> origin/dev
