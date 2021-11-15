using consolas.juegos;
using System;
using consolas.saver;

namespace consolas
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion;
            string g;
            Console.WriteLine("elija una consola: \n 1- playstation, 2- xbox\n");
            opcion = Console.ReadLine();
            Console.WriteLine("elija una generacion: \n 1- primera 2- segunda\n");
            g = Console.ReadLine();

            Consola consola = new Consola(g);

            if (opcion == "1")
            {
                consola.getConsola();
                Abstraccion abstraccion = new Abstraccion("1", "1", consola);
                abstraccion.Ejecutar();
                abstraccion.SetJugador("migue");
                Caretaker caretaker = new Caretaker(abstraccion);
                caretaker.Backup();
                abstraccion.reducirVida();
                caretaker.Backup();
                abstraccion.reducirVida();
                caretaker.Backup();
                abstraccion.reducirVida();

                caretaker.Historial();
                caretaker.Restaurar();
                caretaker.Restaurar();
                caretaker.Restaurar();
                caretaker.Restaurar();
                abstraccion.SetJugador("migue");
                abstraccion.SetJugador("migue");
                abstraccion.SetJugador("migue");
                caretaker.Restaurar();
                abstraccion.reducirVida();
                caretaker.Historial();
                abstraccion.reducirVida();
                abstraccion.reducirVida();
                abstraccion.reducirVida();
                abstraccion.reducirVida();
       
   

            }

            if (opcion == "2")
            {
                Consola consola2 = consola.Clonar();
                consola2.setNombre("XBOX");
                consola2.getConsola();
                
            }


        }


    }
}

