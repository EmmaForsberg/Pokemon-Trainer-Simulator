using Pokémon_Trainer_Simulator.UI;

namespace Pokémon_Trainer_Simulator.Pokemon.Water
{
    internal class WaterPokemon : PokemonBase
    {
        public WaterPokemon(string name, int level, List<Attack> attacks, IUI ui) : base(name, level, attacks, ui)
        {
            Type = ElementType.Water;
        }
    }
}
