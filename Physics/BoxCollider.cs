using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace MonoGame_Basic2DPhysics
{

    class BoxCollider
    {

        public Rectangle rect;
        public Vector2 position;
        public Sprite sprite;
        Texture2D texture;
        Color color = Color.Purple;
        int strokeDepth = 2;
        float alpha = 1f;

        public BoxCollider(Sprite s)
        {
            sprite = s;
            texture = Game1.content.Load<Texture2D>("rect");
        }

        public Rectangle SpriteBoundingBox
        {
            get
            {
                return new Rectangle((int)position.X, (int)position.Y, rect.Width, rect.Height);
            }
        }

        public void Update()
        {
            position = sprite.position;
        }

        public void Collide(BoxCollider me, BoxCollider other)
        {
            //source: https://developer.mozilla.org/en-US/docs/Games/Techniques/2D_collision_detection

            var rect1 = me.SpriteBoundingBox;
            var rect2 = other.SpriteBoundingBox;

            if (rect1.X < rect2.X + rect2.Width && rect1.X + rect1.Width > rect2.X && rect1.Y < rect2.Y + rect2.Height && rect1.Height + rect1.Y > rect2.Y)
            {
                // collision detected!
                color = Color.LawnGreen;
            }
            else
            {
                color = Color.Blue;
            }
        }

        public bool OnTriggerEnter(BoxCollider other)
        {
            if (SpriteBoundingBox.Intersects(other.SpriteBoundingBox))
            {
                return true;
            }

            return false;
        }

        public virtual void DebugDraw(SpriteBatch spriteBatch)
        {
            //spriteBatch.Draw(texture, SpriteBoundingBox, new Rectangle(0, 0, texture.Width, texture.Height), color*0.5f);
            spriteBatch.Draw(texture, new  Rectangle((int)position.X, (int)position.Y, rect.Width, strokeDepth), new Rectangle(0, 0, 5, 5), color * alpha); // Top
            spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, strokeDepth, rect.Height), new Rectangle(0, 0, 5, 5), color * alpha); // Left
            spriteBatch.Draw(texture, new Rectangle((int)position.X + rect.Width, (int)position.Y, strokeDepth, rect.Height), new Rectangle(0, 0, 5, 5), color * alpha);  //Right
            spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y + rect.Height, rect.Width, strokeDepth), new Rectangle(0, 0, 5, 5), color * alpha); // Down
        }
    }
}
