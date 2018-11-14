<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MantenimientoTIPOALIMENTACION.aspx.cs" Inherits="CHSARP_MVC_WEB.VISTAS.MantenimientoTIPOALIMENTACION" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Codigo"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCodigoTipoAli" runat="server" Height="22px" Width="157px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
    <div>
    
        <asp:Label ID="Label2" runat="server" Text="Descripcion"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txtDescripcionTipoAli" runat="server" Height="22px" Width="243px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnListarTipoAli" runat="server" OnClick="btnListarTipoAli_Click" Text="Listar" />
&nbsp;
        <asp:Button ID="btnAgregarTipoAli" runat="server" OnClick="btnAgregarTipoAli_Click" Text="Agregar" />
&nbsp;
        <asp:Button ID="btnUpdateTipoAli" runat="server" OnClick="btnUpdateTipoAli_Click" Text="Actualizar" />
&nbsp;
        <asp:Button ID="btnDeleteTipoAli" runat="server" Height="28px" OnClick="btnDeleteTipoAli_Click" Text="Borrar" Width="65px" />
&nbsp;
        <asp:Button ID="btnClear" runat="server" Height="28px" OnClick="btnClear_Click" Text="Clear" Width="62px" />
        <br />
        <asp:GridView ID="GridView1" runat="server" Width="352px">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
