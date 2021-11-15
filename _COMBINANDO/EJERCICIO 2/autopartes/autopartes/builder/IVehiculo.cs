using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autopartes.builder
{
    interface IVehiculo
    {
        void setComponentes(string v);
        void getComponentes();
    }
}
