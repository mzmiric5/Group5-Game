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

namespace Group5.Game
{
    class Consumable : Item
    {
<<<<<<< HEAD
<<<<<<< HEAD
    	private double xCoord, yCoord, height, width;
	private int stength;
    	
    	public Consumable (double xIn, double yIn, double hIn, double wIn)
=======
        private int strength = 0;
        
        public Consumable (double xIn, double yIn, double hIn, double wIn)
>>>>>>> origin/dev
=======
        private int strength = 0;
        
        public Consumable (double xIn, double yIn, double hIn, double wIn)
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

	public void use(Character character)
	{
		character.heal(strength);
	}
=======
=======
>>>>>>> origin/dev
        public int returnStrength()
        {
            return this.strength;
        }
        
        public void use(Player player)
        {
            player.gainHealth(strength);
        }
<<<<<<< HEAD
>>>>>>> origin/dev
=======
>>>>>>> origin/dev
    }
}
>>>>>>> rollback to before dev branch was created
