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
        public int ExperiencePoints { get; private set; }
        public int Level
        {
            get { return ((ExperiencePoints / 100) + 1); }
        }
        public House PlayerHouse { get; set; }
        public Weapon PlayerWeapon { get; set; }
        public Location CurrentLocation { get; set; }
        public Weapon CurrentWeapon { get; set; }
        public List<InventoryItem> Inventory { get; set; }
        public List<PlayerQuest> Quests { get; set; }

        //constructors
        public Player(string name, int hitChance, int block, int life, int maxLife, int experiencePoints, House playerHouse, Weapon playerWeapon)
        {
            MaxLife = maxLife;
            Name = name;
            HitChance = hitChance;
            Block = block;
            Life = life;
            ExperiencePoints = experiencePoints;
            PlayerHouse = playerHouse;
            PlayerWeapon = playerWeapon;
            Inventory = new List<InventoryItem>();
            Quests = new List<PlayerQuest>();

            switch (playerHouse)
            {
                case House.Gryffindor:
                    HitChance += 5;
                    break;
                case House.Hufflepuff:
                    HitChance -= 3;
                    break;
                case House.Ravenclaw:
                    break;
                case House.Slytherin:
                    HitChance += 3;
                    break;
                default:
                    break;
            }
        }

        //methods
        public override string ToString()
        {
            string description = "";
            switch (PlayerHouse)
            {
                case House.Gryffindor:
                    description = "Gryffindor";
                    break;
                case House.Hufflepuff:
                    description = "Hufflepuff";
                    break;
                case House.Ravenclaw:
                    description = "Ravenclaw";
                    break;
                case House.Slytherin:
                    description = "Slytherin";
                    break;
                default:
                    break;
            }

            return string.Format("\n*****  {0}  *****\nLife: {1} of {2}\nXP: {3}\nLevel: {4}\nHit Chance: {5}%\nWeapon:\n{6}\nBlock: {7}\nDescription: {8}",
                Name,
                Life,
                MaxLife,
                ExperiencePoints,
                Level,
                CalcHitChance(),
                PlayerWeapon,
                Block,
                description);

        }

        public void AddExperiencePoints(int experiencePointsToAdd)
        {
            ExperiencePoints += experiencePointsToAdd;
            PlayerWeapon.MaxDamage = (Level * 10);
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
