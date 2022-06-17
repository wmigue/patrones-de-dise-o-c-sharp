using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Lion : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            // EatWildebeest
            Console.WriteLine(this.GetType().Name + " se morfa al " + h.GetType().Name);
        }

    }
}
