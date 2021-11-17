using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant.COMMAND
{
    class Receiver
    {
        double _monto;
            
        public Receiver(double m)
        {
            _monto = m;
        }
        public void PagarEfectivo()
        {
            Console.WriteLine($"se pago en efectivo, ABONANDO: $ {_monto}");
        }
        public void PagarTarjeta()
        {
            Console.WriteLine($"se pago con targeta, ABONANDO: $ {_monto}");
        }
        public void PagarElectronico()
        {
            Console.WriteLine($"se pago electrónico, ABONANDO: $ {_monto}");
        }

    }
}
