using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_hormigonera
{
    class EstadoDosificando:IEstado
    {
        private Hormigonera _hormigonera;
        public EstadoDosificando(Hormigonera hormigonera)
        {
             _hormigonera=hormigonera;
        }
        public void Esperar()
        {
            Console.WriteLine("Se cambio de estado a ESPERA...");
            _hormigonera.EstadoActual = _hormigonera.EstadoEsperando;
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
                Console.WriteLine("No tenés suficiente arena o piedra. ambos deben ser mayor a 1000 kg.");
            }
            this.ToString();
        }
        public void Abortar()
        {
             Console.WriteLine("Se cambio de estado a Abortado...");
            _hormigonera.EstadoActual = _hormigonera.EstadoAbortando;
            this.ToString();
        }
        public void CargarTolvas()
        {
            Console.WriteLine("cargando tolvas, agregando 1000kg de piedra y otros 1000kg de arena...");
            _hormigonera.Piedra+=1000;
            _hormigonera.Arena += 1000;
            _hormigonera.EstadoActual = _hormigonera.EstadoCargandoTolvas;
            this.ToString();
        }
        public override string ToString()
        {
            return $"PIEDRA STOCK: {_hormigonera.Piedra}, ARENA STOCK: {_hormigonera.Arena} ";
        }


    }
}
