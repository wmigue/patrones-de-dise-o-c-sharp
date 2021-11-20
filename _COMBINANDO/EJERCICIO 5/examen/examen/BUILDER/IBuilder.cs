using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using examen.PROTOTYPE;
using examen.BUILDER;
using examen.DECORATOR;

namespace examen.BUILDER
{
    interface IBuilder
    {
        public void agregarPartes();
        public void getCaracteristicas();
    }
}
