<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AplicacionWebMedidores.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="mensajes">
                <asp:Label runat="server" ID="mensajeLbl" CssClass="text-success"></asp:Label>
            </div>
            <div class="card">
                <div class="card-header bg-dark text-white">
                    <h3>Agregar Medidor</h3>
                </div>
               
                <div class="card-body">
                    <div class="form-group">
                        <label for="medidoresDAL"><b>Seleccione numero de Medidor:</b></label>
                        <asp:DropDownList runat="server" ID="medidoresDdl" CssClass="form-control">
                       
                        </asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label for="nombreTxt"><b>Fecha: </b></label><br />
                        <asp:Calendar ID="Calendar" runat="server"></asp:Calendar>
                          Hora:<asp:TextBox ID="horaTxt" CssClass="form-control" runat="server"></asp:TextBox> 
                          Minutos:<asp:TextBox ID="minutoTxt" CssClass="form-control" runat="server"></asp:TextBox> 
                    </div>
                 
                    <div class="form-group">
                        <label for="rutTxt"><b> Consumo: </b></label>
                        <asp:TextBox ID="consumoTxt" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    
                    
                    <div class="form-group">
                        <asp:Button runat="server" ID="agregarBtn" Text="Agregar" CssClass="btn btn-primary" OnClick="agregarBtn_Click"/>
                    </div>
                    <asp:RangeValidator id="Range1"
           ControlToValidate="consumoTxt"
           MinimumValue="0"
           MaximumValue="600"
           Type="Integer"
           EnableClientScript="false"
           Text="Ingrese una cantidad entre 0 y 600"
           runat="server"/>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
