using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace examen.PROTOTYPE
{
    class Casa:ICasa
    {
        int _pisos=1;
        int _ambientes=0;
        int _muebles = 0;

        public Casa Clonar()
        {
            return new Casa();
        }
        public void setPisos(int p)
        {
            _pisos = p;
        }
        public void setAmbientes(int a)
        {
            _ambientes = a;
        }
        public void setMuebles(int m)
        {
            _muebles = m;
        }
        public int getAmbientes()
        {
            return _ambientes;
        }
        public int getPisos()
        {
            return _pisos;
        }
        public int getMuebles()
        {
            if (_muebles > 0)
                return _muebles;
            else
                return 0;
        }
    }
}
