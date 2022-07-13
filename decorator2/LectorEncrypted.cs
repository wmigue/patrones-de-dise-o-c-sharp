using System;

namespace decorator2
{
    class LectorEncrypted : LectorDecora
    {
        public LectorEncrypted(ILectora lectora) : base(lectora) { }
        public override string Leer()
        {
            string type = base.Leer();
            type += " Encriptada";
            return type;
        }
    }

}

