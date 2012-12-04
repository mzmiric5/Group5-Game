using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;

namespace Group5.Game
{
    public class GameObject
    {
        protected int xCoord, yCoord;

        public GameObject(int xIn, int yIn)
        {
            xCoord = xIn;
            yCoord = yIn;
        }

        public int returnX()
        {
            return xCoord;
        }

        public int returnY()
        {
            return yCoord;
        }
    }
}
