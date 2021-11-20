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
    class Director
    {
        public void Construir(IBuilder b)
        {
            b.agregarPartes();
        }



    }
}
