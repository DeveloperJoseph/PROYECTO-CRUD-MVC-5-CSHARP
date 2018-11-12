<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FCustomer.aspx.cs" Inherits="WA_ASP_MVC.VISTA.FCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../Recursos/Content/Bootstrap/bootstrap.css" rel="stylesheet" />
    <script src="../Recursos/Scripts/Bootstrap/bootstrap.js"></script>
    <script src="../Recursos/Scripts/Jquery/jquery-1.12.4.js"></script>
    <title></title>
    <style>
        .grid{
            margin: 0 auto;
        }
    </style>
</head>
<body>
    <div class="jumbotron text-center text-white bg-danger">
        <h2>CONSULTA PEDIDOS CLIENTES</h2>
    </div>
    <div class="container">
        <form id="form1" runat="server">
                <asp:Label ID="Label1" runat="server" Text="CUSTOMER"></asp:Label>
                &nbsp;
        <asp:DropDownList ID="DropDownList1" CssClass="dropdown-toggle"  runat="server" Height="78px" Width="194px">
        </asp:DropDownList>
                <br />
                <br />
                <asp:Label ID="Label2" runat="server" Text="Codigo a buscar: "></asp:Label>

                <asp:Label ID="txtCodigo" runat="server" Text="Label"></asp:Label>

                <br />
                <br />
                <asp:Button ID="Button1" runat="server" CssClass="btn btn-danger text-white" Text="CONSULTAR PEDIDOS" OnClick="Button1_Click" />

                <br />

                <br />

                <asp:GridView ID="GridView1" runat="server" Height="203px" Width="472px" CssClass="table">
                </asp:GridView>
        </form>
    </div>
</body>
</html>
