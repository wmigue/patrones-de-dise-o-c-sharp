using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabrica_decorator
{
    class CreadorTV
    {
        public CreadorTV(){}
        public IComponente Fabricar(int opcion)
        {
            if (opcion == 1)
                return new TVcomun();
            else if (opcion == 2)
                return new TVsmart();
            else
                return null;
        }

    }
}
