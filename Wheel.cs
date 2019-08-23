using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    public class Wheel
    {
        public int BallFalls { get; set; }

        public int GetBallLocation(int[] wheel)
        {
            int locate; //Looking for where the ball ends up - I called it location
            Random random = new Random();
            BallFalls = random.Next(0, 37); //ball falls in a random spot between 0 and 37
            if (BallFalls == 0) //if location is 0
            {
                locate = wheel[BallFalls];
            }
            else
            {
                locate = wheel[BallFalls - 1];
            }
            return locate;
        }
        public string GetBallColor(string[] color)
        {
            string resultC;
            if (BallFalls == 0)
            {
                resultC = color[BallFalls];
            }
            else
            {
                resultC = color[BallFalls - 1];
            }
            return resultC;
        }
        //This method takes an array and checks if the bin that the ball fell into is within the array
        //that is being checked. 
        public bool InColumn(int[] column)
        {
            for (int i = 0; i < column.Length - 1; i++)
            {
                if (column[i] == BallFalls)
                {
                    return true;
                }
            }
            return false;
        }
        
        public string[] color = new string[38]
          { "green", "green", "Red", "Black", "Red", "Black", "Red", "Black", "Red", "Black", "Red", "Black", "Black",
            "Red", "Black", "Red", "Black", "Red", "Black", "Red", "Red", "Black","Red", "Black", "Red", "Black", "Red",
            "Black", "Red", "Black", "Black", "Red", "Black", "Red", "Black", "Red", "Black", "Red",                    };
        //all possible values
        public int[] wheelAll = new int[38]
          { 0, 00, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36};


        public int[] column1 = new int[12] { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };
        public int[] column2 = new int[12] { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
        public int[] column3 = new int[12] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };

        public int[] street1 = new int[3] { 1, 2, 3 };
        public int[] street2 = new int[3] { 4, 5, 6 };
        public int[] street3 = new int[3] { 7, 8, 9 };
        public int[] street4 = new int[3] { 10, 11, 12 };
        public int[] street5 = new int[3] { 13, 14, 15 };
        public int[] street6 = new int[3] { 16, 17, 18 };
        public int[] street7 = new int[3] { 19, 20, 21 };
        public int[] street8 = new int[3] { 22, 23, 24 };
        public int[] street9 = new int[3] { 25, 26, 27 };
        public int[] street10 = new int[3] { 28, 29, 30 };
        public int[] street11 = new int[3] { 31, 32, 33 };
        public int[] street12 = new int[3] { 34, 35, 36 };

    }
}
