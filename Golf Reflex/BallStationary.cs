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
using Microsoft.Xna.Framework.Input.Touch;

namespace Golf_Reflex
{
    class BallStationary : IBallState
    {

        private Rectangle drag;
        private TouchCollection tl = new TouchCollection();

        public BallStationary(Ball b) : base(b)
        {
        }

        //specialised draw method for the state and ends with the generic player draw
        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }

        //specialised enter method for the state and ends with the generic player enter
        public override void Enter()
        {
            base.Enter();
        }

        //specialised exit method for the state and ends with the generic player exit
        public override void Exit()
        {
            base.Exit();
        }


        public override void Update(GameTime gameTime, GraphicsDeviceManager graphics)
        {
            KeyboardState state = Keyboard.GetState();
            //checks space keypress and changes state to jumping
            if (CheckBallTouch(drag, tl))
            {
                //player.stateMachine.Change("Jumping");
            }

            base.HorizonalMovement(state, gameTime, graphics);

            //remains standing when no keypress
            if (state == null)
            {
                //player.stateMachine.Change("Standing");
            }
            base.Update(gameTime, graphics);
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