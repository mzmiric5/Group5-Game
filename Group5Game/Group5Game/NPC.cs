using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using System.Diagnostics;

namespace Group5.Game
{
    public class NPC : Actor
    {
        private static Random random = new Random();

        public NPC(Game1 new_game, int xIn, int yIn, int hIn, int wIn)
            : base(new_game, xIn, yIn, hIn, wIn)
        {
        }

        public Direction give_random_direction()
        {
            return (Direction)NPC.random.Next(4);
        }
        
        virtual public void calculate_movement(Game1 game)
        {
            this.move(this.give_random_direction(), this.movement_distance);
        }
    }
}
