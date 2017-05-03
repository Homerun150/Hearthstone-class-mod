using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace HearthstoneModGame
{
    class MainMenu
    {
        private Buttoncollision playAIButton;
        private Buttoncollision viewCardDetail;
        private Buttoncollision exitButton;
        private Texture2D mainMenuBackgorund;
        private Texture2D playButton;
        private Texture2D reviewButton;
        private Texture2D exitbutton;

        private Vector2 practiceLocation1 = new Vector2(500, 500);
        private Vector2 practicelocation2 = new Vector2(100, 100);


        public MainMenu(Texture2D mainmenuPNG, Texture2D playbutton, Texture2D viewCardButton)
        {
            mainMenuBackgorund = mainmenuPNG;
            playButton = playbutton;
            reviewButton = viewCardButton;

            playAIButton = new Buttoncollision(playButton, practiceLocation1);
            viewCardDetail = new Buttoncollision(reviewButton, practicelocation2);
            //exitButton = ;
        }

        public void Update()
        {
            playAIButton.CheckMouseCollision();
            viewCardDetail.CheckMouseCollision();
            exitButton.CheckMouseCollision();

            if (playAIButton.complete == true)
            {

            }
            //if (play)

        }
        public void Draw(SpriteBatch spritebatch)
        { 
            spritebatch.Begin();

            spritebatch.Draw(mainMenuBackgorund, new Rectangle(0, 0, 1080, 720), Color.White);

            spritebatch.End();

            playAIButton.Draw(spritebatch);
            viewCardDetail.Draw(spritebatch);
        }

        //public string returnCurrentScreen()
       // {
            //return 
        //}

        //public string returnPreviousScreen()
        //{
            //return
        //}
    }
}
