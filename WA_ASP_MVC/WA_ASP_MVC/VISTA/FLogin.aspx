<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FLogin.aspx.cs" Inherits="WA_ASP_MVC.VISTA.FLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../Recursos/Content/Bootstrap/bootstrap.css" rel="stylesheet" />
    <script src="../Recursos/Scripts/Bootstrap/bootstrap.js"></script>
    <script src="../Recursos/Scripts/Jquery/jquery-1.12.4.js"></script>
    <title></title>
</head>
<body>
    <div class="container">
        <div class="jumbotron-fluid bg-primary text-center text-white">
            <h2>ACCESO AL SISTEMA</h2>
        </div>
        <form id="form1" runat="server">
            <div>
                <label>TIPO DE USUARIO </label>
                <asp:DropDownList ID="DropDownList1" runat="server">
                </asp:DropDownList>
                &nbsp;
                <asp:TextBox ID="txtPrivilegio" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>EMAIL</label>
                <asp:TextBox ID="txtEmail" runat="server" CssClass="text-body"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>PASSWORD</label>
                <asp:TextBox ID="txtPassword" runat="server" CssClass="text-body" TextMode="Password"></asp:TextBox>
            </div>
            <br />
            <div class="form-group">
                <asp:Button ID="btnAcceder" runat="server" CssClass="btn btn-danger" Text="Acceder" OnClick="btnAcceder_Click" />
                <a class="btn btn-success" href="#">Registrarme</a>
            </div>
        </form>
    </div>
</body>
</html>
