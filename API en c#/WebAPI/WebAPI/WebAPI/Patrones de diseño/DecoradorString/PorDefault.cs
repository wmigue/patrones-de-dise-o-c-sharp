
using System;
using System.Collections.Generic;
using System.Text;
using WebAPI.Models;
using WebAPI;

namespace WebAPI
{

    public class PorDefault : IDecorador
    { 
        public string Retornar(bool opcion)
        {      
            if (opcion == true)
            {
                return "entrega eliminada.";

            }
            else
            {
                return "no se pudo eliminar la entrega.";
            }
              
        }
    }

}