using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class InventoryItem
    {
        //Properties
        public Item Details { get; set; }
        public int Quantity { get; set; }

        //Constructors
        public InventoryItem(Item details, int quantity)
        {
            Details = details;
            Quantity = quantity;
        }
    }
}
