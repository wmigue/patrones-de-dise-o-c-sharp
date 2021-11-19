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
            _generacion = gen;

            if (_generacion == "1")
                _generacion = "PRIMERA";
            if (_generacion == "2")
                _generacion = "SEGUNDA";
              
        }
        public void setNombre(string nom)
        {
            _nombre = nom;

            if (_nombre == "1")
                _nombre = "PLAYSTATION";
            if (_nombre == "2")
                _nombre = "XBOX";
        }
        public void setGen(string gen)
        {
            _generacion = gen;

            if (_generacion == "1")
                _generacion = "PRIMERA";
            if (_generacion == "2")
                _generacion = "SEGUNDA";
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
