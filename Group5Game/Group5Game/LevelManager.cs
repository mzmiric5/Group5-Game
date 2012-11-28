using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Group5.Game
{
    public class LevelManager
    {

        public String name;
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
            this.name = "level 0";
            this.game = game;
        }

        public void makeNPCs(List<Friend> friends, List<Enemy> enemies)
        {
            /*
            get stuff from xml file
            */

            // todo: change this: make stuff up for first game iteration
            enemies.Add(new Ork(0.0d, 32.0d, 32.0d, 32.0d));
            enemies.Add(new Ork(32.0d, 0.0d, 32.0d, 32.0d));
        }

        public void makeItems(List<Item> items)
        {
            /*
            get stuff from xml file
            */

            // todo: change this: for first game iteration make stuff up
            items.Add(new Milk(64.0d, 64.0d, 32.0d, 32.0d));
        }

        public bool check_victory_condition()
        {
            // todo: change this: for first game get player to pick up milk
            bool player_has_milk = false;
            foreach (Item item in game.player.inventory)
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
