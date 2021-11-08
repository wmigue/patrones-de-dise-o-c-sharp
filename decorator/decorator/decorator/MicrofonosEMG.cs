using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decorator
{
    class MicrofonosEMG:IGuitarra
    {
       private double _costo = 1000;
       private IGuitarra _guitarra;
        public MicrofonosEMG(IGuitarra g)
        {
            _guitarra = g;
        }
        public double Costo()
        {
            return _guitarra.Costo() + _costo;
        }
        public string Caracteristicas()
        {
            return _guitarra.Caracteristicas() + ",con micrófonos EMG";
        }
    }
}
