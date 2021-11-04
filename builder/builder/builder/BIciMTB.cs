using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    class BiciMTB : IBuilder
    {
        private Producto _producto = new Producto();
        public void AgregarPartes()
        {
            _producto.Agregar("pedales MTB");
            _producto.Agregar("manubrio MTB");
            _producto.Agregar("ruedas MTB");
        }
        public void VerProducto()
        {
            _producto.Ver();
        }
    }
}
