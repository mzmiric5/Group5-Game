using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Group5.TileEngine;

namespace Group5.Game
{
    public class LevelManager
    {
        public Game1 game;

        private Level current_level;
        private Level previous_level;

        public enum GameState { splash, main_menu, level, pause, };

        private GameState game_state = GameState.level;

        public LevelManager(int level_number, Game1 game)
        {
            this.game = game;
            this.game.set_world(new World());
            this.game.get_world().set_tile_size(32);
            this.current_level = new_level(this.game, 1);
        }

        public LevelManager(Game1 game)
            : this(1, game)
        {
        }

        public Level new_level(Game1 game, int level_number)
        {
            Level level = new Level(game, level_number);
            this.load_level_areas();
            this.makeNPCs(level);
            this.makeItems(level);
            return level;
        }

        public void load_level_areas()
        {
            // TODO: get needed level areas from level xml node, and load all tiles in area. instead for now create some predefined tiles:

            this.game.get_world().add_area(new Area(1,10,10));
            for (int i = 0; i < 10; i++)
            {
                this.game.get_world().get_mAreas()[1].Tiles[i, 0] = new Tile(TileType.StoneWall);
                this.game.get_world().get_mAreas()[1].Tiles[i, 9] = new Tile(TileType.StoneWall);
                if ((i != 0) && (i != 9))
                {
                    this.game.get_world().get_mAreas()[1].Tiles[0, i] = new Tile(TileType.StoneWall);
                    this.game.get_world().get_mAreas()[1].Tiles[9, i] = new Tile(TileType.StoneWall);
                    for (int j = 1; j < 9; j++)
                    {
                        this.game.get_world().get_mAreas()[1].Tiles[j, i] = new Tile(TileType.StoneFloor);
                    }
                }
            }
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
            level.enemies.Add(new Ork(64, 32, 32, 32));
            level.enemies.Add(new Ork(32, 64, 32, 32));
        }

        public void makeItems(Level level)
        {
            /*
            get stuff from xml file
            */

            // todo: change this: for first game iteration make stuff up
            level.items.Add(new Milk(64, 64, 32, 32));
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
            switch (this.game_state)
            {
                case GameState.level:
                    {
                        this.current_level.draw();
                        break;
                    }
            }
        }

        public String tile_type_to_texture_key(TileType tile_type)
        {
            String texture_key = "StoneFloor";

            switch (tile_type)
            {
                case TileType.StoneFloor:
                    {
                        texture_key = "StoneFloor";
                        break;
                    }
                case TileType.StoneWall:
                    {
                        texture_key = "StoneWall";
                        break;
                    }
            }

            return texture_key;
        }
    }
}
