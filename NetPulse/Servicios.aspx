<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Servicios.aspx.cs" Inherits="NetPulse.Servicios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1 class="display-5" style="text-align: left; margin: 20px">Administrador De Servicios</h1>
    <div style="margin: 20px">
        <h3>Usuarios Sin Servicio Asociado</h3>
        <asp:GridView ID="dgvListaClientesInactivos" DataKeyNames="IdCliente" runat="server" CssClass="table table-bordered table-responsive" AutoGenerateColumns="false" OnSelectedIndexChanged="dgvListaClientesInactivos_SelectedIndexChanged">
            <Columns>
                <asp:BoundField HeaderText="IdCliente" DataField="IdCliente" />
                <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                <asp:BoundField HeaderText="Telefono" DataField="Telefono" />
                <asp:BoundField HeaderText="Dni" DataField="Dni" />
                <asp:BoundField HeaderText="FechaAlta" DataField="FechaAlta" />
                <asp:CommandField HeaderText="Agregar Servicio" SelectText="Agregar" ShowSelectButton="true" />

            </Columns>
        </asp:GridView>
    </div>

    <div style="margin: 60px 20px">

        <h3>Busqueda de Servicios</h3>

        <asp:Label Style="margin-bottom: 10px" ID="Label1" runat="server" Text="Filtrar DNI"></asp:Label>

        <div style="margin-bottom: 10px; margin-top: 10px" class="col-3">
            <label class="visually-hidden" for="inlineFormInputGroupUsername">DNI</label>
            <asp:TextBox ID="inputDNI" class="form-control" placeholder="0" runat="server"></asp:TextBox>
        </div>

        <div style="margin-bottom: 10px" class="col-12">
            <asp:Button ID="btnBuscarDni" runat="server" Text="Buscar" type="submit" class="btn btn-primary" OnClick="btnBuscarDni_Click" />
        </div>

        <asp:Label Style="color: darkgray" ID="LabelEstado" runat="server" Text="Disponibilidad..."></asp:Label>


        <div style="margin:20px 0px">
            <asp:Label ID="LabelActivo" runat="server" Text="" Visible="false"></asp:Label>
            <%
                if (LabelActivo.Text == "Activo")
                {

            %>
            <asp:GridView ID="dgvServicioEncontrado" runat="server" CssClass="table table-bordered table-responsive" AutoGenerateColumns="false" OnRowCommand="DgvListaServiciosActivos_RowCommand">

                <Columns>
                    <asp:BoundField HeaderText="IdServicio" DataField="IdServicio" />
                    <asp:BoundField HeaderText="Nombre" DataField="Cliente.Nombre" />
                    <asp:BoundField HeaderText="Domicilio" DataField="Domicilio.Direccion" />
                    <asp:BoundField HeaderText="Dni" DataField="Cliente.Dni" />
                    <asp:BoundField HeaderText="Telefono" DataField="Cliente.Telefono" />
                    <asp:BoundField HeaderText="Fecha Alta Servicio" DataField="FechaAlta" />
                    <asp:CheckBoxField HeaderText="Estado" DataField="Estado" />

                    <asp:ButtonField HeaderText="Modificar" Text="Modificar" ButtonType="Link" CommandName="Modificar_onClick" />
                </Columns>

            </asp:GridView>
            <%}
                if (LabelActivo.Text == "Inactivo")
                {


            %>
            <asp:GridView ID="dgvServicioInactivo" runat="server" CssClass="table table-bordered table-responsive" AutoGenerateColumns="false" OnRowCommand="DgvListaServiciosInactivos_RowCommand">

                <Columns>
                    <asp:BoundField HeaderText="IdServicio" DataField="IdServicio" />
                    <asp:BoundField HeaderText="Nombre" DataField="Cliente.Nombre" />
                    <asp:BoundField HeaderText="Domicilio" DataField="Domicilio.Direccion" />
                    <asp:BoundField HeaderText="Dni" DataField="Cliente.Dni" />
                    <asp:BoundField HeaderText="Telefono" DataField="Cliente.Telefono" />
                    <asp:BoundField HeaderText="Fecha Alta Servicio" DataField="FechaAlta" />
                    <asp:CheckBoxField HeaderText="Estado" DataField="Estado" />

                    <asp:ButtonField HeaderText="Activar" Text="Activar" ButtonType="Link" CommandName="Activar_onClick" />

                </Columns>

            </asp:GridView>
            <%}
            %>
        </div>

    </div>

    <div style="margin: 60px 20px">
    <h3>Lista de Servicios</h3>
    <asp:GridView ID="dgvListaServicios" runat="server" CssClass="table table-bordered table-responsive " AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField HeaderText="IdServicio" DataField="IdServicio" />
            <asp:BoundField HeaderText="Cliente" DataField="Cliente.Nombre" />
            <asp:BoundField HeaderText="FormaPago" DataField="AbonoMensual.FormaPago.Nombre" />
            <asp:BoundField HeaderText="CantMegas" DataField="Plan.CantidadMegas" />
            <asp:BoundField HeaderText="Direccion" DataField="Domicilio.Direccion" />
            <asp:BoundField HeaderText="FechaAlta" DataField="FechaAlta" />
            <asp:CheckBoxField HeaderText="Estado" DataField="Estado" />
            <asp:BoundField HeaderText="Comentarios" DataField="Comentarios" />
        </Columns>
    </asp:GridView>
</div>

</asp:Content>
