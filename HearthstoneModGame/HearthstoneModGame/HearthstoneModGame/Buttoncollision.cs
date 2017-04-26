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

        public Buttoncollision(ContentManager Content, Vector2 ButtonPosition, string ButtonImage)
        {
            buttonPosition = ButtonPosition;
            buttonImage = Content.Load<Texture2D>(ButtonImage);
            buttonCollision = new Rectangle((int)(ButtonPosition.X - buttonImage.Width / 2), (int)(ButtonPosition.Y - buttonImage.Height / 2), buttonImage.Width, buttonImage.Height);
        }

        public bool CheckMouseCollision(MouseState mousePosition)
        {
            return buttonCollision.Contains(mousePosition.X, mousePosition.Y);
        }

        public void Draw(SpriteBatch spriteBatch, Color color)
        {
            spriteBatch.Draw(buttonImage, buttonCollision, color);
        }
    }
}
