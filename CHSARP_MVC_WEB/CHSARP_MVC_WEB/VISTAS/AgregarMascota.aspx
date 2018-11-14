<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarMascota.aspx.cs" Inherits="CHSARP_MVC_WEB.VISTAS.AgregarMascota" %>

<!DOCTYPE html5>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            width: 684px;
        }
       
        div{
            font-weight: bold;
        } 

        body{
            background-image: url('/Image/fondo.png');
            background-repeat: no-repeat;
            background-size: 100%;
            }
    </style>
</head>
<body>
    <div class="container">
        <center>
      <h1> Mantenimiento Mascota</h1>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Codigo"></asp:Label>
        <asp:TextBox ID="txtCodigoMascota" runat="server" style="margin-left: 29px" Width="271px"></asp:TextBox>
    
        <br />
    <br />
    </div>
        <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
&nbsp;<asp:TextBox ID="txtNombreMascota" runat="server" style="margin-left: 21px" Width="271px"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Text="Peso"></asp:Label>
        <asp:TextBox ID="txtPeso" runat="server" style="margin-left: 30px" Width="271px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Cod. Raza"></asp:Label>
&nbsp;<asp:TextBox ID="txtCodigoRaza" runat="server" style="margin-left: 14px" Width="271px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Cod. Tipo Alimentacion"></asp:Label>
        <asp:TextBox ID="txtTipoAlimentacion" runat="server" style="margin-left: 30px" Width="180px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnAgregarMascota" runat="server" Text="Agregar Mascota" OnClick="btnAgregarMascota_Click" Height="30px" Width="134px" />
    &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnUpdateMascota" runat="server" OnClick="btnUpdateMascota_Click" Text="Modificar Mascota" Height="31px" Width="121px" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnDeleteMascota" runat="server" Text="Eliminar Mascota" OnClick="btnDeleteMascota_Click" Height="32px" Width="128px" />
    &nbsp;&nbsp;
        <asp:Button ID="btnActualizarListado" runat="server" OnClick="btnActualizarListado_Click" Text="Ver Listado" Height="33px" Width="108px" />
        &nbsp;&nbsp;
        <asp:Button ID="btnClear" runat="server" Height="31px" OnClick="btnClear_Click" Text="Limpiar" Width="113px" />
        <br />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" Width="666px">
        </asp:GridView>
    </form>
            </center>
        </div>
</body>
</html>
    