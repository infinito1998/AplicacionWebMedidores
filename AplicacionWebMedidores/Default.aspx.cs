using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MedidoresWebModel.DAL;
using MedidoresWebModel.DTO;

namespace AplicacionWebMedidores
{
    public partial class Default : System.Web.UI.Page
    {
        private IMedidoresDAL medidoresDAL = new MedidoresDALObjetos();
        private IConsumoMedidoresDAL lecturaDAL = new ConsumoMedidoresDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                List<Medidores> medidores = medidoresDAL.ObtenerMedidores();
                List<Medidores> medidor = medidoresDAL.Obtener(); ;

                if (medidor.Count ==0) {
                    
                    medidor.AddRange(medidores);
                }
                
                this.medidoresDdl.DataSource = medidor;
                this.medidoresDdl.DataTextField = "idMedidor";
                    this.medidoresDdl.DataValueField = "idMedidor";
                this.medidoresDdl.DataBind();
                }
                

                    

            
        }

        protected void agregarBtn_Click(object sender, EventArgs e)
        {
            //1. Obtener los datos del formulario
           
            string medidores = this.medidoresDdl.SelectedItem.Text; 
            string hora = this.horaTxt.Text.Trim();
            string minutos = this.minutoTxt.Text.Trim();
            DateTime fecha = Calendar.SelectedDate;
            try { 
            int consumo = Convert.ToInt32(this.consumoTxt.Text);
                if ((consumo >= 0 && consumo <= 600))
                {
                    string tipo = this.medidoresDdl.SelectedValue;
                    //2. construir el objeto de tipo cliente
                    List<Medidores> medidor = medidoresDAL.Obtener();
                    Medidores medidor1 = medidor.Find(b => b.IdMedidor == this.medidoresDdl.SelectedItem.Value);
                    CultureInfo Culture = new CultureInfo("es-ES");
                    try
                    {
                        DateTime fechaActual = Convert.ToDateTime(fecha.Day + "/" + fecha.Month + "/" + fecha.Year + " " + hora + ":" + minutos);
                        Lectura lectura = new Lectura()
                        {
                            IdMedidor = medidores,
                            Tipo = medidor1.Tipo,
                            Fecha = fechaActual,
                            Consumo = consumo
                        };
                        //3. Llamar al DAL
                        lecturaDAL.Agregar(lectura);
                        //4. Mostrar mensajae de exito
                       
                        this.mensajeLbl.Text = ("Agregado exitosamente");
                        
                        Response.Redirect("VerMedidor.aspx");
                        
                    }
                    catch(Exception ex){
                        Response.Write("<script language=javascript>alert('Error, Fecha Incorrecta');</script>");
                    }
                   
                   
                }
                
          
            }
            catch (Exception ex)
            {
                Response.Write("<script language=javascript>alert('Error, Cantidad Incorrecta');</script>");
            }
        }
    }
}