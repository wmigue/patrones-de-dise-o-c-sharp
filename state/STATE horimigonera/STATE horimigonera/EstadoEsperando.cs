using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_hormigonera
{
    class EstadoEsperando : IEstado
    {
        private Hormigonera _hormigonera;

        public EstadoEsperando(Hormigonera hormigonera)
        {
            _hormigonera = hormigonera;
        }
        public void Esperar()
        {
            Console.WriteLine("Ya estás en estado de espera, no se puede cambiar de estado.");
            this.ToString();
        }
        public void Dosificar()
        {
            if (_hormigonera.Piedra >= 1000 && _hormigonera.Arena >= 1000)
            {
                Console.WriteLine("Dosificando el hormigón... se consumieron 500kg de piedra y 500kg de arena");
                _hormigonera.Piedra -= 500;
                _hormigonera.Arena -= 500;
                _hormigonera.EstadoActual = _hormigonera.EstadoDosificando;
            }
            else
            {
                Console.WriteLine("No tenés suficiente arena = {0} o piedra = {1}", _hormigonera.Arena, _hormigonera.Piedra);
            }
            this.ToString();

        }
        public void Abortar()
        {
            Console.WriteLine("No podés abortar porque estas en estado de espera.");
            this.ToString();
        }
        public void CargarTolvas()
        {
            Console.WriteLine("Cargando tolvas...");
            _hormigonera.Piedra += 1000;
            _hormigonera.Arena += 1000;
            _hormigonera.EstadoActual = _hormigonera.EstadoCargandoTolvas;
            this.ToString();
        }
        public override string ToString()
        {
            return $"PIEDRA STOCK: {_hormigonera.Piedra}, ARENA STOCK: {_hormigonera.Arena}";
        }

    

    } 

}
