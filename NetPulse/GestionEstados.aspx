<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="GestionEstados.aspx.cs" Inherits="NetPulse.GestionEstados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta3/css/all.min.css" rel="stylesheet">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin: 20px">
        <h3>Administrador de Estados Transitorios</h3>
    </div>
    <div style="margin: 20px">
        <h3>Servicios pendientes a Activacion</h3>
        <asp:GridView ID="dgvPendienteActivacion" runat="server" CssClass="table table-bordered table-responsive table-primary" AutoGenerateColumns="false" BorderColor="Blue" OnRowCommand="DgvListaServiciosPendientes_RowCommand">
            <Columns>
                <asp:BoundField HeaderText="IdServicio" DataField="IdServicio" />
                <asp:BoundField HeaderText="Cliente" DataField="Cliente.Nombre" />
                <asp:BoundField HeaderText="FormaPago" DataField="AbonoMensual.FormaPago.Nombre" />
                <asp:BoundField HeaderText="CantMegas" DataField="Plan.CantidadMegas" />
                <asp:BoundField HeaderText="Direccion" DataField="Domicilio.Direccion" />
                <asp:BoundField HeaderText="FechaAlta" DataField="FechaAlta" />
                <asp:BoundField HeaderText="Estado" DataField="Estado.Descripcion" />
                <asp:BoundField HeaderText="Comentarios" DataField="Comentarios" />
                <asp:ButtonField HeaderText="Activar" ButtonType="Link" Text='<i class="fa-solid fa-arrow-right"></i> Activar' CommandName="btnActivar_OnClick"  ControlStyle-CssClass="btn btn-primary"/>
            </Columns>
        </asp:GridView>
       
    </div>
    <div style="margin: 40px 20px">
        <h3>Servicios pendientes a Mantenimientos</h3>
        <asp:GridView ID="dgvPendienteInstalacion" runat="server" CssClass="table table-bordered table-responsive table-warning" AutoGenerateColumns="false" BorderColor="Black">
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

     <div style="margin: 40px 20px">
     <h3>Mantenimientos a Aprobar</h3>
     <asp:GridView ID="dgvServiciosAprobar" runat="server" CssClass="table table-bordered table-responsive table-primary" AutoGenerateColumns="false" BorderColor="Black" OnSelectedIndexChanged="dgvServiciosAprobar_SelectedIndexChanged" OnRowCommand="dgvServiciosAprobar_RowCommand">
         <Columns>
             <asp:BoundField HeaderText="IdServicio" DataField="IdServicio" />
             <asp:BoundField HeaderText="Cliente" DataField="Cliente.Nombre" />
             <asp:BoundField HeaderText="FormaPago" DataField="AbonoMensual.FormaPago.Nombre" />
             <asp:BoundField HeaderText="CantMegas" DataField="Plan.CantidadMegas" />
             <asp:BoundField HeaderText="Direccion" DataField="Domicilio.Direccion" />
             <asp:BoundField HeaderText="FechaAlta" DataField="FechaAlta" />
             <asp:BoundField HeaderText="Estado" DataField="Estado.Descripcion" />
             <asp:BoundField HeaderText="Comentarios" DataField="Comentarios" />
             <asp:ButtonField HeaderText="Aprobar" Text="Aprobar" CommandName="Aprobar_onClick"/>
         </Columns>
     </asp:GridView>
 </div>
</asp:Content>
