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
        protected Game1 game;

        public GameObject(Game1 new_game, int xIn, int yIn)
        {
            xCoord = xIn;
            yCoord = yIn;
            this.game = new_game;
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
