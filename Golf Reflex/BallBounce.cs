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
    class BallBounce : IBallState
    {
        public BallBounce(Ball b) : base(b)
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
            //base.Update(gameTime, graphics);
        }
    }
}