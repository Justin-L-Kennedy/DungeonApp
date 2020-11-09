using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class QuestCompletionItem
    {
        //Properties
        public Item Details { get; set; }
        public int Quantity { get; set; }

        //Constructors
        public QuestCompletionItem(Item details, int quantity)
        {
            Details = details;
            Quantity = quantity;
        }
    }
}
