using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command
{
    class ComandoApagar : IComando
    {
        Automovil _auto;

       public ComandoApagar(Automovil auto)
        {
            _auto = auto;
        }
        public void Ejecutar()
        {
            _auto.Apagar();
        }
    }
}
