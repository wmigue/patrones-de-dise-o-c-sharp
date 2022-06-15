
using System;
using System.Collections.Generic;
using System.Text;
using WebAPI.Models;

namespace WebAPI
{

    public class Windows10:ITema
    {
        string[] windows10 = { "wwin10",  "win1",  "wwindows10", "widow" };
        List<string> _lista;
        public Windows10()
        {
            _lista = new List<string>(windows10);
        }
        public List<string> GetLista()
        {
            return _lista;
        }
        public string Ejecucion()
        {
            return "Windows 10";
        }
    }

}