﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public interface IIterator
    {
        public bool haySiguiente();
        public string next();
        public string back();
        public int getPosicion();


    }
}
