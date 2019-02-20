﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ABMEmpleados.aspx.cs" Inherits="ABMEmpleados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">


        .style1
        {
            width: 123px;
        }
        .style2
        {
            width: 214px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        Actor Participante: Usuario empleado Resumen: Este formulario permitirá realizar 
        cualquiera de las 3 acciones, a partir del ingreso del nombre de usuario de un 
        empleado. Si el valor ya existe se podrá eliminar o modificar dicho empleado 
        (previo despliegue de todos sus datos). En caso de que el usuario no exista, se 
        solicitaran todos los datos para generar un nuevo empleado en el repositorio de 
        datos. Tomar en cuenta que el valor ingresado podrá pertenecer a un cliente, y 
        en este formulario no se manejan clientes (se deberá desplegar un mensaje de 
        error acorde).</p>
        <table style="width:100%;">
            <tr>
                <td class="style1">
                    <asp:Label ID="Label5" runat="server" Text="Usuario:"></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="txtUsuario" ErrorMessage="*" ForeColor="Red" 
                        ValidationGroup="A"></asp:RequiredFieldValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="txtUsuario" ErrorMessage="*" ForeColor="Red" 
                        ValidationGroup="B"></asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:Button ID="btnBuscar" runat="server" onclick="btnBuscar_Click" 
                        Text="Buscar" ValidationGroup="B" />
                </td>
            </tr>
            <tr>
                <td class="style1">
                    <asp:Label ID="Label1" runat="server" Text="Contraseña:"></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="txtContraseña" runat="server" Enabled="False"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                        ControlToValidate="txtContraseña" ErrorMessage="*" ForeColor="Red" 
                        ValidationGroup="A"></asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:Button ID="btnLimpiar" runat="server" onclick="btnLimpiar_Click" 
                        Text="Limpiar" />
                </td>
            </tr>
            <tr>
                <td class="style1">
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
                <td class="style1">
                    <asp:Label ID="Label3" runat="server" Text="Apellido:"></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="txtApellido" runat="server" Enabled="False"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                        ControlToValidate="txtApellido" ErrorMessage="*" ForeColor="Red" 
                        ValidationGroup="A"></asp:RequiredFieldValidator>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style1">
                    <asp:Label ID="Label4" runat="server" Text="Nombre completo:"></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="txtNCompleto" runat="server" Enabled="False"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                        ControlToValidate="txtNCompleto" ErrorMessage="*" ForeColor="Red" 
                        ValidationGroup="A"></asp:RequiredFieldValidator>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style1">
                    <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="TextBox1" runat="server" Enabled="False"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                        ControlToValidate="TextBox1" ErrorMessage="*" ForeColor="Red" 
                        ValidationGroup="A"></asp:RequiredFieldValidator>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style1">
                    <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="TextBox2" runat="server" Enabled="False"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" 
                        ControlToValidate="TextBox2" ErrorMessage="*" ForeColor="Red" 
                        ValidationGroup="A"></asp:RequiredFieldValidator>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style1">
                    <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="TextBox3" runat="server" Enabled="False"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" 
                        ControlToValidate="TextBox3" ErrorMessage="*" ForeColor="Red" 
                        ValidationGroup="A"></asp:RequiredFieldValidator>
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
                        Text="Agregar" Enabled="False" ValidationGroup="A" />
                    <asp:Button ID="btnModificar" runat="server" Enabled="False" Text="Modificar" 
                        onclick="btnModificar_Click" ValidationGroup="A" />
                    <asp:Button ID="btnEliminar" runat="server" Enabled="False" Text="Eliminar" 
                        onclick="btnEliminar_Click" ValidationGroup="B" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
        </asp:Content>

