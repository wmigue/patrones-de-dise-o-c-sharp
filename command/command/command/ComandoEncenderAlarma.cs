using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command
{
    class ComandoEncenderAlarma : IComando
    {
        Automovil _auto;

        public ComandoEncenderAlarma(Automovil auto)
        {
            _auto = auto;
        }
        public void Ejecutar()
        {
            _auto.EncenderAlarma();
        }
    }
}
