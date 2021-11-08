using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decorator
{
    class Guitarra:IGuitarra
    {
        private string _marca;
        private double _costo;
        private string _caracteristicas;
        public Guitarra(string marca, string caracteristicas, double costo)
        {
            _marca = marca;
            _costo = costo;
            _caracteristicas = caracteristicas;
        }
        public string marcaCaracteristicas() {
            return _marca + ", " + _caracteristicas;
        }
        public double Costo()
        {
            return _costo;
        }
        public string Caracteristicas()
        {
            return _caracteristicas;
        }
    }
}
