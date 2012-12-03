using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

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
        
        public Level(Game1 new_game)
        {
            this.game = new_game;
            this.player = new Player();
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
            // TODO: draw tiles from tile engine here
            
            Rectangle player_rectangle = new Rectangle(Convert.ToInt32(this.player.returnX()), Convert.ToInt32(this.player.returnY()), Convert.ToInt32(this.player.returnW()), Convert.ToInt32(this.player.returnH()));

            if (Camera.ObjectIsVisible(player_rectangle) == true)
            {
                game.spriteBatch.Draw(game.texture_dictionary[this.player.get_texture_key()], player_rectangle, Color.White);
            }

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
