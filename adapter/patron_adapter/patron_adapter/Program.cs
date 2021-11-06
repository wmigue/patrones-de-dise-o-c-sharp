using System;

namespace patron_adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            VelocimetroMPH velmph = new VelocimetroMPH();
            Adaptador adaptador = new Adaptador(velmph);
            Printer(adaptador.getVelocidad());

            VelocimetroKM velkm = new VelocimetroKM();
            Printer(velkm.getVelocidad());
        }

        static void Printer(double a)
        {
            Console.WriteLine($"la velocidad es de {a} KM/H");
        }
    }


}
