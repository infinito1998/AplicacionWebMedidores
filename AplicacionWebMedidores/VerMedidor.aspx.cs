using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.DataVisualization.Charting;
using System.Web.UI.WebControls;
using MedidoresWebModel.DAL;
using MedidoresWebModel.DTO;

namespace AplicacionWebMedidores
{
    public partial class VerMedidor : System.Web.UI.Page
    {
        private IMedidoresDAL medidoresDAL = new MedidoresDALObjetos();
        private IConsumoMedidoresDAL consumoDAL = new ConsumoMedidoresDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargaGrilla();
                List<Medidores> medidores = medidoresDAL.ObtenerMedidores();
                List<Medidores> medidor = medidoresDAL.Obtener(); ;

                if (medidor.Count == 0)
                {

                    medidor.AddRange(medidores);
                }

                this.tipoDdl.DataSource = medidor;
                this.tipoDdl.DataTextField = "idMedidor";
                this.tipoDdl.DataValueField = "idMedidor";
                this.tipoDdl.DataBind();
            }
        }
            

        private void cargaGrilla()
        {
            List<Lectura> lectura = consumoDAL.Obtener();
            this.grillaClientes.DataSource = lectura;
            this.grillaClientes.DataBind();
        }
        private void cargaGrilla(List<Lectura> filtrada)
        {
            List<Lectura> clientes = consumoDAL.Obtener();
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
                List<Lectura> filtrada = consumoDAL.Filtrar(nivel);
                cargaGrilla(filtrada);
                List<Medidores> medidores = medidoresDAL.ObtenerMedidores();
                this.Chart1.DataSource = 1;
                this.Chart1.DataBind();
            }
        
        }
        protected void recargar_Click(object sender, EventArgs e)
        {
            Response.Redirect("VerMedidor.aspx");
        }
       
    }

        
}