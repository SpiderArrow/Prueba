using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Librerias para hacer uso de datos de una BD
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class DConexion
    {
        //instancia de una conexion sql
        protected SqlConnection oCnx = null;

        public DConexion()
        {
            //Se define la conexion (servidor, BD, Trusted*) *cuando es Windows Authentication
            oCnx = new SqlConnection(@"Server=STEVCODE\SQLEXPRESS01;Database=CursoSQL;Trusted_Connection=True;");

        }

        public void abrirConexion()
        {

            try
            {

                if (oCnx.State == ConnectionState.Closed || oCnx.State == ConnectionState.Broken) //Evalua el estado de la conexion
                    oCnx.Open(); // abre la conexion

            }
            catch (Exception e)
            {

                throw new Exception("error al abrir la conexion ", e); // excepcion por si falla
            }
        }

        public void cerrarConexion()
        {

            try
            {
                if (oCnx.State == ConnectionState.Open) // evalua el estado de la conexion
                    oCnx.Close();//cierra la conexion
            }
            catch (Exception e)
            {

                throw new Exception("error en cerrar la conexion ", e);
            }

        }

    }
}
