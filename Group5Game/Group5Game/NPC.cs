using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Group5.Game
{
    public class NPC : Actor
    {

        protected int movement_frequency = 1000;
        protected int movement_magnitude = 32;
        protected int sight = 128;
        private static Random random = new Random();

        private int cumlative_movement_decrementor;

        public NPC(int xIn, int yIn, int hIn, int wIn)
            : base(xIn, yIn, hIn, wIn)
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
            this.move(this.give_random_direction(), this.movement_magnitude);
        }


        public int get_movement_frequency()
        {
            return this.movement_frequency;
        }

        public void set_movement_frequency(int new_movement_frequency)
        {
            this.movement_frequency = new_movement_frequency;
        }

        public int get_sight()
        {
            return this.sight;
        }

        public void set_sight(int new_sight)
        {
            this.sight = new_sight;
        }
    }
}
