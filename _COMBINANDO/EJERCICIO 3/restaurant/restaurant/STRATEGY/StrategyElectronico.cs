using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using restaurant.COMMAND;

namespace restaurant.STRATEGY
{
    class StrategyElectronico:IOperacion
    {
        double _monto;

        public StrategyElectronico(double m)
        {
            _monto = m;

        }
        public void Estrategia()
        {
            Receiver _receiver = new Receiver(_monto * 1.07);
            Invoker invoker = new Invoker(_receiver);
            invoker.Boton(1);
       

        }
    }
}
