using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Group5Game
{
    class Player : Actor
    {
    	private double xCoord, yCoord, height, width;
	private List<Item> Inventory = new List<Item>(20);
    	
    	public Player (double xIn, double yIn, double hIn, double wIn, List existingStuff)
    	                : base(xIn, yIn, hIn, wIn)
    	{
		Inventory = existingStuff;
    	}

	public void collect(Item item)
	{
		Inventory.Add(item);
	}

	public void drop(int item)
	{
		Inventory[item] = null;
	}
    	
    }
}
