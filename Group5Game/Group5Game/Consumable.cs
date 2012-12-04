using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Group5.Game
{
    class Consumable : Item
    {
        private int strength = 0;

        public Consumable(Game1 new_game, int xIn, int yIn, int hIn, int wIn)
            : base(new_game, xIn, yIn, hIn, wIn)
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
