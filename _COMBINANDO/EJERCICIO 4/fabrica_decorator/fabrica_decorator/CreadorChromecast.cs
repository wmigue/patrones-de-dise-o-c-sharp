using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabrica_decorator
{
    class CreadorChromeCast
    {
        public IComponente Fabricar(int opcion)
        {
            if (opcion == 1)
                return new Chromecast();
            else
                return null;
        }

    }
}
