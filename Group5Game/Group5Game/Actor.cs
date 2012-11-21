using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Group5.Game
{
    public class Actor : PhysicsObject
    {
        protected int health, maxHealth;
        protected Direction orientation;
        
        public Actor (double xIn, double yIn, double hIn, double wIn)
    	               : base(xIn, yIn, hIn, wIn)
    	{	
    	}

        public enum Direction { Up, Down, Left, Right };

        public void move(Direction direction, int distance)
        {
            // TODO: add collision detection!!!
            if (direction == Direction.Up)
            {
                this.yCoord += distance;
            }
            else if (direction == Direction.Down)
            {
                this.yCoord -= distance;
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

    	
    }
}
