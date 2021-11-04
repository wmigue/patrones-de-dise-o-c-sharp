using System;

namespace builder
{
    //es el director quien dice que se va a hacer,
    //que metodos va a implementar y cuales no de un contructor concreto.
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Director director = new Director();

            string opcion = "";

            do
            {
                Console.WriteLine("\ningrese una opcion \n1-bici MTB   \n2-bici Playera \n");
                opcion = Console.ReadLine();

                IBuilder builder1 = new BiciMTB();
                IBuilder builder2 = new BiciPlayera();

                if (opcion == "1")                 
                    director.Construir(builder1);
                    builder1.VerProducto();
                if (opcion == "2")
                    director.Construir(builder2);
                    builder2.VerProducto();

            } while (Int32.Parse(opcion) <= 2);

            
        }
    }
}

