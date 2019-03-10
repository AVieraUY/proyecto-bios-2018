<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ABMFarmacéuticas.aspx.cs" Inherits="ABMFarmacéuticas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            text-align: center;
        }
        .style2
        {
            width: 224px;
        }
        .style7
        {
            width: 224px;
            height: 25px;
            text-align: left;
        }
        .style8
        {
            height: 23px;
            text-align: left;
        }
        .style9
        {
            text-align: left;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p style="width: 398px; height: 275px">
        <table style="width:100%;">
            <tr>
                <td class="style1" colspan="3">
                    <asp:Label ID="Label5" runat="server" Font-Size="XX-Large" ForeColor="#000099" 
                        Text="ABM Farmacéutica"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style8">
                    &nbsp;</td>
                <td class="style7">
                    &nbsp;</td>
                <td class="style9">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style8">
                    <asp:Label ID="Label1" runat="server" Text="RUC: "></asp:Label>
                </td>
                <td class="style7">
                    <asp:TextBox ID="txtRuc" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtRuc" ErrorMessage="RequiredFieldValidator" 
                        ForeColor="Red" ValidationGroup="A">*</asp:RequiredFieldValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                        ControlToValidate="txtRuc" ErrorMessage="RequiredFieldValidator" 
                        ForeColor="Red" ValidationGroup="B">*</asp:RequiredFieldValidator>
                </td>
                <td class="style9">
                    <asp:Button ID="btnBuscar" runat="server" onclick="btnBuscar_Click" 
                        Text="Buscar" ValidationGroup="B" />
                </td>
            </tr>
            <tr>
                <td class="style8">
                    <asp:Label ID="Label2" runat="server" Text="Nombre:"></asp:Label>
                </td>
                <td class="style7">
                    <asp:TextBox ID="txtNombre" runat="server" Enabled="False"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                        ControlToValidate="txtNombre" ErrorMessage="RequiredFieldValidator" 
                        ForeColor="Red" ValidationGroup="A">*</asp:RequiredFieldValidator>
                </td>
                <td class="style9">
                    <asp:Button ID="btnLimpiar" runat="server" onclick="btnLimpiar_Click" 
                        Text="Limpiar" />
                </td>
            </tr>
            <tr>
                <td class="style8">
                    <asp:Label ID="Label3" runat="server" Text="Correo: "></asp:Label>
                </td>
                <td class="style7">
                    <asp:TextBox ID="txtCorreo" runat="server" Enabled="False"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                        ControlToValidate="txtCorreo" ErrorMessage="RequiredFieldValidator" 
                        ForeColor="Red" ValidationGroup="A">*</asp:RequiredFieldValidator>
                </td>
                <td class="style9">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style8">
                    <asp:Label ID="Label4" runat="server" Text="Direccion:"></asp:Label>
                </td>
                <td class="style7">
                    <asp:TextBox ID="txtDireccion" runat="server" Enabled="False"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                        ControlToValidate="txtDireccion" ErrorMessage="RequiredFieldValidator" 
                        ForeColor="Red" ValidationGroup="A">*</asp:RequiredFieldValidator>
                </td>
                <td class="style9">
                    <asp:Label ID="lblError" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style8">
                    &nbsp;</td>
                <td class="style7">
                    <asp:Button ID="btnAgregar" runat="server" onclick="btnAgregar_Click" 
                        Text="Agregar" ValidationGroup="A" Enabled="False" />
                    <asp:Button ID="btnModificar" runat="server" Enabled="False" Text="Modificar" 
                        onclick="btnModificar_Click" ValidationGroup="A" />
                    <asp:Button ID="btnEliminar" runat="server" Enabled="False" Text="Eliminar" 
                        onclick="btnEliminar_Click" ValidationGroup="B" />
                </td>
                <td class="style9">
                    &nbsp;</td>
            </tr>
        </table>
        </p>
</asp:Content>

