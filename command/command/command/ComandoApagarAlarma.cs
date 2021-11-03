using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command
{
    class ComandoApagarAlarma : IComando
    {
        Automovil _auto;

       public ComandoApagarAlarma(Automovil auto)
        {
            _auto = auto;
        }
        public void Ejecutar()
        {
            _auto.ApagarAlarma();
        }
    }
}
