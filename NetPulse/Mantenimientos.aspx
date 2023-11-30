<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Mantenimientos.aspx.cs" Inherits="NetPulse.Mantenimientos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div style="margin: 20px">
        <div style="margin-bottom: 20px">
            <h3>Mantenimientos Pendientes</h3>
        </div>
        <asp:GridView ID="dgvListaMantenimientosPendientes" runat="server" CssClass="table table-bordered table-responsive " AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField HeaderText="IdMantenimiento" DataField="IdMantenimiento" />
                <asp:BoundField HeaderText="IdServicio" DataField="IdServicio" />
                <asp:BoundField HeaderText="Fecha" DataField="Fecha" />
                <asp:BoundField HeaderText="TecnicoACargo" DataField="Tecnico.Nombre" />
                <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" />
                <asp:BoundField HeaderText="TipoMantenimiento" DataField="TipoMantenimiento.Nombre" />
                <asp:BoundField HeaderText="Comentario" DataField="Comentarios" />
                <asp:CheckBoxField HeaderText="Estado" DataField="EstadoRealizacion" />

            </Columns>
        </asp:GridView>
    </div>

    <div style="margin: 20px">
        <div style="margin-bottom: 20px">
            <h3>Mantenimientos Realizados</h3>
        </div>
        <asp:GridView ID="dgvListaMantenimientosRealizados" runat="server" CssClass="table table-bordered table-responsive " AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField HeaderText="IdMantenimiento" DataField="IdMantenimiento" />
                <asp:BoundField HeaderText="IdServicio" DataField="IdServicio" />
                <asp:BoundField HeaderText="FechaRealizado" DataField="FechaRealizado" />
                <asp:BoundField HeaderText="TecnicoACargo" DataField="Tecnico.Nombre" />
                <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" />
                <asp:BoundField HeaderText="TipoMantenimiento" DataField="TipoMantenimiento.Nombre" />
                <asp:BoundField HeaderText="Comentario" DataField="Comentarios" />
                <asp:CheckBoxField HeaderText="Estado" DataField="EstadoRealizacion" />

            </Columns>
        </asp:GridView>
    </div>

    <div style=" margin: 20px">
        <h3>Funcionalidades</h3>
        <asp:Button ID="BtnAgendarMantenimiento" style="margin: 20px 0px;display:block" type="submit" class="btn btn-primary" runat="server" Text="Agendar Mantenimiento" OnClick="BtnAgendarMantenimiento_Click" />
        <asp:Button ID="btnHistorialMantenimientos" type="submit" class="btn btn-primary" runat="server" Text="Historial de Mantenimientos" OnClick="btnHistorialMantenimientos_Click" />
    </div>
    

</asp:Content>
