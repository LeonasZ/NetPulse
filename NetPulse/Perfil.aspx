<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="NetPulse.Perfil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .container {
            margin: 20px;
        }
        .form-title {
            text-align: center;
            font-size: 24px;
            font-weight: bold;
        }
        .text-field {
            width: 100%;
            padding: 10px;
            margin-bottom: 10px;
            border: 1px solid #ccc;
            border-radius: 5px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="form-title">Perfil</div>
        <asp:Label runat="server" Text="Nombre"></asp:Label>
        <asp:TextBox ID="lblNombre" runat="server" CssClass="text-field" Enabled="false"></asp:TextBox>
        <asp:Label runat="server" Text="Apellido"></asp:Label>
        <asp:TextBox ID="lblApellido" runat="server" CssClass="text-field" Enabled="false"></asp:TextBox>
        <asp:Label runat="server" Text="Usuario"></asp:Label>
        <asp:TextBox ID="lblUsuario" runat="server" CssClass="text-field" Enabled="false"></asp:TextBox>
        <asp:Label runat="server" Text="Mail"></asp:Label>
        <asp:TextBox ID="lblMail" runat="server" CssClass="text-field" Enabled="false"></asp:TextBox>
        <asp:Label runat="server" Text="Teléfono"></asp:Label>
        <asp:TextBox ID="lblTelefono" runat="server" CssClass="text-field" Enabled="false"></asp:TextBox>
        <asp:Label runat="server" Text="Tipo Usuario"></asp:Label>
        <asp:TextBox ID="lblTipo" runat="server" CssClass="text-field" Enabled="false"></asp:TextBox>

        <asp:Label ID="lblUser" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>

