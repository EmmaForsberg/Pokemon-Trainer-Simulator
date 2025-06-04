using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokémon_Trainer_Simulator.UI
{
    internal class ConsoleUI : IUI
    {
        public string GetInput()
        {
            return Console.ReadLine() ?? string.Empty;
        }

        public void Print(string message)
        {
            Console.WriteLine(message);
        }

        public void Print()
        {
            Console.WriteLine();
        }
    }
}
