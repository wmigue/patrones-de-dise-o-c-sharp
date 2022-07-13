using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command3
{
    class Moto:IVehiculo
    {
        public void encender()
        {
            Console.WriteLine("encendiendo moto");
            Console.WriteLine("motor encendido.");
        }
        public void apagar()
        {
            Console.WriteLine("apagando moto");
            Console.WriteLine("motor apagado.");
        }
    }
}
