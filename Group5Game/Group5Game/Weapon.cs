<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
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
    class Weapon : Item
    {
    	private double xCoord, yCoord, height, width;
	private power;
    	
    	public Weapon (double xIn, double yIn, double hIn, double wIn)
=======
=======
>>>>>>> origin/dev
namespace Group5.Game
{
    public class Weapon : Item
    {
        private int power = 0;
        
        public Weapon (double xIn, double yIn, double hIn, double wIn)
<<<<<<< HEAD
>>>>>>> origin/dev
=======
>>>>>>> origin/dev
    	                : base(xIn, yIn, hIn, wIn)
    	{	
    	}

<<<<<<< HEAD
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
=======
>>>>>>> origin/dev
        public int returnPower()
        {
            return this.power;
        }
    }
}
<<<<<<< HEAD
>>>>>>> origin/dev
=======
>>>>>>> origin/dev
