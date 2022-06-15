using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebAPI;

namespace WebAPI
{
    public class Dominio1Strategy:IStrategyCadena
    {
        public string GetConexion()
        {
            return "https://localhost:4000/";
        }
    }
}