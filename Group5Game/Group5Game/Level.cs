using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Group5.TileEngine;
using System.Diagnostics;

namespace Group5.Game
{
    public class Level
    {
        private Game1 game;
        
        private int level_number = 1;
        public Player player;
        public List<Friend> friends;
        public List<Enemy> enemies;
        public List<Item> items;

        private int current_area_index = 1;
        
        public Level(Game1 new_game)
        {
            this.game = new_game;
            this.player = new Player(this.game);
            this.friends = new List<Friend>();
            this.enemies = new List<Enemy>();
            this.items = new List<Item>();
        }

        public Level(Game1 new_game, int new_level_number)
            : this(new_game)
        {
            this.level_number = new_level_number;
        }

        public int get_level_number()
        {
            return this.level_number;
        }

        public void set_level_number(int new_level_number)
        {
            this.level_number = new_level_number;
        }

        public bool is_rectangle_unblocked(Rectangle target_rectangle)
        {
            for (int i = 0; i < target_rectangle.Width; i++)
            {
                for (int j = 0; j < target_rectangle.Height; j++)
                {
                    if (this.game.levelManager.is_tile_type_passthroughable(this.game.get_world().get_mAreas()[this.current_area_index].Tiles[target_rectangle.X + i, target_rectangle.Y + j].Type) == false)
                    {
                        return false;
                    }
                }
            }

            for (int i = 0; i < this.game.levelManager.get_current_level().friends.Count(); i++)
            {
                if (this.game.levelManager.get_current_level().friends[i].get_volume_retangle().Intersects(target_rectangle) == true)
                {
                    return false;
                }
            }

            for (int i = 0; i < this.game.levelManager.get_current_level().enemies.Count(); i++)
            {
                if (this.game.levelManager.get_current_level().enemies[i].get_volume_retangle().Intersects(target_rectangle) == true)
                {
                    return false;
                }
            }

            for (int i = 0; i < this.game.levelManager.get_current_level().items.Count(); i++)
            {
                if (this.game.levelManager.get_current_level().items[i].get_volume_retangle().Intersects(target_rectangle) == true)
                {
                    return false;
                }
            }

            if (this.game.levelManager.get_current_level().player.get_volume_retangle().Intersects(target_rectangle) == true)
            {
                return false;
            }

            return true;
        }

        public void update(GameTime gameTime)
        {
            if (this.game.levelManager.check_victory_condition())
            {
                this.game.Exit();
            }

            this.player.update(this.game, gameTime);

            foreach (Friend friend in this.friends)
            {
                friend.update();
            }

            foreach (Enemy enermy in this.enemies)
            {
                enermy.update(this.game, gameTime);
            }

            foreach (Item item in this.items)
            {
                item.update();
            }

        }

        public void draw()
        {
            for (int i = 0; i < this.game.get_world().get_mAreas()[this.current_area_index].Tiles.GetLength(0); i++)
            {
                for (int j = 0; j < this.game.get_world().get_mAreas()[this.current_area_index].Tiles.GetLength(1); j++)
                {
                    Rectangle tile_rectangle = new Rectangle(this.game.get_world().get_tile_size() * i, this.game.get_world().get_tile_size() * j, this.game.get_world().get_tile_size(), this.game.get_world().get_tile_size());
                    if (Camera.ObjectIsVisible(tile_rectangle) == true)
                    {
                        game.spriteBatch.Draw(game.texture_dictionary[this.game.levelManager.tile_type_to_texture_key(this.game.get_world().get_mAreas()[this.current_area_index].Tiles[i,j].Type)], tile_rectangle, Color.White);
                    }
                }
            }

            Rectangle player_rectangle = new Rectangle(this.game.get_world().get_tile_size() * this.player.returnX(), this.game.get_world().get_tile_size() * this.player.returnY(), this.game.get_world().get_tile_size() * this.player.returnW(), this.game.get_world().get_tile_size() * this.player.returnH());
            if (Camera.ObjectIsVisible(player_rectangle) == true)
            {
                game.spriteBatch.Draw(game.texture_dictionary[this.player.get_texture_key()], player_rectangle, Color.White);
            }

            // TODO: old style below, needs changing to same as above
            foreach (Friend friend in this.friends)
            {
                friend.draw(this.game);
            }
            foreach (Enemy enermy in this.enemies)
            {
                enermy.draw(this.game);
            }
            foreach (Item item in this.items)
            {
                item.draw(this.game);
            }
        }
    }
}
