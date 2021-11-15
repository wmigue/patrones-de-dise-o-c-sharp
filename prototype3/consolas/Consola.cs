using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolas
{
    class Consola:IConsola
    {
        public string _nombre;
        public string _generacion;
        public Consola(string nom, string gen)
        {
            _nombre = nom;
            if (gen == "1")
                _generacion = "PRIMERA";
            else
                _generacion = "SEGUNDA";
              
        }
        public void setNombre(string nom)
        {
            _nombre = nom;
        }
        public Consola Clonar()
        {
            return new Consola(_nombre, _generacion);
        }
        public void getConsola()
        {
            Console.WriteLine($" \n NOMBRE: {_nombre} \n GENERACION: {_generacion} \n");
        }
    }
}
