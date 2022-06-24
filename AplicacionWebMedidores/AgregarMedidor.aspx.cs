using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MedidoresWebModel.DAL;
using MedidoresWebModel.DTO;

namespace AplicacionWebMedidores
{
    public partial class AgregarMedidor : System.Web.UI.Page
    {
        private IMedidoresDAL medidoresDAL = new MedidoresDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void agregarBtn_Click(object sender, EventArgs e)
        {
            //1. Obtener los datos del formulario
            try { 
            string medidores = this.medidorid.Text.Trim();
            string tipo = this.TipoTxt.Text.Trim();
            //2. construir el objeto de tipo cliente
            
            Medidores addmedidor = new Medidores()
            {
                IdMedidor = medidores,
                Tipo = tipo
            };
            //3. Llamar al DAL

            medidoresDAL.Agregar(addmedidor);
            //4. Mostrar mensajae de exito
            this.mensajeLbl.Text = ("Agregado exitosamente");
            Response.Redirect("Default.aspx");
            }
            catch
            {
                Response.Write("<script language=javascript>alert('Error, Agregar Incorrecto');</script>");
            }
        }
    }
}