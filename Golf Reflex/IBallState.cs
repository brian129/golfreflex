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
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Golf_Reflex
{
    class IBallState : IState
    {
        public Ball ball;

        public IBallState(Ball b)
        {
            ball = b;
        }

        //generic drawing for each player state  
        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(ball.sprite, new Rectangle((int)(ball.position.X - ball.origin.X),(int)(ball.position.Y - ball.origin.Y), (int)ball.size.X, (int)ball.size.Y), Color.White);
        }

        //generic enter code for player state
        public virtual void Enter()
        {
        }

        //generic exit code for player state
        public virtual void Exit()
        {
        }

        //generic update code for player state
        public virtual void Update(GameTime gameTime, GraphicsDeviceManager graphics)
        {
        }

        //defines generic left & right movements with all state
        public void HorizonalMovement(KeyboardState state, GameTime gameTime, GraphicsDeviceManager graphics)
        {
            //the player (sprite) moves right 
            if (state.IsKeyDown(Keys.D))
            {
                //player.position.X += 1 * gameTime.ElapsedGameTime.Milliseconds;
            }
            //the player (sprite) moves left 
            else if (state.IsKeyDown(Keys.A))
            {
                //player.position.X -= 1 * gameTime.ElapsedGameTime.Milliseconds;
            }
        }
    }
}