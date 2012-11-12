using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Group5Game
{
    class Actor : PhysicsObject
    {
    	private double xCoord, yCoord, height, width;
	private int health, maxHealth;
	private enum Direction{up, right, down, left};
	private Direction orientation;
    	
    	public Actor (double xIn, double yIn, double hIn, double wIn, int orientIn)
    	               : base(xIn, yIn, hIn, wIn)
    	{
		orientation = orientIn;
    	}

	public void loseHealth(int damage)
	{
		health -= damage;
	}

	public void gainHealth(int heal)
	{
		if(health + heal > maxHealth)
			health = maxHealth;
		else
			health += heal;
	}

	public int returnHealth()
	{
		return health;
	}
    	
    }
}
