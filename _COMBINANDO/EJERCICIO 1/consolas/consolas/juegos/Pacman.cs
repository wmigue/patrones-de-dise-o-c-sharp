using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using consolas.saver;

namespace consolas.juegos
{
    class Pacman : IBridge
    {
        public string _nombre = "PACMAN X";
        public string _generacion;
        public string _nombreJugador=null;
        public int _vida = 300;
        public Pacman(string g)
        {
            _generacion = g;
     
            if (_generacion == "1")
                _generacion = "PRIMERA";
            if (_generacion == "2")
                _generacion = "SEGUNDA";
        }
        public void CorrerJuego()
        {
            Console.WriteLine($"ejecutando... Juego: {_nombre}, generacion: {_generacion}");
        }
        public string getGeneracion()
        {
            return _generacion;
        }

        public void setNombreJugador(string n)
        {
            _nombreJugador = n;
        }
        public string getNombreJugador()
        {
            return _nombreJugador;
        }
        public int getVidas()
        {
            return _vida;
        }
        public void ReducirVida()
        {
            _vida = _vida - 50;
            Console.WriteLine($"vida actual: {_vida}");
        }
        public void setVida(int v, string n)
        {
            _nombreJugador = n;
            _vida = v;
        }
    }

}
