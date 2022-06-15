using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class EntregasPedidosLibros
    {
        public int IdEntregas { get; set; }
        public int IdPedidos { get; set; }
        public string FechaPedido{ get; set; }
        public string FechaEntrega { get; set; }
        public string LibroTematica { get; set; }
        public string LibroAutor { get; set; }
        public bool PedidoEntregado { get; set; }

    }
}
