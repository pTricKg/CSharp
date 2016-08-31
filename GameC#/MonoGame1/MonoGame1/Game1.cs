using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoGame1
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        // declare window constants
        const int WindowWidth = 800;
        const int WindowHeight = 600;

        // bear objects
        TeddyBear bear0;
        TeddyBear bear1;
        TeddyBear bear2;
        
        // draw support
        //Texture2D bear0;
        //Texture2D bear1;
        //Texture2D bear2;

        //Rectangle drawRectangle0;
        //Rectangle drawRectangle1;
        //Rectangle drawRectangle2;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            // resolution to 800 x 600
            graphics.PreferredBackBufferWidth = WindowWidth;
            graphics.PreferredBackBufferHeight = WindowHeight;
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // load bears and draw rectangles
            bear0 = new TeddyBear(Content, @"graphics\teddybear0", 100, 100,
                WindowWidth, WindowHeight);
            bear1 = new TeddyBear(Content, @"graphics\teddybear1", 300, 100,
                WindowWidth, WindowHeight);
            bear2 = new TeddyBear(Content, @"graphics\teddybear2", 500, 100,
                WindowWidth, WindowHeight);

            //bear0 = Content.Load<Texture2D>(@"graphics\teddybear0");
            //drawRectangle0 = new Rectangle(150, 100, bear0.Width, bear0.Height);

            //bear1 = Content.Load<Texture2D>(@"graphics\teddybear1");
            //drawRectangle1 = new Rectangle(300, 200, bear0.Width, bear0.Height);

            //bear2 = Content.Load<Texture2D>(@"graphics\teddybear2");
            //drawRectangle2 = new Rectangle(400, 300, bear0.Width, bear0.Height);

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            bear0.Update();
            bear1.Update();
            bear2.Update();

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            
            // draw bears
            spriteBatch.Begin();

            // bear draws itself form TeddyBear Class
            bear0.Draw(spriteBatch);
            bear1.Draw(spriteBatch);
            bear2.Draw(spriteBatch);

            //spriteBatch.Draw(bear0, drawRectangle0, Color.White);
            //spriteBatch.Draw(bear1, drawRectangle1, Color.White);
            //spriteBatch.Draw(bear2, drawRectangle2, Color.White);


            spriteBatch.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
