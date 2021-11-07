using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_method
{
    class NotebookGamer:INotebook
    {
        string _var = "procesador: i9, ram: 128GB, placa video: RTX3090 SUPER ";
        public string getCaracteristicas()
        {
            return _var;
        }
    }
}
