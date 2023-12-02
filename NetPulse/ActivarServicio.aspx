<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="ActivarServicio.aspx.cs" Inherits="NetPulse.ActivarServicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div style="margin: 20px">
     <h3>Agregar Servicio</h3>
 </div>

 <div class="col-3" style="margin: 20px 20px; display: block">
     <asp:Button ID="AgregarDireccion" runat="server" Text="Agregar Direccion" type="submit" CssClass="btn btn-primary" OnClick="AgregarDireccion_Click" />
 </div>
 <div class="col-3" style="margin: 20px 20px; display: block">
     <asp:Button ID="AgregarPlan" runat="server" Text="Modificar Plan" type="submit" CssClass="btn btn-primary" OnClick="AgregarPlan_Click" />
 </div>
 <div class="col-3" style="margin: 20px 20px; display: block">
     <asp:Button ID="AgregarFormaDePago" runat="server" Text="Agregar Forma de Pago" type="submit" CssClass="btn btn-primary" OnClick="AgregarFormaDePago_Click" />
 </div>

 <div class="col-3" style="margin: 60px 20px; display: block">
     <asp:Button ID="btnFinalizar" runat="server" Text="Finalizar" type="submit" CssClass="btn btn-primary" OnClick="Finalizar_Click" Enabled="false" />
 </div>

 <asp:Label ID="Label1" runat="server" Text="Crear Dgv Historial de modificaciones. Para eso 
  crear una nueva tabla en db con las modificaciones"></asp:Label>
</asp:Content>

