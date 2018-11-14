<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MantenimientoPrivilegio.aspx.cs" Inherits="CHSARP_MVC_WEB.VISTAS.MantenimientoPrivilegio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../RECURSOS/Content/Bootstrap/bootstrap.css" rel="stylesheet" />
    <script src="../RECURSOS/Scripts/Bootstrap/bootstrap.js"></script>
    <script src="../RECURSOS/Scripts/Jquery/jquery-1.12.4.js"></script>
    <title>Mantenimiento Privilegio</title>
</head>
<body>
    <div class="jumbotron-fluid text-center">
        <h1>Mantenimiento Privilegio</h1>
    </div>

    <div class="container">
        <form id="form1" runat="server">
            <div class="form-group">
                <label for="text">NOMBRE DE PRIVILEGIO</label>
                <asp:TextBox ID="txtNombrePrivilegio" CssClass="form-text" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Button ID="btnAgregar" runat="server" Text="Agregar" CssClass="btn btn-danger" OnClick="btnAgregar_Click" />
                <br />
                <br />
                <asp:Label ID="LabelMensaje" runat="server" Text="" CssClass="text-danger"></asp:Label>
            </div>
            <br />
            <asp:GridView ID="GridViewPrivilegio" runat="server" CssClass="table table-hover"></asp:GridView>
             </form>
    </div>
</body>
</html>
