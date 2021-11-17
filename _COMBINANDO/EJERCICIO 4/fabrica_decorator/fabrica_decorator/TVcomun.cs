using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabrica_decorator
{
    class TVcomun:ITelevisores
    {
        Chromecast _cc=null;
        bool _encendido=false;
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
                return "reproduciendo tv comun ";
            else
                return "debe encender el televisor antes de reproducir algo.";
        }
        public void ReproducirNetflix()
        {
            if(_cc==null)
                Console.WriteLine($"conectar un chromecast para usar netflix.");
            else
            Console.WriteLine($"chromecast conectado. reproduciendo netflix.");
        }
        public void ReproducirYoutube()
        {
            if (_cc == null)
                Console.WriteLine($"conectar un chromecast para usar youtube.");
            else
                Console.WriteLine($"chromecast conectado. reproduciendo youtube.");
        }
        public void ConectarChormeCast(Chromecast cc)
        {
            _cc = cc;
        }
    }
}
