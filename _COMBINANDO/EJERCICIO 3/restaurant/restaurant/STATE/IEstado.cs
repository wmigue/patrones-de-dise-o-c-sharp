using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant.STATE
{
    public interface IEstado
    {
        public void Ordenar(double precio);
        public void Pagar(int medioPago);
        public void Reabrir();
    }
}
