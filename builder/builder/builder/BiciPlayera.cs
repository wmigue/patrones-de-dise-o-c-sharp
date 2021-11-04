using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    class BiciPlayera:IBuilder
    {
        private Producto _producto = new Producto();
        public void AgregarPartes()
        {
            _producto.Agregar("pedales playera");
            _producto.Agregar("manubrio playera");
            _producto.Agregar("ruedas playera");
        }
        public void VerProducto()
        {
            _producto.Ver();
        }
    }
}
