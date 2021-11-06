using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memento
{
    class Almacenador
    {
        Origen _origen;
        int i;

        private List<IMemento> _mementos = new List<IMemento>();

        public Almacenador(Origen o)
        {
            _origen = o;
        }
        public void Backup()
        {
            _mementos.Add(_origen.Guardar());
        }
        public void Restore()
        {
            var memento = _mementos[_mementos.Count-2];
            Console.WriteLine(_mementos.Count);
            _mementos.Remove(memento);
            _origen.Restaurar(memento);
        }
        public void Historial()
        {
            foreach(var item in _mementos)
            {
                i++;
                Console.WriteLine($"SOCKET {i}: " + item.getEstado());
            }
        }
        public void EstadoActual()
        {
            Console.WriteLine($"el estado actual es: {_origen.getEstado()}");      
        }


    }
}
