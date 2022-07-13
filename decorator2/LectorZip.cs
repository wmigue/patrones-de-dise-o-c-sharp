using System;

namespace decorator2
{
    class LectorZIP : LectorDecora
    {
        public LectorZIP(ILectora lectora) : base(lectora) { }
        public override string Leer()
        {
            string type = base.Leer();
            type += " con ZIP";
            return type;
        }
    }

}

