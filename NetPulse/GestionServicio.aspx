<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="GestionServicio.aspx.cs" Inherits="NetPulse.GestionServicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div style="margin: 60px 20px">
        <h3>Detalle Servicio</h3>
        <asp:GridView ID="dgvDatosCliente" runat="server" CssClass="table table-bordered table-responsive table-success" AutoGenerateColumns="false" BorderColor="Green">
            <Columns>
                <asp:BoundField HeaderText="Cliente" DataField="Nombre" />
                <asp:BoundField HeaderText="Telefono" DataField="Telefono" />
                <asp:BoundField HeaderText="Mail" DataField="Mail" />
                <asp:BoundField HeaderText="Dni" DataField="Dni" />
                <asp:BoundField HeaderText="Fecha Alta Cliente" DataField="FechaAlta" />
            </Columns>
        </asp:GridView>

        <asp:GridView ID="DgvDomicilio" runat="server" CssClass="table table-bordered table-responsive table-success" AutoGenerateColumns="false" BorderColor="Green">
            <Columns>
                <asp:BoundField HeaderText="Direccion" DataField="Direccion" />
                <asp:BoundField HeaderText="Barrio" DataField="Barrio" />
                <asp:BoundField HeaderText="Ciudad" DataField="Ciudad" />
                <asp:BoundField HeaderText="Comentario sobre el domicilio" DataField="Comentario" />
            </Columns>
        </asp:GridView>

        <asp:GridView ID="DgvPlan" runat="server" CssClass="table table-bordered table-responsive table-success" AutoGenerateColumns="false" BorderColor="Green">
            <Columns>
                <asp:BoundField HeaderText="Nombre plan" DataField="Nombre" />
                <asp:BoundField HeaderText="Cantidad de Megas" DataField="CantidadMegas" />
                <asp:BoundField HeaderText="Precio" DataField="Precio" />
            </Columns>
        </asp:GridView>
        <asp:GridView ID="DgvFormaPago" runat="server" CssClass="table table-bordered table-responsive table-success" AutoGenerateColumns="false" BorderColor="Green">
            <Columns>
                <asp:BoundField HeaderText="Forma de Pago" DataField="Nombre" />
            </Columns>
        </asp:GridView>
    </div>

    <div style="margin: 20px">
        <h3>Modificar Servicio</h3>
    </div>

    <div style="margin: 20px 20px;">
        <asp:Button ID="ModificarDireccion" runat="server" Text="Modificar Direccion" type="submit" CssClass="btn btn-primary" OnClick="ModificarDireccion_Click" />
        <asp:Button ID="ModificarPlan" runat="server" Text="Modificar Plan" type="submit" CssClass="btn btn-primary" OnClick="ModificarPlan_Click" />
        <asp:Button ID="ModificarFormaDePago" runat="server" Text="Modificar Forma de Pago" type="submit" CssClass="btn btn-primary" OnClick="ModificarFormaDePago_Click" />
        <asp:Button ID="DardeBaja" runat="server" Text="Baja del Servicio" type="submit" CssClass="btn btn-primary" OnClick="DardeBaja_Click" />
        <asp:Button ID="btnAgendarMantenimiento" runat="server" Text="Registrar Reclamo" type="submit" CssClass="btn btn-primary" Enabled="true" OnClick="btnAgendarMantenimiento_Click" />
    </div>


    <div style="margin: 60px 20px">
        <h3>Historial </h3>
        <asp:GridView ID="dgvHistorialServicio" runat="server" CssClass="table table-bordered table-responsive table-warning" AutoGenerateColumns="false" BorderColor="Yellow">
            <Columns>
                <asp:BoundField HeaderText="Fecha" DataField="Fecha" />
                <asp:BoundField HeaderText="TipoCambio" DataField="TipoCambio.Descripcion" />
            </Columns>
        </asp:GridView>
    </div>

    <div style="margin: 60px 20px">
        <asp:Button ID="btnCancelar" runat="server" type="submit" class="btn btn-primary" Text="Volver" OnClick="btnCancelar_Click" />
    </div>
</asp:Content>
