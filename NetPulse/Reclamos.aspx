<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Reclamos.aspx.cs" Inherits="NetPulse.Reclamos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin: 20px">
        <h3>Gestion de Reclamos</h3>
    </div>
    <div class="row g-3" style="margin: 20px">
        <asp:TextBox type="text" class="form-control" ID="inputReclamos" placeholder="Causas..." runat="server"></asp:TextBox>
    </div>
    <div style="margin: 20px">
        <asp:CheckBox ID="cbxMantenimiento" runat="server" />
        <asp:Label ID="lblMantenimiento" runat="server" Text="Agendar Mantenimiento"></asp:Label>
    </div>

    <asp:Button ID="btnReclamos" Style="margin: 20px" type="submit" CssClass="btn btn-primary" runat="server" Text="Finalizar" OnClick="btnReclamo_Click" />

    <div style="margin: 40px 20px">
        <h3>Historial de Reclamos</h3>
    </div>
    <asp:Label ID="Label1" runat="server" Text="GridView..."></asp:Label>
</asp:Content>
