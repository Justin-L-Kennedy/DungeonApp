using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Weapon : Item
    {
        //Fields
        private int _minDamage;
        private int _maxDamage;
        private int _bonusHitChance;

        //Properties
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
        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }
        public int BonusHitChance
        {
            get { return _bonusHitChance; }
            set { _bonusHitChance = value; }
        }

        //Constructors
        public Weapon(int id, string name, string namePlural, int minDamage, int maxDamage, int bonusHitChance) :base(id, name, namePlural)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            BonusHitChance = bonusHitChance;
        }

        //Methods
        public override string ToString()
        {
            return string.Format("{0}\t{1} to {2} Damage\nBonus Hit: {3}%",
                Name,
                MinDamage,
                MaxDamage,
                BonusHitChance);
        }
    }
}
