<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Group5Game
{
    class Armour : Item
    {
    	private double xCoord, yCoord, height, width;
	private int strength;
    	
    	public Armour (double xIn, double yIn, double hIn, double wIn)
    	                : base(xIn, yIn, hIn, wIn)
    	{	
    	}

	public int returnStrength()
	{
		return strength;
	}
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Group5.Game
{
    class Armour : Item
    {
<<<<<<< HEAD
<<<<<<< HEAD
    	private double xCoord, yCoord, height, width;
	private int strength;
    	
    	public Armour (double xIn, double yIn, double hIn, double wIn)
=======
        protected int strength = 0;
        
        public Armour (double xIn, double yIn, double hIn, double wIn)
>>>>>>> origin/dev
=======
        protected int strength = 0;
        
        public Armour (double xIn, double yIn, double hIn, double wIn)
>>>>>>> origin/dev
    	                : base(xIn, yIn, hIn, wIn)
    	{	
    	}

<<<<<<< HEAD
<<<<<<< HEAD
	public int returnStrength()
	{
		return strength;
	}
=======
=======
>>>>>>> origin/dev
        public int returnStrength()
        {
            return this.strength;
        }
<<<<<<< HEAD
>>>>>>> origin/dev
=======
>>>>>>> origin/dev
    }
}
>>>>>>> rollback to before dev branch was created
