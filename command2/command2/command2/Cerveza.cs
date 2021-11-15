using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command2
{
    class Cerveza : IItem
    {
        double _precio = 100.50;
        string _descripcion = "cerveza rubia";

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
