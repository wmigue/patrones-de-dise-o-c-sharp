using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memento
{
    class Memento:IMemento
    {
        private string _estado;

        public Memento(string estado)
        {
            _estado = estado;
        }
        public string getEstado()
        {
            return _estado;
        }
    }
}
