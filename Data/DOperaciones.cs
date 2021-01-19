using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Data
{
    public class DOperaciones : DConexion //La clase hereda las propiedades de la clase DConexion
    {
        //devuelve un datatable con la informacion de la tabla de la BD 
        //para ello debe haber una entidad definida con los campos de la tabla
        public DataTable ejecutar(EPrueba pPrueba)
        {
            DataTable vDatos = new DataTable(); //DataTable para la carga de datos
            SqlDataAdapter vAdaptador = new SqlDataAdapter(); //Actua como puente para recuperar los datos de la BD
            SqlCommand vOcmd = null; //es lo que indica al sistema que se trata una sentencia sql
            try
            {
                vOcmd = new SqlCommand();
                vOcmd.Connection = oCnx; //se define la conexion con el campo de la clase padre
                vOcmd.CommandText = "PRC_PRUEBA"; //el comando que se ejecutara 
                vOcmd.CommandType = CommandType.StoredProcedure; //el tipo de comando que se esta definiciendo se agrega cuando es un SP

                //se setea con los valores de la entidad
                //Los parametros del procedimiento almacenado, indicando tambien el tipo de dato
                vOcmd.Parameters.AddWithValue("@pSexo", SqlDbType.NVarChar).Value = pPrueba.sexo; 
                vOcmd.Parameters.AddWithValue("@pEdad", SqlDbType.Int).Value = pPrueba.edad;

                abrirConexion(); //se abre la conexion a la vd

                vAdaptador.SelectCommand = vOcmd;//para seleccionar los registros de la Bd y luego setearlos

                vAdaptador.Fill(vDatos); //Fill, para llenar el DataTable con los datos que trae de la BD


            }
            catch (Exception)
            {
                throw;
            }
            finally //sirve para liberar de recursos al sistema como archivos abiertos, o conexiones a BD
            {
                cerrarConexion();//se cierra la conexion a la BD
            }
            return vDatos;
        }
    }
}
