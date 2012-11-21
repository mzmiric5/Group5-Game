using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Group5.Game
{
    public class Enemy : NPC
    {
        public bool aggresive = false;
        
        public Enemy (double xIn, double yIn, double hIn, double wIn)
    	               : base(xIn, yIn, hIn, wIn)
    	{	
    	}

        public void update()
        {
            //
        }
    	
    }
}
