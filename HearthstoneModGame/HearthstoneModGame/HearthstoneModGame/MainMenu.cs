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
        private Texture2D mainMenuBackgorund;

        public MainMenu(Texture2D mainmenuPNG)
        {
            mainMenuBackgorund = mainmenuPNG;

        }

        public void Update()
        {

        }
         public void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Begin();

            spritebatch.Draw(mainMenuBackgorund, new Rectangle(0, 0, 1080, 720), Color.White);

            spritebatch.End();
        }
    }
}
