using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Group5.Game
{
    class Consumable : Item
    {
        private int strength = 0;

        public Consumable(double xIn, double yIn, double hIn, double wIn)
            : base(xIn, yIn, hIn, wIn)
        {
        }

        public int returnStrength()
        {
            return this.strength;
        }

        public void use(Player player)
        {
            player.gainHealth(strength);
        }
    }
}
