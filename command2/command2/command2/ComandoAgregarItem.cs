using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command2
{
    class ComandoAgregarItem:IComando
    {
        Pedidos _pedido;
        IItem _item;
        public ComandoAgregarItem(Pedidos pedido, IItem item)
        {
            _pedido = pedido;
            _item = item;
        }
        public string Ejecutar()
        {
            _pedido.AgregarItem(_item);
            return Convert.ToString($"se agrego un/una {_item.getDescripcion()}, total actual $: { _pedido.getTotal() }");
        }

    }
}
