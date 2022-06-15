using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace WebAPI
{
    public class Dominio2Strategy: IStrategyCadena
    {
        public string GetConexion()
        {
            return "https://localhost:5001/";
        }
    }
}