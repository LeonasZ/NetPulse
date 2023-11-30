<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NetPulse.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin: 20px">
        <h3>Lista De CLientes</h3>    
    <asp:GridView ID="dgvListaClientes" runat="server" CssClass="table table-bordered table-responsive  ">
    </asp:GridView>
    </div>
    <div style="margin: 20px">

        <div>
            <h3>Busqueda de Cliente</h3>

            <asp:Label Style="margin-bottom: 10px" ID="Label1" runat="server" Text="Filtrar DNI"></asp:Label>

            <div style="margin-bottom: 10px; margin-top: 10px" class="col-3">
                <label class="visually-hidden" for="inlineFormInputGroupUsername">DNI</label>
                <asp:TextBox ID="inputDNI" class="form-control" placeholder="0" runat="server"></asp:TextBox>
            </div>

            <div style="margin-bottom: 10px" class="col-12">
                <asp:Button ID="btnBuscarDni" runat="server" Text="Buscar" type="submit" class="btn btn-primary" OnClick="btnBuscarDni_Click" />
            </div>

            <asp:Label Style="color: darkgray" ID="LabelEstado" runat="server" Text="Disponibilidad..."></asp:Label>

        </div>

        <div>
            <asp:Label ID="LabelActivo" runat="server" Text="" Visible="false"></asp:Label>
            <%
                if (LabelActivo.Text == "Activo")
                {

            %>
            <asp:GridView ID="dgvUsuarioEncontrado" runat="server" CssClass="table table-bordered table-responsive" AutoGenerateColumns="false" OnRowCommand="DgvListaClientesActivos_RowCommand">

                <Columns>
                    <asp:BoundField HeaderText="IdServicio" DataField="IdServicio" />
                    <asp:BoundField HeaderText="Nombre" DataField="Cliente.Nombre" />
                    <asp:BoundField HeaderText="Domicilio" DataField="Domicilio.Direccion" />
                    <asp:BoundField HeaderText="Dni" DataField="Cliente.Dni" />
                    <asp:BoundField HeaderText="Telefono" DataField="Cliente.Telefono" />
                    <asp:BoundField HeaderText="Fecha Alta Servicio" DataField="FechaAlta" />
                    <asp:CheckBoxField HeaderText="Estado" DataField="Estado" />

                    <asp:ButtonField HeaderText="Modificar" Text="Modificar" ButtonType="Link" CommandName="Modificar_onClick" />
                    <asp:ButtonField HeaderText="Baja" Text="Baja" ButtonType="Link" CommandName="BajaLogica_onClick" />
                    <asp:ButtonField HeaderText="Agregar Servicio" Text="Agregar" ButtonType="Link" CommandName="agendarMantenimiento_onClick" />
                    <asp:ButtonField HeaderText="Historial de Modificaciones" Text="Ver" ButtonType="Link" CommandName="Historial_onClick" />
                </Columns>

            </asp:GridView>
            <%} %>
                
        </div>

        <div style="margin: 20px 0px">
            <h3>Funcionalidades</h3>
            <asp:Button Style=" display: block; margin-bottom: 20px" ID="btnAgregarNuevo" runat="server" Text="Agregar Nuevo Cliente" type="submit" class="btn btn-primary" OnClick="btnAgregarNuevo_Click" />

        </div>

    </div>

</asp:Content>
