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
>>>>>>> rollback to before dev branch was created
