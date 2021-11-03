using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command
{
    class ControlRemoto
    {
        private IComando[] comandos = new IComando[4];

        public ControlRemoto(Automovil auto)
        {
            comandos[0] = new ComandoEncender(auto);
            comandos[1] = new ComandoApagar(auto);
            comandos[2] = new ComandoEncenderAlarma(auto);
            comandos[3] = new ComandoApagarAlarma(auto);
        }

        public void Boton(int b)
        {
           comandos[b].Ejecutar();  
        }
    }
}
