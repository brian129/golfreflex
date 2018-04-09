using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Input.Touch;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Audio;
using System;


namespace Golf_Reflex
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class GolfReflex : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D ball;
        Texture2D logo;
        Song Menu;

        // Text to display to user
        string gameOverText = "Game Over";
        string tapToStartText = "Tap to Start";
        string scoreText = "Score : {0}";


        public GolfReflex()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            graphics.IsFullScreen = true;
            graphics.PreferredBackBufferWidth = 1080;
            graphics.PreferredBackBufferHeight = 1920;
            graphics.SupportedOrientations = DisplayOrientation.Portrait;
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
            //ball = Content.Load<Texture2D>("ball");

            logo = Content.Load<Texture2D>("logo");
            Menu = Content.Load<Song>("Menu");

        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
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
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // Calculate the center of the screen
            var center = graphics.GraphicsDevice.Viewport.Bounds.Center.ToVector2();

            // Calculate half the width of the screen
            var half = graphics.GraphicsDevice.Viewport.Height / 2;

            // Calculate aspect ratio of the MonkeyTap logo
            var aspect = (float)logo.Height / logo.Width;

            // Calculate position of logo on screen
            var rect = new Rectangle((int)center.X - (half / 2), 0, half, (int)(half * aspect));

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            spriteBatch.Draw(logo, destinationRectangle: rect, Color.White);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
