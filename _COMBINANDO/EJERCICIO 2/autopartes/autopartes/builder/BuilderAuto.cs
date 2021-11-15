using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using autopartes.factory;

namespace autopartes.builder
{
    class BuilderAuto:IBuilder
    {
        IVehiculo _auto;
       
        public BuilderAuto()
        {
            _auto = new Auto();

        }
        public void agregarPartes(string parte)
        {
            _auto.setComponentes(parte);
         
        }
        public IVehiculo obtenerVehiculo()
        {
            return _auto;
        }
    }
}
