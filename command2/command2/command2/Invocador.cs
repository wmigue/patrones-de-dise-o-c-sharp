using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command2
{
    class Invocador
    {
        IComando _comando;
        IItem _item;
        Pedidos _pedido= new Pedidos();

       public void setOpcion (int opcion)
        {
            switch (opcion)
            {
                case 1:
                    _item = new Hamburguesa();
                    _comando = new ComandoAgregarItem(_pedido, _item);
                    break;
                case 2:
                    _item = new Cerveza();
                    _comando = new ComandoAgregarItem(_pedido, _item);
                    break;
                case 3:              
                    _comando = new ComandoGetTotal(_pedido);
                    break;
                case 4:         
                    _comando = new ComandoVerTodos(_pedido);
                    break;
                case 5:
                    _comando = new ComandoEliminarItem(_pedido, _item);
                    break;
            }
        }


        public void EjecutarComando()
        {
           Console.WriteLine(_comando.Ejecutar());
        }

    }
}
