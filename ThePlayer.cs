using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class ThePlayer
    {
        PickBet pb = new PickBet(); //Class for choosing the bet
        public int bets { get; set; }

        public static int Money { get; set; } //properties

        public static int Wager { get; set; }

        public void PlayerStart(int bets, int points)
        {
            this.bets = bets;
            Money = points;
        }
        //I used Alex's game to help as a reference to understand Roulette. When I first started
        //making my game we had similar properties set up for the player. I switched up some of the 
        //methods to be able to go through the code and help my understand of how the class and
        //methods work together


        public void StartGame()
        {
            DisplayMenu menu = new DisplayMenu();
            PlayerStart(10, 100); //Player has 10 bets, this is the 10 and start with 100 - this is the 100!
            menu.InitialDisplay();
            do
            {
                //What I liked about Alex's game was he used a do while loop
                //for the bet menu, and it remained displayed during the game
                //until the player ran out of bets.
                Console.Clear(); //clear out initial display
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("                          ╔═════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("                          ║      3  6  9  12     |   15  18  21  24    |     27  30  33  36 ║   ");
                Console.WriteLine("                          ║                      |                     |                    ║   ");
                Console.WriteLine("                          ║ 00                   |                     |                    ║   ");
                Console.WriteLine("                          ║      2  5  8  11     |   14  17  20  23    |    26  29  32  35  ║   ");
                Console.WriteLine("                          ║                      |                     |                    ║   ");
                Console.WriteLine("                          ║ 0                    |                     |                    ║   ");
                Console.WriteLine("                          ║      1  4  7  10     |   13  16  19  22    |    25  28  31  34  ║   ");
                Console.WriteLine("                          ║                      |                     |                    ║   ");
                Console.WriteLine("                          ╚═════════════════════════════════════════════════════════════════╝");
                Console.WriteLine(" ╔═══════════════════════════════════╗");
                Console.WriteLine($"   Bets remaining: {bets} | Money ${Money} "); //They display lay out of bets and odds below was used from Alex's project.
                Console.WriteLine(" ╚═══════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("                                                      Choose your bet:");
                Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║  1. Numbers (35 to 1)| 2. Evens/Odds (2 to 1)| 3. Reds/Blacks (2 to 1)| 4. Lows/Highs (2 to 1)| 5. Dozens (3 to 1)  ║");
                Console.WriteLine("║  6. Columns (3 to 1) | 7. Street (12 to 1)   | 8. 6 Numbers (5 to 1)  | 9. Split (18 to 1)    | 10. Corner (8 to 1) ║");
                Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.Write(":>");
                string bet = Console.ReadLine().ToString().ToLower();
                pb.ChooseBet(bet);
                this.bets--; //everytime a bet is picked, bet amount drops by 1
            } while (bets > 0); // while loop wont complete until all the bets are used!

            EndOfGame();

        }
        public void EndOfGame()
        {
            Console.WriteLine($"You left the casino with ${Money}");
            Console.ReadLine();
            StartGame();
        }
    }
}
