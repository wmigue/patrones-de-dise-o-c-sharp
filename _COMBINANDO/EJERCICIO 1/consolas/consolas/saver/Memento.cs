using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolas.saver
{
    class Memento:IMemento
    {
        int _vida;
        string _nombre;
        public Memento(string nombre, int vida)
        {
            _nombre = nombre;
            _vida = vida;
        }
        public string getN()
        {
            return this._nombre;
        }
        public int getV()
        {
            return this._vida;
        }
    }
}
