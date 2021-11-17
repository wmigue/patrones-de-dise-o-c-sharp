using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant.COMMAND
{
    class CommandElectronico : IComando
    {
        public Receiver _receiver;
        public CommandElectronico(Receiver r)
        {
            _receiver = r;
        }

        public void Ejecutar()
        {
            _receiver.PagarElectronico();
        }
    }
}
