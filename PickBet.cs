using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Roulette.ThePlayer;
using static Roulette.Wheel;


namespace Roulette
{
    class PickBet
    {

        Wheel wa = new Wheel();

        public int binChoice { get; set; }

        public void ChooseBet(string menu)
        {
            try
            {
                switch (menu)  //switch statement so the user can choose which bet they would like to do
                {
                    case "1":
                        //Straight number bet
                        Console.WriteLine("What number to you want to bet on? ");
                        Console.Write(":>");
                        NumCheck();
                        Bet();
                        int resultI = wa.GetBallLocation(wa.wheelAll); //the get location method for where the ball falls in reference to the indexing of the wheel all array
                        string resultC = wa.GetBallColor(wa.color); //return the color method based off the color array
                       
                        Console.WriteLine($"The ball landed in {resultC} {resultI}.");
                        Number();
                        Console.ReadLine();
                        break;
                    case "2":
                        //Even or odd bet
                        Console.WriteLine("1. Evens | 2. Odds?");
                        Console.Write(":>");
                        int evenOdd = Convert.ToInt32(Console.ReadLine());
                        Bet();
                        resultI = wa.GetBallLocation(wa.wheelAll);
                        resultC = wa.GetBallColor(wa.color);
                  
                        Console.WriteLine($"The ball landed in {resultC} {resultI}.");
                        EvenOdd(evenOdd);
                        Console.ReadLine();
                        break;
                    case "3":
                        //red or black bet
                        Console.WriteLine("1.Reds | 2. Blacks");
                        Console.Write(":>");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        Bet();
                        resultI = wa.GetBallLocation(wa.wheelAll);
                        resultC = wa.GetBallColor(wa.color);
                     //   ws.Spin();
                        Console.WriteLine($"The ball landed in {resultC} {resultI}.");
                        RedBlack(choice, resultC);
                        Console.ReadLine();
                        break;
                    case "4":
                        //low or high bet
                        Console.WriteLine("1. Lows | 2. Highs");
                        Console.Write(":>");
                        choice = Convert.ToInt32(Console.ReadLine());
                        Bet();
                        resultI = wa.GetBallLocation(wa.wheelAll);
                        resultC = wa.GetBallColor(wa.color);
                      //  ws.Spin();
                        Console.WriteLine($"The ball landed in {resultC} {resultI}.");
                        LowHigh(choice);
                        Console.ReadLine();
                        break;
                    case "5":
                        //dozen bet
                        Console.WriteLine("Which Dozen?\n1. 1 - 12 | 2. 13 - 24 | 3. 25 - 36");
                        Console.Write(":>");
                        choice = Convert.ToInt32(Console.ReadLine());
                        Bet();
                        resultI = wa.GetBallLocation(wa.wheelAll);
                        resultC = wa.GetBallColor(wa.color);
                      //  ws.Spin();
                        Console.WriteLine($"The ball landed in {resultC} {resultI}.");
                        Dozen(choice);
                        Console.ReadLine();
                        break;
                    case "6":
                        //column bet
                        Console.WriteLine("Which Column?\n1. | 2. | 3. ");
                        Console.Write(":>");
                        choice = Convert.ToInt32(Console.ReadLine());
                        Bet();
                        resultI = wa.GetBallLocation(wa.wheelAll);
                        resultC = wa.GetBallColor(wa.color);
                      //  ws.Spin();
                        Console.WriteLine($"The ball landed in {resultC} {resultI}.");
                        Column(choice);
                        Console.ReadLine();
                        break;
                    case "7":
                        //street bet
                        Console.WriteLine("Which Street?\n1 - 12");
                        Console.Write(":>");
                        choice = Convert.ToInt32(Console.ReadLine());
                        Bet();
                        resultI = wa.GetBallLocation(wa.wheelAll);
                        resultC = wa.GetBallColor(wa.color);
                      //  ws.Spin();
                        Console.WriteLine($"The ball landed in {resultC} {resultI}.");
                        Street(choice);
                        Console.ReadLine();
                        break;
                    case "8":
                        //6's bet
                        Console.WriteLine("Which 6?\n1 - 6");
                        Console.Write(":>");
                        choice = Convert.ToInt32(Console.ReadLine());
                        Bet();
                        resultI = wa.GetBallLocation(wa.wheelAll);
                        resultC = wa.GetBallColor(wa.color);
                     //   ws.Spin();
                        Console.WriteLine($"The ball landed in {resultC} {resultI}.");
                        Double6(choice);
                        Console.ReadLine();
                        break;
                    case "9":
                        //split bet, how the betting table is set up, each number is either +1, -1, +4, or -4
                        //away from the user's first bet, so this checks for that condition before the bet is valid
                        Console.WriteLine("Enter your first number, then press enter:");
                        Console.Write(":>");
                        int choicea, choiceb;
                        choicea = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter your second number, then press enter:");
                        Console.Write(":>");
                        do
                        {
                            choiceb = Convert.ToInt32(Console.ReadLine());
                        } while (choicea != choiceb + 1 && choicea != choiceb - 1 && choicea != choiceb + 3 && choicea != choiceb - 3);
                        Bet();
                        resultI = wa.GetBallLocation(wa.wheelAll);
                        resultC = wa.GetBallColor(wa.color);
                      //  ws.Spin();
                        Console.WriteLine($"The ball landed in {resultC} {resultI}.");
                        Split(choicea, choiceb);
                        Console.ReadLine();
                        break;
                    case "10":
                        //corner bet, this asks for the smallest value in the user's bet, the bet cannot be divisible by 3
                        Console.WriteLine("What is the lowest value in your corner bet?");
                        int corner;
                        do
                        {
                            Console.Write(":>");
                            corner = Convert.ToInt32(Console.ReadLine());
                        } while (corner < 1 && corner > 36);
                        Bet();
                        resultI = wa.GetBallLocation(wa.wheelAll);
                        resultC = wa.GetBallColor(wa.color);
                      //  ws.Spin();
                        Console.WriteLine($"The ball landed in {resultC} {resultI}.");
                        Corner(corner);
                        Console.ReadLine();
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadLine();
            }
        }
        //This method checks to see if the ThePlayer has enough Money to bet
        public void Bet()
        {
            try
            {
                ThePlayer p = new ThePlayer();
                Console.WriteLine("How much do you bet?");
                Console.Write(":>");
                ThePlayer.Wager = Convert.ToInt32(Console.ReadLine());
                while (ThePlayer.Wager > ThePlayer.Money)
                {
                    Console.WriteLine("You're trying to bet more than what you have!");
                    Console.WriteLine("Try again:");
                    Console.Write(":>");
                    ThePlayer.Wager = Convert.ToInt32(Console.ReadLine());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        //Corner bet, by adding +1, +2, and +1 to the smallest value, this will make the corner valid
        public void Corner(int corner1)
        {
            int corner2, corner3, corner4;
            if (corner1 % 3 != 0)
            {
                corner2 = corner1 + 1;
                corner3 = corner2 + 2;
                corner4 = corner3 + 1;
            }
            else
            {
                corner2 = corner1 - 1;
                corner3 = corner1 + 3;
                corner4 = corner3 - 1;
            }
            if (corner1 == wa.BallFalls || corner2 == wa.BallFalls || corner3 == wa.BallFalls || corner4 == wa.BallFalls)
            {
                ThePlayer.Money += ((ThePlayer.Wager * 8) - ThePlayer.Wager);
                Console.WriteLine($"You won ${ThePlayer.Wager * 8}!");
                Console.WriteLine("Press enter...");
            }
            else
            {
                ThePlayerLost();
            }
        }
        //Split bet only works if the ThePlayers second bet is +1, -1, +4, or -4 from the first bet
        public void Split(int choicea, int choiceb)
        {
            if (choicea == wa.BallFalls || choiceb == wa.BallFalls)
            {
                ThePlayer.Money += ((ThePlayer.Wager * 18) - ThePlayer.Wager);
                Console.WriteLine($"You won ${ThePlayer.Wager * 18}!");
                Console.WriteLine("Press enter...");
            }
            else
            {
                ThePlayerLost();
            }
        }
        //6's bet splits the board into 6, 5 to 1 odds
        public void Double6(int choice)
        {
            switch (choice)
            {
                case 1:
                    if (choice == 1 && wa.BallFalls <= 6)
                    {
                        ThePlayer.Money += ((ThePlayer.Wager * 6) - ThePlayer.Wager);
                        Console.WriteLine($"You won ${ThePlayer.Wager * 5}!");
                        Console.WriteLine("Press enter...");
                    }
                    else
                    {
                        ThePlayerLost();
                    }
                    break;
                case 2:
                    if (choice == 2 && wa.BallFalls >= 7 && wa.BallFalls <= 12)
                    {
                        ThePlayer.Money += ((ThePlayer.Wager * 6) - ThePlayer.Wager);
                        Console.WriteLine($"You won ${ThePlayer.Wager * 5}!");
                        Console.WriteLine("Press enter...");
                    }
                    else
                    {
                        ThePlayerLost();
                    }
                    break;
                case 3:
                    if (choice == 3 && wa.BallFalls >= 13 && wa.BallFalls <= 18)
                    {
                        ThePlayer.Money += ((ThePlayer.Wager * 6) - ThePlayer.Wager);
                        Console.WriteLine($"You won ${ThePlayer.Wager * 5}!");
                        Console.WriteLine("Press enter...");
                    }
                    else
                    {
                        ThePlayerLost();
                    }
                    break;
                case 4:
                    if (choice == 4 && wa.BallFalls >= 19 && wa.BallFalls <= 24)
                    {
                        ThePlayer.Money += ((ThePlayer.Wager * 6) - ThePlayer.Wager);
                        Console.WriteLine($"You won ${ThePlayer.Wager * 5}!");
                        Console.WriteLine("Press enter...");
                    }
                    else
                    {
                        ThePlayerLost();
                    }
                    break;
                case 5:
                    if (choice == 5 && wa.BallFalls >= 25 && wa.BallFalls <= 30)
                    {
                        ThePlayer.Money += ((ThePlayer.Wager * 6) - ThePlayer.Wager);
                        Console.WriteLine($"You won ${ThePlayer.Wager * 5}!");
                        Console.WriteLine("Press enter...");
                    }
                    else
                    {
                        ThePlayerLost();
                    }
                    break;
                case 6:
                    if (choice == 6 && wa.BallFalls >= 31 && wa.BallFalls <= 36)
                    {
                        ThePlayer.Money += ((ThePlayer.Wager * 6) - ThePlayer.Wager);
                        Console.WriteLine($"You won ${ThePlayer.Wager * 5}!");
                        Console.WriteLine("Press enter...");
                    }
                    else
                    {
                        ThePlayerLost();
                    }
                    break;
            }
        }
        //splits the board into threes, vertically
        public void Street(int choice)
        {
            switch (choice)
            {
                case 1:
                    bool column = wa.InColumn(wa.street1);
                    if (choice == 1 && column == true)
                    {
                        ThePlayer.Money += ((ThePlayer.Wager * 11) - ThePlayer.Wager);
                        Console.WriteLine($"You won ${ThePlayer.Wager * 11}!");
                        Console.WriteLine("Press enter...");
                    }
                    else
                    {
                        ThePlayerLost();
                    }
                    break;
                case 2:
                    column = wa.InColumn(wa.street2);
                    if (choice == 2 && column == true)
                    {
                        ThePlayer.Money += ((ThePlayer.Wager * 11) - ThePlayer.Wager);
                        Console.WriteLine($"You won ${ThePlayer.Wager * 11}!");
                        Console.WriteLine("Press enter...");
                    }
                    else
                    {
                        ThePlayerLost();
                    }
                    break;
                case 3:
                    column = wa.InColumn(wa.street3);
                    if (choice == 3 && column == true)
                    {
                        ThePlayer.Money += ((ThePlayer.Wager * 11) - ThePlayer.Wager);
                        Console.WriteLine($"You won ${ThePlayer.Wager * 11}!");
                        Console.WriteLine("Press enter...");
                    }
                    else
                    {
                        ThePlayerLost();
                    }
                    break;
                case 4:
                    column = wa.InColumn(wa.street4);
                    if (choice == 4 && column == true)
                    {
                        ThePlayer.Money += ((ThePlayer.Wager * 11) - ThePlayer.Wager);
                        Console.WriteLine($"You won ${ThePlayer.Wager * 11}!");
                        Console.WriteLine("Press enter...");
                    }
                    else
                    {
                        ThePlayerLost();
                    }
                    break;
                case 5:
                    column = wa.InColumn(wa.street5);
                    if (choice == 5 && column == true)
                    {
                        ThePlayer.Money += ((ThePlayer.Wager * 11) - ThePlayer.Wager);
                        Console.WriteLine($"You won ${ThePlayer.Wager * 11}!");
                        Console.WriteLine("Press enter...");
                    }
                    else
                    {
                        ThePlayerLost();
                    }
                    break;
                case 6:
                    column = wa.InColumn(wa.street6);
                    if (choice == 6 && column == true)
                    {
                        ThePlayer.Money += ((ThePlayer.Wager * 11) - ThePlayer.Wager);
                        Console.WriteLine($"You won ${ThePlayer.Wager * 11}!");
                        Console.WriteLine("Press enter...");
                    }
                    else
                    {
                        ThePlayerLost();
                    }
                    break;
                case 7:
                    column = wa.InColumn(wa.street7);
                    if (choice == 7 && column == true)
                    {
                        ThePlayer.Money += ((ThePlayer.Wager * 11) - ThePlayer.Wager);
                        Console.WriteLine($"You won ${ThePlayer.Wager * 11}!");
                        Console.WriteLine("Press enter...");
                    }
                    else
                    {
                        ThePlayerLost();
                    }
                    break;
                case 8:
                    column = wa.InColumn(wa.street8);
                    if (choice == 8 && column == true)
                    {
                        ThePlayer.Money += ((ThePlayer.Wager * 11) - ThePlayer.Wager);
                        Console.WriteLine($"You won ${ThePlayer.Wager * 11}!");
                        Console.WriteLine("Press enter...");
                    }
                    else
                    {
                        ThePlayerLost();
                    }
                    break;
                case 9:
                    column = wa.InColumn(wa.street9);
                    if (choice == 9 && column == true)
                    {
                        ThePlayer.Money += ((ThePlayer.Wager * 11) - ThePlayer.Wager);
                        Console.WriteLine($"You won ${ThePlayer.Wager * 11}!");
                        Console.WriteLine("Press enter...");
                    }
                    else
                    {
                        ThePlayerLost();
                    }
                    break;
                case 10:
                    column = wa.InColumn(wa.street10);
                    if (choice == 10 && column == true)
                    {
                        ThePlayer.Money += ((ThePlayer.Wager * 11) - ThePlayer.Wager);
                        Console.WriteLine($"You won ${ThePlayer.Wager * 11}!");
                        Console.WriteLine("Press enter...");
                    }
                    else
                    {
                        ThePlayerLost();
                    }
                    break;
                case 11:
                    column = wa.InColumn(wa.street11);
                    if (choice == 11 && column == true)
                    {
                        ThePlayer.Money += ((ThePlayer.Wager * 11) - ThePlayer.Wager);
                        Console.WriteLine($"You won ${ThePlayer.Wager * 11}!");
                        Console.WriteLine("Press enter...");
                    }
                    else
                    {
                        ThePlayerLost();
                    }
                    break;
                case 12:
                    column = wa.InColumn(wa.street12);
                    if (choice == 12 && column == true)
                    {
                        ThePlayer.Money += ((ThePlayer.Wager * 11) - ThePlayer.Wager);
                        Console.WriteLine($"You won ${ThePlayer.Wager * 11}!");
                        Console.WriteLine("Press enter...");
                    }
                    else
                    {
                        ThePlayerLost();
                    }
                    break;
            }
        }
        //splits the board into three horizontal columns, unlike the street and 6's bet, I chose to have
        //this method check via another array vs just writing in the valid numbers. This way I got 
        //practice using boolean methods and checking values within arrays.
        public void Column(int choice)
        {
            switch (choice)
            {
                case 1:
                    bool column = wa.InColumn(wa.column1);
                    if (choice == 1 && column == true)
                    {
                        ThePlayer.Money += ((ThePlayer.Wager * 3) - ThePlayer.Wager);
                        Console.WriteLine($"You won ${ThePlayer.Wager * 3}!");
                        Console.WriteLine("Press enter...");
                    }
                    else
                    {
                        ThePlayerLost();
                    }
                    break;
                case 2:
                    column = wa.InColumn(wa.column2);
                    if (choice == 2 && column == true)
                    {
                        ThePlayer.Money += ((ThePlayer.Wager * 3) - ThePlayer.Wager);
                        Console.WriteLine($"You won ${ThePlayer.Wager * 3}!");
                        Console.WriteLine("Press enter...");
                    }
                    else
                    {
                        ThePlayerLost();
                    }
                    break;
                case 3:
                    column = wa.InColumn(wa.column3);
                    if (choice == 3 && column == true)
                    {
                        ThePlayer.Money += ((ThePlayer.Wager * 3) - ThePlayer.Wager);
                        Console.WriteLine($"You won ${ThePlayer.Wager * 3}!");
                        Console.WriteLine("Press enter...");
                    }
                    else
                    {
                        ThePlayerLost();
                    }
                    break;
            }
        }
        //splits the board into chunks of 12
        public void Dozen(int choice)
        {
            switch (choice)
            {
                case 1:
                    if (wa.BallFalls <= 12) //Like the low high statement, this if statement breaks the 50/50 into 3rds
                        // after the random generator tells the game what number was randomlly selected, this method
                        // will determine if the generated number is in which dozen
                    {
                        ThePlayer.Money += ((ThePlayer.Wager * 3) - ThePlayer.Wager);
                        Console.WriteLine($"You won ${ThePlayer.Wager * 3}!");
                        Console.WriteLine("Press enter...");
                    }
                    else
                    {
                        ThePlayerLost();
                    }
                    break;
                case 2:
                    if (wa.BallFalls >= 13 && wa.BallFalls <= 24)
                    {
                        ThePlayer.Money += ((ThePlayer.Wager * 3) - ThePlayer.Wager);
                        Console.WriteLine($"You won ${ThePlayer.Wager * 3}!");
                        Console.WriteLine("Press enter...");
                    }
                    else
                    {
                        ThePlayerLost();
                    }
                    break;
                case 3:
                    if (wa.BallFalls >= 25 && wa.BallFalls <= 36)
                    {
                        ThePlayer.Money += ((ThePlayer.Wager * 3) - ThePlayer.Wager);
                        Console.WriteLine($"You won ${ThePlayer.Wager * 3}!");
                        Console.WriteLine("Press enter...");
                    }
                    else
                    {
                        ThePlayerLost();
                    }
                    break;
            }
        }
        //Checks if the ball is 18 or below 
        public void LowHigh(int choice)
        {
            switch (choice)
            {
                case 1:
                    if (wa.BallFalls <= 18)  
                        //If you look at this if statement and look at the color bet statement. They are both 50/50
                        //odds. But we are not looking at two elements such as number and the color array, but we are
                        //checking to see if the number is on the "low" end or the "high" end
                        //
                    {
                        ThePlayer.Money += ((ThePlayer.Wager * 2) - ThePlayer.Wager);
                        Console.WriteLine($"You won ${ThePlayer.Wager * 2}!");
                        Console.WriteLine("Press enter...");
                    }
                    else
                    {
                        ThePlayerLost();
                    }
                    break;
                case 2:
                    if (wa.BallFalls >= 19)
                    {
                        ThePlayer.Money += ((ThePlayer.Wager * 2) - ThePlayer.Wager);
                        Console.WriteLine($"You won ${ThePlayer.Wager * 2}!");
                        Console.WriteLine("Press enter...");
                    }
                    else
                    {
                        ThePlayerLost();
                    }
                    break;

            }
        }
        //Checks if the color is red or black
        public void RedBlack(int choice, string resultC)
        {
            if (choice == 1 && resultC == "Red") // defines which answer is right for the 50/50 chance of correct color
            {
                ThePlayer.Money += ((ThePlayer.Wager * 2) - ThePlayer.Wager);
                Console.WriteLine($"You won ${ThePlayer.Wager * 2}!");
                Console.WriteLine("Press enter...");
            }
            else if (choice == 2 && resultC == "Black")
            {
                ThePlayer.Money += ((ThePlayer.Wager * 2) - ThePlayer.Wager);
                Console.WriteLine($"You won ${ThePlayer.Wager * 2}!");
                Console.WriteLine("Press enter...");
            }
            else
            {
                ThePlayerLost();
            }

        }
        //checks if the ball landed in an even or odd bin
        public void EvenOdd(int evenOdd)
        {
            PickBet bc = new PickBet();
            switch (evenOdd)
            {
                case 1:
                    if (wa.BallFalls % 2 == 0)//%2 is the remainder if divisible by in this case 2
                    {
                        ThePlayer.Money += ((ThePlayer.Wager * 2) - ThePlayer.Wager);
                        Console.WriteLine($"You won ${ThePlayer.Wager * 2}!");
                        Console.WriteLine("Press enter...");
                    }
                    else
                    {
                        ThePlayerLost();
                    }
                    break;
                case 2:
                    if (wa.BallFalls % 2 != 0) //%2 is the remainder if divisible by in this case 2
                    {
                        ThePlayer.Money += ((ThePlayer.Wager * 2) - ThePlayer.Wager);
                        Console.WriteLine($"You won ${ThePlayer.Wager * 2}!");
                        Console.WriteLine("Press enter...");
                    }
                    else
                    {
                        ThePlayerLost();
                    }
                    break;
            }
        }
        //This method occurs every time the ThePlayer loses, it takes out the Wagered amount from the ThePlayer's
        //Money and checks if they have enough Money to keep playing.
        public void ThePlayerLost()
        {
            ThePlayer p = new ThePlayer();
            ThePlayer.Money -= ThePlayer.Wager; //the new money amount =money amount-money lost
            Console.WriteLine($"You lost, you now have ${ThePlayer.Money} left.");
            Console.WriteLine("Press enter...");
            if (ThePlayer.Money <= 0) //if statement to control if user can keep playing with funds
            {
                Console.WriteLine("No cash!\nTry again...");
                Console.ReadLine();
                p.StartGame();
            }
        }
        //number bet, checks if the specific number the ThePlayer is betting on gets called
        public void Number()
        {
            ThePlayer p = new ThePlayer();
            PickBet b = new PickBet();
            if (b.binChoice == wa.BallFalls) //this by some real luck the ball lands in the bin, user bet multipled by 35
            {
                ThePlayer.Money += (ThePlayer.Wager * 35);
                Console.WriteLine($"You won ${ThePlayer.Wager * 35}!");
            }
            else
            {
                ThePlayerLost();
            }

        }
        //validates the ThePlayers choice in the number bet, I only use this method once, it was 
        //practice to pass values around. 
        public int NumCheck()
        {
            int binChoice;
            do
            {
                string choice = (Console.ReadLine().ToString().ToLower());
                if (choice == "0")
                {
                    binChoice = 1;
                }
                else if (choice == "00")
                {
                    binChoice = 2;
                }
                binChoice = Convert.ToInt32(choice);
                binChoice++;
            } while (binChoice < 1 || binChoice > 38);

            return binChoice;
        }

    }
}
