using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;


namespace MonoGame_Basic2DPhysics
{
    class Player : Sprite
    {
        public static BoxCollider bxcollider;

        public Player(ContentManager Content, Vector2 pos)
        {
            position = pos;
            rect = new Rectangle(512, 608, 32, 32);;
            bxcollider = new BoxCollider(this);
            bxcollider.rect = rect;
            texture = Content.Load<Texture2D>("kenney_32x32");
        }

        public override void Update(GameTime gameTime)
        {
            bxcollider.Update();

            //  bxcollider.Collide(this, TestActor.bxcollider);
            bxcollider.Collide(bxcollider, TestActor.bxcollider);

            if (Keyboard.GetState().IsKeyDown(Keys.A))
                position  = new Vector2(position.X - 5, position.Y);

            if (Keyboard.GetState().IsKeyDown(Keys.D))
                position = new Vector2(position.X + 5, position.Y);


            if (Keyboard.GetState().IsKeyDown(Keys.W))
                position = new Vector2(position.X, position.Y - 5);

            if (Keyboard.GetState().IsKeyDown(Keys.S))
                position = new Vector2(position.X, position.Y + 5);

            base.Update(gameTime);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            //  spriteBatch.Draw(texture, position, rect, Color.White);
            spriteBatch.Draw(texture, bxcollider.position, rect, Color.White);
            bxcollider.DebugDraw(spriteBatch);
        }
    }
}
