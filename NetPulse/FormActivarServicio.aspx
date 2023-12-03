<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="FormActivarServicio.aspx.cs" Inherits="NetPulse.FormActivarServicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin: 60px 20px">
    <h3>Servicio Encontrado</h3>
    <asp:GridView ID="dgvServicio" runat="server" CssClass="table table-bordered table-responsive table-primary" AutoGenerateColumns="false" BorderColor="Blue">
        <Columns>
            <asp:BoundField HeaderText="IdServicio" DataField="IdServicio" />
            <asp:BoundField HeaderText="Cliente" DataField="Cliente.Nombre" />
            <asp:BoundField HeaderText="FormaPago" DataField="AbonoMensual.FormaPago.Nombre" />
            <asp:BoundField HeaderText="CantMegas" DataField="Plan.CantidadMegas" />
            <asp:BoundField HeaderText="Direccion" DataField="Domicilio.Direccion" />
            <asp:BoundField HeaderText="FechaAlta" DataField="FechaAlta" />
            <asp:BoundField HeaderText="Estado" DataField="Estado.Descripcion" />
            <asp:BoundField HeaderText="Comentarios" DataField="Comentarios" />
            <asp:ButtonField HeaderText="Activar" ButtonType="Link" Text="Activar" CommandName="btnActivar_OnClick"  />
        </Columns>
    </asp:GridView>
</div>
    <div>
        <asp:Button ID="Button1" runat="server" Text="Aceptar" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Cancelar" />
    </div>
    

</asp:Content>
