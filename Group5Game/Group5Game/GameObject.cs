<<<<<<< HEAD
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
=======
>>>>>>> origin/dev
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
<<<<<<< HEAD
<<<<<<< HEAD

namespace Group5Game
{
    class GameObject
    {
    	private double xCoord, yCoord;
=======
=======
>>>>>>> origin/dev
using Microsoft.Xna.Framework;

namespace Group5.Game
{
    public class GameObject
    {
    	protected double xCoord, yCoord;
<<<<<<< HEAD
>>>>>>> origin/dev
=======
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
=======
>>>>>>> origin/dev

        public double returnY()
        {
            return yCoord;
        }
    }
}
<<<<<<< HEAD
>>>>>>> origin/dev
=======
>>>>>>> origin/dev
