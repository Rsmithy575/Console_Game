using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Services;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace @try
{
    internal class Program
    {
        #region(Variables)
        static int dashTime = 0;
        static int milis = 450;
        static int line = 0;
        static int wait = 12;
        static int gameSpeed = 88;
        static int dashScore = 0;
        //static string password = "pass";
        static int powerSpeed = 0;
        static int timeSlowLine = 1000;
        static int powerMilis = 800;
        static bool ghost = false;
        static int ghostLine = 1000;
        static int timeSlowRT = 0;
        static List<string> dashScorePowerList = new List<string>();
        static List<string> dashScoreNakedList = new List<string>();
        static int refreshCount = 0;
        static int diceAmmount = 0;
        static int maxDiceNumber;
        static int userNumber = 0;
        static int rolledAmmount = 0;
        static bool spikeavail = false;
        static bool spikeactive = false;
        static int spikeline = 0;
        static int cooldown = 11;
        static string userpowerupinput;
        static int extraSpeed;
        static string dice1 = " ", dice2 = " ", dice3 = " ", dice4 = " ", dice5 = " ", dice6 = " ", dice7 = " ", dice8 = " ", dice9 = " ", dice10 = " ", dice11 = " ", dice12 = " ", dice13 = " ", dice14 = " ", dice15 = " ", dice16 = " ", dice17 = " ", dice18 = " ";
        static int Playerturn = 1;
        static bool kbgameActive = false;
        static bool kbrun1 = true;
        static string userDrawing = "";
        static string drawuserinput = "";
        static string drawlinebefore = "";
        static int currency = 10000;

        #region(halloween set)
        static string pumpkin = @"
  _||_  
 //++\\
|| || ||
 \\__//";
        static int pumpkincount;
        static string rare_pumpkin = @"
  __||__   
 / _  _ \
| / \/ \ |  
 \__UU__/";
        static int rare_pumpkincount;
        static string exotic_pumpkin = @"
 /=\  _||_  /=\
/ /\\/|\/|\//\ \
VV _|| VV ||_  VV
  / /\\__//\ \
  VV        VV";
        static int exotic_pumpkincount;
        static string skull = @"
 _--_
|()()|
\ /\ /
 ||||";
        static int skullcount;
        static string spider = @"
_    _
 \||/
==[]==
_/()\_";
        static int spidercount;
        static string candle = @"
  {}
 |--|
 | 6|
/|__|_";
        static int candlecount;
        #endregion

        #region(gaming set)
        static string imposter = @"
  ___
_| (__)
||   |
 |_|_|";
        static int impostercount;
        static string spooktuber = @"
  _==_
 //--\\
[|0 .0|]
 \\--//";
        static int spooktubercount;
        static string lil_cat = @"
|\---/|
/ *w* \
\__ __/
 ||-||";
        static int lil_catcount;
        static string rare_cat = @"
  |\---/|
/=/ owo \=\
|)\__ __/(|
UU ||-|| UU";
        static int rare_catcount;
        static string exotic_cat = @"
     I
  |\_I_/|
/=/ 0w0 \=\
|)\__ __/(|
VV ||-|| VV";
        static int exotic_catcount;
        static string herobrine = @"
 ______
|_----_|
|==__==|
|_[==]_|";
        static int herobrinecount;
        #endregion

        #region(mystic set)
        static string potion = @"
 ([])
  ||
 /__\
(. Oo)
 \0_/";
        static int potioncount;
        static string dragonegg = @"
  ___ 
 /UUU\
|UUUUU|
 \UUU/";
        static int dragoneggcount;
        static string crystal = @"
   /\\
/\ |||
| \|||/\
 \|_||_/";
        static int crystalcount;
        static string castle = @"
      -_-_-
      \___/
      |   |
      | _ |
      ||_||";
        static int castlecount;
        static string rarecastle = @"
         -_-_-
         \___/
   _-_   |   |   _-_
   | |-_-| _ |-_-| |
   |=|___||_||___|=|";
        static int rarecastlecount;
        static string exoticcastle = @"
          =_=_=
   ()     \___/     ()
  =__=    | _ |    =__=
  |[]|-_-_||_||_-_-|[]|
  |  | [] | _ | [] |  |
  |==|____||_||____|==|";
        static int exoticcastlecount;


        #endregion

        #endregion(variables)

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Script();

        }
        #region(Dash)
        static void imDead()
        {
            if (ghost == false)
            {
                //SpikeJump();
                Console.WriteLine(@"||");
                Console.WriteLine(@"||");
                Thread.Sleep(200);
                Console.WriteLine(@"||* *|-");
                Console.WriteLine(@"||/|//-* ))");
                Console.WriteLine(@"||//-*");
                Thread.Sleep(200);
                Console.WriteLine(@"----");
                Console.WriteLine(@"====----");
                Console.WriteLine(@"========---");
                Thread.Sleep(100);
                Console.WriteLine(@"====----");
                Console.WriteLine(@"----");
                Console.WriteLine(@">");
                Thread.Sleep(100);
                Console.WriteLine(@"====    =====   ====   ====");
                Console.WriteLine(@"||  \\  ||     ||  ||  ||  \\");
                Console.WriteLine(@"||  ||  ||===  ||  ||  ||  ||");
                Console.WriteLine(@"||  //  ||     ||==||  ||  //");
                Console.WriteLine(@"====    =====  ==  ==  ====");
                dashTime = 5000;
                Console.WriteLine("your Dash score was, " + dashScore + "!");
                Thread.Sleep(1000);
                dashScoreVoid();
                Thread.Sleep(1000);
                Console.Write("[Play again] or [Return]?: ");
                string AgainNo = Console.ReadLine();
                if (AgainNo == "Play again" || AgainNo == "play again")
                {
                    dash();
                }
                else if (AgainNo == "Return" || AgainNo == "return")
                {
                    option1();
                }
                else
                {
                    Console.WriteLine("Invalid input");
                    Thread.Sleep(1000);
                    option1();
                }

            }
            else
            {
                ghost = false;
                Console.WriteLine("GhostMode ending");
                Thread.Sleep(300);
                dashScore++;
                milis = (int)Math.Ceiling(milis / 2.0) + (milis / 4) + (milis / 5);
                wait -= 1;
                gameSpeed = (int)Math.Ceiling(gameSpeed / 2.0) + (gameSpeed / 4) + (gameSpeed / 5);

                dashScore += 1;
                spikeavail = true;
            }

        }

        private static void dashScoreVoid()
        {
            if (userpowerupinput == "yes" || userpowerupinput == "Yes")
            {
                Console.WriteLine("Enter your tag: ");
                Console.ReadLine();
                string playerTag = Console.ReadLine();
                dashScorePowerList.Add(playerTag + " : " + dashScore);
                Console.WriteLine("All time highest scores w/ powerups:");
                Thread.Sleep(500);
                Console.WriteLine("R.S : 15");
                Thread.Sleep(500);
                Console.WriteLine("Logs : 14");
                Thread.Sleep(500);
                Console.WriteLine("Ewok : 10");
                Thread.Sleep(500);
                Console.WriteLine("Ligma : 10");
                Thread.Sleep(500);
                Console.WriteLine("Spudz : 4");
                Thread.Sleep(500);
                Console.WriteLine("Local highest scores:");
                foreach (string liststring in dashScorePowerList)
                {
                    Console.WriteLine(liststring);
                }
            }
            else
            {
                Console.WriteLine("Enter your tag: ");
                Console.ReadLine();
                string playerTag = Console.ReadLine();
                dashScoreNakedList.Add(playerTag + " : " + dashScore);
                Console.WriteLine("All time highest scores w/o powerups:");
                Thread.Sleep(500);
                Console.WriteLine("Ligma : 22");
                Thread.Sleep(500);
                Console.WriteLine("R.S : 17");
                Thread.Sleep(500);
                Console.WriteLine("Local highest scores:");
                foreach (string liststring in dashScoreNakedList)
                {
                    Console.WriteLine(liststring);
                }
            }
        }
        private static void dash()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("Do you want to play with Powerups active? [Yes] or [No]");
            userpowerupinput = Console.ReadLine();
            if (userpowerupinput == "yes" || userpowerupinput == "Yes")
                Console.WriteLine("Press [Q],[W],[E],[R] to jump in acordance to corresponding situations.\n3,2,1 = [Q]\n3,1,2 = [W]\n3,2,I = [E]\n1,2,3 = [R]\nPowerups: Press space when a powerup symbol appears to activate\nGhostMode-for a short time survive if you hit a spike\nTimeSlow-for a short time, slow down the rate of the game\nRefresh-up to 2 refresh can be collected, if you press space when jumping it will consume 1 refresh and succeed the jump\nYou receive $5 for every completed jump.\n[enter] to start!");
            else if (userpowerupinput == "No" || userpowerupinput == "no")
                Console.WriteLine("Press [Q],[W],[E],[R] to jump in acordance to corresponding situations.\n3,2,1 = [Q]\n3,1,2 = [W]\n3,2,I = [E]\n1,2,3 = [R]\nYou receive $5 for every completed jump.\n[enter] to start!");
            else
            {
                Console.WriteLine("Invalid input");
                Thread.Sleep(1000);
                dash();
            }
            int startInput = Console.Read();
            bool spike = false;
            Random dashrng = new Random();
            int type = 0;

            milis = 450;
            line = 0;
            wait = 12;
            gameSpeed = 88;
            dashScore = 0;
            powerSpeed = 0;
            timeSlowLine = 1000;
            powerMilis = 800;
            ghost = false;
            ghostLine = 1000;
            timeSlowRT = 0;
            refreshCount = 0;




            if (startInput == 13)
            {

                for (dashTime = 0; dashTime < 1550; dashTime++)
                {

                    if (Console.KeyAvailable)
                    {



                        var key = Console.ReadKey(intercept: true).Key;
                        if (key == ConsoleKey.Q)
                        {
                            if (cooldown > 10)
                            {
                                Console.WriteLine(@"===");
                                Console.WriteLine(@"   ===");
                                Console.WriteLine(@"      ==");
                                Thread.Sleep(gameSpeed + timeSlowRT);
                                Console.WriteLine(@"        \\");
                                Console.WriteLine(@"          =");
                                Console.WriteLine(@"           \\");
                                Console.WriteLine(@"            ||");
                                Thread.Sleep(gameSpeed + timeSlowRT);
                                Console.WriteLine(@"           //");
                                Console.WriteLine(@"          =");
                                Console.WriteLine(@"        //");
                                Thread.Sleep(gameSpeed + timeSlowRT);
                                Console.WriteLine(@"      ==");
                                Console.WriteLine(@"   ===");
                                Console.WriteLine(@"===");

                                cooldown = 0;
                            }
                        }
                        else if (key == ConsoleKey.W)
                        {
                            if (cooldown > 10)
                            {
                                Console.WriteLine(@"===");
                                Console.WriteLine(@"   ===");
                                Console.WriteLine(@"      ==");
                                Thread.Sleep(gameSpeed + timeSlowRT);
                                Console.WriteLine(@"        \\");
                                Console.WriteLine(@"          =");
                                Console.WriteLine(@"           \\");
                                Console.WriteLine(@"            ||");
                                Thread.Sleep(gameSpeed + timeSlowRT);
                                Console.WriteLine(@"           //");
                                Console.WriteLine(@"          =");
                                Console.WriteLine(@"        //");
                                Thread.Sleep(gameSpeed + timeSlowRT);
                                Console.WriteLine(@"      ==");
                                Console.WriteLine(@"   ===");
                                Console.WriteLine(@"===");
                                cooldown = 0;
                            }

                        }
                        else if (key == ConsoleKey.E)
                        {
                            if (cooldown > 10)
                            {
                                Console.WriteLine(@"===");
                                Console.WriteLine(@"   ===");
                                Console.WriteLine(@"      ==");
                                Thread.Sleep(gameSpeed + timeSlowRT);
                                Console.WriteLine(@"        \\");
                                Console.WriteLine(@"          =");
                                Console.WriteLine(@"           \\");
                                Console.WriteLine(@"            ||");
                                Thread.Sleep(gameSpeed + timeSlowRT);
                                Console.WriteLine(@"           //");
                                Console.WriteLine(@"          =");
                                Console.WriteLine(@"        //");
                                Thread.Sleep(gameSpeed + timeSlowRT);
                                Console.WriteLine(@"      ==");
                                Console.WriteLine(@"   ===");
                                Console.WriteLine(@"===");
                                cooldown = 0;
                            }

                        }
                        else if (key == ConsoleKey.R)
                        {
                            if (cooldown > 10)
                            {
                                Console.WriteLine(@"===");
                                Console.WriteLine(@"   ===");
                                Console.WriteLine(@"      ==");
                                Thread.Sleep(gameSpeed + timeSlowRT);
                                Console.WriteLine(@"        \\");
                                Console.WriteLine(@"          =");
                                Console.WriteLine(@"           \\");
                                Console.WriteLine(@"            ||");
                                Thread.Sleep(gameSpeed + timeSlowRT);
                                Console.WriteLine(@"           //");
                                Console.WriteLine(@"          =");
                                Console.WriteLine(@"        //");
                                Thread.Sleep(gameSpeed + timeSlowRT);
                                Console.WriteLine(@"      ==");
                                Console.WriteLine(@"   ===");
                                Console.WriteLine(@"===");
                                cooldown = 0;
                            }

                        }
                        else
                        {

                        }


                    }
                    else
                    {
                        if (refreshCount == 0)
                        {
                            Console.WriteLine("||\n||");
                        }
                        else if (refreshCount == 1)
                        {
                            Console.WriteLine("||\n||.");
                        }
                        else if (refreshCount == 2)
                        {
                            Console.WriteLine("||\n||..");
                        }

                    }

                    Thread.Sleep(gameSpeed - extraSpeed);
                    Thread.Sleep(powerSpeed);
                    cooldown++;
                    if (userpowerupinput == "yes" || userpowerupinput == "Yes")
                    {
                        int powerChance = dashrng.Next(1, 150);
                        if (powerChance == 1)
                        {
                            int powerUp = dashrng.Next(1, 5);
                            if (powerUp == 1)
                            {
                                Console.WriteLine(@"||                      __--__");
                                Console.WriteLine(@"||                     |.'  /.|");
                                Console.WriteLine(@"||                    | ' () ' |");
                                Console.WriteLine(@"||                     |'. |.'|");
                                Console.WriteLine(@"||                      --__--");
                                Thread.Sleep(powerMilis);
                                if (Console.KeyAvailable)
                                {
                                    var key = Console.ReadKey(intercept: true).Key;
                                    if (key == ConsoleKey.Spacebar)
                                    {
                                        {
                                            timeSlowLine = dashTime;
                                            powerSpeed = 200;
                                            Console.WriteLine("TimeSlow activated");
                                            Thread.Sleep(300);
                                            timeSlowRT = 200;
                                        }
                                    }
                                }

                            }
                            else if (powerUp == 2)
                            {
                                Console.WriteLine(@"||                     _--_");
                                Console.WriteLine(@"||                    / 00 \ ");
                                Console.WriteLine(@"||                    | o  |");
                                Console.WriteLine(@"||                    |/\/\|");
                                Thread.Sleep(powerMilis);
                                if (Console.KeyAvailable)
                                {
                                    var key = Console.ReadKey(intercept: true).Key;
                                    if (key == ConsoleKey.Spacebar)
                                    {
                                        {
                                            ghostLine = dashTime;
                                            ghost = true;
                                            Console.WriteLine("GhostMode activated");
                                            Thread.Sleep(500);
                                        }
                                    }
                                }
                            }
                            else if (powerUp == 3 || powerUp == 4)
                            {
                                Console.WriteLine(@"||                   . () 0 ");
                                Console.WriteLine(@"||                     .O 'o ");
                                Console.WriteLine(@"||                    o _--_ ");
                                Console.WriteLine(@"||                     |-__-|");
                                Console.WriteLine(@"||                      -__- ");
                                Thread.Sleep(powerMilis);
                                if (Console.KeyAvailable)
                                {
                                    var key = Console.ReadKey(intercept: true).Key;
                                    if (key == ConsoleKey.Spacebar)
                                    {
                                        {
                                            if (refreshCount < 2)
                                            {
                                                Console.WriteLine("Refresh added");
                                                refreshCount++;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Maximum refresh held");
                                            }

                                        }
                                    }
                                }
                            }
                        }
                        if (dashTime == (timeSlowLine + 30))
                        {
                            Console.WriteLine("TimeSlow speeding up");
                            powerSpeed = 150;
                            timeSlowRT = 150;
                        }
                        if (dashTime == (timeSlowLine + 35))
                        {
                            powerSpeed = 100;
                            timeSlowRT = 100;
                        }
                        if (dashTime == (timeSlowLine + 40))
                        {
                            powerSpeed = 50;
                            timeSlowRT = 50;
                        }
                        if (dashTime == (timeSlowLine + 45))
                        {
                            powerSpeed = 0;
                            timeSlowRT = 0;
                        }
                        if (dashTime == (ghostLine + 50))
                        {
                            if (ghost == true)
                            {

                                ghost = false;
                                Console.WriteLine("GhostMode ending");

                            }
                        }
                    }



                    if (dashTime == 20)
                    {
                        line = 20;
                        spike = true;
                        spikeavail = false;
                    }
                    if (spikeavail == true)
                    {
                        spikeavail = false;
                        spikeactive = true;
                        spikeline = dashTime;
                    }
                    if (spikeactive == true)
                    {
                        if (dashTime == spikeline + wait)
                        {
                            spikeactive = false;
                            line = dashTime;
                        }
                    }
                    if (dashTime > 800)
                    {
                        Console.WriteLine(@" ==  ==  =====  ==  ==     ==    == == ==  ==");
                        Console.WriteLine(@"  \\//  //   \\ ||  ||     ||    || || ||\ ||");
                        Console.WriteLine(@"   ||   ||   || ||  ||     || /\ || || ||\\||");
                        Console.WriteLine(@"   ||   \\   // \\  //     ||//\\|| || || \||");
                        Console.WriteLine(@"   ==    =====   ====      ===  === == ==  ==");
                        dashTime = 800;
                        Console.WriteLine("your Dash score was, " + dashScore + "!");
                        Thread.Sleep(1000);
                        dashScoreVoid();
                        Thread.Sleep(1000);
                        Console.Write("[Play again] or [Return]?: ");
                        string AgainNo = Console.ReadLine();
                        if (AgainNo == "Play again" || AgainNo == "play again")
                        {
                            dash();
                        }
                        else if (AgainNo == "Return" || AgainNo == "return")
                        {
                            option1();
                        }
                        else
                        {
                            Console.WriteLine("Invalid input");
                            Thread.Sleep(1000);
                            option1();
                        }
                    }


                    if (spike == true)
                    {


                        if (dashTime == line)
                        {
                            type = dashrng.Next(1, 5);
                        }

                        if (type == 1)
                        {

                            bool dead = false;
                            if (dashTime == line)
                            {
                                Console.WriteLine(@"||  ===\");
                                Console.WriteLine("||     ||");
                                Console.WriteLine("||  ===|");
                                Console.WriteLine("||     ||");
                                Console.WriteLine("||  ===/");
                            }
                            if (dashTime == line + wait)
                            {
                                Console.WriteLine(@"||  ====\");
                                Console.WriteLine("||     ||");
                                Console.WriteLine("||    //");
                                Console.WriteLine("||   //");
                                Console.WriteLine(@"||  =====");

                            }
                            if (dashTime == line + (wait * 2))
                            {
                                Console.WriteLine("||  ==|");
                                Console.WriteLine("||   ||");
                                Console.WriteLine("||   ||");
                                Console.WriteLine("||   ||");
                                Console.WriteLine("||  ====");

                            }
                            if (dashTime == line + ((wait * 3)))
                            {

                                Console.WriteLine(@"||  ====  ==   ==  ==    ==  ||==\\");
                                Console.WriteLine(@"||    ||  ||   ||  |\\  //|  ||  ||");
                                Console.WriteLine(@"||    ||  ||   ||  ||\\//||  ||==//");
                                Console.WriteLine(@"||    ||  \\   //  || -- ||  ||");
                                Console.WriteLine(@"||  ==//   \===/   ||    ||  ||");
                                Thread.Sleep(milis + timeSlowRT);
                                if (Console.KeyAvailable)
                                {
                                    var key = Console.ReadKey(intercept: true).Key;
                                    if (key == ConsoleKey.Q)
                                    {
                                        SpikeJump();
                                    }
                                    else if (refreshCount > 0)
                                    {
                                        RefreshJump(key);
                                    }
                                    else
                                    {
                                        imDead();
                                    }

                                }
                                else
                                {
                                    dead = true;
                                }
                                if (dead == true)
                                {
                                    imDead();
                                }
                            }


                        }
                        else if (type == 2)
                        {
                            bool dead = false;
                            if (dashTime == line)
                            {
                                Console.WriteLine(@"||  ===\");
                                Console.WriteLine("||     ||");
                                Console.WriteLine("||  ===|");
                                Console.WriteLine("||     ||");
                                Console.WriteLine("||  ===/");
                            }
                            if (dashTime == line + wait)
                            {
                                Console.WriteLine("||  ==|");
                                Console.WriteLine("||   ||");
                                Console.WriteLine("||   ||");
                                Console.WriteLine("||   ||");
                                Console.WriteLine("||  ====");

                            }
                            if (dashTime == line + (wait * 2))
                            {
                                Console.WriteLine(@"||  ====\");
                                Console.WriteLine("||     ||");
                                Console.WriteLine("||    //");
                                Console.WriteLine("||   //");
                                Console.WriteLine(@"||  =====");

                            }
                            if (dashTime == line + ((wait * 3)))
                            {

                                Console.WriteLine(@"||  ====  ==   ==  ==    ==  ||==\\");
                                Console.WriteLine(@"||    ||  ||   ||  |\\  //|  ||  ||");
                                Console.WriteLine(@"||    ||  ||   ||  ||\\//||  ||==//");
                                Console.WriteLine(@"||    ||  \\   //  || -- ||  ||");
                                Console.WriteLine(@"||  ==//   \===/   ||    ||  ||");
                                Thread.Sleep(milis + timeSlowRT);
                                if (Console.KeyAvailable)
                                {
                                    var key = Console.ReadKey(intercept: true).Key;
                                    if (key == ConsoleKey.W)
                                    {
                                        SpikeJump();
                                    }
                                    else if (refreshCount > 0)
                                    {
                                        RefreshJump(key);
                                    }
                                    else
                                    {
                                        imDead();
                                    }

                                }
                                else
                                {
                                    dead = true;
                                }
                                if (dead == true)
                                {
                                    imDead();
                                }
                            }
                        }
                        else if (type == 3)
                        {
                            bool dead = false;
                            if (dashTime == line)
                            {
                                Console.WriteLine(@"||  ====");
                                Console.WriteLine("||     ||");
                                Console.WriteLine("||  ====");
                                Console.WriteLine("||     ||");
                                Console.WriteLine("||  ====");
                            }
                            if (dashTime == line + wait)
                            {
                                Console.WriteLine(@"||  ====\");
                                Console.WriteLine("||     ||");
                                Console.WriteLine("||    //");
                                Console.WriteLine("||   //");
                                Console.WriteLine(@"||  =====");

                            }
                            if (dashTime == line + (wait * 2))
                            {
                                Console.WriteLine("||  ====");
                                Console.WriteLine("||   ||");
                                Console.WriteLine("||   ||");
                                Console.WriteLine("||   ||");
                                Console.WriteLine("||  ====");

                            }
                            if (dashTime == line + ((wait * 3)))
                            {

                                Console.WriteLine(@"||  ====  ==   ==  ==    ==  ||==\\");
                                Console.WriteLine(@"||    ||  ||   ||  |\\  //|  ||  ||");
                                Console.WriteLine(@"||    ||  ||   ||  ||\\//||  ||==//");
                                Console.WriteLine(@"||    ||  \\   //  || -- ||  ||");
                                Console.WriteLine(@"||  ==//   \===/   ||    ||  ||");
                                Thread.Sleep(milis + timeSlowRT);
                                if (Console.KeyAvailable)
                                {
                                    var key = Console.ReadKey(intercept: true).Key;
                                    if (key == ConsoleKey.E)
                                    {
                                        SpikeJump();
                                    }
                                    else if (refreshCount > 0)
                                    {
                                        RefreshJump(key);
                                    }
                                    else
                                    {
                                        imDead();
                                    }

                                }
                                else
                                {
                                    dead = true;
                                }
                                if (dead == true)
                                {
                                    imDead();
                                }
                            }
                        }
                        else if (type == 4)
                        {
                            bool dead = false;
                            if (dashTime == line)
                            {
                                Console.WriteLine("||  ==|");
                                Console.WriteLine("||   ||");
                                Console.WriteLine("||   ||");
                                Console.WriteLine("||   ||");
                                Console.WriteLine("||  ====");
                            }
                            if (dashTime == line + wait)
                            {
                                Console.WriteLine(@"||  ===\");
                                Console.WriteLine("||     ||");
                                Console.WriteLine("||    //");
                                Console.WriteLine("||   //");
                                Console.WriteLine(@"||  =====");

                            }
                            if (dashTime == line + (wait * 2))
                            {
                                Console.WriteLine(@"||  ===\");
                                Console.WriteLine("||     ||");
                                Console.WriteLine("||  ===|");
                                Console.WriteLine("||     ||");
                                Console.WriteLine("||  ===/");

                            }
                            if (dashTime == line + ((wait * 3)))
                            {

                                Console.WriteLine(@"||  ====  ==   ==  ==    ==  ||==\\");
                                Console.WriteLine(@"||    ||  ||   ||  |\\  //|  ||  ||");
                                Console.WriteLine(@"||    ||  ||   ||  ||\\//||  ||==//");
                                Console.WriteLine(@"||    ||  \\   //  || -- ||  ||");
                                Console.WriteLine(@"||  ==//   \===/   ||    ||  ||");
                                Thread.Sleep(milis + timeSlowRT);
                                if (Console.KeyAvailable)
                                {
                                    var key = Console.ReadKey(intercept: true).Key;
                                    if (key == ConsoleKey.R)
                                    {
                                        //cooldown = SpikeJump(cooldown);
                                        SpikeJump();

                                    }
                                    else if (refreshCount > 0)
                                    {
                                        RefreshJump(key);
                                    }
                                    else
                                    {
                                        imDead();
                                    }

                                }
                                else
                                {
                                    dead = true;
                                }
                                if (dead == true)
                                {
                                    imDead();
                                }
                            }
                        }
                    }


                }

            }
            else
            {
                Console.WriteLine("Invalid input");
                dash();
            }
        }

        private static void RefreshJump(ConsoleKey key)
        {
            if (key == ConsoleKey.Spacebar)
            {
                Console.WriteLine(@"===");
                Console.WriteLine(@"   ===");
                Console.WriteLine(@">     ==");
                Thread.Sleep(gameSpeed + timeSlowRT);
                Console.WriteLine(@"        \\");
                Console.WriteLine(@"----      =");
                Console.WriteLine(@"====----   \\");
                Console.WriteLine(@"========--- ||");
                Thread.Sleep(gameSpeed + timeSlowRT);
                Console.WriteLine(@"====----   //");
                Console.WriteLine(@"----      =");
                Console.WriteLine(@">       //");
                Thread.Sleep(gameSpeed + timeSlowRT);
                Console.WriteLine(@"      ==");
                Console.WriteLine(@"   ===");
                Console.WriteLine(@"===");
                Console.WriteLine("Refresh consumed");
                if (dashTime < 350)
                {
                    gameSpeed = (int)Math.Ceiling(gameSpeed / 2.0) + (gameSpeed / 4) + (gameSpeed / 6);
                    milis = (int)Math.Ceiling(milis / 2.0) + (milis / 4) + (milis / 6);
                }
                else
                {
                    if (wait > 3)
                        wait--;
                }
                dashScore += 1;
                refreshCount--;
                spikeavail = true;
                cooldown = 0;
            }
            else
            {
                imDead();
            }
        }

        private static void SpikeJump()
        {
            //private static int SpikeJump(Cooldown)
            if (cooldown > 10)
            {
                Console.WriteLine(@"===");
                Console.WriteLine(@"   ===");
                Console.WriteLine(@">     ==");
                Thread.Sleep(gameSpeed + timeSlowRT);
                Console.WriteLine(@"        \\");
                Console.WriteLine(@"----      =");
                Console.WriteLine(@"====----   \\");
                Console.WriteLine(@"========--- ||");
                Thread.Sleep(gameSpeed + timeSlowRT);
                Console.WriteLine(@"====----   //");
                Console.WriteLine(@"----      =");
                Console.WriteLine(@">       //");
                Thread.Sleep(gameSpeed + timeSlowRT);
                Console.WriteLine(@"      ==");
                Console.WriteLine(@"   ===");
                Console.WriteLine(@"===");
                if (dashTime < 350)
                {
                    gameSpeed = (int)Math.Ceiling(gameSpeed / 2.0) + (gameSpeed / 4) + (gameSpeed / 6);
                    milis = (int)Math.Ceiling(milis / 2.0) + (milis / 4) + (milis / 6);
                }
                else
                {
                    if (wait > 3)
                        wait--;
                }
                dashScore += 1;
                currency = currency + 5;
                cooldown = 0;
                spikeavail = true;
            }
            else
            {
                imDead();
            }

            //return cooldown;
        }
        #endregion
        private static void Script()
        {

            //Console.Write("input password: ");
            //String input = Console.ReadLine();

            //if (input == password)
            //{
            //    Console.WriteLine("Access Granted");
            //    option1();

            //}
            //else
            //{
            //    Console.WriteLine("Access Denied");
            //    Script();
            //}
            option1();
        }
        #region(nots and crosses)
        private static void player1(string[] NCnumbers)
        {

            string NCinput1 = Console.ReadLine();
            int.TryParse(NCinput1, out int NCinInt);
            if (NCinput1 == "1" || NCinput1 == "2" || NCinput1 == "3" ||
                NCinput1 == "4" || NCinput1 == "5" || NCinput1 == "6" ||
                 NCinput1 == "7" || NCinput1 == "8" || NCinput1 == "9")
            {
                if (NCnumbers[NCinInt - 1] == "X")
                {
                    Console.WriteLine("Invalid input");
                    player1(NCnumbers);
                }
                else if (NCnumbers[NCinInt - 1] == "O")
                {
                    Console.WriteLine("Invalid input");
                    player1(NCnumbers);
                }
                else
                {
                    if (NCinInt >= 1 && NCinInt <= 9)
                    {
                        NCnumbers[NCinInt - 1] = "X";
                    }
                    else
                    {
                        Console.WriteLine("invalid input");
                        player1(NCnumbers);
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
                player1(NCnumbers);
            }



        }
        private static void NorC()
        {

            bool NCgame = true;
            string[] NCnumbers = new string[9];
            for (int NCi = 0; NCi < 9; NCi++)
            {
                NCnumbers[NCi] = (NCi + 1).ToString();
            }
            double NCtime = 0;
            for (NCtime = 0; NCtime < 2.5; NCtime += 0.5)
            {
                if (NCgame == true)
                {
                    Console.Clear();
                    Console.WriteLine(NCnumbers[0] + " |" + NCnumbers[1] + " |" + NCnumbers[2]);
                    Console.WriteLine("--+--+--");
                    Console.WriteLine(NCnumbers[3] + " |" + NCnumbers[4] + " |" + NCnumbers[5]);
                    Console.WriteLine("--+--+--");
                    Console.WriteLine(NCnumbers[6] + " |" + NCnumbers[7] + " |" + NCnumbers[8]);
                    player1(NCnumbers);
                    if (NCnumbers[0] == "X" & NCnumbers[1] == "X" & NCnumbers[2] == "X")
                    {
                        Console.WriteLine("Player1 wins!");
                        NCgame = false;
                    }
                    else if (NCnumbers[3] == "X" & NCnumbers[4] == "X" & NCnumbers[5] == "X")
                    {
                        Console.WriteLine("Player1 wins!");
                        NCgame = false;
                    }
                    else if (NCnumbers[6] == "X" & NCnumbers[7] == "X" & NCnumbers[8] == "X")
                    {
                        Console.WriteLine("Player1 wins!");
                        NCgame = false;
                    }
                    else if (NCnumbers[0] == "X" & NCnumbers[3] == "X" & NCnumbers[6] == "X")
                    {
                        Console.WriteLine("Player1 wins!");
                        NCgame = false;
                    }
                    else if (NCnumbers[1] == "X" & NCnumbers[4] == "X" & NCnumbers[7] == "X")
                    {
                        Console.WriteLine("Player1 wins!");
                        NCgame = false;
                    }
                    else if (NCnumbers[2] == "X" & NCnumbers[5] == "X" & NCnumbers[8] == "X")
                    {
                        Console.WriteLine("Player1 wins!");
                        NCgame = false;
                    }
                    else if (NCnumbers[0] == "X" & NCnumbers[4] == "X" & NCnumbers[8] == "X")
                    {
                        Console.WriteLine("Player1 wins!");
                        NCgame = false;
                    }
                    else if (NCnumbers[2] == "X" & NCnumbers[4] == "X" & NCnumbers[6] == "X")
                    {
                        Console.WriteLine("Player1 wins!");
                        NCgame = false;
                    }
                    else if (NCtime == 2)
                    {


                        Console.WriteLine(NCnumbers[0] + " |" + NCnumbers[1] + " |" + NCnumbers[2]);
                        Console.WriteLine("--+--+--");
                        Console.WriteLine(NCnumbers[3] + " |" + NCnumbers[4] + " |" + NCnumbers[5]);
                        Console.WriteLine("--+--+--");
                        Console.WriteLine(NCnumbers[6] + " |" + NCnumbers[7] + " |" + NCnumbers[8]);
                        Console.WriteLine("Tied!");
                        NCgame = false;
                    }
                }
                else
                {
                    Console.Write("[Play again] or [Return]?: ");
                    string AgainNo = Console.ReadLine();
                    if (AgainNo == "Play again")
                    {
                        NorC();
                    }
                    else if (AgainNo == "Return")
                    {
                        option1();
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                }
                if (NCgame == true)
                {
                    Console.Clear();
                    Console.WriteLine(NCnumbers[0] + " |" + NCnumbers[1] + " |" + NCnumbers[2]);
                    Console.WriteLine("--+--+--");
                    Console.WriteLine(NCnumbers[3] + " |" + NCnumbers[4] + " |" + NCnumbers[5]);
                    Console.WriteLine("--+--+--");
                    Console.WriteLine(NCnumbers[6] + " |" + NCnumbers[7] + " |" + NCnumbers[8]);
                    player2(NCnumbers);
                    if (NCnumbers[0] == "O" & NCnumbers[1] == "O" & NCnumbers[2] == "O")
                    {
                        Console.WriteLine("Player2 wins!");
                        NCgame = false;
                    }
                    else if (NCnumbers[3] == "O" & NCnumbers[4] == "O" & NCnumbers[5] == "O")
                    {
                        Console.WriteLine("Player2 wins!");
                        NCgame = false;
                    }
                    else if (NCnumbers[6] == "O" & NCnumbers[7] == "O" & NCnumbers[8] == "O")
                    {
                        Console.WriteLine("Player2 wins!");
                        NCgame = false;
                    }
                    else if (NCnumbers[0] == "O" & NCnumbers[3] == "O" & NCnumbers[6] == "O")
                    {
                        Console.WriteLine("Player2 wins!");
                        NCgame = false;
                    }
                    else if (NCnumbers[1] == "O" & NCnumbers[4] == "O" & NCnumbers[7] == "O")
                    {
                        Console.WriteLine("Player2 wins!");
                        NCgame = false;
                    }
                    else if (NCnumbers[2] == "O" & NCnumbers[5] == "O" & NCnumbers[8] == "O")
                    {
                        Console.WriteLine("Player2 wins!");
                        NCgame = false;
                    }
                    else if (NCnumbers[0] == "O" & NCnumbers[4] == "O" & NCnumbers[8] == "O")
                    {
                        Console.WriteLine("Player2 wins!");
                        NCgame = false;
                    }
                    else if (NCnumbers[2] == "O" & NCnumbers[4] == "O" & NCnumbers[6] == "O")
                    {
                        Console.WriteLine("Player2 wins!");
                        NCgame = false;
                    }
                    else if (NCtime == 2)
                    {


                        Console.WriteLine(NCnumbers[0] + " |" + NCnumbers[1] + " |" + NCnumbers[2]);
                        Console.WriteLine("--+--+--");
                        Console.WriteLine(NCnumbers[3] + " |" + NCnumbers[4] + " |" + NCnumbers[5]);
                        Console.WriteLine("--+--+--");
                        Console.WriteLine(NCnumbers[6] + " |" + NCnumbers[7] + " |" + NCnumbers[8]);
                        Console.WriteLine("Tied!");
                        NCgame = false;
                    }
                }
                else
                {
                    Console.WriteLine(NCnumbers[0] + " |" + NCnumbers[1] + " |" + NCnumbers[2]);
                    Console.WriteLine("--+--+--");
                    Console.WriteLine(NCnumbers[3] + " |" + NCnumbers[4] + " |" + NCnumbers[5]);
                    Console.WriteLine("--+--+--");
                    Console.WriteLine(NCnumbers[6] + " |" + NCnumbers[7] + " |" + NCnumbers[8]);
                    Console.Write("[Play again] or [Return]?: ");
                    string AgainNo = Console.ReadLine();
                    if (AgainNo == "Play again" || AgainNo == "play again")
                    {
                        NorC();
                    }
                    else if (AgainNo == "Return" || AgainNo == "return")
                    {
                        option1();
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                        Thread.Sleep(1000);
                        option1();
                    }
                }

            }





        }
        private static void player2(string[] NCnumbers)
        {

            string NCinput2 = Console.ReadLine();
            int.TryParse(NCinput2, out int NCinInt2);
            if (NCinput2 == "1" || NCinput2 == "2" || NCinput2 == "3" ||
                NCinput2 == "4" || NCinput2 == "5" || NCinput2 == "6" ||
                 NCinput2 == "7" || NCinput2 == "8" || NCinput2 == "9")
            {
                if (NCnumbers[NCinInt2 - 1] == "X")
                {
                    Console.WriteLine("Invalid input");
                    player2(NCnumbers);
                }
                else if (NCnumbers[NCinInt2 - 1] == "O")
                {
                    Console.WriteLine("Invalid input");
                    player2(NCnumbers);
                }
                else
                {
                    if (NCinInt2 >= 1 && NCinInt2 <= 9)
                    {
                        NCnumbers[NCinInt2 - 1] = "O";
                    }
                    else
                    {
                        Console.WriteLine("invalid input");
                        player2(NCnumbers);
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
                player2(NCnumbers);
            }


        }
        #endregion
        private static void option1()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.WriteLine("                                                    balance: $" + currency);
            Console.WriteLine("what would you like to do?");
            //Console.WriteLine("1. Change password");
            //Console.WriteLine("2. Log out");
            Console.WriteLine("3. Open images");
            Console.WriteLine("4. Play game");
            Console.WriteLine("5. Draw");
            Console.WriteLine("6. Gamble");
            Console.WriteLine("7. Item storage");
            string todo = Console.ReadLine();

            if (todo == "4")
            {
                gameSelect(todo);
            }
            else if (todo == "3")
            {
                Console.Clear();
                Console.WriteLine("Two images present:\n ");
                Console.WriteLine("________________");
                Console.WriteLine("|              |");
                Console.WriteLine("|   ___        |");
                Console.WriteLine("| [|(_)|=>_I_  |");
                Console.WriteLine("|  |_-_| |_-_| | ");
                Console.WriteLine("|              |");
                Console.WriteLine("----------------\n");

                Console.WriteLine(@" ------------");
                Console.WriteLine(@"|   __--__   |");
                Console.WriteLine(@"|  |      |  |");
                Console.WriteLine(@"| | ()  () | |");
                Console.WriteLine(@"|  |  uu  |  |");
                Console.WriteLine(@"|   --__--   |");
                Console.WriteLine(@" ------------");


                Console.WriteLine("Return ?");
                string imgreturn = Console.ReadLine();
                if (imgreturn == "Return")
                {
                    option1();
                }
                else
                {
                    option1();
                }
            }
            //else if (todo == "2")
            //{
            //    Console.Clear();
            //    Script();
            //}
            //else if (todo == "1")
            //{
            //    Console.Clear();
            //    Console.Write("What would you like to change your password to?: ");
            //    password = Console.ReadLine();

            //    Console.WriteLine("Password changed to, " + password);
            //    option1();
            //}
            else if (todo == "5")
            {
                drawing();
            }
            else if (todo == "6")
            {
                gambleSelect();
            }
            else if (todo == "7")
            {
                itemStorage();
            }
            else
            {
                Console.WriteLine("Invalid Input");
                option1();
            }

        }

        #region(gambling)
        private static void gambleSelect()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine("                                                    balance: $" + currency);
            Console.WriteLine("1. Roulette Wheel");
            Console.WriteLine("2. Russian Roulette");
            Console.WriteLine("3. Slot Machine");
            Console.WriteLine("4. Claw Machine");
            Console.WriteLine("5. Return");

            string ginput = Console.ReadLine();
            if (ginput == "1")
            {
                rouletteWheel();
            }
            else if (ginput == "2")
            {
                russianRoulette();
            }
            else if (ginput == "3")
            {
                slotMachine();
            }
            else if (ginput == "4")
            {
                clawMachine();
            }
            else if (ginput == "5")
            {
                option1();
            }
            else
            {
                Console.WriteLine("Invalid Input");
                Thread.Sleep(500);
                gambleSelect();
            }
        }

        private static void russianRoulette()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Russian Roulette,\nin this game you bet an ammount, then take it in turns with your oponent to shoot a 6 shot revolver,\nthere is one bullet in the gun.\nIf you shoot your money you lose it, but if the oponent does first you gain double your bet.");
            Thread.Sleep(1000);
            Console.WriteLine("Would you like to [Play] or [Return]?");
            string rrrR = Console.ReadLine();
            if (rrrR == "Return" || rrrR == "return")
            {
                gambleSelect();
            }
            else if (rrrR == "Play" || rrrR == "play")
            {
                russianRouletteGame();
            }
            else
            {
                Console.WriteLine("Invalid input");
                Thread.Sleep(1000);
                gambleSelect();
            }


        }

        private static void russianRouletteGame()
        {
            bool rrgameactive = true;
            Console.WriteLine("How much do you wish to bet? You have " + currency + " dollars.");
            string betopt = Console.ReadLine();
            int betNumInt;
            bool success = int.TryParse(betopt, out betNumInt);

            if (success && !(betNumInt > currency) && betNumInt > 0)
            {
                Console.WriteLine("you bet " + betNumInt + " dollars");
                currency = currency - betNumInt;
            }
            else
            {
                Console.WriteLine("Invalid input, enter a valid number");
                Thread.Sleep(2000);
                numberguess();
            }
            Console.Clear();
            Console.WriteLine("Get ready to play...");
            int bullets = 6;
            Thread.Sleep(2000);
            Console.WriteLine("You start,");
            Random bulletpull = new Random();
            int bulletpullint;
            while (rrgameactive == true)
            {
                Console.WriteLine("pull the trigger by pressing [enter]");
                var key = Console.ReadKey(intercept: true).Key;
                if (key == ConsoleKey.Enter)
                {

                    bulletpullint = bulletpull.Next(1, (bullets + 1));
                    bullets -= 1;
                    if (bulletpullint == 1)
                    {
                        rrgameactive = false;
                        Console.Clear();
                        Console.WriteLine("Oh no you shot your bet, better luck next time!");
                        Thread.Sleep(1000);
                        Console.Write("[Play again] or [Return]?: ");
                        string rrrR = Console.ReadLine();
                        if (rrrR == "Play again" || rrrR == "play again")
                        {
                            russianRoulette();
                        }
                        else if (rrrR == "Return" || rrrR == "return")
                        {
                            gambleSelect();
                        }
                        else
                        {
                            Console.WriteLine("Invalid input");
                            Thread.Sleep(1000);
                            gambleSelect();
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You survive this shot, its the oponents turn");

                        Thread.Sleep(2000);
                        Console.Clear();
                        Console.WriteLine("oponent playing");
                        Thread.Sleep(500);
                        Console.Clear();
                        Console.WriteLine("oponent playing.");
                        Thread.Sleep(500);
                        Console.Clear();
                        Console.WriteLine("oponent playing..");
                        Thread.Sleep(500);
                        Console.Clear();
                        Console.WriteLine("oponent playing...");
                        Thread.Sleep(500);
                        Console.Clear();
                        bulletpullint = bulletpull.Next(1, (bullets + 1));
                        bullets -= 1;
                        if (bulletpullint == 1)
                        {
                            Console.WriteLine("Oponent survived this shot, its your turn");
                        }
                        else
                        {
                            rrgameactive = false;
                            Console.WriteLine("oponent got shot! YOU WIN!");
                            Console.WriteLine("Your balance changed from " + currency + " to " + (currency + (betNumInt * 2)) + "!");
                            currency = currency + (betNumInt * 2);
                            Thread.Sleep(1000);
                            Console.Write("[Play again] or [Return]?: ");
                            string rrrR = Console.ReadLine();
                            if (rrrR == "Play again" || rrrR == "play again")
                            {
                                russianRoulette();
                            }
                            else if (rrrR == "Return" || rrrR == "return")
                            {
                                gambleSelect();
                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                                Thread.Sleep(1000);
                                gambleSelect();
                            }
                        }
                    }
                }
            }

        }

        private static void rouletteWheel()
        {
            Console.Clear();
            Console.WriteLine("you have " + currency + " dollars");
            Console.WriteLine("In the roulette wheel you chave a choice between red/black or number guessing. \nWith red/black you have a 50/50 chance of gaining double your bet if it lands on the guessed colour, or losing your bet.\nIn number guess, if your guessed number is whats landed on, you gain 5x your bet!!");
            Thread.Sleep(1000);
            Console.WriteLine("Do you want to play [red/black] or [number guess]?");
            string rwinput = Console.ReadLine();
            if (rwinput == "red/black")
            {
                redblack();
            }
            else if (rwinput == "number guess")
            {
                numberguess();
            }
            else
            {
                Console.WriteLine("invalid input");
                rouletteWheel();
            }
        }

        private static void numberguess()
        {
            Console.Clear();
            Console.WriteLine("How much do you wish to bet? You have " + currency + " dollars.");
            string betopt = Console.ReadLine();
            int betNumInt;
            bool success = int.TryParse(betopt, out betNumInt);

            if (success && !(betNumInt > currency) && betNumInt > 0)
            {
                Console.WriteLine("you bet " + betNumInt + " dollars");
                currency = currency - betNumInt;
            }
            else
            {
                Console.WriteLine("Invalid input, enter a valid number");
                Thread.Sleep(2000);
                numberguess();
            }
            Console.WriteLine("What number do you wish to bet on? (1-6)");
            betopt = Console.ReadLine();
            int tableNumInt;
            bool success2 = int.TryParse(betopt, out tableNumInt);

            if (success)
            {
                Console.WriteLine("you bet on: " + tableNumInt);
            }
            else
            {
                Console.WriteLine("Invalid input, enter a valid number");
                Thread.Sleep(2000);
                numberguess();
            }

            Thread.Sleep(500);
            Console.Clear();
            #region(rolling animation)
            Console.WriteLine(@"        _________");
            Console.WriteLine(@"     --/ 1__|__2 \--");
            Console.WriteLine(@"   -   \_/     \_/   -");
            Console.WriteLine(@"  | \ /-    0     \ / |");
            Console.WriteLine(@" |8  /      |      \  3|");
            Console.WriteLine(@" |--|  ()---H---()  |--|");
            Console.WriteLine(@" |7  \      |      /  4|");
            Console.WriteLine(@"  | / \__   0   __/ \ |");
            Console.WriteLine(@"   -   / \_____/ \   -");
            Console.WriteLine(@"     --\  6 | 5  /--");
            Console.WriteLine(@"        ---------");
            Thread.Sleep(500);
            Console.Clear();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(@"        _________");
                Console.WriteLine(@"     --/ 1__|__2 \--");
                Console.WriteLine(@"   -   \_/     \_/   -");
                Console.WriteLine(@"  | \ /-    0     \ / |");
                Console.WriteLine(@" |8  /      |      \  3|");
                Console.WriteLine(@" |--|  ()---H---()  |--|");
                Console.WriteLine(@" |7  \      |      /  4|");
                Console.WriteLine(@"  | / \__   0   __/ \ |");
                Console.WriteLine(@"   -   / \_____/ \   -");
                Console.WriteLine(@"     --\  6 | 5  /--");
                Console.WriteLine(@"        ---------");
                Thread.Sleep(250);
                Console.Clear();
                Console.WriteLine(@"        _________");
                Console.WriteLine(@"     --/  __|__1 \--");
                Console.WriteLine(@"   - 8 \_/     \_/ 2 -");
                Console.WriteLine(@"  | \ /-    0     \ / |");
                Console.WriteLine(@" |7  /      |      \   |");
                Console.WriteLine(@" |--|  ()---H---()  |--|");
                Console.WriteLine(@" |   \      |      /  3|");
                Console.WriteLine(@"  | / \__   0   __/ \ |");
                Console.WriteLine(@"   - 6 / \_____/ \ 4 -");
                Console.WriteLine(@"     --\  5 |    /--");
                Console.WriteLine(@"        ---------");
                Thread.Sleep(250);
                Console.Clear();
                Console.WriteLine(@"        _________");
                Console.WriteLine(@"     --/ 8__|__  \--");
                Console.WriteLine(@"   - 7 \_/     \_/ 1 -");
                Console.WriteLine(@"  | \ /-    0     \ / |");
                Console.WriteLine(@" |   /      |      \  2|");
                Console.WriteLine(@" |--|  ()---H---()  |--|");
                Console.WriteLine(@" |6  \      |      /   |");
                Console.WriteLine(@"  | / \__   0   __/ \ |");
                Console.WriteLine(@"   - 5 / \_____/ \ 3 -");
                Console.WriteLine(@"     --\    | 4  /--");
                Console.WriteLine(@"        ---------");
                Thread.Sleep(250);
                Console.Clear();
                Console.WriteLine(@"        _________");
                Console.WriteLine(@"     --/ 7__|__8 \--");
                Console.WriteLine(@"   -   \_/     \_/   -");
                Console.WriteLine(@"  | \ /-    0     \ / |");
                Console.WriteLine(@" |6  /      |      \  1|");
                Console.WriteLine(@" |--|  ()---H---()  |--|");
                Console.WriteLine(@" |5  \      |      /  2|");
                Console.WriteLine(@"  | / \__   0   __/ \ |");
                Console.WriteLine(@"   -   / \_____/ \   -");
                Console.WriteLine(@"     --\  4 | 3  /--");
                Console.WriteLine(@"        ---------");
                Thread.Sleep(250);
                Console.Clear();
                Console.WriteLine(@"        _________");
                Console.WriteLine(@"     --/  __|__7 \--");
                Console.WriteLine(@"   - 6 \_/     \_/ 8 -");
                Console.WriteLine(@"  | \ /-    0     \ / |");
                Console.WriteLine(@" |5  /      |      \   |");
                Console.WriteLine(@" |--|  ()---H---()  |--|");
                Console.WriteLine(@" |   \      |      /  1|");
                Console.WriteLine(@"  | / \__   0   __/ \ |");
                Console.WriteLine(@"   - 4 / \_____/ \ 2 -");
                Console.WriteLine(@"     --\  3 |    /--");
                Console.WriteLine(@"        ---------");
                Thread.Sleep(250);
                Console.Clear();
                Console.WriteLine(@"        _________");
                Console.WriteLine(@"     --/ 6__|__  \--");
                Console.WriteLine(@"   - 5 \_/     \_/ 7 -");
                Console.WriteLine(@"  | \ /-    0     \ / |");
                Console.WriteLine(@" |   /      |      \  8|");
                Console.WriteLine(@" |--|  ()---H---()  |--|");
                Console.WriteLine(@" |4  \      |      /   |");
                Console.WriteLine(@"  | / \__   0   __/ \ |");
                Console.WriteLine(@"   - 3 / \_____/ \ 1 -");
                Console.WriteLine(@"     --\    | 2  /--");
                Console.WriteLine(@"        ---------");
                Thread.Sleep(250);
                Console.Clear();
                Console.WriteLine(@"        _________");
                Console.WriteLine(@"     --/ 5__|__6 \--");
                Console.WriteLine(@"   -   \_/     \_/   -");
                Console.WriteLine(@"  | \ /-    0     \ / |");
                Console.WriteLine(@" |4  /      |      \  7|");
                Console.WriteLine(@" |--|  ()---H---()  |--|");
                Console.WriteLine(@" |3  \      |      /  8|");
                Console.WriteLine(@"  | / \__   0   __/ \ |");
                Console.WriteLine(@"   -   / \_____/ \   -");
                Console.WriteLine(@"     --\  2 | 1  /--");
                Console.WriteLine(@"        ---------");
                Thread.Sleep(250);
                Console.Clear();
                Console.WriteLine(@"        _________");
                Console.WriteLine(@"     --/  __|__5 \--");
                Console.WriteLine(@"   - 4 \_/     \_/ 6 -");
                Console.WriteLine(@"  | \ /-    0     \ / |");
                Console.WriteLine(@" |3  /      |      \   |");
                Console.WriteLine(@" |--|  ()---H---()  |--|");
                Console.WriteLine(@" |  \       |     /   7|");
                Console.WriteLine(@"  | / \__   0   __/ \ |");
                Console.WriteLine(@"   - 2 / \_____/ \ 8 -");
                Console.WriteLine(@"     --\  1 |    /--");
                Console.WriteLine(@"        ---------");
                Thread.Sleep(250);
                Console.Clear();
                Console.WriteLine(@"        _________");
                Console.WriteLine(@"     --/ 4__|__  \--");
                Console.WriteLine(@"   - 3 \_/     \_/ 5 -");
                Console.WriteLine(@"  | \ /-    0     \ / |");
                Console.WriteLine(@" |   /      |      \  6|");
                Console.WriteLine(@" |--|  ()---H---()  |--|");
                Console.WriteLine(@" |2 \       |     /    |");
                Console.WriteLine(@"  | / \__   0   __/ \ |");
                Console.WriteLine(@"   - 1 / \_____/ \ 7 -");
                Console.WriteLine(@"     --\    | 8  /--");
                Console.WriteLine(@"        ---------");
                Thread.Sleep(250);
                Console.Clear();
                Console.WriteLine(@"        _________");
                Console.WriteLine(@"     --/ 3__|__4 \--");
                Console.WriteLine(@"   -   \_/     \_/   -");
                Console.WriteLine(@"  | \ /-    0     \ / |");
                Console.WriteLine(@" |2  /      |      \  5|");
                Console.WriteLine(@" |--|  ()---H---()  |--|");
                Console.WriteLine(@" |1 \       |     /   6|");
                Console.WriteLine(@"  | / \__   0   __/ \ |");
                Console.WriteLine(@"   -   / \_____/ \   -");
                Console.WriteLine(@"     --\  8 | 7  /--");
                Console.WriteLine(@"        ---------");
                Thread.Sleep(250);
                Console.Clear();
                Console.WriteLine(@"        _________");
                Console.WriteLine(@"     --/  __|__3 \--");
                Console.WriteLine(@"   - 2 \_/     \_/ 4 -");
                Console.WriteLine(@"  | \ /-    0     \ / |");
                Console.WriteLine(@" |1  /      |      \   |");
                Console.WriteLine(@" |--|  ()---H---()  |--|");
                Console.WriteLine(@" |  \       |     /   5|");
                Console.WriteLine(@"  | / \__   0   __/ \ |");
                Console.WriteLine(@"   - 8 / \_____/ \ 6 -");
                Console.WriteLine(@"     --\  7 |    /--");
                Console.WriteLine(@"        ---------");
                Thread.Sleep(250);
                Console.Clear();
                Console.WriteLine(@"        _________");
                Console.WriteLine(@"     --/ 2__|__  \--");
                Console.WriteLine(@"   - 1 \_/     \_/ 3 -");
                Console.WriteLine(@"  | \ /-    0     \ / |");
                Console.WriteLine(@" |   /      |      \  4|");
                Console.WriteLine(@" |--|  ()---H---()  |--|");
                Console.WriteLine(@" |8 \       |     /    |");
                Console.WriteLine(@"  | / \__   0   __/ \ |");
                Console.WriteLine(@"   - 7 / \_____/ \ 5 -");
                Console.WriteLine(@"     --\    | 6  /--");
                Console.WriteLine(@"        ---------");
                Thread.Sleep(250);
                Console.Clear();
            }
            #endregion
            Random rtRollNumber = new Random();
            int rtnumber = rtRollNumber.Next(1, 7);

            if (rtnumber == tableNumInt)
            {
                Console.Clear();
                Console.WriteLine("It landed on your number! CONGRATS YOU WON!");
                Console.WriteLine("Your balance changed from " + currency + " to " + (currency + (betNumInt * 5)) + "!");
                currency = currency + (betNumInt * 5);
                Thread.Sleep(2000);
            }
            else
            {
                Console.WriteLine("You didnt win sadly, it landed on " + rtnumber + ". Goodluck next time!");
                Thread.Sleep(2000);
            }

            Console.Write("[Play again] or [Return]?: ");
            string rbpR = Console.ReadLine();
            if (rbpR == "Play again" || rbpR == "play again")
            {
                rouletteWheel();
            }
            else if (rbpR == "Return" || rbpR == "return")
            {
                option1();
            }
            else
            {
                Console.WriteLine("Invalid input");
                Thread.Sleep(1000);
                option1();
            }
        }
        private static void redblack()
        {
            Console.Clear();
            Console.WriteLine("How much do you wish to bet? You have " + currency + " dollars.");
            string betopt = Console.ReadLine();
            int betNumInt;
            bool success = int.TryParse(betopt, out betNumInt);

            if (success && !(betNumInt > currency) && betNumInt > 0)
            {
                Console.WriteLine("you bet " + betNumInt + " dollars");
                currency = currency - betNumInt;
            }
            else
            {
                Console.WriteLine("Invalid input, enter a valid number");
                Thread.Sleep(2000);
                redblack();
            }
            Console.WriteLine("[red] or [black]?");
            bool redbet = false;
            betopt = Console.ReadLine();
            if (betopt == "red")
            {
                redbet = true;
            }
            else if (betopt == "black")
            {
                redbet = false;
            }
            else
            {
                Console.WriteLine("invalid input");
                Thread.Sleep(2000);
                redblack();
            }
            Console.Clear();
            #region(rolling animation)
            Console.WriteLine(@"        _________");
            Console.WriteLine(@"     --/ 1__|__2 \--");
            Console.WriteLine(@"   -   \_/     \_/   -");
            Console.WriteLine(@"  | \ /-    0     \ / |");
            Console.WriteLine(@" |8  /      |      \  3|");
            Console.WriteLine(@" |--|  ()---H---()  |--|");
            Console.WriteLine(@" |7  \      |      /  4|");
            Console.WriteLine(@"  | / \__   0   __/ \ |");
            Console.WriteLine(@"   -   / \_____/ \   -");
            Console.WriteLine(@"     --\  6 | 5  /--");
            Console.WriteLine(@"        ---------");
            Thread.Sleep(500);
            Console.Clear();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(@"        _________");
                Console.WriteLine(@"     --/ 1__|__2 \--");
                Console.WriteLine(@"   -   \_/     \_/   -");
                Console.WriteLine(@"  | \ /-    0     \ / |");
                Console.WriteLine(@" |8  /      |      \  3|");
                Console.WriteLine(@" |--|  ()---H---()  |--|");
                Console.WriteLine(@" |7  \      |      /  4|");
                Console.WriteLine(@"  | / \__   0   __/ \ |");
                Console.WriteLine(@"   -   / \_____/ \   -");
                Console.WriteLine(@"     --\  6 | 5  /--");
                Console.WriteLine(@"        ---------");
                Thread.Sleep(250);
                Console.Clear();
                Console.WriteLine(@"        _________");
                Console.WriteLine(@"     --/  __|__1 \--");
                Console.WriteLine(@"   - 8 \_/     \_/ 2 -");
                Console.WriteLine(@"  | \ /-    0     \ / |");
                Console.WriteLine(@" |7  /      |      \   |");
                Console.WriteLine(@" |--|  ()---H---()  |--|");
                Console.WriteLine(@" |   \      |      /  3|");
                Console.WriteLine(@"  | / \__   0   __/ \ |");
                Console.WriteLine(@"   - 6 / \_____/ \ 4 -");
                Console.WriteLine(@"     --\  5 |    /--");
                Console.WriteLine(@"        ---------");
                Thread.Sleep(250);
                Console.Clear();
                Console.WriteLine(@"        _________");
                Console.WriteLine(@"     --/ 8__|__  \--");
                Console.WriteLine(@"   - 7 \_/     \_/ 1 -");
                Console.WriteLine(@"  | \ /-    0     \ / |");
                Console.WriteLine(@" |   /      |      \  2|");
                Console.WriteLine(@" |--|  ()---H---()  |--|");
                Console.WriteLine(@" |6  \      |      /   |");
                Console.WriteLine(@"  | / \__   0   __/ \ |");
                Console.WriteLine(@"   - 5 / \_____/ \ 3 -");
                Console.WriteLine(@"     --\    | 4  /--");
                Console.WriteLine(@"        ---------");
                Thread.Sleep(250);
                Console.Clear();
                Console.WriteLine(@"        _________");
                Console.WriteLine(@"     --/ 7__|__8 \--");
                Console.WriteLine(@"   -   \_/     \_/   -");
                Console.WriteLine(@"  | \ /-    0     \ / |");
                Console.WriteLine(@" |6  /      |      \  1|");
                Console.WriteLine(@" |--|  ()---H---()  |--|");
                Console.WriteLine(@" |5  \      |      /  2|");
                Console.WriteLine(@"  | / \__   0   __/ \ |");
                Console.WriteLine(@"   -   / \_____/ \   -");
                Console.WriteLine(@"     --\  4 | 3  /--");
                Console.WriteLine(@"        ---------");
                Thread.Sleep(250);
                Console.Clear();
                Console.WriteLine(@"        _________");
                Console.WriteLine(@"     --/  __|__7 \--");
                Console.WriteLine(@"   - 6 \_/     \_/ 8 -");
                Console.WriteLine(@"  | \ /-    0     \ / |");
                Console.WriteLine(@" |5  /      |      \   |");
                Console.WriteLine(@" |--|  ()---H---()  |--|");
                Console.WriteLine(@" |   \      |      /  1|");
                Console.WriteLine(@"  | / \__   0   __/ \ |");
                Console.WriteLine(@"   - 4 / \_____/ \ 2 -");
                Console.WriteLine(@"     --\  3 |    /--");
                Console.WriteLine(@"        ---------");
                Thread.Sleep(250);
                Console.Clear();
                Console.WriteLine(@"        _________");
                Console.WriteLine(@"     --/ 6__|__  \--");
                Console.WriteLine(@"   - 5 \_/     \_/ 7 -");
                Console.WriteLine(@"  | \ /-    0     \ / |");
                Console.WriteLine(@" |   /      |      \  8|");
                Console.WriteLine(@" |--|  ()---H---()  |--|");
                Console.WriteLine(@" |4  \      |      /   |");
                Console.WriteLine(@"  | / \__   0   __/ \ |");
                Console.WriteLine(@"   - 3 / \_____/ \ 1 -");
                Console.WriteLine(@"     --\    | 2  /--");
                Console.WriteLine(@"        ---------");
                Thread.Sleep(250);
                Console.Clear();
                Console.WriteLine(@"        _________");
                Console.WriteLine(@"     --/ 5__|__6 \--");
                Console.WriteLine(@"   -   \_/     \_/   -");
                Console.WriteLine(@"  | \ /-    0     \ / |");
                Console.WriteLine(@" |4  /      |      \  7|");
                Console.WriteLine(@" |--|  ()---H---()  |--|");
                Console.WriteLine(@" |3  \      |      /  8|");
                Console.WriteLine(@"  | / \__   0   __/ \ |");
                Console.WriteLine(@"   -   / \_____/ \   -");
                Console.WriteLine(@"     --\  2 | 1  /--");
                Console.WriteLine(@"        ---------");
                Thread.Sleep(250);
                Console.Clear();
                Console.WriteLine(@"        _________");
                Console.WriteLine(@"     --/  __|__5 \--");
                Console.WriteLine(@"   - 4 \_/     \_/ 6 -");
                Console.WriteLine(@"  | \ /-    0     \ / |");
                Console.WriteLine(@" |3  /      |      \   |");
                Console.WriteLine(@" |--|  ()---H---()  |--|");
                Console.WriteLine(@" |  \       |     /   7|");
                Console.WriteLine(@"  | / \__   0   __/ \ |");
                Console.WriteLine(@"   - 2 / \_____/ \ 8 -");
                Console.WriteLine(@"     --\  1 |    /--");
                Console.WriteLine(@"        ---------");
                Thread.Sleep(250);
                Console.Clear();
                Console.WriteLine(@"        _________");
                Console.WriteLine(@"     --/ 4__|__  \--");
                Console.WriteLine(@"   - 3 \_/     \_/ 5 -");
                Console.WriteLine(@"  | \ /-    0     \ / |");
                Console.WriteLine(@" |   /      |      \  6|");
                Console.WriteLine(@" |--|  ()---H---()  |--|");
                Console.WriteLine(@" |2 \       |     /    |");
                Console.WriteLine(@"  | / \__   0   __/ \ |");
                Console.WriteLine(@"   - 1 / \_____/ \ 7 -");
                Console.WriteLine(@"     --\    | 8  /--");
                Console.WriteLine(@"        ---------");
                Thread.Sleep(250);
                Console.Clear();
                Console.WriteLine(@"        _________");
                Console.WriteLine(@"     --/ 3__|__4 \--");
                Console.WriteLine(@"   -   \_/     \_/   -");
                Console.WriteLine(@"  | \ /-    0     \ / |");
                Console.WriteLine(@" |2  /      |      \  5|");
                Console.WriteLine(@" |--|  ()---H---()  |--|");
                Console.WriteLine(@" |1 \       |     /   6|");
                Console.WriteLine(@"  | / \__   0   __/ \ |");
                Console.WriteLine(@"   -   / \_____/ \   -");
                Console.WriteLine(@"     --\  8 | 7  /--");
                Console.WriteLine(@"        ---------");
                Thread.Sleep(250);
                Console.Clear();
                Console.WriteLine(@"        _________");
                Console.WriteLine(@"     --/  __|__3 \--");
                Console.WriteLine(@"   - 2 \_/     \_/ 4 -");
                Console.WriteLine(@"  | \ /-    0     \ / |");
                Console.WriteLine(@" |1  /      |      \   |");
                Console.WriteLine(@" |--|  ()---H---()  |--|");
                Console.WriteLine(@" |  \       |     /   5|");
                Console.WriteLine(@"  | / \__   0   __/ \ |");
                Console.WriteLine(@"   - 8 / \_____/ \ 6 -");
                Console.WriteLine(@"     --\  7 |    /--");
                Console.WriteLine(@"        ---------");
                Thread.Sleep(250);
                Console.Clear();
                Console.WriteLine(@"        _________");
                Console.WriteLine(@"     --/ 2__|__  \--");
                Console.WriteLine(@"   - 1 \_/     \_/ 3 -");
                Console.WriteLine(@"  | \ /-    0     \ / |");
                Console.WriteLine(@" |   /      |      \  4|");
                Console.WriteLine(@" |--|  ()---H---()  |--|");
                Console.WriteLine(@" |8 \       |     /    |");
                Console.WriteLine(@"  | / \__   0   __/ \ |");
                Console.WriteLine(@"   - 7 / \_____/ \ 5 -");
                Console.WriteLine(@"     --\    | 6  /--");
                Console.WriteLine(@"        ---------");
                Thread.Sleep(250);
                Console.Clear();
            }
            #endregion
            Random rtRollNumber = new Random();
            int rtnumber = rtRollNumber.Next(1, 3);
            if (rtnumber == 1)
            {
                if (redbet == true)
                {
                    Console.Clear();
                    Console.WriteLine("It landed on red! CONGRATS YOU WON!");
                    Console.WriteLine("Your balance changed from " + currency + " to " + (currency + (betNumInt * 2)) + "!");
                    currency = currency = currency + (betNumInt * 2);
                    Thread.Sleep(2000);
                }
                else if (redbet == false)
                {
                    Console.WriteLine("You didnt win sadly, it landed on red. Goodluck next time!");
                    Thread.Sleep(2000);
                }
            }
            else if (rtnumber == 2)
            {
                if (redbet == false)
                {
                    Console.Clear();
                    Console.WriteLine("It landed on black! CONGRATS YOU WON!");
                    Console.WriteLine("Your balance changed from " + currency + " to " + (currency + (betNumInt * 2)) + "!");
                    currency = currency = currency + (betNumInt * 2);
                    Thread.Sleep(2000);
                }
                else if (redbet == true)
                {
                    Console.WriteLine("You didnt win sadly, it landed on black. Goodluck next time!");
                    Thread.Sleep(2000);
                }
            }
            Console.Write("[Play again] or [Return]?: ");
            string rbpR = Console.ReadLine();
            if (rbpR == "Play again" || rbpR == "play again")
            {
                rouletteWheel();
            }
            else if (rbpR == "Return" || rbpR == "return")
            {
                option1();
            }
            else
            {
                Console.WriteLine("Invalid input");
                Thread.Sleep(1000);
                option1();
            }
        }

        private static void slotMachine()
        {
            Console.Clear();
            Console.WriteLine("                                                    balance: $" + currency);
            Console.WriteLine("Welcome to slots!\nHere you can pay $100 to pull the slot machine and try your luck for a jackpot!\nGetting two numbers the name gives you a prize of $350!\nGetting all numbers the same awards you with $5000!!");
            Console.WriteLine("Would you like to [Play] or [Return]?");


            string smrR = Console.ReadLine();
            if (smrR == "Return" || smrR == "return")
            {
                gambleSelect();
            }
            else if (smrR == "Play" || smrR == "play")
            {
                if (currency > 100 || currency == 100)
                {
                    currency -= 100;
                }
                else
                {
                    Console.WriteLine("Insufficient ammount");
                    Thread.Sleep(1000);
                    gambleSelect();
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
                Thread.Sleep(1000);
                gambleSelect();
            }
            int slotnumber1 = 7;
            int slotnumber2 = 7;
            int slotnumber3 = 7;
            bool slot1 = false;
            bool slot2 = false;
            bool slot3 = false;
            #region(slot animation)
            Console.Clear();
            Console.WriteLine(@"  ____-----____");
            Console.WriteLine(@" / JAVA  SLOTS \");
            Console.WriteLine(@" |____-----____|  ");
            Console.WriteLine(@" |___  ___  ___| ()");
            Console.WriteLine(@" || |  | |  | || ||");
            Console.WriteLine(@" ||7|  |7|  |7|| ||");
            Console.WriteLine(@" |---  ---  ---|=||");
            Console.WriteLine(@" |_____________|=|/");
            Console.WriteLine(@" //_/__|_|__\__\");
            Console.WriteLine(@"|_______________|");
            Console.WriteLine(@" |    _____    |");
            Console.WriteLine(@" |____|___|____|");
            Thread.Sleep(150);
            Console.Clear();
            Console.WriteLine(@"  ____-----____");
            Console.WriteLine(@" / JAVA  SLOTS \");
            Console.WriteLine(@" |____-----____|  ");
            Console.WriteLine(@" |___  ___  ___| ");
            Console.WriteLine(@" || |  | |  | || ()");
            Console.WriteLine(@" ||7|  |7|  |7|| ||");
            Console.WriteLine(@" |---  ---  ---|=||");
            Console.WriteLine(@" |_____________|=|/");
            Console.WriteLine(@" //_/__|_|__\__\");
            Console.WriteLine(@"|_______________|");
            Console.WriteLine(@" |    _____    |");
            Console.WriteLine(@" |____|___|____|");
            Thread.Sleep(150);
            Console.Clear();
            Console.WriteLine(@"  ____-----____");
            Console.WriteLine(@" / JAVA  SLOTS \");
            Console.WriteLine(@" |____-----____|  ");
            Console.WriteLine(@" |___  ___  ___| ");
            Console.WriteLine(@" || |  | |  | ||  _");
            Console.WriteLine(@" ||7|  |7|  |7|| (_)");
            Console.WriteLine(@" |---  ---  ---|=||");
            Console.WriteLine(@" |_____________|=|/");
            Console.WriteLine(@" //_/__|_|__\__\");
            Console.WriteLine(@"|_______________|");
            Console.WriteLine(@" |    _____    |");
            Console.WriteLine(@" |____|___|____|");
            Thread.Sleep(150);
            Console.Clear();
            Console.WriteLine(@"  ____-----____");
            Console.WriteLine(@" / JAVA  SLOTS \");
            Console.WriteLine(@" |____-----____|  ");
            Console.WriteLine(@" |___  ___  ___| ");
            Console.WriteLine(@" || |  | |  | ||  ");
            Console.WriteLine(@" ||7|  |7|  |7|| ---");
            Console.WriteLine(@" |---  ---  ---| \_/");
            Console.WriteLine(@" |_____________|=|/");
            Console.WriteLine(@" //_/__|_|__\__\");
            Console.WriteLine(@"|_______________|");
            Console.WriteLine(@" |    _____    |");
            Console.WriteLine(@" |____|___|____|");
            Thread.Sleep(150);
            Console.Clear();
            Console.WriteLine(@"  ____-----____");
            Console.WriteLine(@" / JAVA  SLOTS \");
            Console.WriteLine(@" |____-----____|  ");
            Console.WriteLine(@" |___  ___  ___| ");
            Console.WriteLine(@" || |  | |  | ||  ");
            Console.WriteLine(@" ||7|  |7|  |7|| ");
            Console.WriteLine(@" |---  ---  ---| ___");
            Console.WriteLine(@" |_____________|=| |");
            Console.WriteLine(@" //_/__|_|__\__\ \_/");
            Console.WriteLine(@"|_______________|");
            Console.WriteLine(@" |    _____    |");
            Console.WriteLine(@" |____|___|____|");
            Thread.Sleep(300);
            Console.Clear();
            Console.WriteLine(@"  ____-----____");
            Console.WriteLine(@" / JAVA  SLOTS \");
            Console.WriteLine(@" |____-----____|  ");
            Console.WriteLine(@" |___  ___  ___| ");
            Console.WriteLine(@" || |  | |  | ||  ");
            Console.WriteLine(@" ||7|  |7|  |7|| ---");
            Console.WriteLine(@" |---  ---  ---| \_/");
            Console.WriteLine(@" |_____________|=|/");
            Console.WriteLine(@" //_/__|_|__\__\");
            Console.WriteLine(@"|_______________|");
            Console.WriteLine(@" |    _____    |");
            Console.WriteLine(@" |____|___|____|");
            Thread.Sleep(150);
            Console.Clear();
            Console.WriteLine(@"  ____-----____");
            Console.WriteLine(@" / JAVA  SLOTS \");
            Console.WriteLine(@" |____-----____|  ");
            Console.WriteLine(@" |___  ___  ___| ");
            Console.WriteLine(@" || |  | |  | ||  _");
            Console.WriteLine(@" ||7|  |7|  |7|| (_)");
            Console.WriteLine(@" |---  ---  ---|=||");
            Console.WriteLine(@" |_____________|=|/");
            Console.WriteLine(@" //_/__|_|__\__\");
            Console.WriteLine(@"|_______________|");
            Console.WriteLine(@" |    _____    |");
            Console.WriteLine(@" |____|___|____|");
            Thread.Sleep(150);
            Console.Clear();
            Console.WriteLine(@"  ____-----____");
            Console.WriteLine(@" / JAVA  SLOTS \");
            Console.WriteLine(@" |____-----____|  ");
            Console.WriteLine(@" |___  ___  ___| ");
            Console.WriteLine(@" || |  | |  | || ()");
            Console.WriteLine(@" ||7|  |7|  |7|| ||");
            Console.WriteLine(@" |---  ---  ---|=||");
            Console.WriteLine(@" |_____________|=|/");
            Console.WriteLine(@" //_/__|_|__\__\");
            Console.WriteLine(@"|_______________|");
            Console.WriteLine(@" |    _____    |");
            Console.WriteLine(@" |____|___|____|");
            Thread.Sleep(150);
            Console.Clear();
            Console.WriteLine(@"  ____-----____");
            Console.WriteLine(@" / JAVA  SLOTS \");
            Console.WriteLine(@" |____-----____|  ");
            Console.WriteLine(@" |___  ___  ___| ()");
            Console.WriteLine(@" || |  | |  | || ||");
            Console.WriteLine(@" ||7|  |7|  |7|| ||");
            Console.WriteLine(@" |---  ---  ---|=||");
            Console.WriteLine(@" |_____________|=|/");
            Console.WriteLine(@" //_/__|_|__\__\");
            Console.WriteLine(@"|_______________|");
            Console.WriteLine(@" |    _____    |");
            Console.WriteLine(@" |____|___|____|");
            #endregion
            Random slotNumber = new Random();
            Thread.Sleep(1000);
            Console.Clear();
            for (int si = 0; si < 9; si++)
            {
                if (slot1 == false)
                    slotnumber1 = 2;
                if (slot2 == false)
                    slotnumber2 = 5;
                if (slot3 == false)
                    slotnumber3 = 6;
                Console.Clear();
                slotvisual(slotnumber1, slotnumber2, slotnumber3);
                Thread.Sleep(150);
                if (slot1 == false)
                    slotnumber1 = 8;
                if (slot2 == false)
                    slotnumber2 = 3;
                if (slot3 == false)
                    slotnumber3 = 1;
                Console.Clear();
                slotvisual(slotnumber1, slotnumber2, slotnumber3);
                Thread.Sleep(150);
                if (slot1 == false)
                    slotnumber1 = 5;
                if (slot2 == false)
                    slotnumber2 = 0;
                if (slot3 == false)
                    slotnumber3 = 4;
                Console.Clear();
                slotvisual(slotnumber1, slotnumber2, slotnumber3);
                Thread.Sleep(150);
                if (slot1 == false)
                    slotnumber1 = 7;
                if (slot2 == false)
                    slotnumber2 = 6;
                if (slot3 == false)
                    slotnumber3 = 2;
                Console.Clear();
                slotvisual(slotnumber1, slotnumber2, slotnumber3);
                if (si == 4)
                {
                    slot1 = true;
                    slotnumber1 = slotNumber.Next(0, 10);
                }
                if (si == 6)
                {
                    slot2 = true;
                    slotnumber2 = slotNumber.Next(0, 10);
                }
                if (si == 8)
                {
                    slot3 = true;
                    slotnumber3 = slotNumber.Next(0, 10);
                }
            }
            Console.Clear();
            slotvisual(slotnumber1, slotnumber2, slotnumber3);

            if (slotnumber1 == slotnumber2 && slotnumber1 == slotnumber3)
            {
                //1% chance
                Console.WriteLine("THREE NUMBER JACKPOT!");
                Console.WriteLine("You won $5000!");
                currency += 5000;
            }
            else if (slotnumber1 == slotnumber2 || slotnumber1 == slotnumber3 || slotnumber2 == slotnumber3)
            {
                //28% chance
                Console.WriteLine("TWO NUMBER WIN!");
                Console.WriteLine("You won $350!");
                currency += 350;

            }
            else
            {
                Console.WriteLine("You didnt win this time");
            }
            Thread.Sleep(1000);
            Console.Write("[Play again] or [Return]?: ");
            string smpR = Console.ReadLine();
            if (smpR == "Play again" || smpR == "play again")
            {
                slotMachine();
            }
            else if (smpR == "Return" || smpR == "return")
            {
                option1();
            }
            else
            {
                Console.WriteLine("Invalid input");
                Thread.Sleep(1000);
                option1();
            }

        }

        private static void slotvisual(int slotnumber1, int slotnumber2, int slotnumber3)
        {
            Console.WriteLine(@"  ____-----____");
            Console.WriteLine(@" / JAVA  SLOTS \");
            Console.WriteLine(@" |____-----____|  ");
            Console.WriteLine(@" |___  ___  ___| ()");
            Console.WriteLine(@" || |  | |  | || ||");
            Console.WriteLine(@" ||" + slotnumber1 + "|  |" + slotnumber2 + "|  |" + slotnumber3 + "|| ||");
            Console.WriteLine(@" |---  ---  ---|=||");
            Console.WriteLine(@" |_____________|=|/");
            Console.WriteLine(@" //_/__|_|__\__\");
            Console.WriteLine(@"|_______________|");
            Console.WriteLine(@" |    _____    |");
            Console.WriteLine(@" |____|___|____|");
        }
        #endregion
        private static void gameSelect(string todo)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.WriteLine("What game would you like to play?");
            Console.WriteLine("1. Guess the number");
            Console.WriteLine("2. Noughts and crosses");
            Console.WriteLine("3. Dash (you should try this, its a custom game i made from scratch)");
            Console.WriteLine("4. Dice roll");
            Console.WriteLine("5. Nucklebones");
            Console.WriteLine("6. Hangman");
            Console.WriteLine("7. Return");

            string game = Console.ReadLine();

            if (game == "1")
            {
                PANgame();
            }
            else if (game == "2")
            {
                NorC();
            }
            else if (game == "3")
            {
                dash();

            }
            else if (game == "4")
            {
                diceRoll();
            }
            else if (game == "5")
            {
                nuckleBones();
            }
            else if (game == "6")
            {
                hangman();
            }
            else if (game == "7")
            {
                option1();
            }
            else
            {
                Console.WriteLine("Invalid Input");
                gameSelect(todo);
            }
        }

        private static void PANgame()
        {
            Console.Clear();
            Console.Write("How many numbers would you like to choose from?: ");
            String maxNumber = Console.ReadLine();
            Console.WriteLine("pick a number from 1-" + maxNumber);
            int.TryParse(maxNumber, out int maxNumberInt);
            string usernumber = Console.ReadLine();
            Random PANrng = new Random();
            int PANnumber = PANrng.Next(1, maxNumberInt + 1);
            string PANasString = PANnumber.ToString();
            if (usernumber == PANasString)
            {
                Console.WriteLine("You were correct!");
            }
            else
            {
                Console.WriteLine("Womp Womp wrong number :(");
                Console.WriteLine("The number was: " + PANnumber);
            }

            Console.Write("[Play again] or [Return]?: ");
            string aOrR = Console.ReadLine();
            if (aOrR == "Play again" || aOrR == "play again")
            {
                PANgame();
            }
            else if (aOrR == "Return" || aOrR == "return")
            {
                option1();
            }
            else
            {
                Console.WriteLine("Invalid input");
                Thread.Sleep(1000);
                option1();
            }

        }

        private static void diceRoll()
        {

            //Console.Write: Prints the question "How many sides do you want the dice to have?" to the console
            //Console.Readline: Allows the user to input text into the console
            // while(!int): if the user inputs anything other than a number
            //Console.Write: Prints the text "Select a number" to the console
            Console.Clear();
            Console.Write("How many sides do you want the dice to have?: ");
            while (!int.TryParse(Console.ReadLine(), out maxDiceNumber))
            {
                Console.WriteLine("Select a number");
            }

            //Console.Write: Prints the question "How many dice do you want rolled?" to the console
            //Console.Readline: Allows the user to input text into the console
            // while(!int): if the user inputs anything other than a number
            //Console.Write: Prints the text "Select a number" to the console

            Console.Write("How many dice do you want rolled?: ");
            while (!int.TryParse(Console.ReadLine(), out diceAmmount))
            {
                Console.WriteLine("Select a number");
            }

            //Console.Write: Prints the question ""pick a number from 1-" to the console before adding the value of the variable "maxDiceNumber" and adding a selicolin
            //Console.Readline: Allows the user to input text into the console
            // while(!int): if the user inputs anything other than a number
            //Console.Write: Prints the text "Select a number" to the console

            Console.Write("pick a number from 1-" + maxDiceNumber + ": ");
            while (!int.TryParse(Console.ReadLine(), out userNumber))
            {
                Console.WriteLine("Select a number");
            }

            //Declares a variable in the type Random called Dicerng
            //run the code inside the curly brackets how ever many times that the variable diceAmmount is
            //declare a variable Dicenumber as an int
            //make Dicenumber the same as a random number between 1 and the variable maxDiceNumber
            //if(x == y): if Dicenumber is the same as the variable userNumber then run whats in the curly brackets
            //rolledAmmount++: add one to the variable rolledAmmount

            Random Dicerng = new Random();
            for (int i = 0; i < diceAmmount; i++)
            {
                int Dicenumber = Dicerng.Next(1, maxDiceNumber + 1);
                if (Dicenumber == userNumber)
                {
                    rolledAmmount++;
                }
            }

            //Console.Write: Prints the text "Your number was rolled, " to the console followed by the variable rolledAmmount and the test " times!"

            Console.WriteLine("Your number was rolled, " + rolledAmmount + " times!");
            Thread.Sleep(500);
            Console.Write("[Play again] or [Return]?: ");
            string aOrR = Console.ReadLine();
            if (aOrR == "Play again" || aOrR == "play again")
            {
                diceRoll();
            }
            else if (aOrR == "Return" || aOrR == "return")
            {
                option1();
            }
            else
            {
                Console.WriteLine("Invalid input");
                Thread.Sleep(1000);
                option1();
            }

        }
        #region(nucklebones)
        private static void nuckleBones()
        {
            if (kbgameActive == false)
            {
                Console.Clear();
                #region(dicereset)
                dice1 = " ";
                dice2 = " ";
                dice3 = " ";
                dice4 = " ";
                dice5 = " ";
                dice6 = " ";
                dice7 = " ";
                dice8 = " ";
                dice9 = " ";
                dice10 = " ";
                dice11 = " ";
                dice12 = " ";
                dice13 = " ";
                dice14 = " ";
                dice15 = " ";
                dice16 = " ";
                dice17 = " ";
                dice18 = " ";
                #endregion
                Console.WriteLine("Welcome to nucklebones!");
                Console.WriteLine("to play you and an oponent take it in turns to roll a dice and choose a lane on your board to put the number. At the end of the game all numbers on your board are added up into your score, if you get multiple of the same number in a lane you gain a multiplier for that set. If you put a number in your lane that the oponent has in the same lane of theirs, their matching number is removed.");
                Console.WriteLine("Goodluck! press [enter] to begin");
                var key = Console.ReadKey(intercept: true).Key;
                if (key == ConsoleKey.Enter)
                {
                    kbgameActive = true;
                }
            }
            while (kbgameActive == true)
            {

                Random kBDiceNumber = new Random();
                int nBnumber = kBDiceNumber.Next(1, 7);
                Console.Clear();
                nucklebonesVisual();
                if (Playerturn == 1)
                {
                    kbrun1 = true;
                    nbp1turn(nBnumber);
                }
                else if (Playerturn == 2)
                {
                    kbrun1 = true;
                    nbp2turn(nBnumber);
                }
                if (dice1 != " " && dice2 != " " && dice3 != " " && dice4 != " " && dice5 != " " && dice6 != " " && dice7 != " " && dice8 != " " && dice9 != " ")
                {
                    nbendgame();
                }
                if (dice10 != " " && dice11 != " " && dice12 != " " && dice13 != " " && dice14 != " " && dice15 != " " && dice16 != " " && dice17 != " " && dice18 != " ")
                {
                    nbendgame();
                }
            }
        }
        private static void nbendgame()
        {
            int D1s = 0, D2s = 0, D3s = 0, D4s = 0, D5s = 0, D6s = 0, D7s = 0, D8s = 0, D9s = 0, D10s = 0, D11s = 0, D12s = 0, D13s = 0, D14s = 0, D15s = 0, D16s = 0, D17s = 0, D18s = 0;
            if (dice1 != " ")
                D1s = Convert.ToInt32(dice1);
            if (dice2 != " ")
                D2s = Convert.ToInt32(dice2);
            if (dice3 != " ")
                D3s = Convert.ToInt32(dice3);
            if (dice4 != " ")
                D4s = Convert.ToInt32(dice4);
            if (dice5 != " ")
                D5s = Convert.ToInt32(dice5);
            if (dice6 != " ")
                D6s = Convert.ToInt32(dice6);
            if (dice7 != " ")
                D7s = Convert.ToInt32(dice7);
            if (dice8 != " ")
                D8s = Convert.ToInt32(dice8);
            if (dice9 != " ")
                D9s = Convert.ToInt32(dice9);
            if (dice10 != " ")
                D10s = Convert.ToInt32(dice10);
            if (dice11 != " ")
                D11s = Convert.ToInt32(dice11);
            if (dice12 != " ")
                D12s = Convert.ToInt32(dice12);
            if (dice13 != " ")
                D13s = Convert.ToInt32(dice13);
            if (dice14 != " ")
                D14s = Convert.ToInt32(dice14);
            if (dice15 != " ")
                D15s = Convert.ToInt32(dice15);
            if (dice16 != " ")
                D16s = Convert.ToInt32(dice16);
            if (dice17 != " ")
                D17s = Convert.ToInt32(dice17);
            if (dice18 != " ")
                D18s = Convert.ToInt32(dice18);


            #region(calculating multiples)
            if (D1s == D4s)
                D1s = D1s + (D4s * 2);
            if (D1s == D7s)
                D1s = D1s + (D7s * 2);
            if (D4s == D7s)
                D4s = D4s + (D7s * 2);
            if (D1s == D4s && D1s == D7s)
                D1s = D1s + D4s + (D7s * 4);

            if (D2s == D5s)
                D2s = D2s + (D5s * 2);
            if (D2s == D8s)
                D2s = D2s + (D8s * 2);
            if (D8s == D5s)
                D8s = D8s + (D5s * 2);
            if (D2s == D5s && D2s == D8s)
                D2s = D2s + D5s + (D8s * 4);

            if (D3s == D6s)
                D3s = D3s + (D6s * 2);
            if (D3s == D9s)
                D3s = D3s + (D9s * 2);
            if (D9s == D6s)
                D9s = D9s + (D6s * 2);
            if (D3s == D6s && D3s == D9s)
                D3s = D3s + D6s + (D9s * 4);


            if (D10s == D13s)
                D10s = D10s + (D13s * 2);
            if (D10s == D16s)
                D10s = D10s + (D16s * 2);
            if (D13s == D16s)
                D13s = D13s + (D16s * 2);
            if (D10s == D13s && D10s == D16s)
                D10s = D10s + D13s + (D16s * 4);

            if (D11s == D14s)
                D11s = D11s + (D14s * 2);
            if (D11s == D17s)
                D11s = D11s + (D17s * 2);
            if (D17s == D14s)
                D17s = D17s + (D14s * 2);
            if (D11s == D14s && D11s == D17s)
                D11s = D11s + D14s + (D17s * 4);

            if (D12s == D15s)
                D12s = D12s + (D15s * 2);
            if (D12s == D18s)
                D12s = D12s + (D18s * 2);
            if (D18s == D15s)
                D18s = D18s + (D15s * 2);
            if (D12s == D15s && D12s == D18s)
                D12s = D12s + D15s + (D18s * 4);
            #endregion


            int nbP1score = D1s + D2s + D3s + D4s + D5s + D6s + D7s + D8s + D9s;
            int nbP2score = D10s + D11s + D12s + D13s + D14s + D15s + D16s + D17s + D18s;
            Console.WriteLine("Player1's score was " + nbP1score + "!");
            Console.WriteLine("Player2's score was " + nbP2score + "!");
            if (nbP1score > nbP2score)
                Console.WriteLine("Player1 wins!");
            else if (nbP2score > nbP1score)
                Console.WriteLine("Player2 wins!");
            else
                Console.WriteLine("Draw!");
            kbgameActive = false;
            Thread.Sleep(3000);

            Console.Write("[Play again] or [Return]?: ");
            string kBpR = Console.ReadLine();
            if (kBpR == "Play again" || kBpR == "play again")
            {
                nuckleBones();
            }
            else if (kBpR == "Return" || kBpR == "return")
            {
                option1();
            }
            else
            {
                Console.WriteLine("Invalid input");
                Thread.Sleep(1000);
                option1();
            }

        }
        private static void nucklebonesVisual()
        {
            Console.WriteLine("_______\n|" + dice1 + "|" + dice2 + "|" + dice3 + "|");
            Console.WriteLine("|" + dice4 + "|" + dice5 + "|" + dice6 + "|");
            Console.WriteLine("|" + dice7 + "|" + dice8 + "|" + dice9 + "|\n-------");
            Console.WriteLine("_______\n|" + dice10 + "|" + dice11 + "|" + dice12 + "|");
            Console.WriteLine("|" + dice13 + "|" + dice14 + "|" + dice15 + "|");
            Console.WriteLine("|" + dice16 + "|" + dice17 + "|" + dice18 + "|\n-------");
        }
        #endregion
        private static void nbp1turn(int nBnumber)
        {
            if (kbrun1 == true)
            {
                Console.WriteLine("Player1's turn, click [enter] to roll");
                var key = Console.ReadKey(intercept: true).Key;
                if (key == ConsoleKey.Enter)
                {
                    Console.WriteLine("You rolled a " + nBnumber + "!");
                    Console.WriteLine("What space would you like to put it? (1-3)");
                }
                else
                {
                    Console.WriteLine("click [enter] to roll");
                    nbp1turn(nBnumber);
                }
            }
            else
            {
                Console.WriteLine("What space would you like to put it? (1-3)");
            }


            string nBstring = nBnumber.ToString();
            var key2 = Console.ReadKey(intercept: true).Key;
            if (key2 == ConsoleKey.D1)
            {
                if (dice7 == " ")
                {
                    Playerturn = 2;
                    dice7 = nBstring;
                }
                else if (dice4 == " ")
                {
                    Playerturn = 2;
                    dice4 = nBstring;
                }
                else if (dice1 == " ")
                {
                    Playerturn = 2;
                    dice1 = nBstring;
                }
                else
                {
                    Console.WriteLine("Lane full, try again.");
                    kbrun1 = false;
                    nbp1turn(nBnumber);
                }
                if (dice10 == nBstring)
                    dice10 = " ";
                if (dice13 == nBstring)
                    dice13 = " ";
                if (dice16 == nBstring)
                    dice16 = " ";
            }
            else if (key2 == ConsoleKey.D2)
            {
                if (dice8 == " ")
                {
                    Playerturn = 2;
                    dice8 = nBstring;
                }
                else if (dice5 == " ")
                {
                    Playerturn = 2;
                    dice5 = nBstring;
                }
                else if (dice2 == " ")
                {
                    Playerturn = 2;
                    dice2 = nBstring;
                }
                else
                {
                    Console.WriteLine("Lane full, try again.");
                    kbrun1 = false;
                    nbp1turn(nBnumber);
                }
                if (dice11 == nBstring)
                    dice11 = " ";
                if (dice14 == nBstring)
                    dice14 = " ";
                if (dice17 == nBstring)
                    dice17 = " ";
            }
            else if (key2 == ConsoleKey.D3)
            {
                if (dice9 == " ")
                {
                    Playerturn = 2;
                    dice9 = nBstring;
                }
                else if (dice6 == " ")
                {
                    Playerturn = 2;
                    dice6 = nBstring;
                }
                else if (dice3 == " ")
                {
                    Playerturn = 2;
                    dice3 = nBstring;
                }
                else
                {
                    Console.WriteLine("Lane full, try again.");
                    kbrun1 = false;
                    nbp1turn(nBnumber);
                }
                if (dice12 == nBstring)
                    dice12 = " ";
                if (dice15 == nBstring)
                    dice15 = " ";
                if (dice18 == nBstring)
                    dice18 = " ";
            }
            else
            {
                Console.WriteLine("pick one of the lanes");
                nbp1turn(nBnumber);
            }
        }
        private static void nbp2turn(int nBnumber)
        {
            if (kbrun1 == true)
            {
                Console.WriteLine("Player2's turn, click [enter] to roll");
                var key = Console.ReadKey(intercept: true).Key;
                if (key == ConsoleKey.Enter)
                {
                    Console.WriteLine("You rolled a " + nBnumber + "!");
                    Console.WriteLine("What space would you like to put it? (1-3)");
                }
                else
                {
                    Console.WriteLine("click [enter] to roll");
                    nbp2turn(nBnumber);
                }
            }
            else
            {
                Console.WriteLine("What space would you like to put it? (1-3)");
            }

            string nBstring = nBnumber.ToString();
            var key2 = Console.ReadKey(intercept: true).Key;
            if (key2 == ConsoleKey.D1)
            {
                if (dice10 == " ")
                {
                    Playerturn = 1;
                    dice10 = nBstring;
                }
                else if (dice13 == " ")
                {
                    Playerturn = 1;
                    dice13 = nBstring;
                }
                else if (dice16 == " ")
                {
                    Playerturn = 1;
                    dice16 = nBstring;
                }
                else
                {
                    Console.WriteLine("Lane full, try again.");
                    kbrun1 = false;
                    nbp2turn(nBnumber);
                }
                if (dice1 == nBstring)
                    dice1 = " ";
                if (dice4 == nBstring)
                    dice4 = " ";
                if (dice7 == nBstring)
                    dice7 = " ";
            }
            else if (key2 == ConsoleKey.D2)
            {
                if (dice11 == " ")
                {
                    Playerturn = 1;
                    dice11 = nBstring;
                }
                else if (dice14 == " ")
                {
                    Playerturn = 1;
                    dice14 = nBstring;
                }
                else if (dice17 == " ")
                {
                    Playerturn = 1;
                    dice17 = nBstring;
                }
                else
                {
                    Console.WriteLine("Lane full, try again.");
                    kbrun1 = false;
                    nbp2turn(nBnumber);
                }
                if (dice2 == nBstring)
                    dice2 = " ";
                if (dice5 == nBstring)
                    dice5 = " ";
                if (dice8 == nBstring)
                    dice8 = " ";
            }
            else if (key2 == ConsoleKey.D3)
            {
                if (dice12 == " ")
                {
                    Playerturn = 1;
                    dice12 = nBstring;
                }
                else if (dice15 == " ")
                {
                    Playerturn = 1;
                    dice15 = nBstring;
                }
                else if (dice18 == " ")
                {
                    Playerturn = 1;
                    dice18 = nBstring;
                }
                else
                {
                    Console.WriteLine("Lane full, try again.");
                    kbrun1 = false;
                    nbp2turn(nBnumber);
                }
                if (dice3 == nBstring)
                    dice3 = " ";
                if (dice6 == nBstring)
                    dice6 = " ";
                if (dice9 == nBstring)
                    dice9 = " ";
            }
            else
            {
                Console.WriteLine("pick one of the lanes");
                nbp2turn(nBnumber);
            }
        }

        private static void clawMachine()
        {
            Console.Clear();
            Console.WriteLine("                                                    balance: $" + currency);
            Console.WriteLine("Welcome to the claw machine!\nType [play] to spend $1000 and draw an item\nType [Return] to exit");
            Console.WriteLine(@" ________________");
            Console.WriteLine(@" ||Claw Machine||");
            Console.WriteLine(@" |+------------+|");
            Console.WriteLine(@" |______________|");
            Console.WriteLine(@" ||     ||     ||");
            Console.WriteLine(@" ||   /-||-\   ||");
            Console.WriteLine(@" ||   | || |   ||");
            Console.WriteLine(@" || _   __    _||");
            Console.WriteLine(@" ||/_--/__-\_/_||");
            Console.WriteLine(@" ||____|____|__||");
            Console.WriteLine(@"/___[]_____\0\___\");
            Console.WriteLine(@"|________________|");
            Console.WriteLine(@" | _____    []  |");
            Console.WriteLine(@" |_|___|________|");
            string cinput = Console.ReadLine();
            bool cmstart = false;
            if (cinput == "play" || cinput == "Play")
            {
                if (currency > 999)
                {
                    currency -= 1000;
                    cmstart = true;
                }
                else
                {
                    Console.WriteLine("Insufficient ammount");
                    Thread.Sleep(500);
                    gambleSelect();
                }
            }
            else if (cinput == "return" || cinput == "Return")
            {
                gambleSelect();
            }
            else
            {
                Console.WriteLine("Invalid Input");
                Thread.Sleep(500);
                gambleSelect();
            }
            if (cmstart)
            {
                string clawitem = "";
                Random clawrng = new Random();
                int clawchoice = clawrng.Next(1, 58);
                if (clawchoice == 1 || clawchoice == 2 || clawchoice == 3 || clawchoice == 4)
                {
                    clawitem = pumpkin + "\npumpkin!";
                    pumpkincount++;
                }
                if (clawchoice == 7 || clawchoice == 5 || clawchoice == 6 || clawchoice == 8)
                {
                    clawitem = candle + "\ncandle!";
                    candlecount++;
                }
                if (clawchoice == 11 || clawchoice == 10 || clawchoice == 9 || clawchoice == 12)
                {
                    clawitem = skull + "\nskull!";
                    skullcount++;
                }
                if (clawchoice == 13 || clawchoice == 14 || clawchoice == 15 || clawchoice == 16)
                {
                    clawitem = spider + "\nspider!";
                    spidercount++;
                }
                if (clawchoice == 17 || clawchoice == 18)
                {
                    clawitem = rare_pumpkin + "\nrare pumpkin!!";
                    rare_pumpkincount++;
                }
                if (clawchoice == 19)
                {
                    clawitem = exotic_pumpkin + "\nexotic pumpkin!!!";
                    exotic_pumpkincount++;
                }
                if (clawchoice == 20 || clawchoice == 21 || clawchoice == 22 || clawchoice == 23)
                {
                    clawitem = lil_cat + "\nlil cat!";
                    lil_catcount++;
                }
                if (clawchoice == 24 || clawchoice == 25 || clawchoice == 26 || clawchoice == 27)
                {
                    clawitem = imposter + "\nimposter!";
                    impostercount++;
                }
                if (clawchoice == 28 || clawchoice == 29 || clawchoice == 30 || clawchoice == 31)
                {
                    clawitem = herobrine + "\nherobrine!";
                    herobrinecount++;
                }
                if (clawchoice == 32 || clawchoice == 33 || clawchoice == 34 || clawchoice == 35)
                {
                    clawitem = spooktuber + "\nspooktuber!";
                    spooktubercount++;
                }
                if (clawchoice == 36 || clawchoice == 37)
                {
                    clawitem = rare_cat + "\nrare cat!!";
                    rare_catcount++;
                }
                if (clawchoice == 38)
                {
                    clawitem = exotic_cat + "\nexotic cat!!!";
                    exotic_catcount++;
                }
                if (clawchoice == 39 || clawchoice == 40 || clawchoice == 41 || clawchoice == 42)
                {
                    clawitem = dragonegg + "\ndragon egg!";
                    dragoneggcount++;
                }
                if (clawchoice == 43 || clawchoice == 44 || clawchoice == 45 || clawchoice == 46)
                {
                    clawitem = crystal + "\ncrystal!";
                    crystalcount++;
                }
                if (clawchoice == 47 || clawchoice == 48 || clawchoice == 49 || clawchoice == 50)
                {
                    clawitem = potion + "\npotion!";
                    potioncount++;
                }
                if (clawchoice == 51 || clawchoice == 52 || clawchoice == 53 || clawchoice == 54)
                {
                    clawitem = castle + "\ncastle!";
                    spooktubercount++;
                }
                if (clawchoice == 55 || clawchoice == 56)
                {
                    clawitem = rarecastle + "\nrare castle!!";
                    rarecastlecount++;
                }
                if (clawchoice == 57)
                {
                    clawitem = exoticcastle + "\nexotic castle!!!";
                    exoticcastlecount++;
                }
                #region(claw animation)
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine(@" ________________");
                Console.WriteLine(@" ||Claw Machine||");
                Console.WriteLine(@" |+------------+|");
                Console.WriteLine(@" |______________|");
                Console.WriteLine(@" ||     ||     ||");
                Console.WriteLine(@" ||   /-||-\   ||");
                Console.WriteLine(@" ||   | || |   ||");
                Console.WriteLine(@" || _   __    _||");
                Console.WriteLine(@" ||/_--/__-\_/_||");
                Console.WriteLine(@" ||____|____|__||");
                Console.WriteLine(@"/___[]_____\0\___\");
                Console.WriteLine(@"|________________|");
                Console.WriteLine(@" | _____    []()|");
                Console.WriteLine(@" |_|___|________|");
                Thread.Sleep(250);
                Console.Clear();
                Console.WriteLine(@" ________________");
                Console.WriteLine(@" ||Claw Machine||");
                Console.WriteLine(@" |+------------+|");
                Console.WriteLine(@" |______________|");
                Console.WriteLine(@" ||     ||     ||");
                Console.WriteLine(@" ||   /-||-\   ||");
                Console.WriteLine(@" ||   | || |   ||");
                Console.WriteLine(@" || _   __    _||");
                Console.WriteLine(@" ||/_--/__-\_/_||");
                Console.WriteLine(@" ||____|____|__||");
                Console.WriteLine(@"/___[]_____\0\___\");
                Console.WriteLine(@"|________________|");
                Console.WriteLine(@" | _____    [() |");
                Console.WriteLine(@" |_|___|________|");
                Thread.Sleep(250);
                Console.Clear();
                Console.WriteLine(@" ________________");
                Console.WriteLine(@" ||Claw Machine||");
                Console.WriteLine(@" |+------------+|");
                Console.WriteLine(@" |______________|");
                Console.WriteLine(@" ||     ||     ||");
                Console.WriteLine(@" ||   /-||-\   ||");
                Console.WriteLine(@" ||   | || |   ||");
                Console.WriteLine(@" || _   __    _||");
                Console.WriteLine(@" ||/_--/__-\_/_||");
                Console.WriteLine(@" ||____|____|__||");
                Console.WriteLine(@"/___[]_____\0\___\");
                Console.WriteLine(@"|________________|");
                Console.WriteLine(@" | _____    [)  |");
                Console.WriteLine(@" |_|___|________|");
                Thread.Sleep(250);
                Console.Clear();
                Console.WriteLine(@" ________________");
                Console.WriteLine(@" ||Claw Machine||");
                Console.WriteLine(@" |+------------+|");
                Console.WriteLine(@" |______________|");
                Console.WriteLine(@" ||     ||     ||");
                Console.WriteLine(@" ||   /-||-\   ||");
                Console.WriteLine(@" ||   | || |   ||");
                Console.WriteLine(@" || _   __    _||");
                Console.WriteLine(@" ||/_--/__-\_/_||");
                Console.WriteLine(@" ||____|____|__||");
                Console.WriteLine(@"/___[]_____\0\___\");
                Console.WriteLine(@"|________________|");
                Console.WriteLine(@" | _____    []  |");
                Console.WriteLine(@" |_|___|________|");
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine(@" ________________");
                Console.WriteLine(@" ||Claw Machine||");
                Console.WriteLine(@" |+------------+|");
                Console.WriteLine(@" |______________|");
                Console.WriteLine(@" ||     ||     ||");
                Console.WriteLine(@" ||     ||     ||");
                Console.WriteLine(@" ||   /-||-\   ||");
                Console.WriteLine(@" || _ | || |  _||");
                Console.WriteLine(@" ||/_--/__-\_/_||");
                Console.WriteLine(@" ||____|____|__||");
                Console.WriteLine(@"/___[]_____\0\___\");
                Console.WriteLine(@"|________________|");
                Console.WriteLine(@" | _____    []  |");
                Console.WriteLine(@" |_|___|________|");
                Thread.Sleep(250);
                Console.Clear();
                Console.WriteLine(@" ________________");
                Console.WriteLine(@" ||Claw Machine||");
                Console.WriteLine(@" |+------------+|");
                Console.WriteLine(@" |______________|");
                Console.WriteLine(@" ||     ||     ||");
                Console.WriteLine(@" ||     ||     ||");
                Console.WriteLine(@" ||     ||     ||");
                Console.WriteLine(@" || _ /-||-\  _||");
                Console.WriteLine(@" ||/_--/__-\_/_||");
                Console.WriteLine(@" ||____|____|__||");
                Console.WriteLine(@"/___[]_____\0\___\");
                Console.WriteLine(@"|________________|");
                Console.WriteLine(@" | _____    []  |");
                Console.WriteLine(@" |_|___|________|");
                Thread.Sleep(250);
                Console.Clear();
                Console.WriteLine(@" ________________");
                Console.WriteLine(@" ||Claw Machine||");
                Console.WriteLine(@" |+------------+|");
                Console.WriteLine(@" |______________|");
                Console.WriteLine(@" ||     ||     ||");
                Console.WriteLine(@" ||     ||     ||");
                Console.WriteLine(@" ||     ||     ||");
                Console.WriteLine(@" || _   ||    _||");
                Console.WriteLine(@" ||/_--/__-\_/_||");
                Console.WriteLine(@" ||____|____|__||");
                Console.WriteLine(@"/___[]_____\0\___\");
                Console.WriteLine(@"|________________|");
                Console.WriteLine(@" | _____    []  |");
                Console.WriteLine(@" |_|___|________|");
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine(@" ________________");
                Console.WriteLine(@" ||Claw Machine||");
                Console.WriteLine(@" |+------------+|");
                Console.WriteLine(@" |______________|");
                Console.WriteLine(@" ||     ||     ||");
                Console.WriteLine(@" ||     ||     ||");
                Console.WriteLine(@" ||     ||     ||");
                Console.WriteLine(@" || _ |-||-|  _||");
                Console.WriteLine(@" ||/_--/__-\_/_||");
                Console.WriteLine(@" ||____|____|__||");
                Console.WriteLine(@"/___[]_____\0\___\");
                Console.WriteLine(@"|________________|");
                Console.WriteLine(@" | _____    []  |");
                Console.WriteLine(@" |_|___|________|");
                Thread.Sleep(250);
                Console.Clear();
                Console.WriteLine(@" ________________");
                Console.WriteLine(@" ||Claw Machine||");
                Console.WriteLine(@" |+------------+|");
                Console.WriteLine(@" |______________|");
                Console.WriteLine(@" ||     ||     ||");
                Console.WriteLine(@" ||     ||     ||");
                Console.WriteLine(@" ||   |-||-|   ||");
                Console.WriteLine(@" || _ \/||\/  _||");
                Console.WriteLine(@" ||/_--/__-\_/_||");
                Console.WriteLine(@" ||____|____|__||");
                Console.WriteLine(@"/___[]_____\0\___\");
                Console.WriteLine(@"|________________|");
                Console.WriteLine(@" | _____    []  |");
                Console.WriteLine(@" |_|___|________|");
                Thread.Sleep(250);
                Console.Clear();
                Console.WriteLine(@" ________________");
                Console.WriteLine(@" ||Claw Machine||");
                Console.WriteLine(@" |+------------+|");
                Console.WriteLine(@" |______________|");
                Console.WriteLine(@" ||     ||     ||");
                Console.WriteLine(@" ||   |-||-|   ||");
                Console.WriteLine(@" ||   \/||\/   ||");
                Console.WriteLine(@" || _  |__|   _||");
                Console.WriteLine(@" ||/_--/__-\_/_||");
                Console.WriteLine(@" ||____|____|__||");
                Console.WriteLine(@"/___[]_____\0\___\");
                Console.WriteLine(@"|________________|");
                Console.WriteLine(@" | _____    []  |");
                Console.WriteLine(@" |_|___|________|");
                Thread.Sleep(250);
                Console.Clear();
                Console.WriteLine(@" ________________");
                Console.WriteLine(@" ||Claw Machine||");
                Console.WriteLine(@" |+------------+|");
                Console.WriteLine(@" |______________|");
                Console.WriteLine(@" ||   |-||-|   ||");
                Console.WriteLine(@" ||   \/||\/   ||");
                Console.WriteLine(@" ||    |__|    ||");
                Console.WriteLine(@" || _   __    _||");
                Console.WriteLine(@" ||/_--/__-\_/_||");
                Console.WriteLine(@" ||____|____|__||");
                Console.WriteLine(@"/___[]_____\0\___\");
                Console.WriteLine(@"|________________|");
                Console.WriteLine(@" | _____    []  |");
                Console.WriteLine(@" |_|___|________|");
                Thread.Sleep(500);
                #endregion
                Console.WriteLine("Congrats you won a:\n" + clawitem);
                Thread.Sleep(1000);
                Console.WriteLine("Would you like to [play again] or [return]?");
                cinput = Console.ReadLine();
                if (cinput == "play again" || cinput == "Play again")
                {
                    clawMachine();
                }
                else if (cinput == "return" || cinput == "Return")
                {
                    gambleSelect();
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    Thread.Sleep(500);
                    clawMachine();
                }
            }
        }

        private static void itemStorage()
        {
            Console.Clear();
            Console.WriteLine("===============IGNORE=ANY=ITEMS=ABOVE=THIS=POINT===============");
            Console.WriteLine("Halloween set:");
            if (pumpkincount > 0)
                Console.WriteLine(pumpkin + "     pumpkin x" + pumpkincount);
            if (rare_pumpkincount > 0)
                Console.WriteLine(rare_pumpkin + "     rare pumpkin x" + rare_pumpkincount);
            if (exotic_pumpkincount > 0)
                Console.WriteLine(exotic_pumpkin + "     exotic pumpkin x" + exotic_pumpkincount);
            if (skullcount > 0)
                Console.WriteLine(skull + "     skull x" + skullcount);
            if (candlecount > 0)
                Console.WriteLine(candle + "     candle x" + candlecount);
            if (spidercount > 0)
                Console.WriteLine(spider + "     spider x" + spidercount);
            Console.WriteLine("Game set:");
            if (lil_catcount > 0)
                Console.WriteLine(lil_cat + "     lil cat x" + lil_catcount);
            if (rare_catcount > 0)
                Console.WriteLine(rare_cat + "     rare cat x" + rare_catcount);
            if (exotic_catcount > 0)
                Console.WriteLine(exotic_cat + "     exotic cat x" + exotic_catcount);
            if (spooktubercount > 0)
                Console.WriteLine(spooktuber + "     spooktuber x" + spooktubercount);
            if (herobrinecount > 0)
                Console.WriteLine(herobrine + "     herobrine x" + herobrinecount);
            if (impostercount > 0)
                Console.WriteLine(imposter + "     imposter x" + impostercount);
            Console.WriteLine("Mystic set:");
            if (castlecount > 0)
                Console.WriteLine(castle + "     castle x" + castlecount);
            if (rarecastlecount > 0)
                Console.WriteLine(rarecastle + "     rare castle x" + rarecastlecount);
            if (exoticcastlecount > 0)
                Console.WriteLine(exoticcastle + "     exotic castle x" + exoticcastlecount);
            if (crystalcount > 0)
                Console.WriteLine(crystal + "     crystal x" + crystalcount);
            if (dragoneggcount > 0)
                Console.WriteLine(dragonegg + "     dragon egg x" + dragoneggcount);
            if (potioncount > 0)
                Console.WriteLine(potion + "     potion x" + potioncount);
            Console.WriteLine("\nThis is your storage, any and all items will appear here which you can sell or collect!");
            Console.WriteLine("Type [return] to return");
            Console.WriteLine("Common items can be sold for $350, rare items can be sold for $1,500, and exotic items can be sold for $5,000");
            Console.WriteLine("To sell an item, simply type its name.");

            string sinput = Console.ReadLine();

            if (sinput == "return" || sinput == "Return")
            {
                option1();
            }
            else if (sinput == "pumpkin" && pumpkincount > 0)
            {
                pumpkincount -= 1;
                currency += 350;
                itemStorage();
            }
            else if (sinput == "rare pumpkin" && rare_pumpkincount > 0)
            {
                rare_pumpkincount -= 1;
                currency += 1500;
                itemStorage();
            }
            else if (sinput == "exotic pumpkin" && exotic_pumpkincount > 0)
            {
                exotic_pumpkincount -= 1;
                currency += 5000;
                itemStorage();
            }
            else if (sinput == "skull" && skullcount > 0)
            {
                skullcount -= 1;
                currency += 350;
                itemStorage();
            }
            else if (sinput == "spider" && spidercount > 0)
            {
                spidercount -= 1;
                currency += 350;
                itemStorage();
            }
            else if (sinput == "candle" && candlecount > 0)
            {
                candlecount -= 1;
                currency += 350;
                itemStorage();
            }
            else if (sinput == "lil cat" && lil_catcount > 0)
            {
                lil_catcount -= 1;
                currency += 350;
                itemStorage();
            }
            else if (sinput == "rare cat" && rare_catcount > 0)
            {
                rare_catcount -= 1;
                currency += 1500;
                itemStorage();
            }
            else if (sinput == "exotic cat" && exotic_catcount > 0)
            {
                exotic_catcount -= 1;
                currency += 5000;
                itemStorage();
            }
            else if (sinput == "imposter" && impostercount > 0)
            {
                impostercount -= 1;
                currency += 350;
                itemStorage();
            }
            else if (sinput == "spooktuber" && spooktubercount > 0)
            {
                spooktubercount -= 1;
                currency += 350;
                itemStorage();
            }
            else if (sinput == "herobrine" && herobrinecount > 0)
            {
                herobrinecount -= 1;
                currency += 350;
                itemStorage();
            }
            else if (sinput == "dragon egg" && dragoneggcount > 0)
            {
                dragoneggcount -= 1;
                currency += 350;
                itemStorage();
            }
            else if (sinput == "crystal" && crystalcount > 0)
            {
                crystalcount -= 1;
                currency += 350;
                itemStorage();
            }
            else if (sinput == "potion" && potioncount > 0)
            {
                potioncount -= 1;
                currency += 350;
                itemStorage();
            }
            else if (sinput == "castle" && castlecount > 0)
            {
                castlecount -= 1;
                currency += 350;
                itemStorage();
            }
            else if (sinput == "rare castle" && rarecastlecount > 0)
            {
                rarecastlecount -= 1;
                currency += 1500;
                itemStorage();
            }
            else if (sinput == "exotic castle" && exoticcastlecount > 0)
            {
                exoticcastlecount -= 1;
                currency += 5000;
                itemStorage();
            }
            else
            {
                Console.WriteLine("Invalid Input");
                Thread.Sleep(500);
                option1();
            }

        }

        private static void drawing()
        {
            Console.Clear();
            Console.WriteLine("Type each line of your drawing and click [enter] to lock it in.\nClick 1 to finish drawing.\nClick 2 to reset.\nClick 3 to erase last line");
            Console.WriteLine(userDrawing);
            drawuserinput = Console.ReadLine();
            if (drawuserinput == "1")
            {
                option1();
            }
            else if (drawuserinput == "2")
            {
                userDrawing = "";
            }
            else if (drawuserinput == "3")
            {
                userDrawing = drawlinebefore;
            }
            else
            {
                drawlinebefore = userDrawing;
                userDrawing = userDrawing + "\n" + drawuserinput;
            }
            drawing();
        }







        private static void hangman()
        {
            string hm1 = @"

              ||
              ||
              ||
              ||
              ||
              ||
              ||
              ||
              ||
              ||
              ||
              ||
             /||\
            //||\\";
            string hm2 = @"
              =============#=
              ||
              ||
              ||
              ||
              ||
              ||
              ||
              ||
              ||
              ||
              ||
              ||
             /||\
            //||\\";
            string hm3 = @"
              =============#=
              ||          [|]
              ||           |
              ||           |
              ||          ---
              ||         |   |
              ||          -+-
              ||
              ||
              ||
              ||
              ||
              ||
             /||\
            //||\\";
            string hm4 = @"
              =============#=
              ||          [|]
              ||           |
              ||           |
              ||          ---
              ||         |   |
              ||          -+-
              ||           |
              ||           |
              ||           |
              ||
              ||
              ||
             /||\
            //||\\";
            string hm5 = @"
              =============#=
              ||          [|]
              ||           |
              ||           |
              ||          ---
              ||         |   |
              ||          -+-
              ||          /|
              ||         / |
              ||           |
              ||
              ||
              ||
             /||\
            //||\\";
            string hm6 = @"
              =============#=
              ||          [|]
              ||           |
              ||           |
              ||          ---
              ||         |   |
              ||          -+-
              ||          /|\
              ||         / | \
              ||           |
              ||
              ||
              ||
             /||\
            //||\\";
            string hm7 = @"
              =============#=
              ||          [|]
              ||           |
              ||           |
              ||          ---
              ||         |   |
              ||          -+-
              ||          /|\
              ||         / | \
              ||           |
              ||          /
              ||         /
              ||
             /||\
            //||\\";
            string hm8 = @"
              =============#=
              ||          [|]
              ||           |
              ||           |
              ||          ---
              ||         |   |
              ||          -+-
              ||          /|\
              ||         / | \
              ||           |
              ||          / \
              ||         /   \
              ||
             /||\
            //||\\";
            string wordToGuess = "";
            Random hmRan = new Random();
            int hmWord = hmRan.Next(1, 7);
            switch (hmWord)
            {
                case 1: wordToGuess = "viscosity"; break;
                case 2: wordToGuess = "pineapple"; break;
                case 3: wordToGuess = "luminesence"; break;
                case 4: wordToGuess = "carnival"; break;
                case 5: wordToGuess = "equivalent"; break;
                case 6: wordToGuess = "quantity"; break;
                case 7: wordToGuess = "oobleck"; break;
            }
                string letterDashes = new string('_', wordToGuess.Length);
                int hmlives = 8;

                while (hmlives > 0 && letterDashes.Contains("_"))
                {
                    Console.Clear();
                    switch(hmlives)
                    {
                        case 8: Console.WriteLine(hm1); break;
                        case 7: Console.WriteLine(hm2); break;
                        case 6: Console.WriteLine(hm3); break;
                        case 5: Console.WriteLine(hm4); break;
                        case 4: Console.WriteLine(hm5); break;
                        case 3: Console.WriteLine(hm6); break;
                        case 2: Console.WriteLine(hm7); break;
                        case 1: Console.WriteLine(hm8); break;
                    }
                    Console.WriteLine("Current word: " + letterDashes);
                    Console.Write("Guess a letter: ");
                    char guess = Console.ReadLine()[0];

                    if (wordToGuess.Contains(guess))
                    {
                        for (int i = 0; i < wordToGuess.Length; i++)
                        {
                            if (wordToGuess[i] == guess)
                            {
                                letterDashes = letterDashes.Remove(i, 1).Insert(i, guess.ToString());
                            }
                        }
                        Console.WriteLine("Good guess!");
                    }
                    else
                    {
                        hmlives--;
                        Console.WriteLine("Wrong guess! Try again.");
                    }
                }

                if (!letterDashes.Contains("_"))
                {
                    Console.WriteLine("Congratulations! You've guessed the word: " + wordToGuess);
                    Thread.Sleep(2000);
                }
                else
                {
                    Console.WriteLine("Game over! The word was: " + wordToGuess);
                    Thread.Sleep(2000);
                }
            Console.Write("[Play again] or [Return]?: ");
            string hmrR = Console.ReadLine();
            if (hmrR == "Play again" || hmrR == "play again")
            {
                hangman();
            }
            else if (hmrR == "Return" || hmrR == "return")
            {
                option1();
            }
            else
            {
                Console.WriteLine("Invalid input");
                Thread.Sleep(1000);
                option1();
            }

        }

    }
}




//
