﻿<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Reclamos.aspx.cs" Inherits="NetPulse.Reclamos" %>

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
        <asp:CheckBox ID="cbxResolucionTelefonica" runat="server" AutoPostBack="true" />
        <asp:Label ID="lblResolucionTelefonica" runat="server" Text="Resolucion Telefonica"></asp:Label>
    </div>

    <div style="margin: 20px">
        <asp:CheckBox ID="cbxMantenimiento" runat="server" AutoPostBack="true" />
        <asp:Label ID="lblMantenimiento" runat="server" Text="Agendar Mantenimiento"></asp:Label>
    </div>

    <asp:Label ID="lblEstado" runat="server" Text="1" Visible="false"></asp:Label>

    <%if (lblEstado.Text == "2")
        {  %>
    <div class="row g-3" style="margin: 20px">
        <label class="form-label">Prioridad</label>
        <asp:DropDownList ID="DDLPrioridad" runat="server" class="form-select" AutoPostBack="true"></asp:DropDownList>
    </div>

    <div class="row g-3" style="margin: 20px">
        <label class="form-label">Tecnico</label>
        <asp:DropDownList ID="DDLTecnicos" runat="server" class="form-select" AutoPostBack="true"></asp:DropDownList>
    </div>
    <%} %>
    <asp:Button ID="btnReclamos" Style="margin: 20px" type="submit" CssClass="btn btn-primary" runat="server" Text="Finalizar" OnClick="btnReclamo_Click" />
    <asp:Button ID="btnVolver" type="submit" CssClass="btn btn-primary" runat="server" Text="Volver" OnClick="btnVolver_Click" />
    <div style="margin:20px">
        <asp:Label ID="lblSuccess" runat="server" Visible="false" ForeColor="Green" Text="Mantenimiento Agregado con exito"></asp:Label>
    </div>
    
    <div style="margin: 40px 20px">
        <h3>Historial de Reclamos</h3>
        <%-- Ver de poner un dgv solo con el historial de reclamos y mantenimientos de este cliente --%>
    </div>
    <asp:Label ID="Label1" runat="server" Text="GridView..."></asp:Label>
</asp:Content>
