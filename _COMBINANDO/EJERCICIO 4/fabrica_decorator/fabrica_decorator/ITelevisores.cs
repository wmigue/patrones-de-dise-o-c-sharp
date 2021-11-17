using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabrica_decorator
{
    interface ITelevisores:IComponente
    {
        public void Encender();
        public void Apagar();
        public string ReproducirTv();
    }
}
