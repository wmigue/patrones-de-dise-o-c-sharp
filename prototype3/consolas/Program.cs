using System;

namespace consolas
{
    class Program
    {
        static void Main(string[] args)
        {
            string c;
            string g;
            Consola consola = new Consola("PLAYSTATION", "1");

            do
            {
                Console.WriteLine("elija una consola: \n 1- playstation, 2- xbox\n");
                c = Console.ReadLine();
                Console.WriteLine("elija una generacion: \n 1- primera 2- segunda\n");
                g = Console.ReadLine();

                if(g == "1")
                {
                    if (c == "1")
                    {
                        consola.Clonar().getConsola();
                    }

                    if (c == "2")
                    {
                        var con = consola.Clonar();
                        con.setNombre(c);
                        con.getConsola();
                    }
                }
                if (g == "2")
                {
                    if (c == "1")
                    {
                        var con = consola.Clonar();
                        con.setGen(g);
                        con.getConsola();
                    }
                    if (c == "2")
                    {
                        var con = consola.Clonar();
                        con.setNombre(c);
                        con.setGen(g);
                        con.getConsola();
                    }   
                }

            } while (Int32.Parse(c) <= 2);

        }
    }
}
