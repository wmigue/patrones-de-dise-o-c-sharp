using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command
{
    class Automovil
    {
        public void Encender()
        {
            Console.WriteLine("se ha encendido el auto.");
        }
        public void Apagar()
        {
            Console.WriteLine("se ha APAGADO el auto.");
        }
        public void EncenderAlarma()
        {
            Console.WriteLine("se ha encendido ALARMA.");
        }
        public void ApagarAlarma()
        {
            Console.WriteLine("se ha apagado ALARMA.");
        }
    }
}
