<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ABMFarmacéuticas.aspx.cs" Inherits="ABMFarmacéuticas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 103px;
        }
        .style2
        {
            width: 224px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <table style="width:100%;">
            <tr>
                <td class="style1">
                    <asp:Label ID="Label1" runat="server" Text="RUC: "></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="txtRuc" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtRuc" ErrorMessage="RequiredFieldValidator" 
                        ForeColor="Red" ValidationGroup="A">*</asp:RequiredFieldValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                        ControlToValidate="txtRuc" ErrorMessage="RequiredFieldValidator" 
                        ForeColor="Red" ValidationGroup="B">*</asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:Button ID="btnBuscar" runat="server" onclick="btnBuscar_Click" 
                        Text="Buscar" ValidationGroup="B" />
                </td>
            </tr>
            <tr>
                <td class="style1">
                    <asp:Label ID="Label2" runat="server" Text="Nombre:"></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="txtNombre" runat="server" Enabled="False"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                        ControlToValidate="txtNombre" ErrorMessage="RequiredFieldValidator" 
                        ForeColor="Red" ValidationGroup="A">*</asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:Button ID="btnLimpiar" runat="server" onclick="btnLimpiar_Click" 
                        Text="Limpiar" />
                </td>
            </tr>
            <tr>
                <td class="style1">
                    <asp:Label ID="Label3" runat="server" Text="Correo: "></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="txtCorreo" runat="server" Enabled="False"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                        ControlToValidate="txtCorreo" ErrorMessage="RequiredFieldValidator" 
                        ForeColor="Red" ValidationGroup="A">*</asp:RequiredFieldValidator>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style1">
                    <asp:Label ID="Label4" runat="server" Text="Direccion:"></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="txtDireccion" runat="server" Enabled="False"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                        ControlToValidate="txtDireccion" ErrorMessage="RequiredFieldValidator" 
                        ForeColor="Red" ValidationGroup="A">*</asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:Label ID="lblError" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;</td>
                <td class="style2">
                    <asp:Button ID="btnAgregar" runat="server" onclick="btnAgregar_Click" 
                        Text="Agregar" ValidationGroup="A" Enabled="False" />
                    <asp:Button ID="btnModificar" runat="server" Enabled="False" Text="Modificar" 
                        onclick="btnModificar_Click" ValidationGroup="A" />
                    <asp:Button ID="btnEliminar" runat="server" Enabled="False" Text="Eliminar" 
                        onclick="btnEliminar_Click" ValidationGroup="B" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
        </p>
</asp:Content>

