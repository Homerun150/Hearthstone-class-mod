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
using System.Diagnostics;


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

        public Buttoncollision(Texture2D ButtonImage, Vector2 ButtonPosition)
        {
            buttonPosition = ButtonPosition;
            buttonImage = ButtonImage;
            buttonCollision = new Rectangle((int)(ButtonPosition.X - buttonImage.Width / 2), (int)(ButtonPosition.Y - buttonImage.Height / 2), buttonImage.Width, buttonImage.Height);
            complete = false;
        }

        public void CheckMouseCollision()
        {
            mouseState = Mouse.GetState();
            Debug.WriteLine(mouseState.X + " " + mouseState.Y + " BC " + buttonCollision.X + " " + buttonCollision.Y + " " + buttonCollision.Width + " " + buttonCollision.Height + " " +mouseState.LeftButton+ " " + buttonCollision.Contains(mousePosition.X, mousePosition.Y));
            if (buttonCollision.Contains(mouseState.X, mouseState.Y) && mouseState.LeftButton == ButtonState.Pressed)
            {
                complete = true;
            }
            else { complete = false; }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();

            spriteBatch.Draw(buttonImage, buttonCollision, Color.White);

            spriteBatch.End();
        }
    }
}
