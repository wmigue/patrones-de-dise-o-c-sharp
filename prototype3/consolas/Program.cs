using System;

namespace consolas
{
    class Program
    {
        static void Main(string[] args)
        {
            string c;
            Consola consola = new Consola("PLAYSTATION", "1");

            do
            {
                Console.WriteLine("elija una consola: \n 1- playstation, 2- xbox\n");
                c = Console.ReadLine();
                Console.WriteLine("elija una generacion: \n 1- primera 2- segunda\n");
                g = Console.ReadLine();

                if (c == "1")
                    consola.getConsola();
                else
                {
                    consola = consola.Clonar();
                    consola.setNombre("XBOX");
                    consola.getConsola();
                }
            } while (Int32.Parse(c) <= 2);

        }
    }
}
