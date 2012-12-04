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

        public Actor(Game1 new_game, int xIn, int yIn, int hIn, int wIn)
            : base(new_game, xIn, yIn, hIn, wIn)
        {
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
                this.xCoord = target_rectangle.X;
                this.yCoord = target_rectangle.Y;
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



    }
}
