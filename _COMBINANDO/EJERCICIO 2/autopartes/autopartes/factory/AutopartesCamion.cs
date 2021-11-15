using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using autopartes;

namespace autopartes.factory
{
    class AutopartesCamion
    {
        public IParte Fabricar(int opcion)
        {
            if (opcion == 1)
                return new Chasis(1, 8);
            else if (opcion == 2)
                return new Motor(1);
            else
                return null;
        }

    }
}