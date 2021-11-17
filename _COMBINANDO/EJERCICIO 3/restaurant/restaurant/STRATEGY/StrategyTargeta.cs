using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using restaurant.COMMAND;

namespace restaurant.STRATEGY
{
    class StrategyTargeta:IOperacion
    {
        double _monto;

        public StrategyTargeta(double m)
        {
            _monto = m;

        }
        public void Estrategia()
        {
            Receiver _receiver = new Receiver(_monto * 1.10);
            Invoker invoker = new Invoker(_receiver);
            invoker.Boton(2);
        }
    }
}
