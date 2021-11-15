using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using consolas.juegos;

namespace consolas.saver
{
    class Caretaker
    {
        int i;
        private List<Memento> _mementos = new List<Memento>();
   
        Abstraccion _abstraccion;

        public Caretaker(Abstraccion a)
        {
           
            _abstraccion = a;
        }
        public void Backup()
        {
            _mementos.Add(this._abstraccion.getEstado());
            Console.WriteLine($"se hizo backup. vida: {_abstraccion.getEstado().getV()}");
        }
        public void Restaurar()
        {
            if((_mementos.Count) >= 0)
            {
                if (_abstraccion.getRestauraciones() > 0)
                {
                    var memento = _mementos[_mementos.Count-1];
                    Console.WriteLine($"SE RESTAURO EL JUEGO A UN ESTADO ANTERIOR. vida:  {memento.getV()}");
                    _mementos.Remove(memento);
                    _abstraccion.restauraJuego(memento);
                }
                else
                {
                    Console.WriteLine("ya restauraste 3 veces, perdiste gil...");
                }
               
            }
            else
                Console.WriteLine("no tenes un punto de restauracion...");

        }
        public void Historial()
        {
           
            Console.WriteLine("\nGUARDADO EN MEMENTO:");
            if (_mementos.Count > 0)
            {
                foreach (var item in _mementos)
                {
                    i++;
                    Console.WriteLine($"caretaker: " + " nombre jugador: " + item.getN() + "  vida: " + item.getV());
                }
                Console.WriteLine("\n");

            }
            else
            {
                Console.WriteLine("no hay mementos salvados.\n");
            }
                    

        }

    }
}
