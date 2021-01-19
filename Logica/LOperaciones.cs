using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;
using Data;

namespace Logica
{
    public class LOperaciones
    {
        public DataTable ejecutar(EPrueba pPrueba)
        {

            DOperaciones dOperaciones = new DOperaciones();

            return dOperaciones.ejecutar(pPrueba);

        }
    }
}
