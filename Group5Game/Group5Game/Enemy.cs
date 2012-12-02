﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Group5.Game
{
    public class Enemy : NPC
    {
        public bool aggresive = false;

        public Enemy(double xIn, double yIn, double hIn, double wIn)
            : base(xIn, yIn, hIn, wIn)
        {
        }

        public void update(Game1 game, GameTime gameTime)
        {
            if (check_if_time_to_move(game, gameTime))
            {
                calculate_movement(game);
            }
        }

        override public void calculate_movement(Game1 game)
        {
            bool has_moved = false;
            if (this.aggresive == true)
            {
                // if player is above enemy && player is in sight of enemy
                if ((game.levelManager.get_current_level().player.returnY() > this.returnY()) && (this.returnY() + this.returnH() + this.get_sight() >= game.levelManager.get_current_level().player.returnY()))
                {
                    this.move(Direction.Up, this.movement_magnitude);
                    has_moved = true;
                }
                // if player is below enemy && player is in sight of enemy
                else if ((game.levelManager.get_current_level().player.returnY() < this.returnY()) && (this.returnY() - this.get_sight() <= game.levelManager.get_current_level().player.returnY() + game.levelManager.get_current_level().player.returnH()))
                {
                    this.move(Direction.Down, this.movement_magnitude);
                    has_moved = true;
                }
                // if player is right of enemy && player is in sight of enemy
                else if ((game.levelManager.get_current_level().player.returnX() > this.returnX()) && (this.returnX() + this.returnW() + this.get_sight() >= game.levelManager.get_current_level().player.returnX()))
                {
                    this.move(Direction.Right, this.movement_magnitude);
                    has_moved = true;
                }
                // player is left of enemy && player is in sight of enemy
                else if ((game.levelManager.get_current_level().player.returnX() < this.returnX()) && (this.returnX() - this.get_sight() <= game.levelManager.get_current_level().player.returnX() + game.levelManager.get_current_level().player.returnW()))
                {
                    this.move(Direction.Left, this.movement_magnitude);
                    has_moved = true;
                }
            }
            if (has_moved == false)
            {
                this.move(this.give_random_direction(), this.movement_magnitude);
            }
        }

    }
}
