using System;

namespace Lab03WordGuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
        }

        /// <summary>
        /// This is where I create the menu for choosing whether to play, administrate, or exit.
        /// </summary>
        static bool MainMenu()
        {
            try
            {
                string gameMessage = "Play the game";
                Console.Clear();
                Console.WriteLine("Please Choose an option");
                Console.WriteLine($"1) {gameMessage}");
                Console.WriteLine("2) Administrative");
                Console.WriteLine("3) Exit");
                string result = Console.ReadLine();
                if (result == "1")
                {
                    gameMessage = "Play the game, again.";


                }
                return true;
            }
            catch (Exception e)
            {

                throw;
            }
            finally
            {

            }
        }

    }
}
