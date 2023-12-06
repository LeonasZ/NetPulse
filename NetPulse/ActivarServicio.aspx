﻿<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="ActivarServicio.aspx.cs" Inherits="NetPulse.ActivarServicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin: 20px">
        <h3>Agregar Servicio</h3>
    </div>

    <div class="col-3" style="margin: 20px 20px; display: block">
        <asp:Button ID="AgregarDireccion" runat="server" Text="Agregar Direccion" type="submit" CssClass="btn btn-primary" OnClick="AgregarDireccion_Click" />
    </div>
    <div class="col-3" style="margin: 20px 20px; display: block">
        <asp:Button ID="AgregarPlan" runat="server" Text="Agregar Plan" type="submit" CssClass="btn btn-primary" OnClick="AgregarPlan_Click" />
    </div>
    <div class="col-3" style="margin: 20px 20px; display: block">
        <asp:Button ID="AgregarFormaDePago" runat="server" Text="Agregar Forma de Pago" type="submit" CssClass="btn btn-primary" OnClick="AgregarFormaDePago_Click" />
    </div>

    <div style="margin: 20px">

        <asp:GridView ID="DgvDatos" runat="server" CssClass="table table-bordered table-responsive table-success" AutoGenerateColumns="false" BorderColor="Green">
            <Columns>
                <asp:BoundField HeaderText="Direccion" DataField="Domicilio.Direccion" />
                <asp:BoundField HeaderText="Barrio" DataField="Domicilio.Barrio" />
                <asp:BoundField HeaderText="Ciudad" DataField="Domicilio.Ciudad" />
                <asp:BoundField HeaderText="Comentario" DataField="Domicilio.Comentario" />

                <asp:BoundField HeaderText="Plan" DataField="Plan.Nombre" />
                <asp:BoundField HeaderText="CantMegas" DataField="Plan.CantidadMegas" />
                <asp:BoundField HeaderText="Precio" DataField="Plan.Precio" />

                <asp:BoundField HeaderText="Forma Pago" DataField="AbonoMensual.FormaPago.Nombre" />
            </Columns>
        </asp:GridView>

    </div>

    <div class="col-3" style="margin: 60px 20px; display: block">
        <asp:Button ID="btnFinalizar" runat="server" Text="Agregar" type="submit" CssClass="btn btn-primary" OnClick="Finalizar_Click" Visible="false" />
        <asp:Button ID="btnVolver" runat="server" Text="Volver" type="submit" CssClass="btn btn-primary" Visible="false" OnClick="btnVolver_Click" />
    </div>

    <div style="margin:20px">
        <asp:Label ID="lblSuccess" runat="server" ForeColor="Green" Visible="false" Text="Servicio Agregado Con Exito!"></asp:Label>
    </div>
    


    <asp:Label ID="Label1" runat="server" Text="Crear Dgv Historial de modificaciones. Para eso 
  crear una nueva tabla en db con las modificaciones"></asp:Label>
</asp:Content>

