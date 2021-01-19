using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Logica;
namespace Prueba
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EPrueba objEPrueba = new EPrueba();
            objEPrueba.edad = 200;
            objEPrueba.sexo = "Masculino";

            LOperaciones objLOperaciones = new LOperaciones();


            GridUsuarios.DataSource = objLOperaciones.ejecutar(objEPrueba);
      
            GridUsuarios.DataBind();

            
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}