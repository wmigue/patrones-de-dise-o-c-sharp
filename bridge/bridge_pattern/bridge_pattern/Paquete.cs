using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge_pattern
{
    class Paquete
    {
       private string _paquete;
       public Paquete(string nombre)
        {
            _paquete = nombre;
        }
        public string Nombrar()
        {
            return _paquete;
        }
    }
}
