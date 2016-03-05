using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace MonoGame_Basic2DPhysics
{
    class Sprite
    {
        public Vector2 position;
        public Texture2D texture;
        public Rectangle rect;    
    
        public Sprite()
        {
                   
        }

        public virtual void Update(GameTime gameTime)
        {
            //if(Scene.entityList.Count > 0)
      //      AABB.SolveCollisions(collider, Scene.entityList, new Vector2(Game1.graphics.GraphicsDevice.Viewport.Width, Game1.graphics.GraphicsDevice.Viewport.Height));
     //       p = collider.position;
      //      Console.WriteLine("twtwt" + p);
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, rect, Color.White);
        }
    }
}
