﻿<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Mantenimientos.aspx.cs" Inherits="NetPulse.Mantenimientos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <asp:GridView ID="dgvListaMantenimientos" runat="server" CssClass="table table-bordered table-responsive " AutoGenerateColumns ="false">

            <%
                foreach(var in item collection){
                
                }

                %>
        <Columns>
            <asp:BoundField HeaderText ="IdMantenimiento" DataField  ="IdMantenimiento"/>
            <asp:BoundField HeaderText ="IdServicio" DataField  ="IdServicio"/>
            <asp:BoundField HeaderText ="Fecha" DataField  ="Fecha"/>
            <asp:BoundField HeaderText ="TecnicoACargo" DataField  ="Tecnico.Nombre"/>
            <asp:BoundField HeaderText ="Descripcion" DataField  ="Descripcion"/>
            <asp:BoundField HeaderText ="TipoMantenimiento" DataField  ="TipoMantenimiento.Nombre"/>
            <asp:BoundField HeaderText ="Comentario" DataField  ="Comentarios"/>
            <asp:CheckBoxField HeaderText ="Estado" DataField ="EstadoRealizacion" />
        </Columns>


</asp:GridView>
</asp:Content>
