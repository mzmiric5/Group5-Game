using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Group5.Game
{
    public class Actor : PhysicsObject
    {
        private int movement_frequency = 100;
        private int sight = 128;
        
        public Actor (double xIn, double yIn, double hIn, double wIn)
    	               : base(xIn, yIn, hIn, wIn)
    	{	
    	}

        protected enum Direction { Up, Down, Left, Right };

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
    	
    }
}
