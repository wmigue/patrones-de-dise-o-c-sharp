using System;

namespace FACADE
{
    class Program
    {
        static void Main(string[] args)
        {
            IFacade facade = new FacadeConcreto();
            Cliente cliente = new Cliente(facade);

            

        }
    }
}
