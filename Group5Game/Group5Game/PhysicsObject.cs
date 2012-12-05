using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Group5.Game
{
    public class PhysicsObject : GameObject
    {
        protected int width, height;
        private String texture_key;

        protected bool pass_throughable = false;

        public PhysicsObject(Game1 new_game, int xIn, int yIn, int hIn, int wIn)
            : base(new_game, xIn, yIn)
        {
            height = hIn;
            width = wIn;
        }

        public int returnH()
        {
            return height;
        }

        public int returnW()
        {
            return width;
        }

        virtual public Rectangle get_volume_retangle()
        {
            return new Rectangle(this.returnX(), this.returnY(), this.returnW(), this.returnH());
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

        virtual public Rectangle get_draw_rectangle()
        {
            int sprite_x = (this.game.get_world().get_tile_size() * this.returnX());
            int sprite_y = (this.game.get_world().get_tile_size() * this.returnY());
            return new Rectangle(sprite_x, sprite_y, this.game.get_world().get_tile_size() * this.returnW(), this.game.get_world().get_tile_size() * this.returnH());
        }
    }
}
