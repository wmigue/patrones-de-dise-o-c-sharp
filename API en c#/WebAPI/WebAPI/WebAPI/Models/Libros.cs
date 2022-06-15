using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Libros
    {
        public int Id { get; set; }

        public string Autor { get; set; }

        public string Tematica { get; set; }
        public int Stock { get; set; }
  
    }
}
