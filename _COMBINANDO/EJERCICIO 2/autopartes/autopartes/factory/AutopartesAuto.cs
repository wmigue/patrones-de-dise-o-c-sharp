using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using autopartes;

namespace autopartes.factory
{
    class AutopartesAuto
    {
        public IParte Fabricar(int opcion)
        {
            if (opcion == 1)
                return new Chasis(2, 4);
            else if (opcion == 2)
                return new Motor(2);
            else
                return null;
        }

    }
}