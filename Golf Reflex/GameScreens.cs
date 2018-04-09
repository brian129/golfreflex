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

namespace Golf_Reflex
{
    class GameScreens //Class for handling different screens
    {
        public SpriteFont font;

        public StateMachine<IGameState> stateMachine;

        //constructor 
        public GameScreens()
        {
            stateMachine = new StateMachine<IGameState>(new GameStart(this));
            stateMachine.Add("Start", new GameStart(this));
            stateMachine.Add("Playing", new GamePlaying(this));
            stateMachine.Add("Over", new GameOver(this));
        }

        //This function gets the monogame content manager to get stuff
        public void LoadContent(ContentManager content)
        {
            font = content.Load<SpriteFont>("font");
        }

        //This function is used to draw the player (sprite)
        public void Draw(SpriteBatch spriteBatch)
        {
            stateMachine.currentState.Draw(spriteBatch);
        }

        //This function is used to update the players(sprite) position on the screen dependent on the input 
        public void Update(GameTime gameTime, GraphicsDeviceManager graphics)
        {
            stateMachine.currentState.Update(gameTime, graphics);
        }
    }
}