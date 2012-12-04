using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Group5.Game
{
    class Ork : Enemy
    {
        private static String texture_key = "ork_texture";

        public Ork(Game1 new_game)
            : this(new_game, 0, 0, 1, 1)
        {
        }

        public Ork(Game1 new_game, int xIn, int yIn, int hIn, int wIn)
            : base(new_game, xIn, yIn, hIn, wIn)
        {
            this.set_texture_key(Ork.texture_key);
        }
    }
}
