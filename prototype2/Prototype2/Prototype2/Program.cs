using System;

namespace Prototype2
{
    class Program
    {
        static void Main(string[] args)
        {
            Factura factura1 = new Factura(1234, 415.38, "cliente 1");
            NotaCredito nota1 = new NotaCredito(factura1, 4321);

            factura1.getFactura();

            nota1.getNotaCredito(); //conseguir anular una factura determinada, internamenta clona una factura determinada, cambiando atributo denominación y numero.

        
        }
    }
}
