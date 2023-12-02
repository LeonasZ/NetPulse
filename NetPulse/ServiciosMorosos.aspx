<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="ServiciosMorosos.aspx.cs" Inherits="NetPulse.ServiciosMorosos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin: 20px">

    <h3>Busqueda de Servicios</h3>

    <asp:Label Style="margin-bottom: 10px" ID="Label1" runat="server" Text="Filtrar DNI"></asp:Label>

    <div style="margin-bottom: 10px; margin-top: 10px" class="col-3">
        <label class="visually-hidden" for="inlineFormInputGroupUsername">DNI</label>
        <asp:TextBox ID="inputDNI" class="form-control" placeholder="0" runat="server"></asp:TextBox>
    </div>

    <div style="margin-bottom: 10px" class="col-12">
        <asp:Button ID="btnBuscarDni" runat="server" Text="Buscar" type="submit" class="btn btn-primary" OnClick="btnBuscarDni_Click" />
    </div>
 </div>

    <div style="margin:60px 20px">
        <h3>Lista de Deudores</h3>
        <asp:GridView ID="dgvListaDeudores" runat="server" CssClass="table table-bordered table-responsive table-danger " AutoGenerateColumns="false" BorderColor="Red">
            <Columns>
                <asp:BoundField HeaderText="IdServicio" DataField="IdServicio" />
                <asp:BoundField HeaderText="Cliente" DataField="Cliente.Nombre" />
                <asp:BoundField HeaderText="FormaPago" DataField="AbonoMensual.FormaPago.Nombre" />
                <asp:BoundField HeaderText="CantMegas" DataField="Plan.CantidadMegas" />
                <asp:BoundField HeaderText="Direccion" DataField="Domicilio.Direccion" />
                <asp:BoundField HeaderText="FechaAlta" DataField="FechaAlta" />
                <asp:BoundField HeaderText="Estado" DataField="Estado.Descripcion" />
                <asp:BoundField HeaderText="Comentarios" DataField="Comentarios" />
            </Columns>
        </asp:GridView>
    </div>
    <div style="margin: 20px">
        <h3>Lista de Servicios Inactivos</h3>
        <asp:GridView ID="DgvListaInactivos" runat="server" CssClass="table table-bordered table-responsive table-danger" AutoGenerateColumns="false" BorderColor="Red">
            <Columns>
                <asp:BoundField HeaderText="IdServicio" DataField="IdServicio" />
                <asp:BoundField HeaderText="Cliente" DataField="Cliente.Nombre" />
                <asp:BoundField HeaderText="FormaPago" DataField="AbonoMensual.FormaPago.Nombre" />
                <asp:BoundField HeaderText="CantMegas" DataField="Plan.CantidadMegas" />
                <asp:BoundField HeaderText="Direccion" DataField="Domicilio.Direccion" />
                <asp:BoundField HeaderText="FechaAlta" DataField="FechaAlta" />
                <asp:BoundField HeaderText="Estado" DataField="Estado.Descripcion" />
                <asp:BoundField HeaderText="Comentarios" DataField="Comentarios" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
