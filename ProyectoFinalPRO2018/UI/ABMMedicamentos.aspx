﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ABMMedicamentos.aspx.cs" Inherits="ABMMedicamentos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .style1
        {
        }
        .style2
        {
            width: 214px;
        }
        .style7
        {
            height: 23px;
            width: 16px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p style="width: 367px">
        <table style="width:100%;">
            <tr>
                <td class="style1" colspan="3">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label6" runat="server" Font-Size="XX-Large" ForeColor="#000099" 
                        Text="ABM Medicamento"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style7">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style7">
                    <asp:Label ID="Label5" runat="server" Text="Ruc:"></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="txtRuc" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="txtRuc" ErrorMessage="*" ForeColor="Red" ValidationGroup="A"></asp:RequiredFieldValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="txtRuc" ErrorMessage="*" ForeColor="Red" ValidationGroup="B"></asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:Button ID="btnBuscar" runat="server" onclick="btnBuscar_Click" 
                        Text="Buscar" ValidationGroup="B" />
                </td>
            </tr>
            <tr>
                <td class="style7">
                    <asp:Label ID="Label1" runat="server" Text="Código:"></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                        ControlToValidate="txtCodigo" ErrorMessage="*" ForeColor="Red" 
                        ValidationGroup="A"></asp:RequiredFieldValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                        ControlToValidate="txtCodigo" ErrorMessage="*" ForeColor="Red" 
                        ValidationGroup="B"></asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:Button ID="btnLimpiar" runat="server" onclick="btnLimpiar_Click" 
                        Text="Limpiar" />
                </td>
            </tr>
            <tr>
                <td class="style7">
                    <asp:Label ID="Label2" runat="server" Text="Nombre:"></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="txtNombre" runat="server" Enabled="False"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                        ControlToValidate="txtNombre" ErrorMessage="*" ForeColor="Red" 
                        ValidationGroup="A"></asp:RequiredFieldValidator>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style7">
                    <asp:Label ID="Label3" runat="server" Text="Descripción:"></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="txtDescripcion" runat="server" Enabled="False"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                        ControlToValidate="txtDescripcion" ErrorMessage="*" ForeColor="Red" 
                        ValidationGroup="A"></asp:RequiredFieldValidator>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style7">
                    <asp:Label ID="Label4" runat="server" Text="Precio:"></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="txtPrecio" runat="server" Enabled="False"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                        ControlToValidate="txtPrecio" ErrorMessage="*" ForeColor="Red" 
                        ValidationGroup="A"></asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:Label ID="lblError" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style7">
                    &nbsp;</td>
                <td class="style2">
                    <asp:Button ID="btnAgregar" runat="server" Enabled="False" 
                        onclick="btnAgregar_Click" Text="Agregar" ValidationGroup="A" />
                    <asp:Button ID="btnModificar" runat="server" Enabled="False" 
                        onclick="btnModificar_Click" Text="Modificar" ValidationGroup="A" />
                    <asp:Button ID="btnEliminar" runat="server" Enabled="False" 
                        onclick="btnEliminar_Click" Text="Eliminar" ValidationGroup="B" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    </p>
</asp:Content>

