using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command2
{
    class ComandoGetTotal:IComando
    {
        Pedidos _pedido;
        
        public ComandoGetTotal(Pedidos pedido)
        {
            _pedido = pedido;
           
        }
        public string Ejecutar()
        {
          return Convert.ToString( $" TOTAL DEL PEDIDO $ : {_pedido.getTotal()}" );
        }

    }
}
