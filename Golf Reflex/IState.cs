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
    //generic implementation of a state
    interface IState
    {
        void Enter();
        void Exit();
        void Draw(SpriteBatch spriteBatch);
        void Update(GameTime gameTime, GraphicsDeviceManager graphics);
    }
}