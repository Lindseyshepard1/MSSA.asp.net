using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Roulette
{
    class Program
    {
        static void Main()
        {
            ThePlayer thePlayer = new ThePlayer();
            DisplayMenu displayMenu = new DisplayMenu();
            try
            {
                thePlayer.StartGame();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }
    }
}