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
            Console.Title = "The Deathly Hallows";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to the Wonderful World of Harry Potter!");
            Console.ResetColor();
            Console.WriteLine("You must explore and battle Death Eaters on your journey to discover\nThe Deathly Hallows and destroy Lord Voldemort's Horcruxes.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Your adventure as Harry starts now...\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\"I solemnly swear that I am up to no good.\"\n");
            Console.ResetColor();
            
            #region Theme Song
            Console.Beep(493, 200); //B
            System.Threading.Thread.Sleep(125);
            Console.Beep(659, 300); //E
            System.Threading.Thread.Sleep(125);
            Console.Beep(783, 100); //G
            System.Threading.Thread.Sleep(125);
            Console.Beep(739, 200); //F#
            System.Threading.Thread.Sleep(125);
            Console.Beep(659, 400); //E
            System.Threading.Thread.Sleep(125);
            Console.Beep(987, 200); //B
            System.Threading.Thread.Sleep(125);
            Console.Beep(880, 600); //A
            System.Threading.Thread.Sleep(125);
            Console.Beep(739, 600); //F#
            System.Threading.Thread.Sleep(125);
            Console.Beep(659, 300); //E
            System.Threading.Thread.Sleep(125);
            Console.Beep(783, 100); //G
            System.Threading.Thread.Sleep(125);
            Console.Beep(739, 200); //F#
            System.Threading.Thread.Sleep(125);
            Console.Beep(622, 400); //D#
            System.Threading.Thread.Sleep(125);
            Console.Beep(698, 200); //F
            System.Threading.Thread.Sleep(125);
            Console.Beep(493, 600); //B
            System.Threading.Thread.Sleep(200);
            System.Threading.Thread.Sleep(200);
            Console.Beep(493, 200); //B
            System.Threading.Thread.Sleep(125);
            Console.Beep(659, 300); //E
            System.Threading.Thread.Sleep(125);
            Console.Beep(783, 100); //G
            System.Threading.Thread.Sleep(125);
            Console.Beep(739, 200); //F#
            System.Threading.Thread.Sleep(125);
            Console.Beep(659, 400); //E
            System.Threading.Thread.Sleep(125);
            Console.Beep(987, 200); //B
            System.Threading.Thread.Sleep(125);
            Console.Beep(1174, 400); //D
            System.Threading.Thread.Sleep(125);
            Console.Beep(1108, 200); //Db
            System.Threading.Thread.Sleep(125);
            Console.Beep(1046, 400); //C
            System.Threading.Thread.Sleep(125);
            Console.Beep(830, 200); //Ab
            System.Threading.Thread.Sleep(125);
            Console.Beep(1046, 300); //C
            System.Threading.Thread.Sleep(125);
            Console.Beep(987, 100); //B
            System.Threading.Thread.Sleep(125);
            Console.Beep(932, 200); //A#
            System.Threading.Thread.Sleep(125);
            Console.Beep(466, 400); //A#
            System.Threading.Thread.Sleep(125);
            Console.Beep(783, 200); //G
            System.Threading.Thread.Sleep(125);
            Console.Beep(659, 600); //E
            System.Threading.Thread.Sleep(200);
            System.Threading.Thread.Sleep(200);
            Console.Beep(783, 200); //G
            System.Threading.Thread.Sleep(125);
            Console.Beep(987, 400); //B
            System.Threading.Thread.Sleep(125);
            Console.Beep(783, 200); //G
            System.Threading.Thread.Sleep(125);
            Console.Beep(987, 400); //B
            System.Threading.Thread.Sleep(125);
            Console.Beep(783, 200); //G
            System.Threading.Thread.Sleep(125);
            Console.Beep(1046, 400); //C
            System.Threading.Thread.Sleep(125);
            Console.Beep(987, 200); //B
            System.Threading.Thread.Sleep(125);
            Console.Beep(932, 400); //A#
            System.Threading.Thread.Sleep(125);
            Console.Beep(739, 200); //F#
            System.Threading.Thread.Sleep(125);
            Console.Beep(783, 300); //G
            System.Threading.Thread.Sleep(125);
            Console.Beep(987, 100); //B
            System.Threading.Thread.Sleep(125);
            Console.Beep(932, 200); //A#
            System.Threading.Thread.Sleep(125);
            Console.Beep(466, 400); //A#
            System.Threading.Thread.Sleep(125);
            Console.Beep(493, 200); //B
            System.Threading.Thread.Sleep(125);
            Console.Beep(987, 600); //B
            System.Threading.Thread.Sleep(200);
            System.Threading.Thread.Sleep(200);
            Console.Beep(783, 200); //G
            System.Threading.Thread.Sleep(125);
            Console.Beep(987, 400); //B
            System.Threading.Thread.Sleep(125);
            Console.Beep(783, 200); //G
            System.Threading.Thread.Sleep(125);
            Console.Beep(987, 400); //B
            System.Threading.Thread.Sleep(125);
            Console.Beep(783, 200); //G
            System.Threading.Thread.Sleep(125);
            Console.Beep(1174, 400); //D
            System.Threading.Thread.Sleep(125);
            Console.Beep(1108, 200); //Db
            System.Threading.Thread.Sleep(125);
            Console.Beep(1046, 400); //C
            System.Threading.Thread.Sleep(125);
            Console.Beep(830, 200); //Ab
            System.Threading.Thread.Sleep(125);
            Console.Beep(1046, 300); //C
            System.Threading.Thread.Sleep(125);
            Console.Beep(987, 100); //B
            System.Threading.Thread.Sleep(125);
            Console.Beep(932, 200); //A#
            System.Threading.Thread.Sleep(125);
            Console.Beep(932, 400); //A#
            System.Threading.Thread.Sleep(125);
            Console.Beep(783, 200); //G
            System.Threading.Thread.Sleep(125);
            Console.Beep(659, 1200); //E
            System.Threading.Thread.Sleep(125);

            #endregion
            
            int score = 0;

            // 1. Create a weapon
            Weapon wand = World.ItemByID(World.ITEM_ID_WAND) as Weapon;
            //TODO 2. Create a player
            Player wizard = new Player("Harry Potter", 50, 5, 50, 50, 0, House.Gryffindor, wand);
            //3. Create a loop for the room and enemy
            #region Room & Enemy Loop
            bool exit = false;
            do
            {
                //4. Create a room
                //Console.WriteLine(GetRoom());
                Location start = World.LocationByID(World.LOCATION_ID_HOME);
                
                Console.WriteLine(start.Description);

                //TODO 5. Create an enemy
                //Enemy enemy = new Enemy(1, "Rat", 20, 20, 5, 5, "Rat", 3, 1, 5);
                Random rand = new Random();
                int randNbr = rand.Next(World.Enemies.Count);
                Enemy enemy = World.Enemies[randNbr];
                Console.WriteLine("\nIn this room: " + enemy.Name + "\n");
                //6. Create a loop for the menu
                #region Menu Loop
                bool reload = false;
                do
                {
                    //7. Create a menu
                    #region Menu Switch
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Please choose an action:");
                    Console.ResetColor();
                    Console.WriteLine("A) Attack\nR) Run Away\nW) Wizard Info\nD) Death Eater Info\nX) Exit");
                    Console.ResetColor();
                    //8. Catch the user choice
                    ConsoleKey userChoice = Console.ReadKey(true).Key;
                    //9. Clear the console
                    Console.Clear();
                    //TODO 10. Build out the switch for user choice
                    switch (userChoice)
                    {
                        case ConsoleKey.A:
                            //TODO 11. Handle an attack sequence
                            //if (wizard.PlayerHouse == House.Gryffindor)
                            //{
                            //    Combat.DoAttack(wizard, enemy);
                            //}
                            Combat.DoBattle(wizard, enemy);
                            Console.WriteLine();
                            //12. Handle if the player wins
                            if (enemy.Life <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You defeated {0}!\n", enemy.Name);
                                wizard.AddExperiencePoints(enemy.RewardExperiencePoints);
                                Console.WriteLine("You earned {0} Experience Points!\n", enemy.RewardExperiencePoints);
                                Console.ResetColor();
                                reload = true;
                                score++;
                            }
                            break;
                        case ConsoleKey.R:
                            Console.WriteLine("RUN AWAY!!!");
                            //13. Handle Enemy getting a free attack
                            Console.WriteLine($"{enemy.Name} attacks as you flee!");
                            Combat.DoAttack(enemy, wizard); //free attack
                            Console.WriteLine();
                            //14. Handle exiting the inner loop and getting a new room
                            reload = true; //exiting the inner loop and will get a new room and monster
                            break;
                        case ConsoleKey.W:
                            //15. Print out player info
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Wizard Info");
                            Console.ResetColor();
                            Console.WriteLine(wizard);
                            Console.WriteLine("Death Eaters Defeated: " + score + "\n");
                            break;
                        case ConsoleKey.D:
                            //16. Print out enemy info
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Death Eater Info");
                            Console.ResetColor();
                            Console.WriteLine(enemy);
                            break;
                        case ConsoleKey.X:
                        case ConsoleKey.E:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("\"Mischief Managed!\"\n");
                            Console.Beep();
                            Console.ResetColor();
                            //Handle exiting both loops
                            exit = true;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("\"Oh, honestly, don't you read?\" Try again.\n");
                            Console.ResetColor();
                            break;
                    }
                    #endregion
                    //17. Check the player's life before continuing
                    if (wizard.Life <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\"After all, to the well-organized mind, death is but the next great adventure.\"\a");
                        Console.ResetColor();
                        exit = true; //break out of both loops
                    }
                } while (!exit && !reload);
                #endregion
            } while (!exit);
            #endregion
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You defeated " + score + " Death Eater" + ((score == 1) ? "." : "s."));
            Console.ResetColor();
            Console.WriteLine();
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
