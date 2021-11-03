using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class CMulti : IOperacion
    {
        public double Operacion(double a, double b)
        {
            return a * b;
        }
    }
}
