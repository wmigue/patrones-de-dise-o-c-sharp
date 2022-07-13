using System;

namespace decorator2
{
    class LectoraArchivo : ILectora
    {
        public string Leer()
        {
            return "Lectura de archivo";
        }
    }

}

