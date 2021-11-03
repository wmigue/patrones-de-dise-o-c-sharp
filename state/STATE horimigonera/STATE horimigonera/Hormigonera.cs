using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_hormigonera
{
    public class Hormigonera
    {
        public int Arena { get; set; }
        public int Piedra { get; set; }
        public IEstado EstadoActual { get; set; }
        public IEstado EstadoEsperando { get; set; }
        public IEstado EstadoDosificando { get; set; }
        public IEstado EstadoAbortando { get; set; }
        public IEstado EstadoCargandoTolvas { get; set; }

        public Hormigonera ()
        {
            Piedra = 1000;
            Arena = 1000;
            EstadoEsperando = new EstadoEsperando(this);
            EstadoDosificando= new EstadoDosificando(this);
            EstadoAbortando= new EstadoAbortando(this);
            EstadoCargandoTolvas = new EstadoCargandoTolvas(this);
            EstadoActual= EstadoEsperando;
        }
        public void Esperar()
        {
            EstadoActual.Esperar();
        }
        public void Dosificar()
        {
            EstadoActual.Dosificar();
        }
        public void Abortar()
        {
            EstadoActual.Abortar();
        }
        public void CargarTolvas()
        {
            EstadoActual.CargarTolvas();
        }
        public override string ToString()
        {
            return EstadoActual.ToString();
        }
    }
}
