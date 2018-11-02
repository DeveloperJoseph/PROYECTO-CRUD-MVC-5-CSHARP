<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FCustomer.aspx.cs" Inherits="WA_ASP_MVC.VISTA.FCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .grid{
            margin: 0 auto;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

    <div style="text-align:center">
    
   <asp:Label ID="Label1" runat="server" Text="CUSTOMER"></asp:Label>
        &nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" Height="19px" Width="187px">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server"   Text="Codigo a buscar: "></asp:Label>

        <asp:Label ID="txtCodigo" runat="server"  Text="Label"></asp:Label>

        <br />
        <br />
          <asp:Button ID="Button1" runat="server"   Text="CONSULTAR PEDIDOS" OnClick="Button1_Click" />
        
        <br />
        
        <br />
   
        <asp:GridView ID="GridView1" runat="server" Height="203px" Width="472px" CssClass="grid" >
        </asp:GridView>
    
   <br />
    
    </div>
    </form>
</body>
</html>
