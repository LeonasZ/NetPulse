﻿<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="AltaServicio.aspx.cs" Inherits="NetPulse.AltaServicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="display-5" style="text-align: left; margin: 20px">Alta de Servicio </h1>


    <div style="margin: 40px 20px">

        <h3>Busqueda de Usuario</h3>

        <asp:Label Style="margin-bottom: 10px" ID="Label1" runat="server" Text="Filtrar DNI"></asp:Label>

        <div style="margin-bottom: 10px; margin-top: 10px" class="col-3">
            <label class="visually-hidden" for="inlineFormInputGroupUsername">DNI</label>
            <asp:TextBox ID="inputDNI" class="form-control" placeholder="0" runat="server"></asp:TextBox>
        </div>

        <div style="margin-bottom: 10px" class="col-12">
            <asp:Button ID="btnBuscarDni" runat="server" Text="Buscar" type="submit" class="btn btn-primary" OnClick="btnBuscarDni_Click" />
        </div>

        <asp:Label Style="color: darkgray" ID="LabelEstado" runat="server" Text="Disponibilidad..."></asp:Label>

    </div>
    <div style="margin: 20px">
        <h3>Usuario Encontrado</h3>
        <asp:GridView ID="dgvUsuarioEncontrado" DataKeyNames="IdServicio" runat="server" CssClass="table table-bordered table-responsive" AutoGenerateColumns="false" OnSelectedIndexChanged="dgvUsuarioEncontrado_SelectedIndexChanged">
            <Columns>
                <asp:BoundField HeaderText="IdServicio" DataField="IdServicio" />
                <asp:BoundField HeaderText="Nombre" DataField="Cliente.Nombre" />
                <asp:BoundField HeaderText="Domicilio" DataField="Domicilio.Direccion" />
                <asp:BoundField HeaderText="Dni" DataField="Cliente.Dni" />
                <asp:BoundField HeaderText="Telefono" DataField="Cliente.Telefono" />
                <asp:BoundField HeaderText="Fecha Alta Servicio" DataField="FechaAlta" />
                <asp:CommandField HeaderText="Agendar Mantenimiento" SelectText="Agendar" ShowSelectButton="true" />

            </Columns>
        </asp:GridView>
    </div>
    <%--<table class="table">
            <thead>
                <tr>
                    <th scope="col">IdServicio</th>
                    <th scope="col">Nombre</th>
                    <th scope="col">Domicilio</th>
                    <th scope="col">Dni</th>
                    <th scope="col">Telefono</th>
                    <th scope="col">Fecha Alta Servicio</th>
                    <th scope="col">Modificar Servicio</th>
                    <th scope="col">Agendar Mantenimiento</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <th scope="row">
                        <asp:Label ID="lblIdServicio" runat="server" Text=""></asp:Label></th>
                    <td>
                        <asp:Label ID="lblNombre" runat="server" Text=""></asp:Label></td>
                    <td>
                        <asp:Label ID="lblDomicilio" runat="server" Text=""></asp:Label></td>
                    <td>
                        <asp:Label ID="lblDni" runat="server" Text=""></asp:Label></td>
                    <td>
                        <asp:Label ID="lblTelefono" runat="server" Text=""></asp:Label></td>
                    <td>
                        <asp:Label ID="lblFechaAlta" runat="server" Text=""></asp:Label></td>
                    <td>
                        <asp:LinkButton ID="lnkBtnModificar" runat="server" Visible="false" OnClick="lnkBtnModificar_Click">Modificar</asp:LinkButton></td>
                    <td>
                        <asp:LinkButton ID="lnkBtnMantenimiento" runat="server" Visible="false" OnClick="lnkBtnMantenimiento_Click">Mantenimiento</asp:LinkButton></td>
                </tr>
            </tbody>
        </table>
    </div>--%>
    <div style="margin: 20px">
        <h3>Usuarios Inactivos</h3>
        <asp:GridView ID="dgvListaClientesInactivos" DataKeyNames="IdCliente" runat="server" CssClass="table table-bordered table-responsive" AutoGenerateColumns="false" OnSelectedIndexChanged="dgvListaClientesInactivos_SelectedIndexChanged">
            <Columns>
                <asp:BoundField HeaderText="IdCliente" DataField="IdCliente" />
                <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                <asp:BoundField HeaderText="Telefono" DataField="Telefono" />
                <asp:BoundField HeaderText="Dni" DataField="Dni" />
                <asp:BoundField HeaderText="FechaAlta" DataField="FechaAlta" />
                <asp:CommandField HeaderText="Activar Servicio" SelectText="Activar" ShowSelectButton="true" />

            </Columns>
        </asp:GridView>
    </div>


    <div style="margin: 40px 20px">

        <h3>Funcionalidades</h3>

        <asp:Button Style="margin: 20px 0px; display: block; margin-bottom: 20px" ID="btnAgregarNuevo" runat="server" Text="Agregar Nuevo Cliente" type="submit" class="btn btn-primary" OnClick="btnAgregarNuevo_Click" />





    </div>
</asp:Content>



