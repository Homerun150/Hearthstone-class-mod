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
        SoundEffect currentCardIntroMusic; // if card is a lengendary rarity
        SoundEffect currentCardEntrenceQuote;
        SoundEffect currentCardAttackQuote;
        SoundEffect currentCardAbilityQuote; // if card minion has an ability
        SoundEffect currentCardDeathQuote;

        Texture2D previousCard;
        SoundEffect previousCardIntroMusic; // if card is a lengendary rarity
        SoundEffect previousCardEntrenceQuote;
        SoundEffect previousCardAttackQuote;
        SoundEffect previousCardAbilityQuote; // if card minion has an ability
        SoundEffect previousCardDeathQuote;

        Texture2D nextCard;
        SoundEffect nextCardIntroMusic; // if card is a lengendary rarity
        SoundEffect nextCardEntrenceQuote;
        SoundEffect nextCardAttackQuote;
        SoundEffect nextCardAbilityQuote; // if card minion has an ability
        SoundEffect nextCardDeathQuote;

        //all main current cards on the list
        Texture2D Jacob_R_Card;
        SoundEffect JacobRIntroMusic;
        SoundEffect JacobREntrenceQuote;
        SoundEffect JacobRAttackQuote;
        SoundEffect JacobRAbilityQuote;
        SoundEffect JacobRDeathQuote;

        Texture2D Colin_Card;
        SoundEffect ColinIntroMusic;
        SoundEffect ColinEntrenceQuote;
        SoundEffect ColinAttackQuote;
        SoundEffect ColinAbilityQuote;
        SoundEffect ColinDeathQuote;

        Texture2D Brendon_S_Card;
        SoundEffect ColinIntroMusic;
        SoundEffect ColinEntrenceQuote;
        SoundEffect ColinAttackQuote;
        SoundEffect ColinAbilityQuote;
        SoundEffect ColinDeathQuote;

        Texture2D Dekota_Card;
        SoundEffect ColinIntroMusic;
        SoundEffect ColinEntrenceQuote;
        SoundEffect ColinAttackQuote;
        SoundEffect ColinAbilityQuote;
        SoundEffect ColinDeathQuote;

        Texture2D Tristan_Card;
        SoundEffect ColinIntroMusic;
        SoundEffect ColinEntrenceQuote;
        SoundEffect ColinAttackQuote;
        SoundEffect ColinAbilityQuote;
        SoundEffect ColinDeathQuote;

        Texture2D Jamie_Card;
        SoundEffect ColinIntroMusic;
        SoundEffect ColinEntrenceQuote;
        SoundEffect ColinAttackQuote;
        SoundEffect ColinAbilityQuote;
        SoundEffect ColinDeathQuote;

        Texture2D Kyle_Card;
        SoundEffect ColinIntroMusic;
        SoundEffect ColinEntrenceQuote;
        SoundEffect ColinAttackQuote;
        SoundEffect ColinAbilityQuote;
        SoundEffect ColinDeathQuote;

        Texture2D Kenny_Card;
        SoundEffect ColinIntroMusic;
        SoundEffect ColinEntrenceQuote;
        SoundEffect ColinAttackQuote;
        SoundEffect ColinAbilityQuote;
        SoundEffect ColinDeathQuote;

        Texture2D Kirk_Card;
        SoundEffect ColinIntroMusic;
        SoundEffect ColinEntrenceQuote;
        SoundEffect ColinAttackQuote;
        SoundEffect ColinAbilityQuote;
        SoundEffect ColinDeathQuote;

        Texture2D Cameron_P_Card;
        SoundEffect ColinIntroMusic;
        SoundEffect ColinEntrenceQuote;
        SoundEffect ColinAttackQuote;
        SoundEffect ColinAbilityQuote;
        SoundEffect ColinDeathQuote;

        Texture2D Issic_Card;
        SoundEffect ColinIntroMusic;
        SoundEffect ColinEntrenceQuote;
        SoundEffect ColinAttackQuote;
        SoundEffect ColinAbilityQuote;
        SoundEffect ColinDeathQuote;

        Texture2D Gregory_Honsinger_Card;
        SoundEffect ColinIntroMusic;
        SoundEffect ColinEntrenceQuote;
        SoundEffect ColinAttackQuote;
        SoundEffect ColinAbilityQuote;
        SoundEffect ColinDeathQuote;

        Texture2D Josh_R_Card;
        SoundEffect ColinIntroMusic;
        SoundEffect ColinEntrenceQuote;
        SoundEffect ColinAttackQuote;
        SoundEffect ColinAbilityQuote;
        SoundEffect ColinDeathQuote;

        Texture2D Breanna_Card;
        SoundEffect ColinIntroMusic;
        SoundEffect ColinEntrenceQuote;
        SoundEffect ColinAttackQuote;
        SoundEffect ColinAbilityQuote;
        SoundEffect ColinDeathQuote;

        Texture2D Joseph_Card;
        SoundEffect ColinIntroMusic;
        SoundEffect ColinEntrenceQuote;
        SoundEffect ColinAttackQuote;
        SoundEffect ColinAbilityQuote;
        SoundEffect ColinDeathQuote;

        Texture2D Greg_P;
        SoundEffect ColinIntroMusic;
        SoundEffect ColinEntrenceQuote;
        SoundEffect ColinAttackQuote;
        SoundEffect ColinAbilityQuote;
        SoundEffect ColinDeathQuote;

        Texture2D Christan_Gorler_Card;
        SoundEffect ColinIntroMusic;
        SoundEffect ColinEntrenceQuote;
        SoundEffect ColinAttackQuote;
        SoundEffect ColinAbilityQuote;
        SoundEffect ColinDeathQuote;

        Texture2D Josh_G_Card;
        SoundEffect ColinIntroMusic;
        SoundEffect ColinEntrenceQuote;
        SoundEffect ColinAttackQuote;
        SoundEffect ColinAbilityQuote;
        SoundEffect ColinDeathQuote;

        Texture2D Cameron_A_Card_1;
        SoundEffect ColinIntroMusic;
        SoundEffect ColinEntrenceQuote;
        SoundEffect ColinAttackQuote;
        SoundEffect ColinAbilityQuote;
        SoundEffect ColinDeathQuote;

        Texture2D Connor_Card;
        SoundEffect ColinIntroMusic;
        SoundEffect ColinEntrenceQuote;
        SoundEffect ColinAttackQuote;
        SoundEffect ColinAbilityQuote;
        SoundEffect ColinDeathQuote;

        Texture2D Jhon_W_Card;
        SoundEffect ColinIntroMusic;
        SoundEffect ColinEntrenceQuote;
        SoundEffect ColinAttackQuote;
        SoundEffect ColinAbilityQuote;
        SoundEffect ColinDeathQuote;

        Texture2D Emari_L_Card;
        SoundEffect ColinIntroMusic;
        SoundEffect ColinEntrenceQuote;
        SoundEffect ColinAttackQuote;
        SoundEffect ColinAbilityQuote;
        SoundEffect ColinDeathQuote;

        Texture2D Andy_P_Card;
        SoundEffect ColinIntroMusic;
        SoundEffect ColinEntrenceQuote;
        SoundEffect ColinAttackQuote;
        SoundEffect ColinAbilityQuote;
        SoundEffect ColinDeathQuote;

        Texture2D Chayse_H_Card;
        SoundEffect ColinIntroMusic;
        SoundEffect ColinEntrenceQuote;
        SoundEffect ColinAttackQuote;
        SoundEffect ColinAbilityQuote;
        SoundEffect ColinDeathQuote;

        Texture2D Cameron_A_Card_2;
        SoundEffect ColinIntroMusic;
        SoundEffect ColinEntrenceQuote;
        SoundEffect ColinAttackQuote;
        SoundEffect ColinAbilityQuote;
        SoundEffect ColinDeathQuote;

        Texture2D Patrick_B_Card;
        SoundEffect ColinIntroMusic;
        SoundEffect ColinEntrenceQuote;
        SoundEffect ColinAttackQuote;
        SoundEffect ColinAbilityQuote;
        SoundEffect ColinDeathQuote;

        //Spell Cards
        Texture2D Spell_Learning_Time;

        Texture2D Spell_Error_Log;

        Texture2D Spell_Secret_Java_Book_Of_Doom;

        //Minor cards

        //Cam A. fall
        Texture2D Shoulder_Pad_Card;
        SoundEffect ColinIntroMusic;
        SoundEffect ColinEntrenceQuote;
        SoundEffect ColinAttackQuote;
        SoundEffect ColinAbilityQuote;
        SoundEffect ColinDeathQuote;

        Texture2D FootBall_Card;
        SoundEffect ColinIntroMusic;
        SoundEffect ColinEntrenceQuote;
        SoundEffect ColinAttackQuote;
        SoundEffect ColinAbilityQuote;
        SoundEffect ColinDeathQuote;

        Texture2D Helment_Card;
        SoundEffect ColinIntroMusic;
        SoundEffect ColinEntrenceQuote;
        SoundEffect ColinAttackQuote;
        SoundEffect ColinAbilityQuote;
        SoundEffect ColinDeathQuote;

        //Cam A. winter
        Texture2D Bowling_Ball_Card;
        SoundEffect ColinIntroMusic;
        SoundEffect ColinEntrenceQuote;
        SoundEffect ColinAttackQuote;
        SoundEffect ColinAbilityQuote;
        SoundEffect ColinDeathQuote;

        Texture2D Pin_Card;
        SoundEffect ColinIntroMusic;
        SoundEffect ColinEntrenceQuote;
        SoundEffect ColinAttackQuote;
        SoundEffect ColinAbilityQuote;
        SoundEffect ColinDeathQuote;

        Texture2D Bag_Card;
        SoundEffect ColinIntroMusic;
        SoundEffect ColinEntrenceQuote;
        SoundEffect ColinAttackQuote;
        SoundEffect ColinAbilityQuote;
        SoundEffect ColinDeathQuote;

        //Cam A. spring
        Texture2D Bat_Card;
        SoundEffect ColinIntroMusic;
        SoundEffect ColinEntrenceQuote;
        SoundEffect ColinAttackQuote;
        SoundEffect ColinAbilityQuote;
        SoundEffect ColinDeathQuote;

        Texture2D Glove_Card;
        SoundEffect ColinIntroMusic;
        SoundEffect ColinEntrenceQuote;
        SoundEffect ColinAttackQuote;
        SoundEffect ColinAbilityQuote;
        SoundEffect ColinDeathQuote;

        Texture2D Baseball_Card;
        SoundEffect ColinIntroMusic;
        SoundEffect ColinEntrenceQuote;
        SoundEffect ColinAttackQuote;
        SoundEffect ColinAbilityQuote;
        SoundEffect ColinDeathQuote;

        //Cam A. Gamer form
        Texture2D Spartain_150_Card;
        SoundEffect ColinIntroMusic;
        SoundEffect ColinEntrenceQuote;
        SoundEffect ColinAttackQuote;
        SoundEffect ColinAbilityQuote;
        SoundEffect ColinDeathQuote;

        Texture2D HearthStone_Challenger_Card;
        SoundEffect ColinIntroMusic;
        SoundEffect ColinEntrenceQuote;
        SoundEffect ColinAttackQuote;
        SoundEffect ColinAbilityQuote;
        SoundEffect ColinDeathQuote;

        //Spell Minions
        Texture2D Java_Book_Card;
        SoundEffect ColinIntroMusic;
        SoundEffect ColinEntrenceQuote;
        SoundEffect ColinAttackQuote;
        SoundEffect ColinAbilityQuote;
        SoundEffect ColinDeathQuote;

        Texture2D C_Plus_Plus_Book_Card;
        SoundEffect ColinIntroMusic;
        SoundEffect ColinEntrenceQuote;
        SoundEffect ColinAttackQuote;
        SoundEffect ColinAbilityQuote;
        SoundEffect ColinDeathQuote;

        Texture2D C_Sharp_Book_Card;
        SoundEffect C_Sharp_BookIntroMusic;
        SoundEffect C_Sharp_BookEntrenceQuote;
        SoundEffect C_Sharp_BookAttackQuote;
        SoundEffect C_Sharp_BookAbilityQuote;
        SoundEffect C_Sharp_BookDeathQuote;

        Texture2D Python_Book_Card;
        SoundEffect Python_BookIntroMusic;
        SoundEffect Python_BookEntrenceQuote;
        SoundEffect Python_BookAttackQuote;
        SoundEffect Python_BookAbilityQuote;
        SoundEffect Python_BookDeathQuote;

        Texture2D Chicken_Book_Card;
        SoundEffect Chicken_BookIntroMusic;
        SoundEffect Chicken_BookEntrenceQuote;
        SoundEffect Chicken_BookAttackQuote;
        SoundEffect Chicken_BookAbilityQuote;
        SoundEffect Chicken_BookDeathQuote;

        Texture2D Error_Log_Card;
        SoundEffect Error_LogIntroMusic;
        SoundEffect Error_LogEntrenceQuote;
        SoundEffect Error_LogAttackQuote;
        SoundEffect Error_LogAbilityQuote;
        SoundEffect Error_LogDeathQuote;

        //Special Card
        Texture2D Arron_Card;
        SoundEffect IntroMusic;
        SoundEffect ArronEntrenceQuote;
        SoundEffect ArronAttackQuote;
        SoundEffect ArronAbilityQuote;
        SoundEffect ArronDeathQuote;

        public cardReview()
        {

        }
        
        public void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Begin();



            spritebatch.End();
        }
    }
}
