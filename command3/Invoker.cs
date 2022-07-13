using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command3
{
    class Invoker
    {
       private ManejadorComandosVehiculos _comando;

       public void setComando(ManejadorComandosVehiculos ic)
        {
            _comando = ic;
        }
        public void run()
        {
            _comando.getComando();
            _comando.iniciar();
        }
    }
}
