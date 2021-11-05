using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype2
{
    class NotaCredito
    {
        Factura _factura;
        
       public NotaCredito(Factura factura, int numero)
        {
            _factura = factura.clonar();
            _factura.setDenoninacion("NOTA DE CRÉDITO");
            _factura.setNumero(numero);
        }
        public void getNotaCredito()
        {
            _factura.getFactura();
        }
    }
}
