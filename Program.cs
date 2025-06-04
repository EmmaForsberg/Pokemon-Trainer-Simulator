using Pokémon_Trainer_Simulator.Pokemon.Fire;
using Pokémon_Trainer_Simulator.Pokemon.Water;
using Pokémon_Trainer_Simulator.UI;
namespace Pokémon_Trainer_Simulator.Pokemon
{
    namespace Pokémon_Trainer_Simulator
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                IUI ui = new ConsoleUI();
                List<PokemonBase> pokemons = new List<PokemonBase>
                {
                    new Charmander(new List<Attack> {AttackLibrary.Flamethrower, AttackLibrary.Ember },ui),
                    new Squirtle(new List<Attack> {AttackLibrary.Raindance}, ui),
                    new Pikachu(new List<Attack> { AttackLibrary.Nuzzle }, ui)
                };
                Main main = new Main(pokemons,ui);
                main.Run();
            }
        }
    }
}
