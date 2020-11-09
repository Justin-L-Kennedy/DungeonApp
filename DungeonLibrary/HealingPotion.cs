using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class HealingPotion : Item
    {
        //Fields

        //Properties
        public int AmountToHeal { get; set; }

        //Constructors
        public HealingPotion(int id, string name, string namePlural, int amountToHeal) :base(id, name, namePlural)
        {
            AmountToHeal = amountToHeal;
        }

        //Methods
        public override string ToString()
        {
            return string.Format("{0}\nHealing Amount: {1}",
                Name,
                AmountToHeal);
        }
    }
}
