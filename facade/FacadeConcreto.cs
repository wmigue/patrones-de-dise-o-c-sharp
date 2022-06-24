using System;

namespace FACADE
{
    class FacadeConcreto:IFacade

    {
        SubSistema1 sub1;
        SubSistema2 sub2;
        public FacadeConcreto()
        {
            sub1 = new SubSistema1();
            sub2 = new SubSistema2();
        }

        public void facadeMetodo()
        {
            sub1.ejecutarTarea();
            sub2.ejecutarAccion();
            sub2.ejecutarOtraAccion();
        }
    }
}
