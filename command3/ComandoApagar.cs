using System;

namespace command3
{
    class ComandoApagar:IComando
    {
        private IVehiculo _vehiculo;

        public ComandoApagar(IVehiculo m)
        {
            _vehiculo = m;
        }
        public void ejecutar()
        {
            _vehiculo.apagar();
        }
        
    }
}
