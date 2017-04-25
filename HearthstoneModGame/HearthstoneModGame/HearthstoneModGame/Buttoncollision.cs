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
    class Buttoncollision
    {
        private Texture2D buttonImage;
        private Rectangle buttonCollision;
        private Vector2 buttonPosition;
        private Vector2 mousePosition;

        public ButtonCollision(ContentManager Content, Vector2 ButtonPosition, string ButtonImage)
        {
            buttonPosition = ButtonPosition;
            buttonImage = Content.Load<Texture2D>(ButtonImage);
            buttonCollision = new Rectangle((int)ButtonPosition.X, (int)ButtonPosition.Y, (int) Button
        }
    }
}
