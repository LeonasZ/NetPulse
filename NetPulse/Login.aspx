﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="NetPulse.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Login</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js"></script>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <style>
        .wrapper {
            display: flex;
            align-items: center;
            flex-direction: column;
            justify-content: center;
            width: 100%;
            min-height: 100%;
            padding: 20px;
        }

        #formcontent {
            -webkit-border-radius: 10px 10px 10px 10px;
            border-radius: 10px 10px 10px 10px;
            background: #fff;
            padding: 30px;
            width: 90%;
            max-width: 450px;
            position: relative;
            padding: 0px;
            -webkit-box-shadow: 0 30px 60px 0 rgba(0,0,0,0.3);
            box-shadow: 0 30px 60px 0 rgba(0,0,0,0.3);
            text-align: center;
        }
    </style>
</head>
<body class="bg-light">
    <div class="wrapper">
        <div class="formcontent">
            <form id="formLogin" runat="server">
                <div class="form-control">
                    <div>
                        <asp:Label ID="lblUser" runat="server" Text="Usuario:"></asp:Label>
                        <asp:TextBox ID="tbUser" runat="server" placeholder="Nombre de usuario" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div>
                        <asp:Label ID="lblPass" runat="server" Text="Contraseña:"></asp:Label>
                        <asp:TextBox ID="tbPass" runat="server" placeholder="Contraseña" CssClass="form-control"></asp:TextBox>
                    </div>
                    <hr />
                    <div class="row">
                        <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" CssClass="btn btn-primary btn-dark" OnClick="btnIngresar_Click" />
                    </div>
                </div>
            </form>
        </div>
    </div>
</body>
</html>
