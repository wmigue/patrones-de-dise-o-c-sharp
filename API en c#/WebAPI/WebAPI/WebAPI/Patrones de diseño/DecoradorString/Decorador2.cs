
using System;
using System.Collections.Generic;
using System.Text;
using WebAPI.Models;

namespace WebAPI
{

    public class Decorador2:IDecorador
    {
        public IDecorador _pordefecto;
        public Decorador2(IDecorador pd)
        {
            _pordefecto = pd;
        }
        public string Retornar(bool opcion)
        {
            return _pordefecto.Retornar(opcion) + ", server response name XYZ-123456.";
        }
    }

}