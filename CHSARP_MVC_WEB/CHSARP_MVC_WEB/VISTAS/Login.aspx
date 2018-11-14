<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CHSARP_MVC_WEB.VISTAS.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
      <link href="../RECURSOS/Content/Bootstrap/bootstrap.css" rel="stylesheet" />
    <script src="../RECURSOS/Scripts/Bootstrap/bootstrap.js"></script>
    <script src="../RECURSOS/Scripts/Jquery/jquery-1.12.4.js"></script>
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
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
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
