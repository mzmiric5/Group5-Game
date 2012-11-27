﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Group5.Game
{
    public class Actor : PhysicsObject
    {
        protected int health, maxHealth, attackDamage;
        protected Direction orientation;
		protected Weapon currentWeapon;
        
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
		
		public void attack(List<Actor> targets)
		{
			// Attack animation
			int yDist, xDist;
			
			foreach (Actor target in targets)
			{
				xDist = Math.Pow((target.returnX() - xCoord), 2);
				yDist = Math.Pow((target.returnY() - yCoord), 2);
				if (Math.Sqrt(xDist + yDist) <= 16)
					if (orientation == UP && target.returnY() - yCoord >= 0 || orientation == DOWN && target.returnY() - yCoord <= 0
						|| orientation == LEFT && target.returnX() - xCoord <= 0 || orientation == RIGHT && target.returnX() - xCoord >= 0)
						target.loseHealth(attackDamage);
			}
		}
			

    	
    }
}
