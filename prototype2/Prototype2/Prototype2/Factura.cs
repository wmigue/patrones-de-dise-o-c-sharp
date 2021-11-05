using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype2
{
    class Factura:ifactura
    {
        public string _denominacion;
        private int _numero;
        private double _monto;
        private string _cliente;

        public Factura(int numero, double monto, string cliente)
        {
            _denominacion = "FACTURA";
            _numero = numero;
            _monto = monto;
            _cliente = cliente;
        }
        public void setDenoninacion(string d)
        {
            _denominacion = d;
        }
        public void setNumero(int n)
        {
            _numero = n;
        }
        public Factura clonar() //clono tal cual la factura
        {
            return new Factura(_numero, _monto, _cliente);
        }
        public void getFactura()
        {
            Console.WriteLine($" \n TIPO: {_denominacion} \n Nº: {_numero} \n MONTO $: {_monto} \n CLIENTE: {_cliente} \n");
        }


    }
}
