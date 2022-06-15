using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Pedidos
    {
        public int Id { get; set; }
        public int IdLibros { get; set; }

        public string Fecha{ get; set; }

        public bool Entregado { get; set; }
  
    }
}
