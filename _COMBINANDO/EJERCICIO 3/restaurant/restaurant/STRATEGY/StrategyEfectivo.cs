using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using restaurant.COMMAND;

namespace restaurant.STRATEGY
{
    class StrategyEfectivo:IOperacion
    {
        double _monto; 
        
       public StrategyEfectivo(double m)
        {
            _monto = m;      
           
        }

        public void Estrategia()
        {
            Receiver _receiver = new Receiver(_monto);
            Invoker invoker = new Invoker(_receiver);
            invoker.Boton(0);
            
        }
    }
}
