using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public sealed class Player : Character
    {
        //fields

        //properties
        public Type PlayerType { get; set; }
        public Weapon PlayerWeapon { get; set; }

        //constructors
        public Player(string name, int hitChance, int block, int life, int maxLife, Type playerType, Weapon playerWeapon)
        {
            MaxLife = maxLife;
            Name = name;
            HitChance = hitChance;
            Block = block;
            Life = life;
            PlayerType = playerType;
            PlayerWeapon = playerWeapon;

            switch (PlayerType)
            {
                default:
                    break;
            }
        }

        //methods
        public override string ToString()
        {
            string description = "";
            switch (PlayerType)
            {
                default:
                    break;
            }

            return string.Format("*****  {0}  *****\nLife: {1} of {2}\nHit Chance: {3}%\nWeapon:\n{4}\nBlock: {5}\nDescription: {6}",
                Name,
                Life,
                MaxLife,
                CalcHitChance(),
                PlayerWeapon,
                Block,
                description);

        }

        public override int CalcDamage()
        {
            //return base.CalcDamage(); we don't want to return 0
            //create a random object
            Random rand = new Random();
            //determine the damage
            int damage = rand.Next(PlayerWeapon.MinDamage, PlayerWeapon.MaxDamage + 1);
            //return the damage
            return damage;
            //OR could be written as below
            //return new Random().Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
        }

        public override int CalcHitChance()
        {
            return base.CalcHitChance() + PlayerWeapon.BonusHitChance;
        }
    }
}
