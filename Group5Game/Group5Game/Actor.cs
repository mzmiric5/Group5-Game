using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using System.Diagnostics;

namespace Group5.Game
{
    public class Actor : PhysicsObject
    {
        protected int health, maxHealth, attackDamage;
        public enum Direction { Up, Down, Left, Right };
        protected Direction orientation;
        protected int movement_distance = 1;
        protected bool is_moving = false;
        protected Point movement_target;
        protected double percentage_of_movement_complete = 0.0d;
        protected int movement_frequency = 1000;
        protected int sight = 5;
        protected int movement_update_frequency = 10;

        public Actor(Game1 new_game, int xIn, int yIn, int hIn, int wIn)
            : base(new_game, xIn, yIn, hIn, wIn)
        {
        }

        public bool get_is_moving()
        {
            return this.is_moving;
        }

        public int get_movement_update_frequency()
        {
            return this.movement_update_frequency;
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

        public void set_is_moving(bool new_is_moving)
        {
            this.is_moving = new_is_moving;
        }

        public Point get_movement_target()
        {
            return this.movement_target;
        }

        public void set_movement_target(Point new_movement_target)
        {
            this.movement_target = new_movement_target;
        }

        public void move(Direction direction)
        {
            this.move(direction, this.get_movement_distance());
        }

        public void move(Direction direction, int distance)
        {
            Rectangle target_rectangle = new Rectangle(this.returnX(), this.returnY(), this.returnW(), this.returnH());
            if (direction == Direction.Up)
            {
                target_rectangle.Y -= distance;
            }
            else if (direction == Direction.Down)
            {
                target_rectangle.Y += distance;
            }
            if (direction == Direction.Left)
            {
                target_rectangle.X -= distance;
            }
            else if (direction == Direction.Right)
            {
                target_rectangle.X += distance;
            }

            if (this.game.levelManager.get_current_level().is_rectangle_unblocked(target_rectangle) == true)
            {
                this.percentage_of_movement_complete = 0.0d;
                this.movement_target.X = target_rectangle.X;
                this.movement_target.Y = target_rectangle.Y;
                this.set_is_moving(true);
            }
        }

        public void update_movement()
        {
            this.percentage_of_movement_complete += 1.0d / this.movement_update_frequency;
            if (this.percentage_of_movement_complete >= 1.0d)
            {
                this.set_is_moving(false);
                this.xCoord = Convert.ToInt32(this.movement_target.X);
                this.yCoord = Convert.ToInt32(this.movement_target.Y);
            }
        }

        public int get_movement_distance()
        {
            return this.movement_distance;
        }

        public void set_movement_distance(int new_movement_distance)
        {
            this.movement_distance = new_movement_distance;
        }

        public void loseHealth(int damage)
        {
            this.health -= damage;
        }

        public void gainHealth(int heal)
        {
            if (health + heal > maxHealth)
            {
                this.health = maxHealth;
            }
            else
            {
                this.health += heal;
            }
        }

        public int returnHealth()
        {
            return this.health;
        }

        public void attack(List<Actor> targets)
        {
            // Attack animation
            int yDist, xDist;

            foreach (Actor target in targets)
            {
                xDist = (int)Math.Pow((target.returnX() - xCoord), 2);
                yDist = (int)Math.Pow((target.returnY() - yCoord), 2);
                if (Math.Sqrt(xDist + yDist) <= 16)
                    if (orientation == Direction.Up && target.returnY() - yCoord >= 0 || orientation == Direction.Down && target.returnY() - yCoord <= 0
                        || orientation == Direction.Left && target.returnX() - xCoord <= 0 || orientation == Direction.Right && target.returnX() - xCoord >= 0)
                        target.loseHealth(attackDamage);
            }
        }

        override public Rectangle get_draw_rectangle()
        {
            int sprite_x = (this.game.get_world().get_tile_size() * this.returnX());
            int sprite_y = (this.game.get_world().get_tile_size() * this.returnY());
            if (this.get_is_moving() == true)
            {
                if (this.returnX() - this.movement_target.X > 0)
                {
                    sprite_x -= Convert.ToInt32(this.percentage_of_movement_complete * Convert.ToDouble(this.game.get_world().get_tile_size()));
                }
                else if (this.returnX() - this.movement_target.X < 0)
                {
                    sprite_x += Convert.ToInt32(this.percentage_of_movement_complete * Convert.ToDouble(this.game.get_world().get_tile_size()));
                }
                if (this.returnY() - this.movement_target.Y > 0)
                {
                    sprite_y -= Convert.ToInt32(this.percentage_of_movement_complete * Convert.ToDouble(this.game.get_world().get_tile_size()));
                }
                else if (this.returnY() - this.movement_target.Y < 0)
                {
                    sprite_y += Convert.ToInt32(this.percentage_of_movement_complete * Convert.ToDouble(this.game.get_world().get_tile_size()));
                }
            }

            return new Rectangle(sprite_x, sprite_y, this.game.get_world().get_tile_size() * this.returnW(), this.game.get_world().get_tile_size() * this.returnH());
        }
    }
}
