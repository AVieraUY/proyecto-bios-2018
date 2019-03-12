<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RegistroCliente.aspx.cs" Inherits="RegistroCliente2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
        }
        .style2
        {
            width: 214px;
        }
        .style3
        {
            width: 162px;
        }
    </style>
</head>
<body bgcolor="#e1e1ff" >
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td class="style3">
                    <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Logueo.aspx">Login</asp:LinkButton>
                    <br />
                    <asp:LinkButton ID="LinkButton2" runat="server" 
                        PostBackUrl="~/ConsultaEstadoPedido.aspx">Consultar pedido</asp:LinkButton>
                </td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style1" colspan="2">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label8" runat="server" Font-Size="XX-Large" ForeColor="#000099" 
                        Text="Registrar cliente"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="Label5" runat="server" Text="Usuario:"></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="txtUsuario" ErrorMessage="*" ForeColor="Red" 
                        ValidationGroup="A"></asp:RequiredFieldValidator>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="Label1" runat="server" Text="Contraseña:"></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="txtContraseña" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                        ControlToValidate="txtContraseña" ErrorMessage="*" ForeColor="Red" 
                        ValidationGroup="A"></asp:RequiredFieldValidator>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="Label2" runat="server" Text="Nombre:"></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                        ControlToValidate="txtNombre" ErrorMessage="*" ForeColor="Red" 
                        ValidationGroup="A"></asp:RequiredFieldValidator>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="Label3" runat="server" Text="Apellido:"></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                        ControlToValidate="txtApellido" ErrorMessage="*" ForeColor="Red" 
                        ValidationGroup="A"></asp:RequiredFieldValidator>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="Label6" runat="server" Text="Dirección de entrega:"></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="txtDirEntrega" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                        ControlToValidate="txtDirEntrega" ErrorMessage="*" ForeColor="Red" 
                        ValidationGroup="A"></asp:RequiredFieldValidator>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="Label7" runat="server" Text="Teléfono:"></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="txtTel" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" 
                        ControlToValidate="txtTel" ErrorMessage="*" ForeColor="Red" ValidationGroup="A"></asp:RequiredFieldValidator>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3">
                    &nbsp;</td>
                <td class="style2">
                    <asp:Button ID="btnAgregar" runat="server" onclick="btnAgregar_Click" 
                        Text="Agregar" ValidationGroup="A" />
                    <asp:Button ID="btnLimpiar" runat="server" onclick="btnLimpiar_Click" 
                        Text="Limpiar" />
                </td>
                <td>
                    <asp:Label ID="lblError" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
