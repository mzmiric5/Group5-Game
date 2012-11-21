using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Group5.Game
{
    class Ork : Enemy
    {
        public Ork()
            : this(0.0d, 0.0d, 1.0d, 1.0d)
      {
      }
      
      public Ork (double xIn, double yIn, double hIn, double wIn)
    	               : base(xIn, yIn, hIn, wIn)
    	{
    	}
    	
    }
}