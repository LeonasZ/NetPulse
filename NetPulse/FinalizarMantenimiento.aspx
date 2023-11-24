<%@ Page Title="" Language="C#" MasterPageFile="~/MasterTecnico.Master" AutoEventWireup="true" CodeBehind="FinalizarMantenimiento.aspx.cs" Inherits="NetPulse.FinalizarMantenimiento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin: 20px">
        <h3>Finalizar Mantenimiento</h3>
    </div>
    <div style="margin:20px">
        <div class="mb-3">
            <label for="InputComentarios" class="form-label">Comentarios</label>
            <asp:TextBox type="text" class="form-control" id="TextComentarios" runat="server" MaxLength="255"></asp:TextBox>          
            
        </div>

        <div class="mb-3 form-check">
            <asp:CheckBox type="checkbox" class="form-check-input" id="CheckRealizado" runat="server"></asp:CheckBox>
            <label class="form-check-label" for="CheckRealizado">Realizado</label> 
        </div>
        <asp:Button type="submit" class="btn btn-primary" ID="btnFinalizar" runat="server" Text="Registrar Visita" OnClick="btnFinalizar_Click" />
    </div>
</asp:Content>
