using System;

namespace decorator2
{
    class LectorDecora : ILectora
    {
        private ILectora _lectora;
        public LectorDecora(ILectora lectora)
        {
            _lectora = lectora;
        }
        public virtual string Leer()
        {
            return _lectora.Leer();
        }
    }

}

