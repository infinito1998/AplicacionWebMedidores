<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerMedidor.aspx.cs" Inherits="AplicacionWebMedidores.VerMedidor" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-danger text-white">
                    <h3>Ver Consumo</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for ="tipoDdl"> Filtrar por Id Medidor: </label>
                        <asp:DropDownList AutoPostBack="true" OnSelectedIndexChanged="nivelDdl_SelectedIndexChanged" runat="server" ID="tipoDdl">
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
                           <asp:BoundField DataField="fecha" HeaderText="fecha" />
                           <asp:BoundField DataField="consumo" HeaderText="consumo" />
                           <asp:TemplateField>
                               <ItemTemplate>
                                   <asp:Button CommandName="eliminar" 
                                       CommandArgument='<%# Eval("idMedidor") %>'
                                       runat="server" 
                                       CssClass="btn btn-danger" Text="Eliminar" />
                               </ItemTemplate>
                           </asp:TemplateField>
                       </Columns>
                    </asp:GridView>
                
                
    
<asp:Chart ID="Chart1" runat="server" DataSourceID="ObjectDataSource3">
        <Series>
            <asp:Series Name="Series1" XValueMember="Fecha" YValueMembers="Consumo" ChartType="Line"></asp:Series>
        </Series>
        <ChartAreas>
            <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
        </ChartAreas>
    </asp:Chart>
    <asp:ObjectDataSource runat="server" ID="ObjectDataSource3" SelectMethod="Obtener" TypeName="MedidoresWebModel.DAL.ConsumoMedidoresDALObjetos"></asp:ObjectDataSource>
                    </div>
            </div>
        </div>
    </div>
</asp:Content>
