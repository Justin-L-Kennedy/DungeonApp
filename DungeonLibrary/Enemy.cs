using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Enemy : Character
    {
        //fields
        private int _minDamage;

        //properties
        public int ID { get; set; }
        public int MaxDamage { get; set; }
        public string Description { get; set; }
        public int RewardExperiencePoints { get; set; }
        public List<LootItem> LootTable { get; set; }
        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (value > 0 && value <= MaxDamage)
                {
                    _minDamage = value;
                }
                else
                {
                    _minDamage = 1;
                }
            }
        }

        //constructors
        public Enemy(int id, string name, int hitChance, int block, int life, int maxLife, string description, int rewardExperiencePoints, int minDamage, int maxDamage)
        {
            ID = id;
            MaxLife = maxLife;
            Name = name;
            HitChance = hitChance;
            Block = block;
            Life = life;
            MaxDamage = maxDamage;
            Description = description;
            RewardExperiencePoints = rewardExperiencePoints;
            LootTable = new List<LootItem>();
            MinDamage = minDamage;
        }
        public Enemy() { }

        //methods
        public override string ToString()
        {
            return string.Format("\n*****  DEATH EATER  *****\n{0}\nLife: {1} of {2}\nDamage: {3} to {4}\nBlock: {5}\nDescription:\n{6}\n",
                Name,
                Life,
                MaxLife,
                MinDamage,
                MaxDamage,
                Block,
                Description);
        }
        public override int CalcDamage()
        {
            Random rand = new Random();
            return rand.Next(MinDamage, MaxDamage + 1);
        }
    }
}
