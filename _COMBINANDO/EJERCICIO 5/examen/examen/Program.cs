using System;
using examen.PROTOTYPE;
using examen.BUILDER;
using examen.DECORATOR;

namespace examen
{
    class Program
    {
        static void Main(string[] args)
        {
            int tipocasa;
            int plus;
            CasaTipo1 c1;
            CasaTipo2 c2;
            CasaTipo3 c3;
            Director constructora = new Director();

            Console.WriteLine("\n :::: CONSTRUCTORA PREFABRICADOS V1.0 ::::\n\n");

            do
            {
                Console.WriteLine("\n\nINGRESE UNA OPCION:  \n 1- casa 2 ambientes \n 2- casa 3 ambientes\n 3- casa 4 ambientes");
                tipocasa =Int32.Parse( Console.ReadLine() );
                Console.WriteLine("\n\nAGREGAR AMOBLAMIENTOS Y 1 PISO EXTRA:  \n 1- SI \n 2- NO");
                plus = Int32.Parse(Console.ReadLine());

                if(plus == 2)
                {
                    if (tipocasa == 1)
                    {
                        c1 = new CasaTipo1(0);
                        constructora.Construir(c1);
                        c1.getCaracteristicas();
                    }
                    if (tipocasa == 2)
                    {
                        c2 = new CasaTipo2(0);
                        constructora.Construir(c2);
                        c2.getCaracteristicas();
                    }
                    if (tipocasa == 3)
                    {
                        c3 = new CasaTipo3(0);
                        constructora.Construir(c3);
                        c3.getCaracteristicas();
                    }
                }
                else
                {
                    if (tipocasa == 1)
                    {
                        c1 = new CasaTipo1(1);
                        constructora.Construir(c1);
                        c1.getCaracteristicas();
                    }
                    if (tipocasa == 2)
                    {
                        c2 = new CasaTipo2(1);
                        constructora.Construir(c2);
                        c2.getCaracteristicas();
                    }
                    if (tipocasa == 3)
                    {
                        c3 = new CasaTipo3(1);
                        constructora.Construir(c3);
                        c3.getCaracteristicas();
                    }
                }


            } while (tipocasa <= 3);

     
        }
    }
}
