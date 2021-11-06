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

            IOperacion miOperacion = new CSuma();

            do
            {
                Console.WriteLine("1- Suma, 2- Resta, 3- Multiplicación, 4- División, 5- Salir");
                opcion = Console.ReadLine();
                Console.WriteLine("Dame el valor de a");
                x = double.Parse(Console.ReadLine());
                Console.WriteLine("Dame el valor de b");
                y = double.Parse(Console.ReadLine());

                if (opcion == "1")
                    miOperacion = new CSuma();

                if (opcion == "2")
                    miOperacion = new CResta();

                if (opcion == "3")
                    miOperacion = new CMulti();

                if (opcion == "4")
                    miOperacion = new CDiv();

                Console.WriteLine($"El resultado es {miOperacion.Operacion(x, y)}");

            } while (Int32.Parse(opcion) <= 4);
        }
    }
}
