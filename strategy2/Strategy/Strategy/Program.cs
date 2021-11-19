using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0;
            double y = 0;
            string opcion = "";

            

            do
            {
                Console.WriteLine("1- Suma, 2- Resta, 3- Multiplicación, 4- División, 5- Salir");
                opcion = Console.ReadLine();
                Console.WriteLine("Dame el valor de a");
                x = double.Parse(Console.ReadLine());
                Console.WriteLine("Dame el valor de b");
                y = double.Parse(Console.ReadLine());

                Abstraccion abstraccion = new Abstraccion(Convert.ToInt32(opcion), x, y);

                Console.WriteLine($"El resultado es {abstraccion.Operar()}");

            } while (Int32.Parse(opcion) <= 4);
        }
    }
}
