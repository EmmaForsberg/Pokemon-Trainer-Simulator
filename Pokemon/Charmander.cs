
using Pokémon_Trainer_Simulator.UI;


namespace Pokémon_Trainer_Simulator.Pokemon.Fire
{
    internal class Charmander : FirePokemon, IEvolvable
    {
        public Charmander(List<Attack> Attacks, IUI ui) : base("Charmander", 4, Attacks, ui)
        {      
        }

        public void Evolve()
        {
            var oldname = Name;
            Name = "Charmeleeon";
            Level += 10;

            Console.WriteLine($"{oldname} is  evolving... Now it´s {Name}! Level {Level}" );
        }
    }
}
