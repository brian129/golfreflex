using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input.Touch;

namespace Golf_Reflex
{
    class GameStart : IGameState
    {
        private SpriteFont font;
        private Texture2D texture;

        // Text to display to user
        string startText = "Tap to Start";
        
        public Vector2 Position = new Vector2(100,100);

        public GameStart()
        {
            
        }

        //This function gets the monogame content manager to get stuff
        public void LoadContent(ContentManager content)
        {
            font = content.Load<SpriteFont>("font");
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(font, startText,Position, Color.Black);
        }

        public override void Update(GameTime gameTime, GraphicsDeviceManager graphics)
        {
            TouchCollection tc = new TouchCollection();
            //check for one touch then change state
            if(tc.Count > 0)
            {

            }
        }

    }
}