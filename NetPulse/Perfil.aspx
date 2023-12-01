<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="NetPulse.Perfil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin: 20px">
        <asp:GridView ID="dgvPerfiles" runat="server" CssClass="table table-bordered table-responsive">
        </asp:GridView>
        <asp:Label ID="lblUsuario" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
