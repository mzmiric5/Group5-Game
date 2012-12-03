using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Group5.Game
{
    public class PhysicsObject : GameObject
    {
        protected double width, height;
        private String texture_key;

        protected bool pass_throughable = false;

        public PhysicsObject(double xIn, double yIn, double hIn, double wIn)
            : base(xIn, yIn)
        {
            height = hIn;
            width = wIn;
        }

        public double returnH()
        {
            return height;
        }

        public double returnW()
        {
            return width;
        }

        public String get_texture_key()
        {
            return this.texture_key;
        }

        protected void set_texture_key(String new_texture_key)
        {
            this.texture_key = new_texture_key;
        }

        public bool get_pass_throughable()
        {
            return this.pass_throughable;
        }

        public void set_pass_throughable(bool can_pass_through)
        {
            this.pass_throughable = can_pass_through;
        }

        virtual public void draw(Game1 game) // aim to remove this function
        {
            game.spriteBatch.Draw(game.texture_dictionary[this.texture_key], new Rectangle(Convert.ToInt32(xCoord), Convert.ToInt32(yCoord), Convert.ToInt32(width), Convert.ToInt32(height)), Color.White);
        }
    }
}
