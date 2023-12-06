<%@ Page Title="" Language="C#" MasterPageFile="~/MasterTecnico.Master" AutoEventWireup="true" CodeBehind="MainTecnico.aspx.cs" Inherits="NetPulse.MainTecnico" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta3/css/all.min.css" rel="stylesheet">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin: 20px">
        <div style="margin-bottom: 20px">
            <h3>Mantenimientos Pendientes</h3>
        </div>

        <asp:GridView ID="dgvPrioridadAlta" DataKeyNames="IdServicio" runat="server" CssClass="table table-bordered table-responsive table-danger " AutoGenerateColumns="false" OnRowCommand="dgvListaMantenimientosPendientes_RowCommand">
            <Columns>
                <asp:BoundField HeaderText="IdMantenimiento" DataField="IdMantenimiento" />
                <asp:BoundField HeaderText="IdServicio" DataField="IdServicio" />
                <asp:BoundField HeaderText="Fecha" DataField="Fecha" />
                <asp:BoundField HeaderText="TecnicoACargo" DataField="Tecnico.Nombre" />
                <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" />
                <asp:BoundField HeaderText="TipoMantenimiento" DataField="TipoMantenimiento.Nombre" />
                <asp:BoundField HeaderText="Comentario" DataField="Comentarios" />
                <asp:CheckBoxField HeaderText="Estado" DataField="EstadoRealizacion" />

                <asp:TemplateField HeaderText="Info Del Usuario">
                    <ItemTemplate>
                        <asp:LinkButton ID="btnInfoUsuario" runat="server" CommandName="Info_onClick" CssClass="btn btn-secondary">
                            <span class="fa-solid fa-bars" style="margin-right: 5px;"></span>Ver
                        </asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Finalizar Mantenimiento">
                    <ItemTemplate>
                        <asp:LinkButton ID="btnFinalizar" runat="server" CommandName="Finalizar_onClick" CssClass="btn btn-primary" Text="Finalizar"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>

    <div style="margin: 20px">
    <asp:GridView ID="dgvPrioridadBaja" DataKeyNames="IdServicio" runat="server" CssClass="table table-bordered table-responsive table-primary  " AutoGenerateColumns="false" OnRowCommand="dgvListaMantenimientosPendientes_RowCommand">
        <Columns>
            <asp:BoundField HeaderText="IdMantenimiento" DataField="IdMantenimiento" />
            <asp:BoundField HeaderText="IdServicio" DataField="IdServicio" />
            <asp:BoundField HeaderText="Fecha" DataField="Fecha" />
            <asp:BoundField HeaderText="TecnicoACargo" DataField="Tecnico.Nombre" />
            <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" />
            <asp:BoundField HeaderText="TipoMantenimiento" DataField="TipoMantenimiento.Nombre" />
            <asp:BoundField HeaderText="Comentario" DataField="Comentarios" />
            <asp:CheckBoxField HeaderText="Estado" DataField="EstadoRealizacion" />

            <asp:TemplateField HeaderText="Info Del Usuario">
                <ItemTemplate>
                    <asp:LinkButton ID="btnInfoUsuario" runat="server" CommandName="Info_onClick" CssClass="btn btn-secondary">
                        <span class="fa-solid fa-bars" style="margin-right: 5px;"></span>Ver
                    </asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Finalizar Mantenimiento">
                <ItemTemplate>
                    <asp:LinkButton ID="btnFinalizar" runat="server" CommandName="Finalizar_onClick" CssClass="btn btn-primary" Text="Finalizar"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    </div>

    <hr>

    <div style="margin: 20px">
        <div style="margin-bottom: 20px">
            <h3>Mantenimientos Realizados</h3>
        </div>
        <asp:GridView ID="dgvListaMantenimientosRealizados" runat="server" CssClass="table table-bordered table-responsive table-success " AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField HeaderText="IdMantenimiento" DataField="IdMantenimiento" />
                <asp:BoundField HeaderText="IdServicio" DataField="IdServicio" />
                <asp:BoundField HeaderText="Fecha" DataField="Fecha" />
                <asp:BoundField HeaderText="FechaRealizado" DataField="FechaRealizado" />
                <asp:BoundField HeaderText="TecnicoACargo" DataField="Tecnico.Nombre" />
                <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" />
                <asp:BoundField HeaderText="TipoMantenimiento" DataField="TipoMantenimiento.Nombre" />
                <asp:BoundField HeaderText="Comentario" DataField="Comentarios" />
                <asp:CheckBoxField HeaderText="Estado" DataField="EstadoRealizacion" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
