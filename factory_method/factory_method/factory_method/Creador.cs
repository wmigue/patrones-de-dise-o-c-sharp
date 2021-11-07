using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_method
{
    class Creador
    {
        public static INotebook Fabricar(int opcion)
        {
            if (opcion == 1)
                return new NotebookOffice();
            else if (opcion == 2)
                return new NotebookGamer();
            else
                return null;
        }
        
    }
}