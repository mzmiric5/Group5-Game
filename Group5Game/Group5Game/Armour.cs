using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Group5.Game
{
    class Armour : Item
    {
        protected int strength = 0;

        public Armour(Game1 new_game, int xIn, int yIn, int hIn, int wIn)
            : base(new_game, xIn, yIn, hIn, wIn)
        {
        }

        public int returnStrength()
        {
            return this.strength;
        }
    }
}
