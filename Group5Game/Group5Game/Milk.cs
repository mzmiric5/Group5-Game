using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Group5.Game
{
    class Milk : Item
    {
        private static String texture_key = "milk_texture";

        public Milk(Game1 new_game, int xIn, int yIn, int hIn, int wIn)
            : base(new_game, xIn, yIn, hIn, wIn)
        {
            this.set_texture_key(Milk.texture_key);
        }

        public void pick_up(Player player)
        {
            player.inventory.Add(this);
        }
    }
}
