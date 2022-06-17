using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    public abstract class AbstractTemplate
    {
        public void EjecutarMetodos()
        {
            this.Metodo1();
            this.Metodo2();
            this.Metodo3();
        }

        public void Metodo1()
        {
            Console.WriteLine("soy el metodo 1");
        }
        public void Metodo2()
        {
            Console.WriteLine("soy el metodo 2");
        }
        public abstract void Metodo3(); //este método se sobreescribe en cada template concreto.

    }
}
