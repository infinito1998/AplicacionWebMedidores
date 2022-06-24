<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AgregarMedidor.aspx.cs" Inherits="AplicacionWebMedidores.AgregarMedidor" %>
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
                        <label for="medidorid"><b> Ingrese numero de Medidor: </b></label>
                        <asp:TextBox ID="medidorid" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="TipoTxt"><b> Ingrese Tipo: </b></label>
                        <asp:DropDownList runat="server" ID="TipoTxt" CssClass="form-control">
                            <asp:ListItem Value="Medidor" Text="Medidor"></asp:ListItem>
                            <asp:ListItem Value="No Medidor" Text="No Medidor"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    
                    <div class="form-group">
                        <asp:Button runat="server" ID="agregarBtn" Text="Agregar" CssClass="btn btn-primary" OnClick="agregarBtn_Click"/>
                    </div>

                </div>
            </div>
        </div>
    </div>
</asp:Content>