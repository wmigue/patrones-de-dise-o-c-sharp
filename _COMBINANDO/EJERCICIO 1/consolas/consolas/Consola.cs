﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolas
{
    class Consola:IConsola
    {
        public string _nombre="playstation";
        public string _generacion;
        public Consola(string gen)
        {
            _generacion = gen;
            if (_generacion == "1")
                _generacion = "PRIMERA";
            if (_generacion == "2")
                _generacion = "SEGUNDA";

        }
        public void setNombre(string nom)
        {
            _nombre = nom;
        }
        public Consola Clonar()
        {
            return new Consola(_generacion);
        }
        public void getConsola()
        {
            Console.WriteLine($" \n NOMBRE: {_nombre} \n GENERACION: {_generacion} \n");
        }

    }
}
