using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    //hago uso del patron "BRIDGE" para generar una abstraccion de clases suma , resta, etc... solo uso metoto Operar() en el cliente.
    //desde aqui hago las implementaciones
    //con encapsulo metodos y clases.(las oculto al cliente)
    class Abstraccion
    {
        int _tipo;
        double _x, _y;
        IOperacion _operacion;
        public Abstraccion(int tipo, double x, double y)
        {
            _tipo = tipo;
            _x = x;
            _y = y;
        }

        public double Operar()
        {
            if (_tipo == 1)       
                _operacion = new CSuma();                      
            if (_tipo == 2)
                _operacion = new CResta();       
            if (_tipo == 3)        
                _operacion = new CMulti();
            if (_tipo == 4)
                _operacion = new CDiv();

            return _operacion.Operacion(_x, _y);
        }
    }
}
