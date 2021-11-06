using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// CONSIDERANDO: 1 KM/H = 37 MPH 

namespace patron_adapter
{
    class Adaptador:IVelocimetro
    {
        private VelocimetroMPH _vMPH;
        public Adaptador(VelocimetroMPH vMPH)
        {
            _vMPH = vMPH;
        }
        public double getVelocidad()
        {
            var kmh = Double.Parse(_vMPH.ObtenerVel()) / 37;
            return kmh;
        }
    }
}
