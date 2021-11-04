using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    class Producto
    {
        public List<string> componentes = new List<string>();
        
        public void Agregar(string c)
        {
            componentes.Add(c);
        }
        public void Ver()
        {
            foreach (string c in componentes)
            {
                Console.WriteLine(c);
            }
        }

}
}
