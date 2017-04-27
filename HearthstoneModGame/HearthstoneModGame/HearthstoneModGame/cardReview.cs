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
        

    }
}
