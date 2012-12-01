﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Group5.Game
{
    public class Player : Actor
    {
        public List<Item> inventory;
        private static String texture_key = "default_player_texture";

        public Player()
            : this(256.0d, 256.0d, 32.0d, 32.0d)
        {
        }

        public Player(double xIn, double yIn, double hIn, double wIn)
            : base(xIn, yIn, hIn, wIn)
        {
            this.inventory = new List<Item>();
            this.set_texture_key(Player.texture_key);
            this.set_movement_distance(32);
        }

        private TimeSpan time_since_last_movement = new TimeSpan(0);
        private bool move_up_pressed = false;
        private bool move_down_pressed = false;
        private bool move_left_pressed = false;
        private bool move_right_pressed = false;

        public void update(Game1 game, GameTime gameTime)
        {
            this.time_since_last_movement += gameTime.ElapsedGameTime;

            if (Game1.input.IsUpAction(null) == true)
            {
                this.move_up_pressed = true;
                this.move_down_pressed = false;
            }
            else if (Game1.input.IsDownAction(null) == true)
            {
                this.move_down_pressed = true;
                this.move_up_pressed = false;
            }

            if (Game1.input.IsLeftAction(null) == true)
            {
                this.move_left_pressed = true;
                this.move_right_pressed = false;
            }
            else if (Game1.input.IsRightAction(null) == true)
            {
                this.move_right_pressed = true;
                this.move_left_pressed = false;
            }


            if (this.time_since_last_movement.Milliseconds >= 100)
            {
                this.time_since_last_movement -= new TimeSpan(0, 0, 0, 0, 100);
                Game1.input.Update();

                if (this.move_up_pressed == true)
                {
                    this.move(Direction.Up);
                    this.move_up_pressed = false;
                }
                else if (this.move_down_pressed == true)
                {
                    this.move(Direction.Down);
                    this.move_down_pressed = false;
                }

                if (this.move_left_pressed == true)
                {
                    this.move(Direction.Left);
                    this.move_left_pressed = false;
                }
                else if (this.move_right_pressed == true)
                {
                    this.move(Direction.Right);
                    this.move_right_pressed = false;
                }
            }
        }

        public void collect_item(Item item)
        {
            this.inventory.Add(item);
        }


        public void drop_item(int item_index)
        {
            this.inventory.RemoveAt(item_index);
        }
    }
}

