using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Group5.Game
{
    public class NPC : Actor
    {
        private double xCoord, yCoord, height, width;

        public NPC(double xIn, double yIn, double hIn, double wIn)
            : base(xIn, yIn, hIn, wIn)
        {
        }


        public void draw()
        {
            // TODO: add draw method
        }
    	

    }
}
