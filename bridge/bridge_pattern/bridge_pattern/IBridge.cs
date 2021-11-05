using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge_pattern
{
    interface IBridge
    {
        public void RecogerPaquete();
        public void EnviarPaquete();
        public void EntregarPaquete();
    }
}
