using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Combat
    {
        public static void DoAttack(Character attacker, Character defender)
        {
            //get a random number from 1-100 as our dice roll
            Random rand = new Random();
            int diceRoll = rand.Next(1, 101);
            System.Threading.Thread.Sleep(30);
            if (diceRoll <= (attacker.CalcHitChance() - defender.CalcBlock())) //how you determine whether the attack is successful
            {
                //the attacker hit
                int damageDealt = attacker.CalcDamage();
                //assign damage
                defender.Life -= damageDealt;
                //write the result out to the screen
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0} hit {1} for {2} damage!", attacker.Name, defender.Name, damageDealt);
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("{0} missed!", attacker.Name);
            }
        }

        public static void DoBattle(Player wizard, Enemy enemy)
        {
            //player attacks first
            DoAttack(wizard, enemy);
            //monster gets to attack next, if they are still alive
            if (enemy.Life > 0)
            {
                DoAttack(enemy, wizard);
            }
        }
    }
}
