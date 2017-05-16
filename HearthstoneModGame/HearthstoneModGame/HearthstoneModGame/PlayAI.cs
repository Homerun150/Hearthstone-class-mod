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
    class PlayAI
    {
        Texture2D Gamefield;

        Texture2D card1;
        Texture2D fieldMinion1;
        Texture2D card2;

        Vector2 playerMinionPosition1;

        Vector2 aiMinionPosition1;

        Texture2D PAIBG;

        public PlayAI(Texture2D paibg)
        {
            PAIBG = paibg;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();

            spriteBatch.Draw(PAIBG, new Rectangle(0, 0, 1080, 720), Color.White);

            spriteBatch.End();
        }
    }
}
