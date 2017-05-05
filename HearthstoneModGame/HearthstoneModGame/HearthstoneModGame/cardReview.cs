﻿using System;
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
    class cardReview
    {
        //to change through the different cards
        Buttoncollision rightArrow;
        Buttoncollision leftArrow;

        //to play selective audio ques
        Buttoncollision playMusicBackGround;
        Buttoncollision playEntranceQuote;
        Buttoncollision playAttackQuote;
        Buttoncollision playAbilityQuote;
        Buttoncollision playDeathQuote;

        //to know current ques and card image
        Texture2D currentCard;
        Texture2D previousCard;
        Texture2D nextCard;

        //all main current cards on the list
        Texture2D Jacob_R_Card;
        Texture2D Colin_Card;
        Texture2D Brendon_S_Card;
        Texture2D Dekota_Card;
        Texture2D Tristan_Card;
        Texture2D Jamie_Card;
        Texture2D Kyle_Card;
        Texture2D Kenny_Card;
        Texture2D Kirk_Card;
        Texture2D Cameron_P_Card;
        Texture2D Issic_Card;
        Texture2D Gregory_Honsinger_Card;
        Texture2D Josh_R_Card;
        Texture2D Breanna_Card;
        Texture2D Joseph_Card;
        Texture2D Greg_P;
        Texture2D Christan_Gorler_Card;
        Texture2D Josh_G_Card;
        Texture2D Cameron_A_Card_1;
        Texture2D Connor_Card;
        Texture2D Jhon_W_Card;
        Texture2D Emari_L_Card;
        Texture2D Andy_P_Card;
        Texture2D Chayse_H_Card;
        Texture2D Cameron_A_Card_2;
        Texture2D Patrick_B_Card;

        //Spell Cards
        Texture2D Spell_Learning_Time;
        Texture2D Spell_Error_Log;
        Texture2D Spell_Secret_Java_Book_Of_Doom;

        //Minor cards

        //fall
        Texture2D Shoulder_Pad;
        Texture2D FootBall;
        Texture2D Helment;

        //winter

        public void Draw(SpriteBatch spritebatch)
        {
            
        }
    }
}
