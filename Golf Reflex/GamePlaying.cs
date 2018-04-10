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
    class GamePlaying : IGameState
    {
        public GamePlaying(GameScreens gs, SpriteFont font) : base(gs)
        {
        }
    }
}