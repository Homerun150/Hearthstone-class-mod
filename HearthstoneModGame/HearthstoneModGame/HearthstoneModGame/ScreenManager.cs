using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace HearthstoneModGame
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class ScreenManager : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        //Menu setup
        MainMenu menu;
        Texture2D menuBG;
        Texture2D menuPAB;
        Texture2D menuRCB;
        Texture2D menuEB;

        public string currentScreen = "MainMenu";
        public string previousScreen = "";

        //Card review setup
        //Card list check
        //cards 1-26 are main card minions
        Texture2D Card1;
        Texture2D Card2;
        Texture2D Card3;
        Texture2D Card4;
        Texture2D Card5;
        Texture2D Card7;
        Texture2D Card8;
        Texture2D Card9;
        Texture2D Card10;
        Texture2D Card11;
        Texture2D Card12;
        Texture2D Card13;
        Texture2D Card14;
        Texture2D Card15;
        Texture2D Card16;
        Texture2D Card17;
        Texture2D Card18;
        Texture2D Card19;
        Texture2D Card20;
        Texture2D Card21;
        Texture2D Card22;
        Texture2D Card23;
        Texture2D Card24;
        Texture2D Card25;
        Texture2D Card26;

        //Cards 27 - 29 are spell cards
        Texture2D Card27;
        Texture2D Card28;
        Texture2D Card29;

        //cards 30 - 40 are minor minions "summon by other minions"
        Texture2D Card30;
        Texture2D Card31;
        Texture2D Card32;
        Texture2D Card33;
        Texture2D Card34;
        Texture2D Card35;
        Texture2D Card36;
        Texture2D Card37;
        Texture2D Card38;
        Texture2D Card39;
        Texture2D Card40;

        //Cards 41 - 46 are spell minions "summon by spells"
        Texture2D Card41;
        Texture2D Card42;
        Texture2D Card43;
        Texture2D Card44;
        Texture2D Card45;
        Texture2D Card46;

        //card 47 are special cards "former classmates"
        Texture2D Card47;

        //buttons and background
        Texture2D CRLB;
        Texture2D CRENB;
        Texture2D CRAB;
        Texture2D CREXB;
        Texture2D CRRAB;
        Texture2D CRLAB;
        Texture2D CRBG;

        //PlayAI setup
        Texture2D PAIBG;
        Texture2D PAIMRBH;
        Texture2D PAIMRDH;
        Texture2D PAIECB;

        public SoundEffect buttonClicked;


        public ScreenManager()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
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
            graphics.IsFullScreen = false;
            graphics.PreferredBackBufferHeight = 720;
            graphics.PreferredBackBufferWidth = 1080;
            this.IsMouseVisible = true;
            graphics.ApplyChanges();

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

            // TODO: use this.Content to load your game content here
            menuBG = Content.Load<Texture2D>("background fix");
            menuPAB = Content.Load<Texture2D>("play-AI-fix");
            menuRCB = Content.Load<Texture2D>("review-card-fix");
            menuEB = Content.Load<Texture2D>("Exit");

            menu = new MainMenu(menuBG, menuPAB, menuRCB, menuEB);
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
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
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // TODO: Add your update logic here
            if (currentScreen == "MainMenu")
            {
                menu.Update();
                if (menu.pAButtonIsClicked == true)
                {
                    previousScreen = currentScreen;
                    currentScreen = "PlayAIMenu";
                    this.Exit();
                }
                else if (menu.rButtonIsClicked == true)
                {
                    previousScreen = currentScreen;
                    currentScreen = "cardReview";
                    this.Exit();
                }
                else if (menu.eButtonIsClicked)
                {
                    this.Exit();
                }
                else
                {

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
            if (currentScreen == "MainMenu")
            {
                menu.Draw(spriteBatch);
            }
            
            if (currentScreen == "playAI")
            {
                
            }

            if (currentScreen == "cardReview")
            
            base.Draw(gameTime);
        }
    }
}
