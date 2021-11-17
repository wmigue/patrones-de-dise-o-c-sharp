using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using restaurant.STATE;


namespace restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(":::::::::: BIENVENIDOS AL RESTAURANTE ::::::::::\n\n");

            Mesa mesa = new Mesa();
            int opcion;
            double monto;
            int medio;
            do
            {
                if (mesa.EstadoActual == mesa.EstadoCerrada)
                break;
                Console.WriteLine(" 1)Cagar consumos a la mesa\n 2)pagar MESA\n 3)SALIR");
                opcion = Int32.Parse( Console.ReadLine());
                if (opcion == 1)
                {
                    Console.WriteLine("elegir monto:");
                    monto = double.Parse( Console.ReadLine());
                    mesa.OrdenarMesa(monto);
                }
                if (opcion == 2)
                {
                    Console.WriteLine("elegir medio de pago:\n 1) efectivo 2) electronico 3) tarjeta.");
                    medio = Int32.Parse(Console.ReadLine());
                    if (medio == 1)
                        mesa.PagarMesa(1);
                    if (medio == 2)
                        mesa.PagarMesa(2);
                    if (medio == 3)
                        mesa.PagarMesa(3);
                }
            } while (opcion != 3);



            //mesa.changeEstado();
            //mesa.PagarMesa(3);
            //mesa.OrdenarMesa(1);
            //mesa.PagarMesa(3);
            //mesa.OrdenarMesa(6);
        }

    }
}
