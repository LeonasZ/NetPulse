<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="ModificarServicio.aspx.cs" Inherits="NetPulse.ModificarServicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div style="margin: 20px">
        <h3>Domicilio</h3>
    </div>

    <div class="row g-3" style="margin: 20px">
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
            <asp:TextBox type="text" class="form-control" ID="inputComentarios" placeholder="Especificaciones sobre el domicilio..." runat="server"></asp:TextBox>
        </div>

    </div>

    <div style="margin: 20px">
        <h3>Plan Elegido</h3>
    </div>

    <div class="row g-3" style="margin: 20px">

        <div class="col-12">
            <label for="inputState" class="form-label">Plan</label>
            <asp:DropDownList ID="DDLPlanes" runat="server" class="form-select" AutoPostBack="true"></asp:DropDownList>
        </div>

        <div class="col-6">
            <label for="inputIdPlan" class="form-label">ID</label>
            <asp:TextBox type="text" class="form-control" ID="inputIdPlan" placeholder="someone@example.com" aria-label="Disabled input" ReadOnly="true" runat="server"></asp:TextBox>
        </div>

        <div class="col-6">
            <label for="inputCantMegas" class="form-label">CantMegas</label>
            <asp:TextBox type="text" class="form-control" ID="inputCantMegas" placeholder="XX-XXX-XXX" aria-label="Disabled input" ReadOnly="true" runat="server"></asp:TextBox>
        </div>

        <div class="col-6">
            <label for="inputPrecio" class="form-label">Precio</label>
            <asp:TextBox type="text" class="form-control" ID="inputPrecio" placeholder="XX-XXX-XXX" aria-label="Disabled input" ReadOnly="true" runat="server"></asp:TextBox>
        </div>

    </div>

    <div style="margin: 20px">
        <h3>Forma de Pago</h3>
    </div>

    <div class="row g-3" style="margin: 20px">
        <div class="col-12">
            <label for="inputPago" class="form-label">Medio de pago</label>
            <asp:DropDownList ID="DDLMedioDePago" runat="server" class="form-select" AutoPostBack="true"></asp:DropDownList>
        </div>

    </div>

    <div style="margin: 20px">
        <h3>Observaciones</h3>
    </div>

    <div class="row g-3" style="margin: 20px">
        <asp:TextBox type="text" class="form-control" ID="inputComentariosServicio" placeholder="Especificaciones sobre el servicio..." runat="server"></asp:TextBox>
    </div>

    <div class="col-3" style="margin: 20px;">
        <asp:Button ID="Modificar" runat="server" Text="Modificar" type="submit" CssClass="btn btn-success" />
    </div>

</asp:Content>
