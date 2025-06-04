using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokémon_Trainer_Simulator
{
    internal static class AttackLibrary
    {
       public static Attack Flamethrower => new Attack("Flamethrower", ElementType.Fire, 12);
        public static Attack Ember => new Attack("Ember", ElementType.Fire, 6);
        public static Attack Raindance => new Attack("Rain Dance", ElementType.Water, 50);
        public static Attack Bubble => new Attack("Bubble", ElementType.Water, 20);
        public static Attack Nuzzle => new Attack("Nuzzle", ElementType.Electric, 20);
    }
}
