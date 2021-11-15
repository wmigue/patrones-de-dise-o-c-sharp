using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using autopartes.factory;

namespace autopartes.builder
{
    class BuilderCamion:IBuilder
    {
        IVehiculo _camion;
        AutopartesCamion _autopartescamion;
        string _chasis;
        string _motor;
        public BuilderCamion()
        {
            _camion = new Camion();
            _autopartescamion = new AutopartesCamion();
            string _chasis = _autopartescamion.Fabricar(1).Caracteristicas();
            string _motor = _autopartescamion.Fabricar(2).Caracteristicas();
        }
        public void agregarPartes(string parte)
        {
            _camion.setComponentes(parte);
            
        }
        public IVehiculo obtenerVehiculo()
        {
            return _camion;
        }

    }
}
