using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using examen.PROTOTYPE;
using examen.BUILDER;
using examen.DECORATOR;

namespace examen.BUILDER
{
    class CasaTipo1 : IBuilder
    {
        Casa _casa;
        Plus _plus;
        int _p=0;
        public CasaTipo1(int p)
        {
            _p = p;
            _casa = new Casa();
            _casa = _casa.Clonar();
        }
        public void agregarPartes()
        {
            _casa.setAmbientes(2);
            _casa.setPisos(1);
            _casa.setMuebles(0);

            if (_p == 1)
            {
                _plus = new Plus(_casa);
            }
        }

        public void getCaracteristicas()
        {
            if (_casa.getMuebles() > 0)
                Console.WriteLine($"\n SE CONSTRUYO CASA CON: \n AMBIENTES: {_casa.getAmbientes()}, PISOS: {_casa.getPisos()}, LA CASA VIENE AMOBLADA, PLACARES...");
            else
                Console.WriteLine($"\n SE CONSTRUYO CASA CON: \n AMBIENTES: {_casa.getAmbientes()}, PISOS: {_casa.getPisos()}");

        }
    }
}