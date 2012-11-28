using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Group5.Game
{
    public class Actor : PhysicsObject
    {
        protected int health, maxHealth, attackDamage;
        public enum Direction { Up, Down, Left, Right };
        protected Direction orientation;
        private int movement_distance;

        public Actor(double xIn, double yIn, double hIn, double wIn)
            : base(xIn, yIn, hIn, wIn)
        {
        }

        public void move(Direction direction)
        {
            this.move(direction, this.get_movement_distance());
        }

        public void move(Direction direction, int distance)
        {
            // TODO: add collision detection!!!
            if (direction == Direction.Up)
            {
                this.yCoord -= distance;
            }
            else if (direction == Direction.Down)
            {
                this.yCoord += distance;
            }
            else if (direction == Direction.Right)
            {
                this.xCoord += distance;
            }
            else if (direction == Direction.Left)
            {
                this.xCoord -= distance;
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
