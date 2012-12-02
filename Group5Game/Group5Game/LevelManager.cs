using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Group5.Game
{
    public class LevelManager
    {
        public Game1 game;

        private Level current_level;
        private Level previous_level;

        public LevelManager(int level_number, Game1 game)
        {
            this.game = game;
            this.current_level = new_level(this.game, 1);
            this.game.set_world(new TileEngine.World());
            this.game.get_world().set_tile_size(32);
        }

        public LevelManager(Game1 game)
            : this(1, game)
        {
        }

        public Level new_level(Game1 game, int level_number)
        {
            Level level = new Level(game, level_number);
            this.makeNPCs(level);
            this.makeItems(level);
            return level;
        }

        public void update(GameTime gameTime)
        {
            this.current_level.update(gameTime);
        }

        public Level get_current_level()
        {
            return this.current_level;
        }

        public void set_current_level(Level new_current_level)
        {
            this.current_level = new_current_level;
        }

        public Level get_previous_level()
        {
            return this.previous_level;
        }

        public void set_previous_level(Level new_previous_level)
        {
            this.previous_level = new_previous_level;
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
            foreach (Item item in game.levelManager.get_current_level().player.inventory)
            {
                if (item is Milk)
                {
                    player_has_milk = true;
                }
            }
            return player_has_milk;
        }

        public void draw(GameTime gameTime)
        {
            this.current_level.draw();
        }
    }
}
