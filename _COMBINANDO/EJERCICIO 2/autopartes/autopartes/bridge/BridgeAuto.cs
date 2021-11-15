using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using autopartes.builder;
using autopartes.factory;

namespace autopartes.bridge
{
    class BridgeAuto : IBridge
    {
        BuilderAuto _builder;
        AutopartesAuto _autopartesauto;
        string _chasis;
        string _motor;

        public BridgeAuto()
        {
            _builder = new BuilderAuto();
            _autopartesauto = new AutopartesAuto();
            _chasis = _autopartesauto.Fabricar(1).Caracteristicas();
            _motor = _autopartesauto.Fabricar(2).Caracteristicas();
        }
        public void Construir()
        {
            _builder.agregarPartes(_chasis);
            _builder.agregarPartes(_motor);
            _builder.obtenerVehiculo().getComponentes();
        }


    }
}
