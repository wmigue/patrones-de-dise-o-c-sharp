using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command2
{
    class Pedidos
    {
        List<IItem> Lista = new List<IItem>();
        double _totales;
        public void AgregarItem(IItem item) {
            Lista.Add(item);
            _totales = _totales + item.getPrecio();
        }
        public void EliminarItem(IItem item)
        {
            if(Lista.Count != 0)
            {
                IItem ultimo = Lista[Lista.Count - 1];
                Lista.Remove(ultimo);
                _totales = _totales - ultimo.getPrecio();
            }
            else
            {
                Console.WriteLine("Lista vacia, agregue un producto...");
            }

        }
        public double getTotal()
        {
            return _totales;
        }
        public string verTodos()
        {
            string variable="";
            foreach(IItem i in Lista)
            {
              variable += $"item: {i.getDescripcion()} precio: {i.getPrecio()}\n";
            }
            return variable;
        }

    }
}
