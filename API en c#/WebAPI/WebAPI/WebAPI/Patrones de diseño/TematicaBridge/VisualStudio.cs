
using System;
using System.Collections.Generic;
using System.Text;
using WebAPI.Models;

namespace WebAPI
{

    public class VisualStudio : ITema
    {
        string[] _visualstudio = { "vs", "visuals", "visualstu", "microsoft vs", "icrosoft" };
        List<string> _lista;
        public VisualStudio()
        {
            _lista = new List<string>(_visualstudio);
        }
        public List<string> GetLista()
        {
            return _lista;
        }
        public string Ejecucion()
        {
            return "visual studio";
        }
    }

}