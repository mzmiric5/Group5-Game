using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Group5.Game
{
    public class LevelManager
    {
        public Game1 game;

        public LevelManager(Game1 game)
            : this(0, game)
        {
        }

        public LevelManager(int level_number, Game1 game)
        {
            // todo: use level_number to read an xml file
            /*
            xml file contains information about the level which the LevelManager then handles. 
            */
            this.game = game;
        }

        public Level new_level(Game1 game, int level_number)
        {
            Level level = new Level(game, level_number);
            this.makeNPCs(level);
            this.makeItems(level);
            return level;
        }

        public void makeNPCs(Level level)
        {
            /*
            get stuff from xml file
            */

            // todo: change this: make stuff up for first game iteration
            level.enemies.Add(new Ork(0.0d, 32.0d, 32.0d, 32.0d));
            level.enemies.Add(new Ork(32.0d, 0.0d, 32.0d, 32.0d));
        }

        public void makeItems(Level level)
        {
            /*
            get stuff from xml file
            */

            // todo: change this: for first game iteration make stuff up
            level.items.Add(new Milk(64.0d, 64.0d, 32.0d, 32.0d));
        }

        public bool check_victory_condition()
        {
            // todo: change this: for first game get player to pick up milk
            bool player_has_milk = false;
            foreach (Item item in game.get_current_level().player.inventory)
            {
                if (item is Milk)
                {
                    player_has_milk = true;
                }
            }
            return player_has_milk;
        }
    }
}
