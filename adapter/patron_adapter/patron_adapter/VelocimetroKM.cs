using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patron_adapter
{
    class VelocimetroKM:IVelocimetro
    {
        double _velocidad = 1;
       public double getVelocidad()
        {
            return _velocidad; 
        }
    }
}
