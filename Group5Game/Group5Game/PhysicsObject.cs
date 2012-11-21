using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Group5.Game
{
    public class PhysicsObject : GameObject
    {
    	protected double width, height;

        protected bool pass_throughable = false;
    	
    	public PhysicsObject (double hIn, double wIn, double xIn,
    	                        double yIn) : base(xIn, yIn)
    	{
    		height = hIn;
    		width = wIn;
    	}
    	
    	public double returnH()
    	{
		return height;
	}
	
	public double returnW()
	{
        return width;
	}

    public bool get_pass_throughable()
    {
        return this.pass_throughable;
    }

    public void set_pass_throughable(bool can_pass_through)
    {
        this.pass_throughable = can_pass_through;
    }


    }
}
