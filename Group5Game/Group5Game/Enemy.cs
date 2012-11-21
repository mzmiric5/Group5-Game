using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Group5.Game
{
    public class Enemy : NPC
    {
        public bool aggresive = false;
        
        public Enemy (double xIn, double yIn, double hIn, double wIn)
    	               : base(xIn, yIn, hIn, wIn)
    	{	
    	}

        public void update(Game1 game)
        {
            bool has_moved = false;
            if (this.aggresive == true)
            {
                // if player is above enemy && player is in sight of enemy
                if ((game.player.returnY() > this.returnY()) && (this.returnY() + this.returnH() + this.get_sight() >= game.player.returnY()))
                {
                    // TODO: move towards player
                    has_moved = true;
                }
                // if player is below enemy && player is in sight of enemy
                else if ((game.player.returnY() < this.returnY()) && (this.returnY() - this.get_sight() <= game.player.returnY() + game.player.returnH()))
                {
                    // TODO: move towards player
                    has_moved = true;
                }
                // if player is right of enemy && player is in sight of enemy
                else if ((game.player.returnX() > this.returnX()) && (this.returnX() + this.returnW() + this.get_sight() >= game.player.returnX()))
                {
                    // TODO: move towards player
                    has_moved = true;
                }
                // player is left of enemy && player is in sight of enemy
                else if ((game.player.returnX() < this.returnX()) && (this.returnX() - this.get_sight() <= game.player.returnX() + game.player.returnW()))
                {
                    // TODO: move towards player
                    has_moved = true;
                }
            }
            if (has_moved == false)
            {
                // TODO: move in a random direction
            }

        }
    	
    }
}
