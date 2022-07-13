using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command3
{
    class ManejadorComandosVehiculos
    {
        private int _opcion;
        private IVehiculo _vehiculo;
        IComando _comando;
        public void setAccion(int o)
        {
            _opcion = o;
        }
        public void setVehiculo(IVehiculo v)
        {
            _vehiculo = v;
        }

        public void getComando()
        {
            if (_opcion == 1)
            {
               _comando= new ComandoEncender(_vehiculo);
            }
            if (_opcion == 0)
            {
                _comando = new ComandoApagar(_vehiculo);
            }
        }
        public void iniciar()
        {
            _comando.ejecutar();
        }
    

    }
}
