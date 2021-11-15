using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autopartes.builder
{
    interface IBuilder

    {
        void agregarPartes(string parte);
        IVehiculo obtenerVehiculo();
    }
}
