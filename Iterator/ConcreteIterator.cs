using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class ConcreteIterator1 : IIterator
    {
        //private Iterator _iterador;
        private List<string> _lista;
        private int _posicion;

        public ConcreteIterator1(List<string> l)
        {
            _lista = l;
            _posicion = -1;

        }
        public bool haySiguiente()
        {
            if (_posicion < _lista.Count - 1)
            {
                _posicion++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public string next()
        {
            if (haySiguiente())
            {
                string valor = _lista[_posicion];
                return valor;
            }
            else
            {
                return "error next";
            }

        }
        public string back()
        {
            if (_posicion >= 1)
            {
                string valor = _lista[--_posicion];
                return valor;
            }
            else
            {
                return "error back";
            }

        }
        public int getPosicion()
        {
            return _posicion + 1;
        }
    }
}
