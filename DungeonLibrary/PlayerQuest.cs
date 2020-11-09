using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class PlayerQuest
    {
        //Properties
        public Quest Details { get; set; }
        public bool IsCompleted { get; set; }

        //Constructors
        public PlayerQuest(Quest details)
        {
            Details = details;
            IsCompleted = false;
        }
    }
}
