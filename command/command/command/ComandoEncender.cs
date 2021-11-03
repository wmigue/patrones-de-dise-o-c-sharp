using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command
{
    class ComandoEncender:IComando
    {
        Automovil _auto;

        public ComandoEncender(Automovil auto)
        {
            _auto = auto;
        }
        public void Ejecutar()
        {
            _auto.Encender();
        }
    }
}
