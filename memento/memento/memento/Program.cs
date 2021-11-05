using System;

namespace memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Origen origen = new Origen("estado1");
            Almacenador almacenador = new Almacenador(origen);

            origen.NuevaAccion("bienvenido");
            almacenador.Backup();
            origen.NuevaAccion("otra cosa");
            almacenador.Backup();
            origen.NuevaAccion("buenos aires");
            almacenador.Backup();
            origen.NuevaAccion("avion");
            almacenador.Backup();
            origen.NuevaAccion("programame esta");
            almacenador.Backup();

            almacenador.Historial();
            almacenador.EstadoActual();
            almacenador.Restore();
            almacenador.Restore();
            almacenador.Restore();
            almacenador.EstadoActual();
            almacenador.Historial();
            origen.NuevaAccion("depuerando");
            almacenador.Backup();
            origen.NuevaAccion("testando");
            almacenador.Backup();
            almacenador.EstadoActual();
            almacenador.Historial();
            almacenador.Restore();
            almacenador.Restore();
            almacenador.EstadoActual();
        }
    }
}
