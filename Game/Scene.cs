using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGame_Basic2DPhysics
{
    static class Scene
    {
        public static List<Sprite> entityList = new List<Sprite>();

        public static void Update(GameTime gameTime)
        {
            foreach (var s in entityList)
                s.Update(gameTime);
        }

        public static void Draw(SpriteBatch spriteBatch)
        {
            foreach (var s in entityList)
                s.Draw(spriteBatch);
        }

    }
}
