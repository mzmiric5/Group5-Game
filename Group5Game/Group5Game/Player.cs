using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using System.Diagnostics;

namespace Group5.Game
{
    public class Player : Actor
    {
        public List<Item> inventory;
        private static String texture_key = "default_player_texture";

        private bool move_up_pressed = false;
        private bool move_down_pressed = false;
        private bool move_left_pressed = false;
        private bool move_right_pressed = false;

        private int human_button_delay = 500;

        public Player(Game1 new_game)
            : this(new_game, 7, 7, 1, 1)
        {
        }

        public Player(Game1 new_game, int xIn, int yIn, int hIn, int wIn)
            : base(new_game, xIn, yIn, hIn, wIn)
        {
            this.inventory = new List<Item>();
            this.set_texture_key(Player.texture_key);
            this.set_movement_distance(1);
            this.set_movement_frequency(1);
        }

        public void update(Game1 game, GameTime gameTime)
        {
            this.timespan_since_last_movement += gameTime.ElapsedGameTime;

            Game1.input.Update();
            
            Debug.WriteLine(this.timespan_since_last_movement.TotalMilliseconds);
            if (this.timespan_since_last_movement >= new TimeSpan(0, 0, 0, 0, this.human_button_delay))
            {
                if (Game1.input.IsUpAction() == true)
                {
                    this.move_up_pressed = true;
                    this.move_down_pressed = false;
                }
                else if (Game1.input.IsDownAction() == true)
                {
                    this.move_down_pressed = true;
                    this.move_up_pressed = false;
                }

                if (Game1.input.IsLeftAction() == true)
                {
                    this.move_left_pressed = true;
                    this.move_right_pressed = false;
                }
                else if (Game1.input.IsRightAction() == true)
                {
                    this.move_right_pressed = true;
                    this.move_left_pressed = false;
                }
            }

            if (this.get_is_moving() == true)
            {
                this.update_movement(gameTime);
            }
            else
            {
                if (check_if_time_to_move(game, gameTime) == true)
                {
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

