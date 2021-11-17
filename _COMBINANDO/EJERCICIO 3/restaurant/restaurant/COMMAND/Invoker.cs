using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using restaurant.COMMAND;

namespace restaurant.COMMAND
{
    class Invoker
    {
        private IComando[] comandos = new IComando[3];

        public Invoker(Receiver r)
        {
            comandos[0] = new CommandEfectivo(r);
            comandos[1] = new CommandElectronico(r);
            comandos[2] = new CommandTarjeta(r);

        }

        public void Boton(int b)
        {
            comandos[b].Ejecutar();

        }
    }
}
