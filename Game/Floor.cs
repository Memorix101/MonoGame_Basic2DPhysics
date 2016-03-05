using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace MonoGame_Basic2DPhysics
{
    class Floor : Sprite
    {
        public static BoxCollider bxcollider;

        public Floor(ContentManager Content, Vector2 p)
        {
            position = p;
            rect = new Rectangle(928, 544, 16 * 32, 8 * 32);
            //size = rect;
            bxcollider = new BoxCollider(this);
            bxcollider.rect = rect;
            texture = Content.Load<Texture2D>("kenney_32x32");
        }

        public override void Update(GameTime gameTime)
        {

                bxcollider.Update();
         
                     if (bxcollider.OnTriggerEnter(Player.bxcollider))
                     {
                         Console.WriteLine("Collide");
                     }
          

            base.Update(gameTime);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            //  spriteBatch.Draw(texture, position, rect, Color.White);
            spriteBatch.Draw(texture, position, rect, Color.White);
            bxcollider.DebugDraw(spriteBatch);
        }
    }
}
