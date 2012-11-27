using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Bot;

namespace Group5.Game
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        public SpriteBatch spriteBatch;

        public Dictionary<string, Texture2D> texture_dictionary;

        public static InputState input = new InputState();

        // Data Structure
        public Player player;
        public List<Friend> friends;
        public List<Enemy> enemies;
        public List<Item> items;
        public LevelManager levelManager;

        public Game1()
        {
            friends = new List<Friend>();
            enemies = new List<Enemy>();
            items = new List<Item>();
            
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            texture_dictionary = new Dictionary<string, Texture2D>();
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            
            
            this.levelManager = new LevelManager(this);
            this.player = new Player();
            this.levelManager.makeNPCs(this.friends, this.enemies);
            this.levelManager.makeItems(this.items);
            
            
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            
            // TODO: use this.Content to load your game content here

            texture_dictionary.Add("default_player_texture", this.Content.Load<Texture2D>("textures/default_player_texture"));
            texture_dictionary.Add("milk_texture", this.Content.Load<Texture2D>("textures/milk_texture"));
            texture_dictionary.Add("ork_texture", this.Content.Load<Texture2D>("textures/ork_texture"));

        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();
				
			if (/* InputState.CurrentState == attack */)
				player.attack(enemies);

            // player update
            input.Update();
            if (levelManager.check_victory_condition())
            {
              Exit();
            }

            // world update
            foreach (Friend friend in this.friends)
            {
                //friend.update(this);
            }
            foreach (Enemy enermy in this.enemies)
            {
                //enermy.update(this, gameTime);
            }
            /*foreach (Item item in this.items)
            {
                item.update(this);
            }*/


            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
            
            // draw all items in data structure
            this.player.draw(this);
            foreach (Friend friend in this.friends)
            {
                friend.draw();
            }
            foreach (Enemy enermy in this.enemies)
            {
                enermy.draw();
            }
            foreach (Item item in this.items)
            {
              item.draw();
            }

            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
