using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autopartes.builder
{
    class Auto:IVehiculo
    {
        public List<string> componentes = new List<string>();

        public void getComponentes()
        {
            Console.WriteLine("AUTO CON: \n");
            foreach (string item in componentes)
            {
                Console.WriteLine($"{item}");
            }
           
        }
        public void setComponentes(string v)
        {
            componentes.Add(v);
        }
    }
}
