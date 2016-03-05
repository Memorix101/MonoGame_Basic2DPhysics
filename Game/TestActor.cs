using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace MonoGame_Basic2DPhysics
{
    class TestActor : Sprite
    {
       public static BoxCollider bxcollider;

        public TestActor(ContentManager Content, Vector2 p)
        {
            position = p;
            rect = new Rectangle(416, 352, 32, 32);
            bxcollider = new BoxCollider(this);
            bxcollider.rect = rect;
            texture = Content.Load<Texture2D>("kenney_32x32");
        }

        public override void Update(GameTime gameTime)
        {              
            bxcollider.Update();

            bxcollider.Collide(bxcollider, Player.bxcollider);

        //    base.Update(gameTime);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            //  spriteBatch.Draw(texture, position, rect, Color.White);
            spriteBatch.Draw(texture, position, rect, Color.White);
            bxcollider.DebugDraw(spriteBatch);
        }
    }
}
