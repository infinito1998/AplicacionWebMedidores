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
    public partial class VerMedidores : System.Web.UI.Page
    {
        private IMedidoresDAL medidoresDAL = new MedidoresDALObjetos();
        private IConsumoMedidoresDAL consumoDAL = new ConsumoMedidoresDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargaGrilla();
                
            }
        }


        private void cargaGrilla()
        {
            List<Medidores> medidores = medidoresDAL.ObtenerMedidores();
            List<Medidores> medidor = medidoresDAL.Obtener(); ;

            if (medidor.Count == 0)
            {

                medidor.AddRange(medidores);
            }
            this.grillaClientes.DataSource = medidor;
            this.grillaClientes.DataBind();
        }
        private void cargaGrilla(List<Medidores> filtrada)
        {
            List<Medidores> medidores = medidoresDAL.ObtenerMedidores();
            List<Medidores> medidor = medidoresDAL.Obtener(); ;

            if (medidor.Count == 0)
            {

                medidor.AddRange(medidores);
            }
            this.grillaClientes.DataSource = filtrada;
            this.grillaClientes.DataBind();
        }
        protected void grillaClientes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "eliminar")
            {
                //significa que el usuario apreto el boton eliminar
                //por tanto, tengo que eliminar el cliente
                string rut = Convert.ToString(e.CommandArgument);
                consumoDAL.Eliminar(rut);
                cargaGrilla();
            }
        }

        protected void nivelDdl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tipoDdl.SelectedItem != null)
            {
                
                string nivel = this.tipoDdl.SelectedItem.Value;
                //filtrar por nivel
                List<Medidores> filtrada = medidoresDAL.Filtrar(nivel);
                cargaGrilla(filtrada);
                

                
            }

        }
        protected void recargar_Click(object sender, EventArgs e)
        {
            Response.Redirect("VerMedidores.aspx");
        }

    }
}
