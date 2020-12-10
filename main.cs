using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Repl.it används för att testa
namespace EnterText
{
    class Program
    {
        static void Main(string[] args)
        {
            startmenu();
        }
        public static void startmenu()
        {
                              string title = @"
  _______  _______  _______       _______   ______  __   
(  ____ \(  ____ \(  ____ )     / ___   ) / ____ \/  \  
| (    \/| (    \/| (    )|     \/   )  |( (    \/\/) ) 
| (_____ | |      | (____)| _____   /   )| (____    | | 
(_____  )| |      |  _____)(_____)_/   / |  ___ \   | | 
      ) || |      | (            /   _/  | (   ) )  | | 
/\____) || (____/\| )           (   (__/\( (___) )__) (_
\_______)(_______/|/            \_______/ \_____/ \____/
                                                        
                                               
";

            Console.WriteLine(title);
            gameTitle();

        }
        public static void gameTitle()
        {
            Console.WriteLine("Welcome to SCP-261 the game");
            Console.WriteLine("Press 'Enter' to start");
            Console.ReadLine();
            Console.Clear();
            first();

        }
        public static void first()
        {
          Console.Clear();
          string choice; 
          string day1 = @"
 ______   _______             __   
(  __  \ (  ___  )|\     /|  /  \  
| (  \  )| (   ) |( \   / )  \/) ) 
| |   ) || (___) | \ (_) /     | | 
| |   | ||  ___  |  \   /      | | 
| |   ) || (   ) |   ) (       | | 
| (__/  )| )   ( |   | |     __) (_
(______/ |/     \|   \_/     \____/
                                   
";
         Console.WriteLine(day1);
          Console.WriteLine("Welcome!");
          Console.WriteLine("You wake up, you look around. Where am I? You start to open everything to find a clue.");
          string player = @"

                                                  
                                                  
                                                  
                    Lt #..L                       
               GL jD Kj #D.W                      
            fE#  # tW EG ED #                     
            ;ti #  # DE WG EL                     
            EEj  # #t #  #  # .                   
            .tt  Gt # ,# DW G#E                   
             .it  # Wi #  # :# W                  
             :ii  # tK #i ff.KjW                  
              ,ii # ,:GDG LG#KWEi                 
              :,tijLLGfWWKEDGf#KG;                
               E;iDEWKDDL#DDDDDDDWK               
                i jKLEGDDDDDDGKDGW..              
                :tLLLGKDjDDDDffDjGGD              
                 tGf DEGLGLjEi E #LiE             
                 ,f#fLEDf#GE WW    ED             
                  .if#GL;D# ;i.W ..L,D            
                  fjftD    GE iLGLDEGLD           
                  .;j,LLW DGELGDE#DLGDf           
                   tL.tfGLDED#DjDLG#WWW           
                    ;itKDfDDGDE#WWWWWEG           
                    :itfLtD#W#WWWKKDGf:           
                     ;LGDDWWWKKEGLL               
                      j#WKKEDLG                   
                       GDDG                       
                                                  
                                                  
";
          Console.WriteLine(player);
          Console.WriteLine("You find a device that says LISTEN on it. What do you do?");
          Console.WriteLine("[1] Press the start button");
          Console.WriteLine("[2] Destroy it");
          Console.WriteLine("[3] Put it back");
          Console.WriteLine("[4] Put it in my bag");
          Console.WriteLine("Choice: ");
          choice = Console.ReadLine().ToLower();
          
          switch (choice)
          {
            case "1":
            case "press the start button":
            case "Start the audio": 
            case "press":
               {
                  Console.WriteLine("You press the start button.");
                  Console.WriteLine("A voice start talking:");
                  Console.WriteLine("Hello SCP-261 testbunny");
                  Console.WriteLine("You need to survive! But if you die, well you respawn.");
                  Console.WriteLine("Good Luck and make good decision");
                  Console.WriteLine("Best Luck");
                  string logoscp = @"
@@@@@@@@@@@@@@@@@Qj\vzz11zz1zzc=HQ@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@h,a#QQQQQQQQQR?|M@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@QX]^;Q@@@@@@@@@@Qd:rZH@@@@@@@@@@@@@@
@@@@@@@@@@@@q\|zaNQ@@@@@QQ@@@@@@BD]/|vg@@@@@@@@@@@
@@@@@@@@@@o|\DQ@@@@@@@@Qe,Q@@@@@@@@@gerFD@@@@@@@@@
@@@@@@@@6\\wQ@@@@QQ6S\>;' :;|vPDQQ@@@@Qv^2#@@@@@@@
@@@@@@RL\O@Q@@Qkl'`':L{e\`ea7?,`-:eg@@@@Q1;XQ@@@@@
@@@@@Q;^QQQQQH7` ^}NQ@@Qo`Q@QQ#O?,`,kQQQQQH:/QQ@@@
@@@@Q]\8QQQQ&, :]QQQQQQm|`a6QQQQQN^-.=QQQQQ]:KQQ@@
QQQ@j:RQQQQQr 'WQQQQQQQ;` ,vQQQQQQBo``aQQQQBF|DQQQ
QQQQ;:QQQQQR`,]QQQQQQQQ&7.EQQQQQQQQQ:`:QQQQQH:uQQQ
QQQQ:rQQQQQo`>8QQQQQQQQQBhQQQQQQQQQQv--#QQQQN,|NQQ
QQQQ:rQQQQQe`^OQQQU:_,~zDQo^,~:^#QQQi-'#QQQQW~\g#Q
QQHj:/QQQQQN''\gK7>,''>#QQQK,`,:|]DR~`>QQQQQR:rKNQ
#6:rHBQQQQQQ/`.:;7SDPwNQQQQQKuDDF\:~`-XQQQQQQd2;*H
#R>*#QQQQQMu;:''^DBQQQQQQQQQQQQQMe,`:^^KQQQQQQq;\9
gNKz/6QQQQBOKNh;'~>Zq#QQQQQQ#gm]:':?&B9NQQQQBz^uhD
88gM/rdBQQQQQQQgh?;',;r/7vi\;:',rlD#QQQQQQQ&2^z9H8
DDDDR9^\NQBNWQQBQQQgDmStzvJFZ6W#QQQBBBNBQ#O;>mUDDD
dHdHHDw/\z/||FPNBBBBBBBBBBQBBBBBBB#82l?L7crvoKddHH
OOOOOODKlluam7\\cohRg##BBBBB#N8deF\??coj]/7m6OOOOO
KKKKKKOK99qKKq9euL\\/icvvzvvi/\||/]oPkqqq$6qKKKKKK
qqqqqqKKqqqqqKKqq$6kPa2uffuujomXPk$9qqqqqqqqqKqqKK
qqqqqqqqqqqqqqqqqqqqqqq9999q99qqqqqqqqqqqqqqqKqqKq
";
                  Console.WriteLine(logoscp);
                  first2h();
                  break;

               };

            case "2":
              {
                Console.WriteLine("Yupp");
                gameOver();
                break;
              };
            

            case "4":
            {
            
              Console.WriteLine("You put the device in your bag");
              string[] inv = { "1. Audio Player Device" };
              System.IO.File.WriteAllLines(@"data/inv.txt", inv);
              first2h();
              string[] lines = System.IO.File.ReadAllLines(@"data/inv.txt");

        // Display the file contents by using a foreach loop.
              System.Console.WriteLine("You have ");
              foreach (string line in lines)
              {
                // Use a tab to indent each line of the file.
                Console.WriteLine("\t" + line);
              }         
              Console.WriteLine("in your inventory");
             break;

            }

            
          }

        }

        public static void first2h()
        {
          Console.Clear();
          Random rnd = new Random();
          string secop = {"You walk out the room and see a long hall.", "You walk out of the room. You find three doors. One is red, one is blue and one is brown."," You go out of the room. You see a long hall, and one person. You start walking to the person and start yelling."

          }
          int randomNumber = 
        }

        public static void first3h()
        {
        }

        public static void first4h()
        {
        }

        public static void first5h()
        {
        }

        public static void second()
        {
        }

        public static void third()
        {
        }

        public static void gameOver()
        {
        }
        public static void youWin()
        {
        }
    }
}