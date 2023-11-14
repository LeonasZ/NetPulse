<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="AltaServicio.aspx.cs" Inherits="NetPulse.AltaServicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="display-5" style="text-align: left; margin: 20px">ALTA DE SERVICIO </h1>

    <div class="row row-cols-lg-auto g-3 align-items-center" style="margin: 40px 20px">

        <asp:Label ID="Label1" runat="server" Text="Filtrar DNI"></asp:Label>
        <div class="col-12">
            <label class="visually-hidden" for="inlineFormInputGroupUsername">DNI</label>
            <input type="text" class="form-control" id="inlineFormInputGroupUsername" placeholder="DNI">
        </div>

        <div class="col-12">
            <asp:Button ID="btnBuscarDni" runat="server" Text="Buscar" type="submit" class="btn btn-primary" OnClick="btnBuscarDni_Click" />
        </div>
        <asp:Label Style="color: darkgray" ID="Label2" runat="server" Text="Disponibilidad..."></asp:Label>
    </div>

    <asp:GridView ID="dgvListaClientesInactivos" runat="server" CssClass="table table-bordered table-responsive" AutoGenerateColumns ="false">
        <Columns>
            <asp:BoundField HeaderText="IdCliente" DataField="IdCliente" />
            <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
            <asp:BoundField HeaderText="Telefono" DataField="Telefono" />
            <asp:BoundField HeaderText="Dni" DataField="Dni" />
            <asp:BoundField HeaderText="FechaAlta" DataField="FechaAlta" />
            <asp:ButtonField HeaderText="Activar Servicio" ButtonType="Button" Text ="Activar" />
            
        </Columns>
    </asp:GridView>
    <div class="row row-cols-lg-auto g-3 align-items-center" style="margin: 40px 20px">
        <asp:Button Style="margin: 40px 20px; display: block; margin-bottom: 20px" ID="btnAgregarNuevo" runat="server" Text="Agregar Nuevo" type="submit" class="btn btn-primary" OnClick="btnAgregarNuevo_Click" />

        <asp:Button Style="margin: 40px 20px; display: block; margin-bottom: 20px" ID="btnReincorporar" runat="server" Text="Activar" type="submit" class="btn btn-primary" OnClick="btnReincorporar_Click" />

        <asp:Button Style="margin: 40px 20px; display: block; margin-bottom: 20px" ID="btnAgregarPlan" runat="server" Text="AgregarPlan" type="submit" class="btn btn-primary" OnClick="btnAgregarPlan_Click" />

        <asp:Button Style="margin: 40px 20px; display: block; margin-bottom: 20px" ID="btnAgregarDomicilio" runat="server" Text="AgregarDomicilio" type="submit" class="btn btn-primary" OnClick="btnAgregarDomicilio_Click" />
    </div>

</asp:Content>



