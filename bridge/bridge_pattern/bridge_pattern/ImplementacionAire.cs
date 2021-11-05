using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge_pattern
{
    class ImplementacionAire:IBridge
    {
        private Paquete _paquete;
        string _imp;
       public ImplementacionAire(Paquete paquete)
        {
            _paquete = paquete;
            _imp = "AIRE";
        }
        
        public void RecogerPaquete()
        {
            Console.WriteLine($"se recogió el paquete {_paquete.Nombrar()} por {_imp}");
        }
        public void EnviarPaquete()
        {
            Console.WriteLine($"se envió el paquete {_paquete.Nombrar()}  por {_imp}");
        }
        public void EntregarPaquete()
        {
            Console.WriteLine($"se entregó el paquete {_paquete.Nombrar()}  por {_imp}");
        }
    }
}
