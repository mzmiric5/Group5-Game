<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Group5Game
{
    class Player : Actor
    {
    	private double xCoord, yCoord, height, width;
	private List<Item> Inventory = new List<Item>(20);
    	
    	public Player (double xIn, double yIn, double hIn, double wIn, List existingStuff)
    	                : base(xIn, yIn, hIn, wIn)
    	{
		Inventory = existingStuff;
    	}

	public void collect(Item item)
	{
		Inventory.Add(item);
	}

	public void drop(int item)
	{
		Inventory[item] = null;
	}
    	
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Group5.Game
{
    public class Player : Actor
    {
<<<<<<< HEAD
<<<<<<< HEAD
    	private double xCoord, yCoord, height, width;
	private List<Item> Inventory = new List<Item>(20);
    	
    	public Player (double xIn, double yIn, double hIn, double wIn, List existingStuff)
    	                : base(xIn, yIn, hIn, wIn)
    	{
		Inventory = existingStuff;
    	}

	public void collect(Item item)
	{
		Inventory.Add(item);
	}

	public void drop(int item)
	{
		Inventory[item] = null;
	}
=======
=======
>>>>>>> origin/dev
      public List<Item> inventory;
      private static String texture_key = "default_player_texture";

      public Player()
          : this(256.0d, 256.0d, 32.0d, 32.0d)
      {
      }

    	public Player (double xIn, double yIn, double hIn, double wIn)
    	                : base(xIn, yIn, hIn, wIn)
    	{
            this.inventory = new List<Item>();
            this.set_texture_key(Player.texture_key);
    	}

        private TimeSpan time_since_last_movement = new TimeSpan(0);

        public void update(Game1 game, GameTime gameTime)
        {
            this.time_since_last_movement += gameTime.ElapsedGameTime;

            if (this.time_since_last_movement.Milliseconds >= 100)
            {
                this.time_since_last_movement -= new TimeSpan(0, 0, 0, 0, 100);
                Game1.input.Update();

                if (Game1.input.IsUpAction(null) == true)
                {
                    this.move(Direction.Up, 32);
                }
                else if (Game1.input.IsDownAction(null) == true)
                {
                    this.move(Direction.Down, 32);
                }
                else if (Game1.input.IsLeftAction(null) == true)
                {
                    this.move(Direction.Left, 32);
                }
                else if (Game1.input.IsRightAction(null) == true)
                {
                    this.move(Direction.Right, 32);
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
<<<<<<< HEAD
>>>>>>> origin/dev
=======
>>>>>>> origin/dev
    	
    }
}
>>>>>>> rollback to before dev branch was created
