using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command2
{
    class ComandoVerTodos : IComando
    {
        Pedidos _pedido;

        public ComandoVerTodos(Pedidos pedido)
        {
            _pedido = pedido;

        }
        public string Ejecutar()
        {
            if (_pedido.verTodos() == "")
                return "no hay pedidos en el carrito.";
            else
                return $"CARRITO: \n { _pedido.verTodos() } ";
        }

    }
}   
