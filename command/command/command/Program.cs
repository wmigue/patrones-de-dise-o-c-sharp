using System;

namespace command
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion = "";
            Automovil auto = new Automovil();
            ControlRemoto control = new ControlRemoto(auto);
            
            do
            {         
                Console.WriteLine("\n presione un botón\n 1-encender \n 2-apagar \n 3-encender alarma \n 4-apagar alarma \n");
                opcion = Console.ReadLine();

                if (opcion == "0") {
                    control.Boton(Int32.Parse(opcion));
                }
                if (opcion == "1")
                {
                    control.Boton(Int32.Parse(opcion));
                }
                if (opcion == "2")
                {
                    control.Boton(Int32.Parse(opcion));
                }
                if (opcion == "3")
                {
                    control.Boton(Int32.Parse(opcion));
                }


            } while (Int32.Parse(opcion) <= 4); 
        }
    }
}
