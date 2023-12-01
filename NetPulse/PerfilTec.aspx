<%@ Page Title="" Language="C#" MasterPageFile="~/MasterTecnico.Master" AutoEventWireup="true" CodeBehind="PerfilTec.aspx.cs" Inherits="NetPulse.PerfilTec" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin: 20px">
        <asp:GridView ID="dgvPerfilTec" runat="server" CssClass="table table-bordered table-responsive">
        </asp:GridView>
        <asp:Label ID="lblUsuarioTec" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
