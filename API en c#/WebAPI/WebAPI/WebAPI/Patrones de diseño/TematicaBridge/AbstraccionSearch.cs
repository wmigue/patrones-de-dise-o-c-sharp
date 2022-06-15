
using System;
using System.Collections.Generic;
using System.Text;
using WebAPI.Models;

namespace WebAPI
{    public class AbstraccionSearch
    {
        string _string;
        ITema _tema;
        List<string> _windows10 = new Windows10().GetLista();
        List<string> _visualstudio = new VisualStudio().GetLista();
        public AbstraccionSearch(string s)
        {
             _string = s;
        }
        public string Ejecutar()
        {
            foreach(string iterador in _windows10)
            {
                if (_string == iterador)
                {
                    _tema = new Windows10();
                    _string = _tema.Ejecucion();
                }
            }
            foreach (string iterador in _visualstudio)
            {
                if (_string == iterador)
                {
                    _tema = new VisualStudio();
                    _string = _tema.Ejecucion();
                }
            }

            return _string;
        }
        
    }

}