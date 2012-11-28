using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Group5.Game
{
    public class Player : Actor
    {
      public List<Item> inventory;

      public Player()
          : this(256.0d, 256.0d, 32.0d, 32.0d)
      {
      }

    	public Player (double xIn, double yIn, double hIn, double wIn)
    	                : base(xIn, yIn, hIn, wIn)
    	{
            this.inventory = new List<Item>();
    	}


        public void draw(Game1 game)
        {
            game.spriteBatch.Draw(game.texture_dictionary["default_player_texture"], new Rectangle(Convert.ToInt32(xCoord), Convert.ToInt32(yCoord), Convert.ToInt32(width), Convert.ToInt32(height)), Color.White);
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
