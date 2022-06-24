<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerMedidores.aspx.cs" Inherits="AplicacionWebMedidores.VerMedidores" %>
<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-danger text-white">
                    <h3>Ver Medidores</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for ="tipoDdl"> Filtrar por Tipo de Medidor: </label>
                        <asp:DropDownList AutoPostBack="true" OnSelectedIndexChanged="nivelDdl_SelectedIndexChanged" runat="server" ID="tipoDdl">
                            <asp:ListItem Value="Medidor" Text="Medidor"></asp:ListItem>
                            <asp:ListItem Value="No Medidor" Text="No Medidor"></asp:ListItem>
                        </asp:DropDownList>
                        <asp:Button ID="recargar" runat="server" Text="Recargar" OnClick="recargar_Click"/>
                    </div>
                    
  
                    <asp:GridView CssClass="table table-hover table-bordered mt-5" 
                        OnRowCommand="grillaClientes_RowCommand"
                        EmptyDataText="No hay Medidores Ingresados" ShowHeader="true"
                        AutoGenerateColumns="false" runat="server" ID="grillaClientes">
                       <Columns>
                           <asp:BoundField DataField="tipo" HeaderText="Tipo" />
                           <asp:BoundField DataField="idMedidor" HeaderText="Numero de Medidor" />
                       </Columns>
                    </asp:GridView>
                
                
                    </div>
            </div>
        </div>
    </div>
</asp:Content>
