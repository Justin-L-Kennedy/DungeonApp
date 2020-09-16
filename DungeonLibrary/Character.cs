using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public abstract class Character
    {
        //fields
        private int _life;

        //properties
        public string Name { get; set; }
        public int HitChance { get; set; }
        public int Block { get; set; }
        public int MaxLife { get; set; }
        public int Life
        {
            get { return _life; }
            set
            {
                if (value <= MaxLife)
                {
                    _life = value;
                }
                else
                {
                    _life = MaxLife;
                }
            }
        }

        //constructors
        //Since we do NOT inherit ctors, we will not create any here. We will still get the default, parameterless constructor
        //However, because this class is abstract, we will NOT be able to create an instance of Character

        //methods
        //Since we are NOT creating an instance of Character, we will not need to override the ToString()
        //Below we will define methods that we want to be inherited by player and monster, so we are creating default versions of each method here
        //The child classes will either use this default functionality or override it to create custom functionality
        public virtual int CalcBlock()
        {
            //To be able to override this in a child class, we MUST make it virtual
            //This basic version will just return the Block property. Child classes will modify
            return Block;
        }
        public virtual int CalcHitChance()
        {
            return HitChance;
        }
        public virtual int CalcDamage()
        {
            //This functionality will be customized in Child classes
            return 0;
        }

    }
}
