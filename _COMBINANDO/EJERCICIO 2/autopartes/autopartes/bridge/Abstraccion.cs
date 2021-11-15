using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autopartes.bridge
{
    class Abstraccion
    {
        public IBridge _bridge;
        public void SetBridge(IBridge ib)
        {
            _bridge = ib;
        }
        public void BridgeFabricarVehiculo()
        {
            _bridge.Construir();
        }
    }
}
