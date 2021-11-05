using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge_pattern
{
    class Abstraccion
    {
        IBridge _implementacion;

        public Abstraccion(int tipo, Paquete paq)
        {
      
            
            switch (tipo)
            {
                case 1:
                    _implementacion = new ImplementacionAire(paq);
                    break;
                case 2:
                    _implementacion = new ImplementacionTierra(paq);
                    break;
                case 3:
                    _implementacion = new ImplementacionMar(paq);
                    break;
            }

        }
        public void setImplementacion(IBridge imp)
        {
            _implementacion = imp;
        }
        public void Recoger()
        {
            _implementacion.RecogerPaquete();
        }
        public void Enviar()
        {
            _implementacion.EnviarPaquete();
        }
        public void Entregar()
        {
            _implementacion.EntregarPaquete();
        }
    }
}
