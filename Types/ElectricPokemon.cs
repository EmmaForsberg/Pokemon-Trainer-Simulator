using Pokémon_Trainer_Simulator.UI;

namespace Pokémon_Trainer_Simulator.Pokemon.Elektric
{
    internal class ElectricPokemon : PokemonBase
    {
        public ElectricPokemon(string name, int level, List<Attack> attacks, IUI ui ) : base(name, level, attacks, ui)
        {
            Type = ElementType.Electric;
        }
    }
}