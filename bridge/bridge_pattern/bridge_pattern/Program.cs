using System;

namespace bridge_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Paquete paquete = new Paquete("MacBook Air");
            string opcion;

            do
            {
                opcion = Console.ReadLine();
                Console.WriteLine("ingrese una opcion \n 1 AIRE \n 2 TIERRA \n 3 MAR");
                Abstraccion abstracion = new Abstraccion(Int32.Parse(opcion), paquete);
                abstracion.Recoger();
                abstracion.Enviar();
                abstracion.Entregar();
            } while (Int32.Parse(opcion) <= 3);
        }
    }
}
