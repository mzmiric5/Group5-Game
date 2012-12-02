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
            // draw all items in data structure
            this.player.draw(this.game);
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
