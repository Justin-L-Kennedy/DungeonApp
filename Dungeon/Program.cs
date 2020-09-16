using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace Dungeon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "GAMBIT";
            Console.WriteLine("And so it begins...");

            int score = 0;

            //TODO 1. Create a weapon
            //TODO 2. Create a player

            //3. Create a loop for the room and monster
            #region Room & Monster Loop
            bool exit = false;
            do
            {
                //4. Create a room
                Console.WriteLine(GetRoom());

                //TODO 5. Create a monster

                //6. Create a loop for the menu
                #region Menu Loop
                bool reload = false;
                do
                {
                    //7. Create a menu
                    #region Menu Switch
                    Console.WriteLine("Please choose an action:\nX) Exit\n");
                    //8. Catch the user choice
                    ConsoleKey userChoice = Console.ReadKey(true).Key;
                    //9. Clear the console
                    Console.Clear();
                    //TODO 10. Build out the switch for user choice
                    switch (userChoice)
                    {
                        //TODO 11. Handle an attack sequence
                        //TODO 12. Handle if the player wins
                        //TODO 13. Handle Monster getting a free attack
                        //TODO 14. Handle exiting the inner loop and getting a new room
                        //TODO 15. Print out player info
                        //TODO 16. Print out monster info
                        default:
                            break;
                    }
                    #endregion
                    //TODO 17. Check the player's life before continuing
                } while (!exit && !reload);
                #endregion
            } while (!exit);
            #endregion
        }

        private static string GetRoom()
        {
            string[] rooms =
            {
            };
            int indexNbr = -1;
            string room = rooms[indexNbr + 1];
            return room;
        }
    }
}
