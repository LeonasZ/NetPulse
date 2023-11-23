<%@ Page Title="" Language="C#" MasterPageFile="~/MasterTecnico.Master" AutoEventWireup="true" CodeBehind="MainTecnico.aspx.cs" Inherits="NetPulse.MainTecnico" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin: 20px">
    <div style="margin-bottom: 20px">
        <h3>Mantenimientos Pendientes</h3>
    </div>
     
    <asp:GridView ID="dgvListaMantenimientosPendientes" runat="server" CssClass="table table-bordered table-responsive " AutoGenerateColumns="false" OnRowCommand="dgvListaMantenimientosPendientes_RowCommand" >
        <Columns>
            <asp:BoundField HeaderText="IdMantenimiento" DataField="IdMantenimiento" />
            <asp:BoundField HeaderText="IdServicio" DataField="IdServicio" />
            <asp:BoundField HeaderText="Fecha" DataField="Fecha" />
            <asp:BoundField HeaderText="TecnicoACargo" DataField="Tecnico.Nombre" />
            <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" />
            <asp:BoundField HeaderText="TipoMantenimiento" DataField="TipoMantenimiento.Nombre" />
            <asp:BoundField HeaderText="Comentario" DataField="Comentarios" />
            <asp:CheckBoxField HeaderText="Estado" DataField="EstadoRealizacion" />
                      
            
            <asp:ButtonField HeaderText="Info Del Usuario" Text="Ver" ButtonType="Link" CommandName="Info_onClick" />
            <asp:ButtonField HeaderText="Finalizar Mantenimiento" Text="Finalizar" ButtonType="Link" CommandName="Finalizar_onClick" />

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
            <asp:BoundField HeaderText="Fecha" DataField="Fecha" />
            <asp:BoundField HeaderText="TecnicoACargo" DataField="Tecnico.Nombre" />
            <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" />
            <asp:BoundField HeaderText="TipoMantenimiento" DataField="TipoMantenimiento.Nombre" />
            <asp:BoundField HeaderText="Comentario" DataField="Comentarios" />
            <asp:CheckBoxField HeaderText="Estado" DataField="EstadoRealizacion" />
        </Columns>
    </asp:GridView>
</div>
</asp:Content>
