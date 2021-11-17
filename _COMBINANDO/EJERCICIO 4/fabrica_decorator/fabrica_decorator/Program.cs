using System;

namespace fabrica_decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            CreadorTV creadortv = new  CreadorTV();
            CreadorChromeCast creadorcc = new CreadorChromeCast();
            IComponente tvcomun = creadortv.Fabricar(1); 
            IComponente tvsmart = creadortv.Fabricar(2);
            IComponente cc = creadorcc.Fabricar(1); //chromecast


            //((Chromecast)cc).conectarTV((TVsmart)tvsmart);

            ((Chromecast)cc).conectarTV((TVcomun)tvcomun);
            ((Chromecast)cc).ReproducirNetflix();
            Console.WriteLine(((TVcomun)tvcomun).ReproducirTv());

            //((ITelevisores)tvsmart).Encender();
            //Console.WriteLine(((TVsmart)tvsmart).ReproducirTv());
            //((TVsmart)tvsmart).ReproducirNetflix();






        }

        static void Printer(string s)
        {
            Console.WriteLine(s);
        }
    }
}
