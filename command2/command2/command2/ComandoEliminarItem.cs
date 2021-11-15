using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command2
{
    class ComandoEliminarItem : IComando
    {
        Pedidos _pedido;
        IItem _item;
        public ComandoEliminarItem(Pedidos pedido, IItem item)
        {
            _pedido = pedido;
            _item = item;
        }
        public string Ejecutar()
        {
            if (_pedido.getTotal() > 0)
            {
                _pedido.EliminarItem(_item);
                return Convert.ToString($"se eliminó un/una {_item.getDescripcion()}, total actual $: { _pedido.getTotal() }");
            }
            else
                return "carrito vacio...";
        }

    }
}
