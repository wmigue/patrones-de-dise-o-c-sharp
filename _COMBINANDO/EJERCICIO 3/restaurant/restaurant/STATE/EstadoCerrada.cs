using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant.STATE
{
    class EstadoCerrada:IEstado
    {
        Mesa _mesa;
        public EstadoCerrada(Mesa mesa)
        {
            _mesa = mesa;
        }
        public void Ordenar(double precio)
        {
            Console.WriteLine("la mesa está cerrada");

        }
        public void Pagar(int medio)
        {
            Console.WriteLine("la mesa está cerrada");
        }
        public void Reabrir()
        {
            _mesa.EstadoActual = _mesa.EstadoAbierta;
            _mesa.cuenta = 0;
        }
    }
}
