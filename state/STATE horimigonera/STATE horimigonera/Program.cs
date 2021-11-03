using System;

namespace STATE_hormigonera
{
    class Program
    {
        static void Main(string[] args)
        {
            Hormigonera hormigonera = new Hormigonera();
            string opcion;
            do
            {
                Console.WriteLine("1- dosificar, 2- esperar, 3- cargar tolvas, 4 - abortar operacion");
                opcion = Console.ReadLine();

                if (opcion == "1")
                    hormigonera.Dosificar();
                if (opcion == "2")
                    hormigonera.Esperar();
                if (opcion == "3")
                    hormigonera.CargarTolvas();
                if (opcion == "4")
                    hormigonera.Abortar();

                Console.WriteLine(hormigonera);

            } while (opcion == "1" || opcion == "2" || opcion == "3" || opcion == "4");
        }
    }
}
