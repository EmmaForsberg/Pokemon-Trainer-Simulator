using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokémon_Trainer_Simulator
{
    abstract class Pokemon
    {
        public string Name { get; set; }
        // Level
        // Type
        // Attack

        //abstract metod
        public abstract string Attack();

        //A non-overridable instance method:
        //public void RaiseLevel()
        //This should increment the level and print:
        //{Name} leveled up to {Level}
    }
}


