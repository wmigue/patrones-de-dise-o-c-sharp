﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
class AmericaFactory:ContinentFactory
  {
    public override Herbivore CreateHerbivore()
    {
        return new Bison();
    }

    public override Carnivore CreateCarnivore()
    {
        return new Lion();
    }
}
}
