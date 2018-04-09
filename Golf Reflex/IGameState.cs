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

namespace Golf_Reflex
{
    class IGameState : IState
    {
        public virtual void Draw(SpriteBatch spriteBatch)
        {
            throw new NotImplementedException();
        }

        public virtual void Enter()
        {
            throw new NotImplementedException();
        }

        public virtual void Exit()
        {
            throw new NotImplementedException();
        }

        public virtual void Update(GameTime gameTime, GraphicsDeviceManager graphics)
        {
            throw new NotImplementedException();
        }
    }
}