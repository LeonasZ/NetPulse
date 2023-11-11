<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="AgregarTecnico.aspx.cs" Inherits="NetPulse.AgregarTecnico" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h2>Agregar Técnico</h2>
        <asp:Label ID="lblMensaje" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <asp:TextBox ID="txtNombre" runat="server" placeholder="Nombre" Required="true"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtContacto" runat="server" placeholder="Contacto" Required="true"></asp:TextBox>
        <br />
        <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
    </div>
</asp:Content>
