using System;

namespace factory_method
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion;
            do
            {
                Console.WriteLine("INGRESE UNA OPCION: \n 1- Necesito pc para trabajar \n 2- Necesito pc para jugar ");
                opcion = Console.ReadLine();
                INotebook objeto = Creador.Fabricar(Int32.Parse(opcion));
                Printar(objeto);
            } while (Int32.Parse(opcion) <= 2);
        }

        public static void Printar(INotebook o)
        {
            Console.WriteLine(o.getCaracteristicas());
        }
    }
}
