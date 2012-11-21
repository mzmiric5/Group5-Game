<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Group5Game
{
    class Consumable : Item
    {
    	private double xCoord, yCoord, height, width;
	private int stength;
    	
    	public Consumable (double xIn, double yIn, double hIn, double wIn)
    	                    : base(xIn, yIn, hIn, wIn)
    	{	
    	}

	public int returnStrength()
	{
		return strength;
	}

	public void use(Character character)
	{
		character.heal(strength);
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
    class Consumable : Item
    {
    	private double xCoord, yCoord, height, width;
	private int stength;
    	
    	public Consumable (double xIn, double yIn, double hIn, double wIn)
    	                    : base(xIn, yIn, hIn, wIn)
    	{	
    	}

	public int returnStrength()
	{
		return strength;
	}

	public void use(Character character)
	{
		character.heal(strength);
	}
    }
}
>>>>>>> rollback to before dev branch was created
