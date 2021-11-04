using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    class Director
    {   
        public void Construir(IBuilder b) 
        {
            b.AgregarPartes();
        }

    }
}
