<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FEmployee.aspx.cs" Inherits="WA_ASP_MVC.VISTA.FEmployee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <link href="../Recursos/Content/Bootstrap/bootstrap.css" rel="stylesheet" />
    <script src="../Recursos/Scripts/Bootstrap/bootstrap.js"></script>
    <script src="../Recursos/Scripts/Jquery/jquery-1.12.4.js"></script>
    <style>
        .grid{
            margin: 0 auto;
        }
    </style>
    <title></title>
</head>
<body>
    <div style="text-align: center">
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="EMPLOYEE"></asp:Label>
&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" Height="19px" Width="160px">
        </asp:DropDownList>
        <br />
        <br />
    <div>
    
        <asp:Label ID="Label2" runat="server" Text="Search:"></asp:Label>
&nbsp;
        <asp:Label ID="txtCodigo" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" CssClass="btn btn-primary" Text="CONSULTAR PEDIDOS" OnClick="Button1_Click" />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" Width="376px" CssClass="grid">
        </asp:GridView>
    
    </div>
    </form>
        </div>
</body>
</html>
