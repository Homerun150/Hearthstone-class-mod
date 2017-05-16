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
        //to change through the different cards and exit
        Buttoncollision rightArrow;
        Buttoncollision leftArrow;
        Buttoncollision Exit;
        Texture2D BackGround;

        //Bool change screen
        bool CREBIsClicked;

        //to play selective audio ques
        Buttoncollision playMusicBackGround;
        Buttoncollision playEntranceQuote;
        Buttoncollision playAttackQuote;
        Buttoncollision playAbilityQuote;
        Buttoncollision playDeathQuote;

        //start position
        Vector2 PMBGBPosition = new Vector2(100, 620);
        Vector2 PEQBPosition = new Vector2(300, 620);
        Vector2 PATQBPosition = new Vector2(500, 620);
        Vector2 PABQBPosition = new Vector2(700, 620);
        Vector2 PDQBPosition = new Vector2(900, 620);
        Vector2 RABPosition = new Vector2(50, 300);
        Vector2 LABPosition = new Vector2(1030, 300);
        Vector2 CCPosition = new Vector2(200, 50);
        Vector2 EBPosition = new Vector2(100, 100);


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

        Texture2D resetCard;
        SoundEffect resetIntroMusic;
        SoundEffect resetEntrenceQuote;
        SoundEffect resetAttackQuote;
        SoundEffect resetAbilityQuote;
        SoundEffect resetDeathQuote;

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
        SoundEffect Brendon_SIntroMusic;
        SoundEffect Brendon_SEntrenceQuote;
        SoundEffect Brendon_SAttackQuote;
        SoundEffect Brendon_SAbilityQuote;
        SoundEffect Brendon_SDeathQuote;

        Texture2D Dekota_Card;
        SoundEffect DekotaIntroMusic;
        SoundEffect DekotaEntrenceQuote;
        SoundEffect DekotaAttackQuote;
        SoundEffect DekotaAbilityQuote;
        SoundEffect DekotaDeathQuote;

        Texture2D Tristan_Card;
        SoundEffect TristanIntroMusic;
        SoundEffect TristanEntrenceQuote;
        SoundEffect TristanAttackQuote;
        SoundEffect TristanAbilityQuote;
        SoundEffect TristanDeathQuote;

        Texture2D Jamie_Card;
        SoundEffect JamieIntroMusic;
        SoundEffect JamieEntrenceQuote;
        SoundEffect JamieAttackQuote;
        SoundEffect JamieAbilityQuote;
        SoundEffect JamieDeathQuote;

        Texture2D Kyle_Card;
        SoundEffect KyleIntroMusic;
        SoundEffect KyleEntrenceQuote;
        SoundEffect KyleAttackQuote;
        SoundEffect KyleAbilityQuote;
        SoundEffect KyleDeathQuote;

        Texture2D Kenny_Card;
        SoundEffect KennyIntroMusic;
        SoundEffect KennyEntrenceQuote;
        SoundEffect KennyAttackQuote;
        SoundEffect KennyAbilityQuote;
        SoundEffect KennyDeathQuote;

        Texture2D Kirk_Card;
        SoundEffect KirkIntroMusic;
        SoundEffect KirkEntrenceQuote;
        SoundEffect KirkAttackQuote;
        SoundEffect KirkAbilityQuote;
        SoundEffect KirkDeathQuote;

        Texture2D Cameron_P_Card;
        SoundEffect Cameron_PIntroMusic;
        SoundEffect Cameron_PEntrenceQuote;
        SoundEffect Cameron_PAttackQuote;
        SoundEffect Cameron_PAbilityQuote;
        SoundEffect Cameron_PDeathQuote;

        Texture2D Issic_Card;
        SoundEffect IssicIntroMusic;
        SoundEffect IssicEntrenceQuote;
        SoundEffect IssicAttackQuote;
        SoundEffect IssicAbilityQuote;
        SoundEffect IssicDeathQuote;

        Texture2D Gregory_Honsinger_Card;
        SoundEffect Gregory_HonsingerIntroMusic;
        SoundEffect Gregory_HonsingerEntrenceQuote;
        SoundEffect Gregory_HonsingerAttackQuote;
        SoundEffect Gregory_HonsingerAbilityQuote;
        SoundEffect Gregory_HonsingerDeathQuote;

        Texture2D Josh_R_Card;
        SoundEffect Josh_RIntroMusic;
        SoundEffect Josh_REntrenceQuote;
        SoundEffect Josh_RAttackQuote;
        SoundEffect Josh_RAbilityQuote;
        SoundEffect Josh_RDeathQuote;

        Texture2D Breanna_Card;
        SoundEffect BreannaIntroMusic;
        SoundEffect BreannaEntrenceQuote;
        SoundEffect BreannaAttackQuote;
        SoundEffect BreannaAbilityQuote;
        SoundEffect BreannaDeathQuote;

        Texture2D Joseph_Card;
        SoundEffect JosephIntroMusic;
        SoundEffect JosephEntrenceQuote;
        SoundEffect JosephAttackQuote;
        SoundEffect JosephAbilityQuote;
        SoundEffect JosephDeathQuote;

        Texture2D Greg_P_Card;
        SoundEffect Greg_PIntroMusic;
        SoundEffect Greg_PEntrenceQuote;
        SoundEffect Greg_PAttackQuote;
        SoundEffect Greg_PAbilityQuote;
        SoundEffect Greg_PDeathQuote;

        Texture2D Christan_Gorler_Card;
        SoundEffect Christan_GorlerIntroMusic;
        SoundEffect Christan_GorlerEntrenceQuote;
        SoundEffect Christan_GorlerAttackQuote;
        SoundEffect Christan_GorlerAbilityQuote;
        SoundEffect Christan_GorlerDeathQuote;

        Texture2D Josh_G_Card;
        SoundEffect Josh_GIntroMusic;
        SoundEffect Josh_GEntrenceQuote;
        SoundEffect Josh_GAttackQuote;
        SoundEffect Josh_GAbilityQuote;
        SoundEffect Josh_GDeathQuote;

        Texture2D Cameron_A_Card_1;
        SoundEffect Cameron_A_Card_1IntroMusic;
        SoundEffect Cameron_A_Card_1EntrenceQuote;
        SoundEffect Cameron_A_Card_1AttackQuote;
        SoundEffect Cameron_A_Card_1AbilityQuote;
        SoundEffect Cameron_A_Card_1DeathQuote;

        Texture2D Connor_Card;
        SoundEffect ConnorIntroMusic;
        SoundEffect ConnorEntrenceQuote;
        SoundEffect ConnorAttackQuote;
        SoundEffect ConnorAbilityQuote;
        SoundEffect ConnorDeathQuote;

        Texture2D Jhon_W_Card;
        SoundEffect Jhon_WIntroMusic;
        SoundEffect Jhon_WEntrenceQuote;
        SoundEffect Jhon_WAttackQuote;
        SoundEffect Jhon_WAbilityQuote;
        SoundEffect Jhon_WDeathQuote;

        Texture2D Emari_L_Card;
        SoundEffect Emari_LIntroMusic;
        SoundEffect Emari_LEntrenceQuote;
        SoundEffect Emari_LAttackQuote;
        SoundEffect Emari_LAbilityQuote;
        SoundEffect Emari_LDeathQuote;

        Texture2D Andy_P_Card;
        SoundEffect Andy_PIntroMusic;
        SoundEffect Andy_PEntrenceQuote;
        SoundEffect Andy_PAttackQuote;
        SoundEffect Andy_PAbilityQuote;
        SoundEffect Andy_PDeathQuote;

        Texture2D Chayse_H_Card;
        SoundEffect Chayse_HIntroMusic;
        SoundEffect Chayse_HEntrenceQuote;
        SoundEffect Chayse_HAttackQuote;
        SoundEffect Chayse_HAbilityQuote;
        SoundEffect Chayse_HDeathQuote;

        Texture2D Cameron_A_Card_2;
        SoundEffect Cameron_A_Card_2IntroMusic;
        SoundEffect Cameron_A_Card_2EntrenceQuote;
        SoundEffect Cameron_A_Card_2AttackQuote;
        SoundEffect Cameron_A_Card_2AbilityQuote;
        SoundEffect Cameron_A_Card_2DeathQuote;

        Texture2D Patrick_B_Card;
        SoundEffect Patrick_BIntroMusic;
        SoundEffect Patrick_BEntrenceQuote;
        SoundEffect Patrick_BAttackQuote;
        SoundEffect Patrick_BAbilityQuote;
        SoundEffect Patrick_BDeathQuote;

        //Spell Cards
        Texture2D Spell_Learning_Time;

        Texture2D Spell_Error_Log;

        Texture2D Spell_Secret_Java_Book_Of_Doom;

        //Minor cards

        //Cam A. fall
        Texture2D Shoulder_Pad_Card;
        SoundEffect Shoulder_PadIntroMusic;
        SoundEffect Shoulder_PadEntrenceQuote;
        SoundEffect Shoulder_PadAttackQuote;
        SoundEffect Shoulder_PadAbilityQuote;
        SoundEffect Shoulder_PadDeathQuote;

        Texture2D FootBall_Card;
        SoundEffect FootBallIntroMusic;
        SoundEffect FootBallEntrenceQuote;
        SoundEffect FootBallAttackQuote;
        SoundEffect FootBallAbilityQuote;
        SoundEffect FootBallDeathQuote;

        Texture2D Helment_Card;
        SoundEffect HelmentIntroMusic;
        SoundEffect HelmentEntrenceQuote;
        SoundEffect HelmentAttackQuote;
        SoundEffect HelmentAbilityQuote;
        SoundEffect HelmentDeathQuote;

        //Cam A. winter
        Texture2D Bowling_Ball_Card;
        SoundEffect Bowling_BallIntroMusic;
        SoundEffect Bowling_BallEntrenceQuote;
        SoundEffect Bowling_BallAttackQuote;
        SoundEffect Bowling_BallAbilityQuote;
        SoundEffect Bowling_BallDeathQuote;

        Texture2D Pin_Card;
        SoundEffect PinIntroMusic;
        SoundEffect PinEntrenceQuote;
        SoundEffect PinAttackQuote;
        SoundEffect PinAbilityQuote;
        SoundEffect PinDeathQuote;

        Texture2D Bag_Card;
        SoundEffect BagIntroMusic;
        SoundEffect BagEntrenceQuote;
        SoundEffect BagAttackQuote;
        SoundEffect BagAbilityQuote;
        SoundEffect BagDeathQuote;

        //Cam A. spring
        Texture2D Bat_Card;
        SoundEffect BatIntroMusic;
        SoundEffect BatEntrenceQuote;
        SoundEffect BatAttackQuote;
        SoundEffect BatAbilityQuote;
        SoundEffect BatDeathQuote;

        Texture2D Glove_Card;
        SoundEffect GloveIntroMusic;
        SoundEffect GloveEntrenceQuote;
        SoundEffect GloveAttackQuote;
        SoundEffect GloveAbilityQuote;
        SoundEffect GloveDeathQuote;

        Texture2D Baseball_Card;
        SoundEffect BaseballIntroMusic;
        SoundEffect BaseballEntrenceQuote;
        SoundEffect BaseballAttackQuote;
        SoundEffect BaseballAbilityQuote;
        SoundEffect BaseballDeathQuote;

        //Cam A. Gamer form
        Texture2D Spartain_150_Card;
        SoundEffect Spartain_150IntroMusic;
        SoundEffect Spartain_150EntrenceQuote;
        SoundEffect Spartain_150AttackQuote;
        SoundEffect Spartain_150AbilityQuote;
        SoundEffect Spartain_150DeathQuote;

        Texture2D HearthStone_Challenger_Card;
        SoundEffect HearthStone_ChallengerIntroMusic;
        SoundEffect HearthStone_ChallengerEntrenceQuote;
        SoundEffect HearthStone_ChallengerAttackQuote;
        SoundEffect HearthStone_ChallengerAbilityQuote;
        SoundEffect HearthStone_ChallengerDeathQuote;

        //Spell Minions
        Texture2D Java_Book_Card;
        SoundEffect Java_BookIntroMusic;
        SoundEffect Java_BookEntrenceQuote;
        SoundEffect Java_BookAttackQuote;
        SoundEffect Java_BookAbilityQuote;
        SoundEffect Java_BookDeathQuote;

        Texture2D C_Plus_Plus_Book_Card;
        SoundEffect C_Plus_Plus_BookIntroMusic;
        SoundEffect C_Plus_Plus_BookEntrenceQuote;
        SoundEffect C_Plus_Plus_BookAttackQuote;
        SoundEffect C_Plus_Plus_BookAbilityQuote;
        SoundEffect C_Plus_Plus_BookDeathQuote;

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
        SoundEffect ArronIntroMusic;
        SoundEffect ArronEntrenceQuote;
        SoundEffect ArronAttackQuote;
        SoundEffect ArronAbilityQuote;
        SoundEffect ArronDeathQuote;

        Texture2D CRRAB;
        Texture2D CRLAB;
        Texture2D CRIMB;
        Texture2D CREQB;
        Texture2D CRATQB;
        Texture2D CRABQB;
        Texture2D CRDQB;
        Texture2D CREXB;
        Texture2D CRBG;

        public cardReview(Texture2D card1, SoundEffect card1IntroMusic, SoundEffect card1EntrenceQuote, SoundEffect card1AttackQuote, SoundEffect card1AbilityQuote, SoundEffect card1DeathQuote, Texture2D card2, SoundEffect card2IntroMusic, SoundEffect card2EntrenceQuote, SoundEffect card2AttackQuote, SoundEffect card2AbilityQuote, SoundEffect card2DeathQuote, Texture2D card3, SoundEffect card3IntroMusic, SoundEffect card3EntrenceQuote, SoundEffect card3AttackQuote, SoundEffect card3AbilityQuote, SoundEffect card3DeathQuote, Texture2D card4, SoundEffect card4IntroMusic, SoundEffect card4EntrenceQuote, SoundEffect card4AttackQuote, SoundEffect card4AbilityQuote, SoundEffect card4DeathQuote, Texture2D card5, SoundEffect card5IntroMusic, SoundEffect card5EntrenceQuote, SoundEffect card5AttackQuote, SoundEffect card5AbilityQuote, SoundEffect card5DeathQuote, Texture2D card6, SoundEffect card6IntroMusic, SoundEffect card6EntrenceQuote, SoundEffect card6AttackQuote, SoundEffect card6AbilityQuote, SoundEffect card6DeathQuote, Texture2D card7, SoundEffect card7IntroMusic, SoundEffect card7EntrenceQuote, SoundEffect card7AttackQuote, SoundEffect card7AbilityQuote, SoundEffect card7DeathQuote, Texture2D card8, SoundEffect card8IntroMusic, SoundEffect card8EntrenceQuote, SoundEffect card8AttackQuote, SoundEffect card8AbilityQuote, SoundEffect card8DeathQuote, Texture2D card9, SoundEffect card9IntroMusic, SoundEffect card9EntrenceQuote, SoundEffect card9AttackQuote, SoundEffect card9AbilityQuote, SoundEffect card9DeathQuote, Texture2D card10, SoundEffect card10IntroMusic, SoundEffect card10EntrenceQuote, SoundEffect card10AttackQuote, SoundEffect card10AbilityQuote, SoundEffect card10DeathQuote, Texture2D card11, SoundEffect card11IntroMusic, SoundEffect card11EntrenceQuote, SoundEffect card11AttackQuote, SoundEffect card11AbilityQuote, SoundEffect card11DeathQuote, Texture2D card12, SoundEffect card12IntroMusic, SoundEffect card12EntrenceQuote, SoundEffect card12AttackQuote, SoundEffect card12AbilityQuote, SoundEffect card12DeathQuote, Texture2D card13, SoundEffect card13IntroMusic, SoundEffect card13EntrenceQuote, SoundEffect card13AttackQuote, SoundEffect card13AbilityQuote, SoundEffect card13DeathQuote, Texture2D card14, SoundEffect card14IntroMusic, SoundEffect card14EntrenceQuote, SoundEffect card14AttackQuote, SoundEffect card14AbilityQuote, SoundEffect card14DeathQuote, Texture2D card15, SoundEffect card15IntroMusic, SoundEffect card15EntrenceQuote, SoundEffect card15AttackQuote, SoundEffect card15AbilityQuote, SoundEffect card15DeathQuote, Texture2D card16, SoundEffect card16IntroMusic, SoundEffect card16EntrenceQuote, SoundEffect card16AttackQuote, SoundEffect card16AbilityQuote, SoundEffect card16DeathQuote, Texture2D card17, SoundEffect card17IntroMusic, SoundEffect card17EntrenceQuote, SoundEffect card17AttackQuote, SoundEffect card17AbilityQuote, SoundEffect card17DeathQuote, Texture2D card18, SoundEffect card18IntroMusic, SoundEffect card18EntrenceQuote, SoundEffect card18AttackQuote, SoundEffect card18AbilityQuote, SoundEffect card18DeathQuote, Texture2D card19, SoundEffect card19IntroMusic, SoundEffect card19EntrenceQuote, SoundEffect card19AttackQuote, SoundEffect card19AbilityQuote, SoundEffect card19DeathQuote, Texture2D card20, SoundEffect card20IntroMusic, SoundEffect card20EntrenceQuote, SoundEffect card20AttackQuote, SoundEffect card20AbilityQuote, SoundEffect card20DeathQuote, Texture2D card21, SoundEffect card21IntroMusic, SoundEffect card21EntrenceQuote, SoundEffect card21AttackQuote, SoundEffect card21AbilityQuote, SoundEffect card21DeathQuote, Texture2D card22, SoundEffect card22IntroMusic, SoundEffect card22EntrenceQuote, SoundEffect card22AttackQuote, SoundEffect card22AbilityQuote, SoundEffect card22DeathQuote, Texture2D card23, SoundEffect card23IntroMusic, SoundEffect card23EntrenceQuote, SoundEffect card23AttackQuote, SoundEffect card23AbilityQuote, SoundEffect card23DeathQuote, Texture2D card24, SoundEffect card24IntroMusic, SoundEffect card24EntrenceQuote, SoundEffect card24AttackQuote, SoundEffect card24AbilityQuote, SoundEffect card24DeathQuote, Texture2D card25, SoundEffect card25IntroMusic, SoundEffect card25EntrenceQuote, SoundEffect card25AttackQuote, SoundEffect card25AbilityQuote, SoundEffect card25DeathQuote, Texture2D card26, SoundEffect card26IntroMusic, SoundEffect card26EntrenceQuote, SoundEffect card26AttackQuote, SoundEffect card26AbilityQuote, SoundEffect card26DeathQuote, Texture2D card27, Texture2D card28, Texture2D card29, Texture2D card30, SoundEffect card30IntroMusic, SoundEffect card30EntrenceQuote, SoundEffect card30AttackQuote, SoundEffect card30AbilityQuote, SoundEffect card30DeathQuote, Texture2D card31, SoundEffect card31IntroMusic, SoundEffect card31EntrenceQuote, SoundEffect card31AttackQuote, SoundEffect card31AbilityQuote, SoundEffect card31DeathQuote, Texture2D card32, SoundEffect card32IntroMusic, SoundEffect card32EntrenceQuote, SoundEffect card32AttackQuote, SoundEffect card32AbilityQuote, SoundEffect card32DeathQuote, Texture2D card33, SoundEffect card33IntroMusic, SoundEffect card33EntrenceQuote, SoundEffect card33AttackQuote, SoundEffect card33AbilityQuote, SoundEffect card33DeathQuote, Texture2D card34, SoundEffect card34IntroMusic, SoundEffect card34EntrenceQuote, SoundEffect card34AttackQuote, SoundEffect card34AbilityQuote, SoundEffect card34DeathQuote, Texture2D card35, SoundEffect card35IntroMusic, SoundEffect card35EntrenceQuote, SoundEffect card35AttackQuote, SoundEffect card35AbilityQuote, SoundEffect card35DeathQuote, Texture2D card36, SoundEffect card36IntroMusic, SoundEffect card36EntrenceQuote, SoundEffect card36AttackQuote, SoundEffect card36AbilityQuote, SoundEffect card36DeathQuote, Texture2D card37, SoundEffect card37IntroMusic, SoundEffect card37EntrenceQuote, SoundEffect card37AttackQuote, SoundEffect card37AbilityQuote, SoundEffect card37DeathQuote, Texture2D card38, SoundEffect card38IntroMusic, SoundEffect card38EntrenceQuote, SoundEffect card38AttackQuote, SoundEffect card38AbilityQuote, SoundEffect card38DeathQuote, Texture2D card39, SoundEffect card39IntroMusic, SoundEffect card39EntrenceQuote, SoundEffect card39AttackQuote, SoundEffect card39AbilityQuote, SoundEffect card39DeathQuote, Texture2D card40, SoundEffect card40IntroMusic, SoundEffect card40EntrenceQuote, SoundEffect card40AttackQuote, SoundEffect card40AbilityQuote, SoundEffect card40DeathQuote, Texture2D card41, SoundEffect card41IntroMusic, SoundEffect card41EntrenceQuote, SoundEffect card41AttackQuote, SoundEffect card41AbilityQuote, SoundEffect card41DeathQuote, Texture2D card42, SoundEffect card42IntroMusic, SoundEffect card42EntrenceQuote, SoundEffect card42AttackQuote, SoundEffect card42AbilityQuote, SoundEffect card42DeathQuote, Texture2D card43, SoundEffect card43IntroMusic, SoundEffect card43EntrenceQuote, SoundEffect card43AttackQuote, SoundEffect card43AbilityQuote, SoundEffect card43DeathQuote, Texture2D card44, SoundEffect card44IntroMusic, SoundEffect card44EntrenceQuote, SoundEffect card44AttackQuote, SoundEffect card44AbilityQuote, SoundEffect card44DeathQuote, Texture2D card45, SoundEffect card45IntroMusic, SoundEffect card45EntrenceQuote, SoundEffect card45AttackQuote, SoundEffect card45AbilityQuote, SoundEffect card45DeathQuote, Texture2D card46, SoundEffect card46IntroMusic, SoundEffect card46EntrenceQuote, SoundEffect card46AttackQuote, SoundEffect card46AbilityQuote, SoundEffect card46DeathQuote, Texture2D card47, SoundEffect card47IntroMusic, SoundEffect card47EntrenceQuote, SoundEffect card47AttackQuote, SoundEffect card47AbilityQuote, SoundEffect card47DeathQuote, Texture2D RAB, Texture2D LAB, Texture2D PIMB, Texture2D PEQB, Texture2D PATQB, Texture2D PABQB, Texture2D PDQB, Texture2D exit, Texture2D BG)
        {
            Jacob_R_Card = card1;
            JacobRIntroMusic = card1IntroMusic;
            JacobREntrenceQuote = card1EntrenceQuote;
            JacobRAttackQuote = card1AttackQuote;
            JacobRAbilityQuote = card1AbilityQuote;
            JacobRDeathQuote = card1DeathQuote;

            Colin_Card = card2;
            ColinIntroMusic = card2IntroMusic;
            ColinEntrenceQuote = card2EntrenceQuote;
            ColinAttackQuote = card2AttackQuote;
            ColinAbilityQuote = card2AbilityQuote;
            ColinDeathQuote = card2DeathQuote;

            Brendon_S_Card = card3;
            Brendon_SIntroMusic = card3IntroMusic;
            Brendon_SEntrenceQuote = card3EntrenceQuote;
            Brendon_SAttackQuote = card3AttackQuote;
            Brendon_SAbilityQuote = card3AbilityQuote;
            Brendon_SDeathQuote = card3DeathQuote;

            Dekota_Card = card4;
            DekotaIntroMusic = card4IntroMusic;
            DekotaEntrenceQuote = card4EntrenceQuote;
            DekotaAttackQuote = card4AttackQuote;
            DekotaAbilityQuote = card4AbilityQuote;
            DekotaDeathQuote = card4DeathQuote;

            Tristan_Card = card5;
            TristanIntroMusic = card5IntroMusic;
            TristanEntrenceQuote = card5EntrenceQuote;
            TristanAttackQuote = card5AttackQuote;
            TristanAbilityQuote = card5AbilityQuote;
            TristanDeathQuote = card5DeathQuote;

            Jamie_Card = card6;
            JamieIntroMusic = card6IntroMusic;
            JamieEntrenceQuote = card6EntrenceQuote;
            JamieAttackQuote = card6AttackQuote;
            JamieAbilityQuote = card6AbilityQuote;
            JamieDeathQuote = card6DeathQuote;

            Kyle_Card = card7;
            KyleIntroMusic = card7IntroMusic;
            KyleEntrenceQuote = card7EntrenceQuote;
            KyleAttackQuote = card7AttackQuote;
            KyleAbilityQuote = card7AbilityQuote;
            KyleDeathQuote = card7DeathQuote;

            Kenny_Card = card8;
            KennyIntroMusic = card8IntroMusic;
            KennyEntrenceQuote = card8EntrenceQuote;
            KennyAttackQuote = card8AttackQuote;
            KennyAbilityQuote = card8AbilityQuote;
            KennyDeathQuote = card8DeathQuote;

            Kirk_Card = card9;
            KirkIntroMusic = card9IntroMusic;
            KirkEntrenceQuote = card9EntrenceQuote;
            KirkAttackQuote = card9AttackQuote;
            KirkAbilityQuote = card9AbilityQuote;
            KirkDeathQuote = card9DeathQuote;

            Cameron_P_Card = card10;
            Cameron_PIntroMusic = card10IntroMusic;
            Cameron_PEntrenceQuote = card10EntrenceQuote;
            Cameron_PAttackQuote = card10AttackQuote;
            Cameron_PAbilityQuote = card10AbilityQuote;
            Cameron_PDeathQuote = card10DeathQuote;

            Issic_Card = card11;
            IssicIntroMusic = card11IntroMusic;
            IssicEntrenceQuote = card11EntrenceQuote;
            IssicAttackQuote = card11AttackQuote;
            IssicAbilityQuote = card11AbilityQuote;
            IssicDeathQuote = card11DeathQuote;

            Gregory_Honsinger_Card = card12;
            Gregory_HonsingerIntroMusic = card12IntroMusic;
            Gregory_HonsingerEntrenceQuote = card12EntrenceQuote;
            Gregory_HonsingerAttackQuote = card12AttackQuote;
            Gregory_HonsingerAbilityQuote = card12AbilityQuote;
            Gregory_HonsingerDeathQuote = card12DeathQuote;

            Josh_R_Card = card13;
            Josh_RIntroMusic = card13IntroMusic;
            Josh_REntrenceQuote = card13EntrenceQuote;
            Josh_RAttackQuote = card13AttackQuote;
            Josh_RAbilityQuote = card13AbilityQuote;
            Josh_RDeathQuote = card13DeathQuote;

            Breanna_Card = card14;
            BreannaIntroMusic = card14IntroMusic;
            BreannaEntrenceQuote = card14EntrenceQuote;
            BreannaAttackQuote = card14AttackQuote;
            BreannaAbilityQuote = card14AbilityQuote;
            BreannaDeathQuote = card14DeathQuote;

            Joseph_Card = card15;
            JosephIntroMusic = card15IntroMusic;
            JosephEntrenceQuote = card15EntrenceQuote;
            JosephAttackQuote = card15AttackQuote;
            JosephAbilityQuote = card15AbilityQuote;
            JosephDeathQuote = card15DeathQuote;

            Greg_P_Card = card16;
            Greg_PIntroMusic = card16IntroMusic;
            Greg_PEntrenceQuote = card16EntrenceQuote;
            Greg_PAttackQuote = card16AttackQuote;
            Greg_PAbilityQuote = card16AbilityQuote;
            Greg_PDeathQuote = card16DeathQuote;

            Christan_Gorler_Card = card17;
            Christan_GorlerIntroMusic = card17IntroMusic;
            Christan_GorlerEntrenceQuote = card17EntrenceQuote;
            Christan_GorlerAttackQuote = card17AttackQuote;
            Christan_GorlerAbilityQuote = card17AbilityQuote;
            Christan_GorlerDeathQuote = card17DeathQuote;

            Josh_G_Card = card18;
            Josh_GIntroMusic = card18IntroMusic;
            Josh_GEntrenceQuote = card18EntrenceQuote;
            Josh_GAttackQuote = card18AttackQuote;
            Josh_GAbilityQuote = card18AbilityQuote;
            Josh_GDeathQuote = card18DeathQuote;

            Cameron_A_Card_1 = card19;
            Cameron_A_Card_1IntroMusic = card19IntroMusic;
            Cameron_A_Card_1EntrenceQuote = card19EntrenceQuote;
            Cameron_A_Card_1AttackQuote = card19AttackQuote;
            Cameron_A_Card_1AbilityQuote = card19AbilityQuote;
            Cameron_A_Card_1DeathQuote = card19DeathQuote;

            Connor_Card = card20;
            ConnorIntroMusic = card20IntroMusic;
            ConnorEntrenceQuote = card20EntrenceQuote;
            ConnorAttackQuote = card20AttackQuote;
            ConnorAbilityQuote = card20AbilityQuote;
            ConnorDeathQuote = card20DeathQuote;

            Jhon_W_Card = card21;
            Jhon_WIntroMusic = card21IntroMusic;
            Jhon_WEntrenceQuote = card21EntrenceQuote;
            Jhon_WAttackQuote = card21AttackQuote;
            Jhon_WAbilityQuote = card21AbilityQuote;
            Jhon_WDeathQuote = card21DeathQuote;

            Emari_L_Card = card22;
            Emari_LIntroMusic = card22IntroMusic;
            Emari_LEntrenceQuote = card22EntrenceQuote;
            Emari_LAttackQuote = card22AttackQuote;
            Emari_LAbilityQuote = card22AbilityQuote;
            Emari_LDeathQuote = card22DeathQuote;

            Andy_P_Card = card23;
            Andy_PIntroMusic = card23IntroMusic;
            Andy_PEntrenceQuote = card23EntrenceQuote;
            Andy_PAttackQuote = card23AttackQuote;
            Andy_PAbilityQuote = card23AbilityQuote;
            Andy_PDeathQuote = card23DeathQuote;

            Chayse_H_Card = card24;
            Chayse_HIntroMusic = card24IntroMusic;
            Chayse_HEntrenceQuote = card24EntrenceQuote;
            Chayse_HAttackQuote = card24AttackQuote;
            Chayse_HAbilityQuote = card24AbilityQuote;
            Chayse_HDeathQuote = card24DeathQuote;

            Cameron_A_Card_2 = card25;
            Cameron_A_Card_2IntroMusic = card25IntroMusic;
            Cameron_A_Card_2EntrenceQuote = card25EntrenceQuote;
            Cameron_A_Card_2AttackQuote = card25AttackQuote;
            Cameron_A_Card_2AbilityQuote = card25AbilityQuote;
            Cameron_A_Card_2DeathQuote = card25DeathQuote;

            Patrick_B_Card = card26;
            Patrick_BIntroMusic = card26IntroMusic;
            Patrick_BEntrenceQuote = card26EntrenceQuote;
            Patrick_BAttackQuote = card26AttackQuote;
            Patrick_BAbilityQuote = card26AbilityQuote;
            Patrick_BDeathQuote = card26DeathQuote;

            //spell cards
            Spell_Learning_Time = card27;
            Spell_Error_Log = card28;
            Spell_Secret_Java_Book_Of_Doom = card29;

            //Minor minion
            Shoulder_Pad_Card = card30;
            Shoulder_PadIntroMusic = card30IntroMusic;
            Shoulder_PadEntrenceQuote = card30EntrenceQuote;
            Shoulder_PadAttackQuote = card30AttackQuote;
            Shoulder_PadAbilityQuote = card30AbilityQuote;
            Shoulder_PadDeathQuote = card30DeathQuote;

            FootBall_Card = card31;
            FootBallIntroMusic = card31IntroMusic;
            FootBallEntrenceQuote = card31EntrenceQuote;
            FootBallAttackQuote = card31AttackQuote;
            FootBallAbilityQuote = card31AbilityQuote;
            FootBallDeathQuote = card31DeathQuote;

            Helment_Card = card32;
            HelmentIntroMusic = card32IntroMusic;
            HelmentEntrenceQuote = card32EntrenceQuote;
            HelmentAttackQuote = card32AttackQuote;
            HelmentAbilityQuote = card32AbilityQuote;
            HelmentDeathQuote = card32DeathQuote;

            Bowling_Ball_Card = card33;
            Bowling_BallIntroMusic = card33IntroMusic;
            Bowling_BallEntrenceQuote = card33EntrenceQuote;
            Bowling_BallAttackQuote = card33AttackQuote;
            Bowling_BallAbilityQuote = card33AbilityQuote;
            Bowling_BallDeathQuote = card33DeathQuote;

            Pin_Card = card34;
            PinIntroMusic = card34IntroMusic;
            PinEntrenceQuote = card34EntrenceQuote;
            PinAttackQuote = card34AttackQuote;
            PinAbilityQuote = card34AbilityQuote;
            PinDeathQuote = card34DeathQuote;

            Bag_Card = card35;
            BagIntroMusic = card35IntroMusic;
            BagEntrenceQuote = card35EntrenceQuote;
            BagAttackQuote = card35AttackQuote;
            BagAbilityQuote = card35AbilityQuote;
            BagDeathQuote = card35DeathQuote;

            Bat_Card = card36;
            BatIntroMusic = card36IntroMusic;
            BatEntrenceQuote = card36EntrenceQuote;
            BatAttackQuote = card36AttackQuote;
            BatAbilityQuote = card36AbilityQuote;
            BatDeathQuote = card36DeathQuote;

            Glove_Card = card37;
            GloveIntroMusic = card37IntroMusic;
            GloveEntrenceQuote = card37EntrenceQuote;
            GloveAttackQuote = card37AttackQuote;
            GloveAbilityQuote = card37AbilityQuote;
            GloveDeathQuote = card37DeathQuote;

            Baseball_Card = card38;
            BaseballIntroMusic = card38IntroMusic;
            BaseballEntrenceQuote = card38EntrenceQuote;
            BaseballAttackQuote = card38AttackQuote;
            BaseballAbilityQuote = card38AbilityQuote;
            BaseballDeathQuote = card38DeathQuote;

            Spartain_150_Card = card39;
            Spartain_150IntroMusic = card39IntroMusic;
            Spartain_150EntrenceQuote = card39EntrenceQuote;
            Spartain_150AttackQuote = card39AttackQuote;
            Spartain_150AbilityQuote = card39AbilityQuote;
            Spartain_150DeathQuote = card39DeathQuote;

            HearthStone_Challenger_Card = card40;
            HearthStone_ChallengerIntroMusic = card40IntroMusic;
            HearthStone_ChallengerEntrenceQuote = card40EntrenceQuote;
            HearthStone_ChallengerAttackQuote = card40AttackQuote;
            HearthStone_ChallengerAbilityQuote = card40AbilityQuote;
            HearthStone_ChallengerDeathQuote = card40DeathQuote;

            //spell minions
            Java_Book_Card = card41;
            Java_BookIntroMusic = card41IntroMusic;
            Java_BookEntrenceQuote = card41EntrenceQuote;
            Java_BookAttackQuote = card41AttackQuote;
            Java_BookAbilityQuote = card41AbilityQuote;
            Java_BookDeathQuote = card41DeathQuote;

            C_Plus_Plus_Book_Card = card42;
            C_Plus_Plus_BookIntroMusic = card42IntroMusic;
            C_Plus_Plus_BookEntrenceQuote = card42EntrenceQuote;
            C_Plus_Plus_BookAttackQuote = card42AttackQuote;
            C_Plus_Plus_BookAbilityQuote = card42AbilityQuote;
            C_Plus_Plus_BookDeathQuote = card42DeathQuote;

            C_Sharp_Book_Card = card43;
            C_Sharp_BookIntroMusic = card43IntroMusic;
            C_Sharp_BookEntrenceQuote = card43EntrenceQuote;
            C_Sharp_BookAttackQuote = card43AttackQuote;
            C_Sharp_BookAbilityQuote = card43AbilityQuote;
            C_Sharp_BookDeathQuote = card43DeathQuote;

            Python_Book_Card = card44;
            Python_BookIntroMusic = card44IntroMusic;
            Python_BookEntrenceQuote = card44EntrenceQuote;
            Python_BookAttackQuote = card44AttackQuote;
            Python_BookAbilityQuote = card44AbilityQuote;
            Python_BookDeathQuote = card44DeathQuote;

            Chicken_Book_Card = card45;
            Chicken_BookIntroMusic = card45IntroMusic;
            Chicken_BookEntrenceQuote = card45EntrenceQuote;
            Chicken_BookAttackQuote = card45AttackQuote;
            Chicken_BookAbilityQuote = card45AbilityQuote;
            Chicken_BookDeathQuote = card45DeathQuote;

            Error_Log_Card = card46;
            Error_LogIntroMusic = card46IntroMusic;
            Error_LogEntrenceQuote = card46EntrenceQuote;
            Error_LogAttackQuote = card46AttackQuote;
            Error_LogAbilityQuote = card46AbilityQuote;
            Error_LogDeathQuote = card46DeathQuote;

            //special minion
            Arron_Card = card47;
            ArronIntroMusic = card47IntroMusic;
            ArronEntrenceQuote = card47EntrenceQuote;
            ArronAttackQuote = card47AttackQuote;
            ArronAbilityQuote = card47AbilityQuote;
            ArronDeathQuote = card47DeathQuote;

            //button setup
            CRRAB = RAB;
           

            //rightArrow = new Buttoncollision(CRRAB, RABPosition);
            //leftArrow = new Buttoncollision(LAB, LABPosition);
            playMusicBackGround = new Buttoncollision(PIMB, PMBGBPosition);
            playEntranceQuote = new Buttoncollision(PEQB, PEQBPosition);
            playAttackQuote = new Buttoncollision(PATQB, PATQBPosition);
            playAbilityQuote = new Buttoncollision(PABQB, PABQBPosition);
            playDeathQuote = new Buttoncollision(PDQB, PDQBPosition);
            Exit = new Buttoncollision(exit, EBPosition);
            BackGround = BG;

            currentCard = Jacob_R_Card;
            currentCardIntroMusic = JacobRIntroMusic;
            currentCardEntrenceQuote = JacobREntrenceQuote;
            currentCardAttackQuote = JacobRAttackQuote;
            currentCardAbilityQuote = JacobRAbilityQuote;
            currentCardDeathQuote = JacobRDeathQuote;

            nextCard = Colin_Card;
            nextCardIntroMusic = ColinIntroMusic;
            nextCardEntrenceQuote = ColinEntrenceQuote;
            nextCardAttackQuote = ColinAttackQuote;
            nextCardAbilityQuote = ColinAbilityQuote;
            nextCardDeathQuote = ColinDeathQuote;
            
        }

        public void CurrentCardUpdate()
        {
            if (currentCard == Jacob_R_Card)
            {
                previousCard = resetCard;
                previousCardIntroMusic = resetIntroMusic;
                previousCardEntrenceQuote = resetEntrenceQuote;
                previousCardAttackQuote = resetAttackQuote;
                previousCardAbilityQuote = resetAbilityQuote;
                previousCardDeathQuote = resetDeathQuote;
            }
        }

        public void Update()
        {
            //rightArrow.CheckMouseCollision();
            //leftArrow.CheckMouseCollision();
            playMusicBackGround.CheckMouseCollision();
            playEntranceQuote.CheckMouseCollision();
            playAttackQuote.CheckMouseCollision();
            playAbilityQuote.CheckMouseCollision();
            playDeathQuote.CheckMouseCollision();
            Exit.CheckMouseCollision();

            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                if (currentCard == Arron_Card && currentCardIntroMusic == ArronIntroMusic && currentCardEntrenceQuote == ArronEntrenceQuote && currentCardAttackQuote == ArronAttackQuote && currentCardAbilityQuote == ArronAbilityQuote && currentCardDeathQuote == ArronDeathQuote)
                {

                }
                else
                {
                    currentCard = nextCard;
                    currentCardIntroMusic = nextCardIntroMusic;
                    currentCardEntrenceQuote = nextCardEntrenceQuote;
                    currentCardAttackQuote = nextCardAttackQuote;
                    currentCardAbilityQuote = nextCardAbilityQuote;
                    currentCardDeathQuote = nextCardDeathQuote;
                }
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                if (currentCard == Jacob_R_Card && currentCardIntroMusic == JacobRIntroMusic && currentCardEntrenceQuote == JacobREntrenceQuote && currentCardAttackQuote == JacobRAttackQuote && currentCardAbilityQuote == JacobRAbilityQuote && currentCardDeathQuote == JacobRDeathQuote)
                {

                }
                else
                {
                    currentCard = previousCard;
                    currentCardIntroMusic = previousCardIntroMusic;
                    currentCardEntrenceQuote = previousCardEntrenceQuote;
                    currentCardAttackQuote = previousCardAttackQuote;
                    currentCardAbilityQuote = previousCardAbilityQuote;
                    currentCardDeathQuote = previousCardDeathQuote;
                }
            }

            if (playMusicBackGround.complete == true)
            {

            }
            if (playEntranceQuote.complete == true)
            {

            }
            if (playAttackQuote.complete == true)
            {

            }
            if (playAbilityQuote.complete == true)
            {

            }
            if (playDeathQuote.complete == true)
            {

            }
            if (Exit.complete == true)
            {
                CREBIsClicked = true;
            }
        }
        
        public void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Begin();

            spritebatch.Draw(BackGround, new Rectangle(0, 0, 1080, 720), Color.White);
            spritebatch.Draw(currentCard, CCPosition, Color.White);

            spritebatch.End();

            //rightArrow.Draw(spritebatch);
            //leftArrow.Draw(spritebatch);
            playMusicBackGround.Draw(spritebatch);
            playEntranceQuote.Draw(spritebatch);
            playAttackQuote.Draw(spritebatch);
            playAbilityQuote.Draw(spritebatch);
            playDeathQuote.Draw(spritebatch);
            Exit.Draw(spritebatch);
        }
    }
}
