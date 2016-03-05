using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;



namespace MonoGame_Basic2DPhysics
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        public static GraphicsDeviceManager graphics;
        public static ContentManager content;
        SpriteBatch spriteBatch;

     //   Texture2D Ground;
     //   Rectangle GroundRect = new Rectangle(928,544, 16*32, 8*32);

        

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            content = Content;
            graphics.PreferredBackBufferWidth = 800;
            graphics.PreferredBackBufferHeight = 600;
        }

        protected override void Initialize()
        {
            Scene.entityList.Add(new Floor(Content,  new Vector2(graphics.GraphicsDevice.Viewport.Width / 2 - 16*32, graphics.GraphicsDevice.Viewport.Width / 2)));
            Scene.entityList.Add(new Player(Content, new Vector2(graphics.GraphicsDevice.Viewport.Width / 2 - 32 / 2, graphics.GraphicsDevice.Viewport.Width / 2 - 32 * 5)));
            Scene.entityList.Add(new TestActor(Content, new Vector2 (graphics.GraphicsDevice.Viewport.Width / 2 - 32 * 5, graphics.GraphicsDevice.Viewport.Width / 2 - 32 * 5)));

            base.Initialize();
        }

        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // Ground = Content.Load<Texture2D>("kenney_32x32");
        }

        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            Scene.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
     //       spriteBatch.Draw(Ground, new Vector2(graphics.GraphicsDevice.Viewport.Width / 2 - GroundRect.Width/2, graphics.GraphicsDevice.Viewport.Width / 2), GroundRect, Color.White);
            Scene.Draw(spriteBatch);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
