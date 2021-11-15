using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command2
{
    class Hamburguesa:IItem
    {
        double _precio = 50.50;
        string _descripcion="hamburguesa completa";

        public double getPrecio()
        {
            return this._precio;
        }
        public string getDescripcion()
        {
            return this._descripcion;
        }

    }
}
