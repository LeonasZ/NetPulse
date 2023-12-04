﻿<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="GestionEstados.aspx.cs" Inherits="NetPulse.GestionEstados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin: 20px">
        <h3>Administrador de Estados Transitorios</h3>
    </div>
    <div style="margin: 20px">
        <h3>Operaciones pendientes a aprobacion</h3>
        <asp:Label ID="Label1" runat="server" Text="dgv operaciones a aprobar"></asp:Label>
    </div>
    <div style="margin: 40px 20px">
        <h3>Servicios pendientes a Mantenimientos</h3>
        <asp:GridView ID="dgvPendienteInstalacion" runat="server" CssClass="table table-bordered table-responsive table-warning" AutoGenerateColumns="false" BorderColor="Blue">
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