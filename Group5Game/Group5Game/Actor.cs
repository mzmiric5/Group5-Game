using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Group5.Game
{
    public class Actor : PhysicsObject
    {

        
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

    	
    }
}
