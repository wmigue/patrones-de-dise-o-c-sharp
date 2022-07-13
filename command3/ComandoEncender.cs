using System;

namespace command3
{
    class ComandoEncender:IComando
    {
        private IVehiculo _vehiculo;

        public ComandoEncender(IVehiculo m)
        {
            _vehiculo = m;
        }
        public void ejecutar()
        {
            _vehiculo.encender();
        }
        
    }
}
