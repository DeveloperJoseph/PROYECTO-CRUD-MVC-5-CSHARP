<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MantenimientoRAZA.aspx.cs" Inherits="CHSARP_MVC_WEB.VISTAS.MantenimientoRAZA" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <center>
    <h1>Mantenimiento Tabla Raza</h1>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Codigo Raza"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCodigoRaza" runat="server" Width="201px"></asp:TextBox>
        <br />
        <br />
    
    </div>
        <asp:Label ID="Label2" runat="server" Text="Descripción"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtDescripcion" runat="server" Width="201px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnListarRaza" runat="server" Text="Listar Razas" OnClick="btnListarRaza_Click" style="height: 26px" />
        &nbsp;
        <asp:Button ID="btnAgregarMascota" runat="server" OnClick="btnAgregarMascota_Click" Text="Agregar Raza" Height="28px" />
&nbsp;<asp:Button ID="btnUpdateRaza" runat="server" Height="30px" OnClick="btnUpdateRaza_Click" Text=" Modificar Raza" />
&nbsp;
        <asp:Button ID="btnDeleteRaza" runat="server" Height="28px" OnClick="btnDeleteRaza_Click" Text="Delete Raza" Width="123px" />
&nbsp;<asp:Button ID="btnClear" runat="server" Height="30px" OnClick="btnClear_Click" Text="Clear" Width="69px" />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" Width="373px">
        </asp:GridView>
        <br />
    </form>

</center>        
</body>
</html>
