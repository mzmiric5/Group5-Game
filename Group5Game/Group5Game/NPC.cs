using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Group5.Game
{
    public class NPC : Actor
    {
        private static Random random = new Random();

        private int cumlative_movement_decrementor;

        public NPC(Game1 new_game, int xIn, int yIn, int hIn, int wIn)
            : base(new_game, xIn, yIn, hIn, wIn)
        {
            cumlative_movement_decrementor = this.get_movement_frequency();
        }

        public Direction give_random_direction()
        {
            return (Direction)NPC.random.Next(4);
        }

        public bool check_if_time_to_move(Game1 game, GameTime gameTime)
        {
            this.cumlative_movement_decrementor -= gameTime.ElapsedGameTime.Milliseconds;
            if (this.cumlative_movement_decrementor < 0)
            {
                this.cumlative_movement_decrementor = this.get_movement_frequency();
                return true;
            }
            return false;
        }

        virtual public void calculate_movement(Game1 game)
        {
            this.move(this.give_random_direction(), this.movement_distance);
        }
    }
}
