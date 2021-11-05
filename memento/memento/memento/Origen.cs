using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memento
{
    class Origen
    {
        private string _estado;

        public Origen(string estado)
        {
            _estado = estado;
        }
        public void NuevaAccion(string a)
        {
            _estado = a;
        }
        public Memento Guardar()
        {
            return new Memento(_estado);
        }
        public void Restaurar(IMemento memento)
        {
            _estado = memento.getEstado();
        }
        public string getEstado()
        {
            return _estado;
        }


    }
}
