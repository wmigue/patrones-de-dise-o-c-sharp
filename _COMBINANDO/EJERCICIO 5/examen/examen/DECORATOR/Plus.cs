using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using examen.PROTOTYPE;
using examen.BUILDER;
using examen.DECORATOR;

namespace examen.DECORATOR
{
    class Plus
    {
        Casa _casa;
        public Plus(Casa c) //Le agrego muebles y piso a la casa como un plus. 
        {
            _casa = c;
            _casa.setMuebles(1);
            _casa.setPisos(2);
        }




    }
}
