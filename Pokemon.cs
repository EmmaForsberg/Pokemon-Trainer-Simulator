namespace Pokémon_Trainer_Simulator
{
    abstract class Pokemon
    {
        private string _name;
        private int _level;
        public ElementType Type { get; set; }
        public List<Attack> Attacks { get; private set; }

        public string Name
        {
            get { return _name; }
            set
            {
                //name ska vara mellan 2- 15 characters
                if (value.Length < 2 || _name.Length > 16)
                {
                    Console.WriteLine("Name must be between 2 - 15 characters long");
                }
                else
                {
                    _name = value;
                }
            }
        }

        public int Level
        {
            get { return _level; }
            set
            {
                if (value > 1)
                {
                    _level = value;
                }
            }
        }


        //A List<Attack> field called Attacks, which should be passed in and set via the constructor. This list will represent the attacks that a Pokémon knows
        protected Pokemon(List<Attack> Attacks)
        {
            this.Attacks = Attacks;
        }

        public void RandomAttack()
        {
            // Picks a random attack from the list of attacks and invokes its .Use-method.
        }

        public void Attack()
        {
            // Lets the user pick an attack from the list of attacks and invoke its .Use-method.
        }

        public void RaiseLevel()
        {
            // That should increment the level of the given pokemon and print that the pokemon has leveled up.
        }
    }
}


