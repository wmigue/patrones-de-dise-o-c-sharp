using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Unico uno = Unico.Instanciar();
            uno.Holar();

            Unico dos = Unico.Instanciar();


        }
    }
}
