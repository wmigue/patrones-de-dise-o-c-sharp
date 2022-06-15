
using System;
using System.Collections.Generic;
using System.Text;
using WebAPI.Models;

namespace WebAPI
{

    public class Decorador1:IDecorador
    {
        public IDecorador _pordefecto;
        public Decorador1(IDecorador pd)
        {
            _pordefecto = pd;
        }
        public string Retornar(bool opcion)
        {
            return _pordefecto.Retornar(opcion) + ", respuesta del servidor nombre: Server XYZ-123456";
        }
    }

}