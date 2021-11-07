using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_method
{
    class NotebookOffice:INotebook
    {
        string _var = "procesador: i5, ram: 16GB, placa video: integrada intel HD ";
        public string getCaracteristicas()
        {
            return _var;
        }
    }
}
