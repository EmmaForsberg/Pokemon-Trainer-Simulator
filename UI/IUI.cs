﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokémon_Trainer_Simulator.UI
{
    internal interface IUI
    {
        string GetInput();
        void Print(string message);
        void Print();
    }
}
