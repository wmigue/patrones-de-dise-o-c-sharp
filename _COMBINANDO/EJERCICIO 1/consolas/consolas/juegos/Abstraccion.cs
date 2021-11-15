using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using consolas.saver;

namespace consolas.juegos
{
    class Abstraccion
    {
        IBridge _juego;
        Consola _consola;
        int _restauraciones=3;

        public Abstraccion(string o, string g, Consola c)
        {
            _consola = c;

            if (o == "1")
                _juego = new Mario(g);
            if (o == "2")
                _juego = new Pacman(g);
        }
        public void setImplementacion(IBridge imp)
        {
            _juego = imp;
        }
        public void Ejecutar()
        {
            if (_consola._generacion == _juego.getGeneracion())
                _juego.CorrerJuego();
            else
                Console.WriteLine("el juego elegido elegido no es de de la misma generacion que la consola...");
        }
        public void SetJugador(string n)
        {
            if (_juego.getNombreJugador() == null)
            {
                _juego.setNombreJugador(n);
                Console.WriteLine($"se agrego tu nombre: {_juego.getNombreJugador()}");
            }
               
            else
                Console.WriteLine("error: ya existe un jugador jugando a ese juego.");
        }
        public string GetJugador()
        {
            return _juego.getNombreJugador();
        }
        public int getVida()
        {
            return _juego.getVidas();
        }
        public void reducirVida()
        {
            if(_restauraciones<=0)
                Console.WriteLine($"perdiste, no tenes mas vidas.");
            else
            {
                if (_juego.getVidas() == 0)
                    Console.WriteLine($"perdiste, no tenes mas vidas.");
                else
                {
                    _juego.ReducirVida();
                    if (_juego.getVidas() == 0)
                        Console.WriteLine($"perdiste, no tenes mas vidas.");
                    else
                        Console.WriteLine($"se redujo tu vida a : {_juego.getVidas()}");
                }
            }


        }
        public Memento getEstado()
        {
            return new Memento(_juego.getNombreJugador(), _juego.getVidas());
        }
        public void restauraJuego(IMemento m)
        {
                
                _restauraciones = _restauraciones-1;
                _juego.setVida(m.getV(), m.getN());         

        }
        public int getRestauraciones()
        {
            return _restauraciones;
        }

    }
}
