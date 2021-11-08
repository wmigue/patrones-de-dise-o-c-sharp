using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decorator
{
    class Cuerdas010 : IGuitarra
    {
        private double _costo = 500;
        private IGuitarra _guitarra;
        public Cuerdas010(IGuitarra g)
        {
            _guitarra = g;
        }
        public double Costo()
        {
            return _guitarra.Costo() + _costo;
        }
        public string Caracteristicas()
        {
            return _guitarra.Caracteristicas() + " + cuerdas gauge 0.10";
        }
    }
}
