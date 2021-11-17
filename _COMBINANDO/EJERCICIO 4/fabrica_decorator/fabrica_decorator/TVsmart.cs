using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabrica_decorator
{
    class TVsmart:ITelevisores, IChromecast

    {
        bool _encendido = false;
        public void Encender()
        {
            Console.WriteLine("la tv se encendio. ");
            _encendido = true;
        }
        public void Apagar()
        {
            Console.WriteLine("la tv se apago. ");
            _encendido = false;
        }
        public string ReproducirTv()
        {
            if (_encendido==true)
                return "reproduciendo tvsmart";
            else
                return "debe encender el televisor antes de reproducir algo.";
        }
        public void ReproducirNetflix()
        {
    
                Console.WriteLine($"reproduciendo netflix.");
        }
        public void ReproducirYoutube()
        {
            Console.WriteLine($"reproduciendo youtube.");
        }


    }
}
