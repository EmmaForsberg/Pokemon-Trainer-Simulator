using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokémon_Trainer_Simulator
{
    internal class Attack
    {

        public string Name { get; set; }
        public ElementType Type { get; set; }
        public int BasePower { get; set; }

        public Attack(string Name, ElementType Type, int BasePower)
        {
            this.Name = Name;
            this.Type = Type;
            this.BasePower = BasePower;

        }
        //Metod
        // Return string: Flamethrower hits with total power 22!
        // Where 22 is BasePower + level.
        public string Use(int level)
        {
            return $"{Type} hits with total power {BasePower + level}";
        }

    }
}
