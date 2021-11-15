using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autopartes.factory
{
    class Motor : IParte
    {
        int _vehiculo;
       public Motor(int vehiculo)
        {
            _vehiculo = vehiculo;
        }

        public string Caracteristicas()
        {
            if (_vehiculo == 1)
                return "motor camión";
            else
                return "motor auto";
        }
    }
}
