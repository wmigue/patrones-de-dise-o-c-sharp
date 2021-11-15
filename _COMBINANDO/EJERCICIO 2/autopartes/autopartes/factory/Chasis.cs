using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autopartes.factory
{
    class Chasis:IParte
    {
        int _vehiculo;
        int _ejes;
        public Chasis(int vehiculo, int ejes)
        {
            _vehiculo=vehiculo;
            _ejes = ejes;
        }
        
        public string Caracteristicas()
        {
            if(_vehiculo==1)
               return $"chasis camion, con {_ejes} ejes";
            else
                return $"chasis auto, con {_ejes} ejes";
        }
    }
}
