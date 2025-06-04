using Pokémon_Trainer_Simulator.UI;

namespace Pokémon_Trainer_Simulator.Pokemon
{
    internal class Main
    {
        private List<PokemonBase> _pokemons;
        private IUI _ui;

        public Main(List<PokemonBase> pokemons, IUI ui)
        {
            _pokemons = pokemons;
            _ui = ui;
        }
        public void Run()
        {
            foreach (var pokemon in _pokemons)
            {
                pokemon.RandomAttack();
            }

            _ui.Print();

            foreach (var pokemon in _pokemons)
            {
                if (pokemon is IEvolvable evolvable)
                {
                    evolvable.Evolve();
                }
                else
                {
                    _ui.Print($"{pokemon.Name} is not evolable");
                }
            }

            _ui.Print();

            foreach (var pokemon in _pokemons)
            {
                pokemon.Attack();
            }

        }
    }
}
