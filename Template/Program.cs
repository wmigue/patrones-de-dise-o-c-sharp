using System;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Cliente.codigoCliente(new ConcreteTemplate1());
            Cliente.codigoCliente(new ConcreteTemplate2());


        }
    }
}
