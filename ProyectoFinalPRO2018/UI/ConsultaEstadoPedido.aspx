<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ConsultaEstadoPedido.aspx.cs" Inherits="ConsultaEP" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body bgcolor="#e1e1ff">
    <form id="form1" runat="server">
    <div>
    
    <table style="width:100%;">
        <tr>
            <td>
                <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Logueo.aspx">Login</asp:LinkButton>
                <br />
                <asp:LinkButton ID="LinkButton2" runat="server" 
                    PostBackUrl="~/RegistroCliente.aspx">Registro de clientes</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Font-Size="XX-Large" ForeColor="#000099" 
                    Text="Consultar estado de pedido"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Código"></asp:Label>
                <asp:TextBox ID="txtCodigo" runat="server" Width="79px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtCodigo" ErrorMessage="*" ForeColor="Red" 
                    ValidationGroup="a"></asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnConsular" runat="server" onclick="btnConsular_Click" 
                    Text="Consultar estado" ValidationGroup="a" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblMensaje" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    
    </div>
    </form>
</body>
</html>
