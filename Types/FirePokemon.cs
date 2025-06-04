using Pokémon_Trainer_Simulator.UI;


namespace Pokémon_Trainer_Simulator.Pokemon.Fire
{
    internal class FirePokemon : PokemonBase
    {
        public FirePokemon(string name, int level, List<Attack> attacks, IUI ui) : base(name, level, attacks, ui)
        {
            Type = ElementType.Fire;
        }
    }
}
