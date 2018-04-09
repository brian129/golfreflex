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
    class Ball : Game
    {
        public Texture2D sprite;
        public Vector2 size;
        public Vector2 position;
        public Vector2 origin;

        public StateMachine<IBallState> stateMachine;

        public Ball(Vector2 position, Vector2 size)
        {
            this.position = position;
            this.size = size;

            //setting the origin point to the center of the texture
            origin = new Vector2(size.X / 2, size.Y / 2);

            stateMachine = new StateMachine<IBallState>(new BallStationary(this));
            stateMachine.Add("Stationary", new BallStationary(this));
            stateMachine.Add("Rolling", new BallRolling(this));
            stateMachine.Add("Bounce", new BallBounce(this));
            stateMachine.Add("Stopped", new BallStopped(this));
        }


        //This function gets the monogame content manager to get stuff
        public void LoadContent(ContentManager content)
        {
            sprite = content.Load<Texture2D>("ball");
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


        //checks if player is touching the ball
        public bool CheckBallTouch(Rectangle target, TouchCollection touchCollection)
        {
            if (touchCollection.Count > 0)
            {
                foreach (var touch in touchCollection)
                {
                    if (target.Contains(touch.Position))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}