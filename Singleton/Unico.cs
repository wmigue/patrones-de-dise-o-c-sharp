using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Unico
    {
        private static Unico _unico;
        private string _palabra;
        private Unico()
        {
            _palabra = " Hola, soy unico el objeto unico.";
        }

        public static Unico Instanciar()
        {
            if (_unico == null)
            {
                _unico = new Unico();
            }
            else
            {
                Console.WriteLine("ya hay una instancia, y es unica.");
            }
            return _unico;
        }

        public void Holar()
        {
            Console.WriteLine(_palabra);
        }
    }
}
