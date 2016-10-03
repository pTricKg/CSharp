using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using TeddyMineExplosion;

namespace ProgrammingAssignment5
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        // window dimensions
        const int WindowWidth = 800;
        const int WindowHeight = 600;

        // teddy support
        Texture2D teddySprite;
        Random rand = new Random();

        // spawning support
        int totalSpawnDelayMilliseconds = 3000;
        int elapsedSpawnDelayMilliseconds = 0;

        // mine support
        Texture2D mineSprite;
        List<Mine> mines = new List<Mine>();

        // saved for efficiency
        Texture2D explosionSprite;

        // game objects
        List<TeddyBear> bears = new List<TeddyBear>();
        List<Explosion> explosions = new List<Explosion>();

        // click processing
        bool leftClickStarted = false;
        bool leftButtonReleased = true;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            
            graphics.PreferredBackBufferHeight = WindowHeight;
            graphics.PreferredBackBufferWidth = WindowWidth;

            // set mouse visible
            IsMouseVisible = true;

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

            // load sprites
            teddySprite = Content.Load<Texture2D>(@"graphics/teddybear");
             
            mineSprite = Content.Load<Texture2D>(@"graphics/mine");
            
            explosionSprite = Content.Load<Texture2D>(@"graphics/explosion");

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
            // spawn teddies
            elapsedSpawnDelayMilliseconds += gameTime.ElapsedGameTime.Milliseconds;
            if (elapsedSpawnDelayMilliseconds > totalSpawnDelayMilliseconds)
            {
                elapsedSpawnDelayMilliseconds = 0;
                totalSpawnDelayMilliseconds = rand.Next(4) * 1000;
                // set velocity
                float Xvelocity = (float)rand.NextDouble() - 0.5f;
                float Yvelocity = (float)rand.NextDouble() - 0.5f;
                bears.Add(new TeddyBear(teddySprite,
                    new Vector2(Xvelocity, Yvelocity),
                    WindowWidth, WindowHeight));
            }
            // update bears
            foreach (TeddyBear teddyBear in bears)
            {
                teddyBear.Update(gameTime);
            }
            // mouse stuff
            MouseState mouse = Mouse.GetState();
            if (mouse.LeftButton == ButtonState.Pressed &&
                leftButtonReleased)
            {
                leftClickStarted = true;
                leftButtonReleased = false;
            }
            else if (mouse.LeftButton == ButtonState.Released)
            {
                leftButtonReleased = true;

                if (leftClickStarted)
                {
                    leftClickStarted = false;
                    
                    Mine mine = new Mine(mineSprite, mouse.X, mouse.Y);
                    mines.Add(mine);

                }
            }

            // check for collisions
            foreach (Mine mine in mines)
            {
                if (mine.Active)
                {
                    foreach (TeddyBear bear in bears)
                    {
                        if (bear.Active)
                        {
                            if (bear.CollisionRectangle.Intersects(mine.CollisionRectangle))
                            {
                                bear.Active = false;
                                mine.Active = false;
                                explosions.Add(new Explosion(explosionSprite, mine.CollisionRectangle.Center.X, mine.CollisionRectangle.Center.Y));
                            }
                        }
                    }
                }
            }

            //update explosions
            foreach (Explosion explosion in explosions)
            {
                explosion.Update(gameTime);
            }
            // remove dead teddies
            for (int i = bears.Count - 1; i >= 0; i--)
            {
                if (!bears[i].Active)
                {
                    bears.RemoveAt(i);
                }
            }
            // remove dead mines
            for (int i = mines.Count - 1; i >= 0; i--)
            {
                if (!mines[i].Active)
                {
                    mines.RemoveAt(i);
                }
            }
            // remove dead explosions
            for (int i = explosions.Count - 1; i >= 0; i--)
            {
                if (!explosions[i].Playing)
                {
                    explosions.RemoveAt(i);
                }
            }
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            // draw game objects
            spriteBatch.Begin();

            foreach (TeddyBear teddyBear in bears)
            {
                teddyBear.Draw(spriteBatch);
            }
            foreach (Mine mine in mines)
            {
                mine.Draw(spriteBatch);
            }
            foreach (Explosion explosion in explosions)
            {
                explosion.Draw(spriteBatch);
            }
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
