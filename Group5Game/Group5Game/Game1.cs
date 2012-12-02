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
        
        public LevelManager levelManager;

        private Level current_level;
        private Level previous_level;

        public Game1()
        {
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

            this.current_level = this.levelManager.new_level(this, 1);

            base.Initialize();
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

            this.current_level.update(gameTime);

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Magenta);
            spriteBatch.Begin();

            this.current_level.draw();

            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
