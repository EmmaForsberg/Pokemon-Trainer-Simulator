using Pokémon_Trainer_Simulator.UI;

namespace Pokémon_Trainer_Simulator.Pokemon
{
    abstract class PokemonBase
    {
        private string _name = string.Empty;
        private int _level;
        protected IUI _ui;
        Random random = new Random();
        public ElementType Type { get; protected set; }
        public List<Attack> Attacks { get; private set; }

        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length < 2 || value.Length > 15 || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name must be between 2 - 15 characters long");
                }
                _name = value;
            }
        }

        public int Level
        {
            get { return _level; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Level must be 1 or greater.");
                }
                _level = value;
            }
        }

        protected PokemonBase(string name, int level, List<Attack> attacks, IUI ui)
        {
            Name = name;
            Level = level;
            Attacks = attacks;
            _ui = ui;
        }

        public void RandomAttack()
        {
            if (Attacks.Count == 0)
            {
                _ui.Print($"{Name} doesnt have any attacks.");
            }

            var randomnumber = random.Next(Attacks.Count);

            int choice = randomnumber;
            _ui.Print(Attacks[choice].Use(Level));
        }

        public void Attack()
        {
            bool isvalid = false;
            while (!isvalid)
            {
                _ui.Print($"{Name} is level {Level} and can perform this attacks:");
                for (int i = 0; i < Attacks.Count; i++)
                {
                    _ui.Print($"{i + 1}: {Attacks[i].Name}");
                }

                _ui.Print("Choose an attack by number: ");
                string input = _ui.GetInput();

                if (int.TryParse(input, out int choice) && choice <= Attacks.Count)
                {
                    _ui.Print(Attacks[choice - 1].Use(Level));
                    isvalid = true;
                }
                else
                {
                    _ui.Print("Invalid choice, try again");
                    isvalid = false;
                }
            }
        }

        public void RaiseLevel()
        {
            Level++;
            _ui.Print($"{Name} has reached {Level}");
        }
    }
}


