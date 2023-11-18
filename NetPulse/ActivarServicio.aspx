<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="ActivarServicio.aspx.cs" Inherits="NetPulse.ActivarServicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="display-5" style="text-align: left; margin: 20px">Datos domicilio </h1>
<div class="row g-3" style="margin: 50px">
    <div class="col-md-6">
        <label for="inputDireccion" class="form-label">Direccion</label>
        <asp:TextBox type="text" class="form-control" ID="inputDireccion" placeholder="Calle 123" runat="server"></asp:TextBox>

    </div>
    <div class="col-md-6">
        <label for="inputBarrio" class="form-label">Barrio</label>
        <asp:TextBox type="text" class="form-control" ID="inputBarrio" placeholder="Barrio" runat="server"></asp:TextBox>
    </div>
    <div class="col-6">
        <label for="inputCiudad" class="form-label">Ciudad</label>
        <asp:TextBox type="text" class="form-control" ID="inputCiudad" placeholder="Ciudad" runat="server"></asp:TextBox>
    </div>
    <div class="col-6">
        <label for="inputComentarios" class="form-label">Comentarios</label>
        <asp:TextBox type="text" class="form-control" ID="inputComentarios" placeholder="Comentarios..." runat="server"></asp:TextBox>
    </div>
   
    
    <div class="col-12">
    </div>
</div>
    <h1 class="display-5" style="text-align: left; margin: 20px">Plan elegido</h1>
<div class="row g-3" style="margin: 100px">
    <div class="col-12">
        <label for="inputState" class="form-label">Plan</label>
        <asp:DropDownList ID="DDLPlanes" runat="server" class="form-select" AutoPostBack="true"></asp:DropDownList>
    </div>
    <div class="col-6">
        <label for="inputIdPlan" class="form-label">ID</label>
        <asp:TextBox type="text" class="form-control" ID="inputIdPlan" placeholder="someone@example.com" ReadOnly="true" runat="server"></asp:TextBox>
    </div>
    <div class="col-6">
        <label for="inputCantMegas" class="form-label">CantMegas</label>
        <asp:TextBox type="text" class="form-control" ID="inputCantMegas" placeholder="XX-XXX-XXX" ReadOnly="true" runat="server"></asp:TextBox>
    </div>
    <div class="col-6">
        <label for="inputPrecio" class="form-label">Precio</label>
        <asp:TextBox type="text" class="form-control" ID="inputPrecio" placeholder="XX-XXX-XXX" ReadOnly="true" runat="server"></asp:TextBox>
    </div>
    <div class="col-12">
            <asp:Button ID="ActivarServicio" runat="server" Text="Activar" type="submit" class="btn btn-success" OnClick="Activar_Click" />

    </div>

</div>
        <h1 class="display-5" style="text-align: left; margin: 20px">Forma de pago</h1>
</asp:Content>
