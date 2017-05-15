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
        //Main menu setup
        private Buttoncollision playAIButton;
        private Buttoncollision viewCardDetail;
        private Buttoncollision exitButton;
        private Texture2D mainMenuBackgorund;
        private Texture2D playButton;
        private Texture2D reviewButton;
        private Texture2D Ebutton;

        private Vector2 practiceLocation1 = new Vector2(950, 500);
        private Vector2 practicelocation2 = new Vector2(100, 100);

        public bool rButtonIsClicked = false;
        public bool pAButtonIsClicked = false;
        public bool eButtonIsClicked = false;

        //review card setup



        public MainMenu(Texture2D mainmenuPNG, Texture2D playbutton, Texture2D viewCardButton, Texture2D eButton)
        {
            mainMenuBackgorund = mainmenuPNG;
            playButton = playbutton;
            reviewButton = viewCardButton;
            Ebutton = eButton;

            playAIButton = new Buttoncollision(playButton, practiceLocation1);
            viewCardDetail = new Buttoncollision(reviewButton, practicelocation2);
            exitButton = new Buttoncollision(Ebutton, new Vector2 (400, 400));
        }

        public void Update()
        {
            playAIButton.CheckMouseCollision();
            viewCardDetail.CheckMouseCollision();
            exitButton.CheckMouseCollision();

            if (playAIButton.complete == true)
            {
                pAButtonIsClicked = true;
            }
            else if (viewCardDetail.complete == true)
            {
                rButtonIsClicked = true;
            }
            else if (exitButton.complete == true)
            {
                eButtonIsClicked = true;
            }
            else
            {
                pAButtonIsClicked = false;
                rButtonIsClicked = false;
                eButtonIsClicked = false;
            }

        }
        public void Draw(SpriteBatch spritebatch)
        { 
            spritebatch.Begin();

            spritebatch.Draw(mainMenuBackgorund, new Rectangle(0, 0, 1080, 720), Color.White);

            spritebatch.End();

            playAIButton.Draw(spritebatch);
            viewCardDetail.Draw(spritebatch);
            exitButton.Draw(spritebatch);
        }
    }
}
