using System;

namespace command3
{
    class Program
    {
        static void Main(string[] args)
        {
            IVehiculo moto = new Moto();
            ManejadorComandosVehiculos manejador = new ManejadorComandosVehiculos();
            Invoker invocador = new Invoker();

            manejador.setVehiculo(moto);
            manejador.setAccion(1);    
            invocador.setComando(manejador);
            invocador.run();

            manejador.setVehiculo(moto);
            manejador.setAccion(0);
            invocador.setComando(manejador);
            invocador.run();
        }
    }
}
