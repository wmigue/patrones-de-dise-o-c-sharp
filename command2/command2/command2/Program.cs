using System;

namespace command2
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion;   
            Invocador inv = new Invocador();
            do
            {
                Console.WriteLine("\nELEGIR UNA OPCION: \n 1) agregar burguer\n 2) agregar cerveza\n 3) ver totales\n 4) ver items\n 5) eliminar ultimo\n 6) salir.");
                opcion = Console.ReadLine();
                    
                    inv.setOpcion(Int32.Parse(opcion));
                    inv.EjecutarComando();

            } while (Int32.Parse( opcion )<=5);


        }


    }
}
