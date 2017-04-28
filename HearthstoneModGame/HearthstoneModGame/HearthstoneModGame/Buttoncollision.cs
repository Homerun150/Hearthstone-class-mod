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
        public bool complete;
        MouseState mouseState;
        MouseState mousePosition;

        public Buttoncollision(ContentManager Content, Vector2 ButtonPosition, string ButtonImage)
        {
            buttonPosition = ButtonPosition;
            buttonImage = Content.Load<Texture2D>(ButtonImage);
            buttonCollision = new Rectangle((int)(ButtonPosition.X - buttonImage.Width / 2), (int)(ButtonPosition.Y - buttonImage.Height / 2), buttonImage.Width, buttonImage.Height);
            complete = false;
        }

        public void CheckMouseCollision()
        {
            mouseState = Mouse.GetState();
            if (buttonCollision.Contains(mousePosition.X, mousePosition.Y) && mouseState.LeftButton == ButtonState.Pressed)
                complete = true;
            else { complete = false; }
        }

        public void Draw(SpriteBatch spriteBatch, Color color)
        {
            spriteBatch.Draw(buttonImage, buttonCollision, color);
        }
    }
}
