using System;
using autopartes;
using autopartes.factory;
using autopartes.builder;
using autopartes.bridge;


namespace autopartes
{
    class Program
    {
        static void Main(string[] args)
        {
            //BridgeAuto auto = new BridgeAuto();
            BridgeCamion camion = new BridgeCamion();
            Abstraccion abs = new Abstraccion();

            abs.SetBridge(camion);
            abs.BridgeFabricarVehiculo();

        }
    }
}
