using Pokémon_Trainer_Simulator.Pokemon.Elektric;
using Pokémon_Trainer_Simulator.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokémon_Trainer_Simulator.Pokemon
{
    internal class Pikachu : ElectricPokemon
    {
        public Pikachu( List<Attack> Attacks, IUI ui) : base("Pikachu",52, Attacks, ui)
        {      
        }
    }
}
