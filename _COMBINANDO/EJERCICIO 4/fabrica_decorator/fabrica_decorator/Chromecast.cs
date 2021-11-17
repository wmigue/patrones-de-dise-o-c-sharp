using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabrica_decorator
{
    class Chromecast: IChromecast
    {
        ITelevisores _tv=null;

       public void ReproducirNetflix()
        {
            if(_tv !=null)
            {
                Console.WriteLine($"{_tv.ReproducirTv()} , con netflix."); 
            }
            else
            {
                Console.WriteLine($"el chromecast no funciona sin una tv comun, conectar una. tampoco funciona en smartTV");
            }


        }
        public void ReproducirYoutube()
        {
            if (_tv != null)
            {
                Console.WriteLine($" {_tv.ReproducirTv()} , con youtube.");
            }
            else
            {
                Console.WriteLine($"el chromecast no funciona sin una tv comun, conectar una. tampoco funciona en smartTV");
            }
        }

        public void conectarTV(ITelevisores t)
        {        
            if(t is TVcomun)
            {
                _tv = t;
                _tv.Encender();
            }
              
            else
                Console.WriteLine("solo conectar chromecast a tv comun, no funciona en smartTVs----");
            
        }
    }
}
