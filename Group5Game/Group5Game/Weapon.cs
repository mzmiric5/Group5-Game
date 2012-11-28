<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> origin/dev
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

<<<<<<< HEAD
namespace Group5Game
{
    class Weapon : Item
    {
    	private double xCoord, yCoord, height, width;
	private power;
    	
    	public Weapon (double xIn, double yIn, double hIn, double wIn)
=======
namespace Group5.Game
{
    public class Weapon : Item
    {
        private int power = 0;
        
        public Weapon (double xIn, double yIn, double hIn, double wIn)
>>>>>>> origin/dev
    	                : base(xIn, yIn, hIn, wIn)
    	{	
    	}

<<<<<<< HEAD
	public int returnPower()
	{
		return power;
	}
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Group5Game
{
    class Weapon : Item
    {
    	private double xCoord, yCoord, height, width;
	private power;
    	
    	public Weapon (double xIn, double yIn, double hIn, double wIn)
    	                : base(xIn, yIn, hIn, wIn)
    	{	
    	}

	public int returnPower()
	{
		return power;
	}
    }
}
>>>>>>> rollback to before dev branch was created
=======
        public int returnPower()
        {
            return this.power;
        }
    }
}
>>>>>>> origin/dev
