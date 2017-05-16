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
        cardReview cardreview;
        //Card list check
        //cards 1-26 are main card minions
        Texture2D Card1;
        SoundEffect Card1IntroMusic;
        SoundEffect Card1EntrenceQuote;
        SoundEffect Card1AttackQuote;
        SoundEffect Card1AbilityQuote;
        SoundEffect Card1DeathQuote;

        Texture2D Card2;
        SoundEffect Card2IntroMusic;
        SoundEffect Card2EntrenceQuote;
        SoundEffect Card2AttackQuote;
        SoundEffect Card2AbilityQuote;
        SoundEffect Card2DeathQuote;

        Texture2D Card3;
        SoundEffect Card3IntroMusic;
        SoundEffect Card3EntrenceQuote;
        SoundEffect Card3AttackQuote;
        SoundEffect Card3AbilityQuote;
        SoundEffect Card3DeathQuote;

        Texture2D Card4;
        SoundEffect Card4IntroMusic;
        SoundEffect Card4EntrenceQuote;
        SoundEffect Card4AttackQuote;
        SoundEffect Card4AbilityQuote;
        SoundEffect Card4DeathQuote;

        Texture2D Card5;
        SoundEffect Card5IntroMusic;
        SoundEffect Card5EntrenceQuote;
        SoundEffect Card5AttackQuote;
        SoundEffect Card5AbilityQuote;
        SoundEffect Card5DeathQuote;

        Texture2D Card6;
        SoundEffect Card6IntroMusic;
        SoundEffect Card6EntrenceQuote;
        SoundEffect Card6AttackQuote;
        SoundEffect Card6AbilityQuote;
        SoundEffect Card6DeathQuote;

        Texture2D Card7;
        SoundEffect Card7IntroMusic;
        SoundEffect Card7EntrenceQuote;
        SoundEffect Card7AttackQuote;
        SoundEffect Card7AbilityQuote;
        SoundEffect Card7DeathQuote;

        Texture2D Card8;
        SoundEffect Card8IntroMusic;
        SoundEffect Card8EntrenceQuote;
        SoundEffect Card8AttackQuote;
        SoundEffect Card8AbilityQuote;
        SoundEffect Card8DeathQuote;

        Texture2D Card9;
        SoundEffect Card9IntroMusic;
        SoundEffect Card9EntrenceQuote;
        SoundEffect Card9AttackQuote;
        SoundEffect Card9AbilityQuote;
        SoundEffect Card9DeathQuote;

        Texture2D Card10;
        SoundEffect Card10IntroMusic;
        SoundEffect Card10EntrenceQuote;
        SoundEffect Card10AttackQuote;
        SoundEffect Card10AbilityQuote;
        SoundEffect Card10DeathQuote;

        Texture2D Card11;
        SoundEffect Card11IntroMusic;
        SoundEffect Card11EntrenceQuote;
        SoundEffect Card11AttackQuote;
        SoundEffect Card11AbilityQuote;
        SoundEffect Card11DeathQuote;

        Texture2D Card12;
        SoundEffect Card12IntroMusic;
        SoundEffect Card12EntrenceQuote;
        SoundEffect Card12AttackQuote;
        SoundEffect Card12AbilityQuote;
        SoundEffect Card12DeathQuote;

        Texture2D Card13;
        SoundEffect Card13IntroMusic;
        SoundEffect Card13EntrenceQuote;
        SoundEffect Card13AttackQuote;
        SoundEffect Card13AbilityQuote;
        SoundEffect Card13DeathQuote;

        Texture2D Card14;
        SoundEffect Card14IntroMusic;
        SoundEffect Card14EntrenceQuote;
        SoundEffect Card14AttackQuote;
        SoundEffect Card14AbilityQuote;
        SoundEffect Card14DeathQuote;

        Texture2D Card15;
        SoundEffect Card15IntroMusic;
        SoundEffect Card15EntrenceQuote;
        SoundEffect Card15AttackQuote;
        SoundEffect Card15AbilityQuote;
        SoundEffect Card15DeathQuote;

        Texture2D Card16;
        SoundEffect Card16IntroMusic;
        SoundEffect Card16EntrenceQuote;
        SoundEffect Card16AttackQuote;
        SoundEffect Card16AbilityQuote;
        SoundEffect Card16DeathQuote;

        Texture2D Card17;
        SoundEffect Card17IntroMusic;
        SoundEffect Card17EntrenceQuote;
        SoundEffect Card17AttackQuote;
        SoundEffect Card17AbilityQuote;
        SoundEffect Card17DeathQuote;

        Texture2D Card18;
        SoundEffect Card18IntroMusic;
        SoundEffect Card18EntrenceQuote;
        SoundEffect Card18AttackQuote;
        SoundEffect Card18AbilityQuote;
        SoundEffect Card18DeathQuote;

        Texture2D Card19;
        SoundEffect Card19IntroMusic;
        SoundEffect Card19EntrenceQuote;
        SoundEffect Card19AttackQuote;
        SoundEffect Card19AbilityQuote;
        SoundEffect Card19DeathQuote;

        Texture2D Card20;
        SoundEffect Card20IntroMusic;
        SoundEffect Card20EntrenceQuote;
        SoundEffect Card20AttackQuote;
        SoundEffect Card20AbilityQuote;
        SoundEffect Card20DeathQuote;

        Texture2D Card21;
        SoundEffect Card21IntroMusic;
        SoundEffect Card21EntrenceQuote;
        SoundEffect Card21AttackQuote;
        SoundEffect Card21AbilityQuote;
        SoundEffect Card21DeathQuote;

        Texture2D Card22;
        SoundEffect Card22IntroMusic;
        SoundEffect Card22EntrenceQuote;
        SoundEffect Card22AttackQuote;
        SoundEffect Card22AbilityQuote;
        SoundEffect Card22DeathQuote;

        Texture2D Card23;
        SoundEffect Card23IntroMusic;
        SoundEffect Card23EntrenceQuote;
        SoundEffect Card23AttackQuote;
        SoundEffect Card23AbilityQuote;
        SoundEffect Card23DeathQuote;

        Texture2D Card24;
        SoundEffect Card24IntroMusic;
        SoundEffect Card24EntrenceQuote;
        SoundEffect Card24AttackQuote;
        SoundEffect Card24AbilityQuote;
        SoundEffect Card24DeathQuote;

        Texture2D Card25;
        SoundEffect Card25IntroMusic;
        SoundEffect Card25EntrenceQuote;
        SoundEffect Card25AttackQuote;
        SoundEffect Card25AbilityQuote;
        SoundEffect Card25DeathQuote;

        Texture2D Card26;
        SoundEffect Card26IntroMusic;
        SoundEffect Card26EntrenceQuote;
        SoundEffect Card26AttackQuote;
        SoundEffect Card26AbilityQuote;
        SoundEffect Card26DeathQuote;

        //Cards 27 - 29 are spell cards
        Texture2D Card27;

        Texture2D Card28;

        Texture2D Card29;

        //cards 30 - 40 are minor minions "summon by other minions"
        Texture2D Card30;
        SoundEffect Card30IntroMusic;
        SoundEffect Card30EntrenceQuote;
        SoundEffect Card30AttackQuote;
        SoundEffect Card30AbilityQuote;
        SoundEffect Card30DeathQuote;

        Texture2D Card31;
        SoundEffect Card31IntroMusic;
        SoundEffect Card31EntrenceQuote;
        SoundEffect Card31AttackQuote;
        SoundEffect Card31AbilityQuote;
        SoundEffect Card31DeathQuote;

        Texture2D Card32;
        SoundEffect Card32IntroMusic;
        SoundEffect Card32EntrenceQuote;
        SoundEffect Card32AttackQuote;
        SoundEffect Card32AbilityQuote;
        SoundEffect Card32DeathQuote;

        Texture2D Card33;
        SoundEffect Card33IntroMusic;
        SoundEffect Card33EntrenceQuote;
        SoundEffect Card33AttackQuote;
        SoundEffect Card33AbilityQuote;
        SoundEffect Card33DeathQuote;

        Texture2D Card34;
        SoundEffect Card34IntroMusic;
        SoundEffect Card34EntrenceQuote;
        SoundEffect Card34AttackQuote;
        SoundEffect Card34AbilityQuote;
        SoundEffect Card34DeathQuote;

        Texture2D Card35;
        SoundEffect Card35IntroMusic;
        SoundEffect Card35EntrenceQuote;
        SoundEffect Card35AttackQuote;
        SoundEffect Card35AbilityQuote;
        SoundEffect Card35DeathQuote;

        Texture2D Card36;
        SoundEffect Card36IntroMusic;
        SoundEffect Card36EntrenceQuote;
        SoundEffect Card36AttackQuote;
        SoundEffect Card36AbilityQuote;
        SoundEffect Card36DeathQuote;

        Texture2D Card37;
        SoundEffect Card37IntroMusic;
        SoundEffect Card37EntrenceQuote;
        SoundEffect Card37AttackQuote;
        SoundEffect Card37AbilityQuote;
        SoundEffect Card37DeathQuote;

        Texture2D Card38;
        SoundEffect Card38IntroMusic;
        SoundEffect Card38EntrenceQuote;
        SoundEffect Card38AttackQuote;
        SoundEffect Card38AbilityQuote;
        SoundEffect Card38DeathQuote;

        Texture2D Card39;
        SoundEffect Card39IntroMusic;
        SoundEffect Card39EntrenceQuote;
        SoundEffect Card39AttackQuote;
        SoundEffect Card39AbilityQuote;
        SoundEffect Card39DeathQuote;

        Texture2D Card40;
        SoundEffect Card40IntroMusic;
        SoundEffect Card40EntrenceQuote;
        SoundEffect Card40AttackQuote;
        SoundEffect Card40AbilityQuote;
        SoundEffect Card40DeathQuote;

        //Cards 41 - 46 are spell minions "summon by spells"
        Texture2D Card41;
        SoundEffect Card41IntroMusic;
        SoundEffect Card41EntrenceQuote;
        SoundEffect Card41AttackQuote;
        SoundEffect Card41AbilityQuote;
        SoundEffect Card41DeathQuote;

        Texture2D Card42;
        SoundEffect Card42IntroMusic;
        SoundEffect Card42EntrenceQuote;
        SoundEffect Card42AttackQuote;
        SoundEffect Card42AbilityQuote;
        SoundEffect Card42DeathQuote;

        Texture2D Card43;
        SoundEffect Card43IntroMusic;
        SoundEffect Card43EntrenceQuote;
        SoundEffect Card43AttackQuote;
        SoundEffect Card43AbilityQuote;
        SoundEffect Card43DeathQuote;

        Texture2D Card44;
        SoundEffect Card44IntroMusic;
        SoundEffect Card44EntrenceQuote;
        SoundEffect Card44AttackQuote;
        SoundEffect Card44AbilityQuote;
        SoundEffect Card44DeathQuote;

        Texture2D Card45;
        SoundEffect Card45IntroMusic;
        SoundEffect Card45EntrenceQuote;
        SoundEffect Card45AttackQuote;
        SoundEffect Card45AbilityQuote;
        SoundEffect Card45DeathQuote;

        Texture2D Card46;
        SoundEffect Card46IntroMusic;
        SoundEffect Card46EntrenceQuote;
        SoundEffect Card46AttackQuote;
        SoundEffect Card46AbilityQuote;
        SoundEffect Card46DeathQuote;

        //card 47 are special cards "former classmates"
        Texture2D Card47;
        SoundEffect Card47IntroMusic;
        SoundEffect Card47EntrenceQuote;
        SoundEffect Card47AttackQuote;
        SoundEffect Card47AbilityQuote;
        SoundEffect Card47DeathQuote;

        //buttons and background
        Texture2D CRRAB;
        Texture2D CRLAB;
        Texture2D CRIMB;
        Texture2D CREQB;
        Texture2D CRATQB;
        Texture2D CRABQB;
        Texture2D CRDQB;
        Texture2D CREXB;
        Texture2D CRBG;

        //PlayAI setup
        Texture2D PAIBG;
        Texture2D PAIMRBH;
        Texture2D PAIMRDH;
        Texture2D PAIECB;
        PlayAI playAI;

        //LIsts
        List<SoundEffect> Effects = new List<SoundEffect>();
        List<Texture2D> Cards = new List<Texture2D>();

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

            //CRRAB = Content.Load<Texture2D>("right button");
            //CRLAB = Content.Load<Texture2D>("left button");
            CRIMB = Content.Load<Texture2D>("Background Sound");
            CREQB = Content.Load<Texture2D>("Entrance");
            CRATQB = Content.Load<Texture2D>("Attack");
            CRABQB = Content.Load<Texture2D>("card sound fix");
            CRDQB = Content.Load<Texture2D>("Death");
            CREXB = Content.Load<Texture2D>("EXIT");
            CRBG = Content.Load<Texture2D>("sand tan");

            Card1 = Content.Load<Texture2D>("Jacob R");

            Card2 = Content.Load<Texture2D>("Colin");


            PAIBG = Content.Load<Texture2D>("Back-ground-battle-field");

            cardreview = new cardReview(Card1, Card1IntroMusic, Card1EntrenceQuote, Card1AttackQuote, Card1AbilityQuote, Card1DeathQuote, Card2, Card2IntroMusic, Card2EntrenceQuote, Card2AttackQuote, Card2AbilityQuote, Card2DeathQuote, Card3, Card3IntroMusic, Card3EntrenceQuote, Card3AttackQuote, Card3AbilityQuote, Card3DeathQuote, Card4, Card4IntroMusic, Card4EntrenceQuote, Card4AttackQuote, Card4AbilityQuote, Card4DeathQuote, Card5, Card5IntroMusic, Card5EntrenceQuote, Card5AttackQuote, Card5AbilityQuote, Card5DeathQuote, Card6, Card6IntroMusic, Card6EntrenceQuote, Card6AttackQuote, Card6AbilityQuote, Card6DeathQuote, Card7, Card7IntroMusic, Card7EntrenceQuote, Card7AttackQuote, Card7AbilityQuote, Card7DeathQuote, Card8, Card8IntroMusic, Card8EntrenceQuote, Card8AttackQuote, Card8AbilityQuote, Card8DeathQuote, Card9, Card9IntroMusic, Card9EntrenceQuote, Card9AttackQuote, Card9AbilityQuote, Card9DeathQuote, Card10, Card10IntroMusic, Card10EntrenceQuote, Card10AttackQuote, Card10AbilityQuote, Card10DeathQuote, Card11, Card11IntroMusic, Card11EntrenceQuote, Card11AttackQuote, Card11AbilityQuote, Card11DeathQuote, Card12, Card12IntroMusic, Card12EntrenceQuote, Card12AttackQuote, Card12AbilityQuote, Card12DeathQuote, Card13, Card13IntroMusic, Card13EntrenceQuote, Card13AttackQuote, Card13AbilityQuote, Card13DeathQuote, Card14, Card14IntroMusic, Card14EntrenceQuote, Card14AttackQuote, Card14AbilityQuote, Card14DeathQuote, Card15, Card15IntroMusic, Card15EntrenceQuote, Card15AttackQuote, Card15AbilityQuote, Card15DeathQuote, Card16, Card16IntroMusic, Card16EntrenceQuote, Card16AttackQuote, Card16AbilityQuote, Card16DeathQuote, Card17, Card17IntroMusic, Card17EntrenceQuote, Card17AttackQuote, Card17AbilityQuote, Card17DeathQuote, Card18, Card18IntroMusic, Card18EntrenceQuote, Card18AttackQuote, Card18AbilityQuote, Card18DeathQuote, Card19, Card19IntroMusic, Card19EntrenceQuote, Card19AttackQuote, Card19AbilityQuote, Card19DeathQuote, Card20, Card20IntroMusic, Card20EntrenceQuote, Card20AttackQuote, Card20AbilityQuote, Card20DeathQuote, Card21, Card21IntroMusic, Card21EntrenceQuote, Card21AttackQuote, Card21AbilityQuote, Card21DeathQuote, Card22, Card22IntroMusic, Card22EntrenceQuote, Card22AttackQuote, Card22AbilityQuote, Card22DeathQuote, Card23, Card23IntroMusic, Card23EntrenceQuote, Card23AttackQuote, Card23AbilityQuote, Card23DeathQuote, Card24, Card24IntroMusic, Card24EntrenceQuote, Card24AttackQuote, Card24AbilityQuote, Card24DeathQuote, Card25, Card25IntroMusic, Card25EntrenceQuote, Card25AttackQuote, Card25AbilityQuote, Card25DeathQuote, Card26, Card26IntroMusic, Card26EntrenceQuote, Card26AttackQuote, Card26AbilityQuote, Card26DeathQuote, Card27, Card28, Card29, Card30, Card30IntroMusic, Card30EntrenceQuote, Card30AttackQuote, Card30AbilityQuote, Card30DeathQuote, Card31, Card31IntroMusic, Card31EntrenceQuote, Card31AttackQuote, Card31AbilityQuote, Card31DeathQuote, Card32, Card32IntroMusic, Card32EntrenceQuote, Card32AttackQuote, Card32AbilityQuote, Card32DeathQuote, Card33, Card33IntroMusic, Card33EntrenceQuote, Card33AttackQuote, Card33AbilityQuote, Card33DeathQuote, Card34, Card34IntroMusic, Card34EntrenceQuote, Card34AttackQuote, Card34AbilityQuote, Card34DeathQuote, Card35, Card35IntroMusic, Card35EntrenceQuote, Card35AttackQuote, Card35AbilityQuote, Card35DeathQuote, Card36, Card36IntroMusic, Card36EntrenceQuote, Card36AttackQuote, Card36AbilityQuote, Card36DeathQuote, Card37, Card37IntroMusic, Card37EntrenceQuote, Card37AttackQuote, Card37AbilityQuote, Card37DeathQuote, Card38, Card38IntroMusic, Card38EntrenceQuote, Card38AttackQuote, Card38AbilityQuote, Card38DeathQuote, Card39, Card39IntroMusic, Card39EntrenceQuote, Card39AttackQuote, Card39AbilityQuote, Card39DeathQuote, Card40, Card40IntroMusic, Card40EntrenceQuote, Card40AttackQuote, Card40AbilityQuote, Card40DeathQuote, Card41, Card41IntroMusic, Card41EntrenceQuote, Card41AttackQuote, Card41AbilityQuote, Card41DeathQuote, Card42, Card42IntroMusic, Card42EntrenceQuote, Card42AttackQuote, Card42AbilityQuote, Card42DeathQuote, Card43, Card43IntroMusic, Card43EntrenceQuote, Card43AttackQuote, Card43AbilityQuote, Card43DeathQuote, Card44, Card44IntroMusic, Card44EntrenceQuote, Card44AttackQuote, Card44AbilityQuote, Card44DeathQuote, Card45, Card45IntroMusic, Card45EntrenceQuote, Card45AttackQuote, Card45AbilityQuote, Card45DeathQuote, Card46, Card46IntroMusic, Card46EntrenceQuote, Card46AttackQuote, Card46AbilityQuote, Card46DeathQuote, Card47, Card47IntroMusic,Card47EntrenceQuote, Card47AttackQuote, Card47AbilityQuote,Card47DeathQuote, CRRAB, CRLAB, CRIMB, CREQB, CRATQB, CRABQB, CRDQB, CREXB, CRBG);
            menu = new MainMenu(menuBG, menuPAB, menuRCB, menuEB);
            playAI = new PlayAI(PAIBG);
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
                if (menu.pAButtonIsClicked)
                {
                    previousScreen = currentScreen;
                    currentScreen = "PlayAIMenu";
                }
                else if (menu.rButtonIsClicked)
                {
                    previousScreen = currentScreen;
                    currentScreen = "cardReview";
                }
                else if (menu.eButtonIsClicked)
                {
                    this.Exit();
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
            
            if (currentScreen == "PlayAIMenu")
            {
                playAI.Draw(spriteBatch);
            }

            if (currentScreen == "cardReview")
            {
                cardreview.Draw(spriteBatch);
            }
            
            base.Draw(gameTime);
        }
    }
}
