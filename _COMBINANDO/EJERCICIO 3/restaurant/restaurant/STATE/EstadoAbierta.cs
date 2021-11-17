using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using restaurant.STRATEGY;
using restaurant.COMMAND;

namespace restaurant.STATE
{
    class EstadoAbierta:IEstado
    {
        Mesa _mesa;
        public EstadoAbierta(Mesa mesa)
        {
            _mesa = mesa;
        }
        public void Ordenar(double precio)
        {
            _mesa.cuenta = _mesa.cuenta + precio;
            Console.WriteLine($"se agrego un item a la cuenta, saldo actual $ {_mesa.GetCuenta()}");

        }
        public void Pagar(int medio)
        {
            int confirmacion;
            if (_mesa.GetCuenta() != 0)
            {    
            if(medio == 1)
            {
                 Console.WriteLine("confirmar? efectivo no tiene recargo. \n1-SI \n2-NO");
                 confirmacion = Int32.Parse( Console.ReadLine() );
                 if(confirmacion == 1)
                 {
                    StrategyEfectivo Sefectivo = new StrategyEfectivo(_mesa.GetCuenta());
                    Sefectivo.Estrategia();
                    _mesa.cuenta = 0;
                    _mesa.EstadoActual = _mesa.EstadoCerrada;
                    Console.WriteLine("MESA CERRADA. Reabrir mesa? \n1-SI \n2-NO");
                    confirmacion = Int32.Parse(Console.ReadLine());
                        if (confirmacion == 1)
                            _mesa.ReabrirMesa();
                        else
                            Console.WriteLine("mesa cerrada. saliendo del programa.");
                 }
            }

            if (medio == 2)
            {
                Console.WriteLine("confirmar? pago electrónico tiene recargo del 7%. \n1-SI \n2-NO");
                confirmacion = Int32.Parse(Console.ReadLine());
                if (confirmacion == 1)
                {
                    StrategyElectronico Selectronico = new StrategyElectronico(_mesa.GetCuenta());
                    Selectronico.Estrategia();
                    _mesa.cuenta = 0;
                    _mesa.EstadoActual = _mesa.EstadoCerrada;
                        Console.WriteLine("MESA CERRADA. Reabrir mesa? \n1-SI \n2-NO");
                        confirmacion = Int32.Parse(Console.ReadLine());
                        if (confirmacion == 1)
                            _mesa.ReabrirMesa();
                        else
                            Console.WriteLine("mesa cerrada. saliendo del programa.");
                    }

            }

            if (medio == 3)
            {
                Console.WriteLine("confirmar? tarjeta tiene recargo del 10%. \n1-SI \n2-NO");
                confirmacion = Int32.Parse(Console.ReadLine());
                if (confirmacion == 1)
                {
                    StrategyTargeta Stargeta = new StrategyTargeta(_mesa.GetCuenta());
                    Stargeta.Estrategia();
                    _mesa.cuenta = 0;
                    _mesa.EstadoActual = _mesa.EstadoCerrada;
                    Console.WriteLine("MESA CERRADA. Reabrir mesa? \n1-SI \n2-NO");
                    confirmacion = Int32.Parse(Console.ReadLine());
                        if (confirmacion == 1)
                           _mesa.ReabrirMesa();
                        else
                         Console.WriteLine("mesa cerrada. saliendo del programa.");
                    }

            }
            }
            else
            {
                Console.WriteLine("debe consumir algo antes de pagar y cerrar la mesa.");
            }
        }
        public void Reabrir()
        {
            Console.WriteLine("la mesa ya está abierta.");
        }
    }
}
