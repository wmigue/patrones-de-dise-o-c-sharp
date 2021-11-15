using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using consolas.saver;


namespace consolas.juegos
{
    public interface IBridge
    {
        void CorrerJuego();
        string getGeneracion();
        void setNombreJugador(string n);
        public string getNombreJugador();
        public int getVidas();
        public void ReducirVida();
        public void setVida(int v, string n);

    }
}
