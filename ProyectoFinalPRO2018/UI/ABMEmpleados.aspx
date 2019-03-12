<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ABMEmpleados.aspx.cs" Inherits="ABMEmpleados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">


        .style1
        {
            width: 137px;
        }
        .style2
        {
            width: 214px;
        }
        .style7
        {
            height: 23px;
            }
        .style8
        {
            height: 25px;
        }
        .style10
        {
            width: 18%;
            height: 23px;
            text-align: center;
        }
        .style13
        {
            width: 127%;
            height: 25px;
        }
        .style14
        {
            width: 18%;
            height: 23px;
        }
        .style16
        {
            width: 127%;
        }
        .style18
        {
            width: 17%;
            height: 25px;
        }
        .style19
        {
            width: 18%;
            height: 25px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">
    <p>
        <table style="width:40%; height: 208px; margin-right: 0px;">
            <tr>
                <td class="style7" colspan="3">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="Label8" runat="server" Font-Size="XX-Large" 
                        ForeColor="#000099" Text="ABM Empleados" Width="247px" 
                        style="text-align: center"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style14">
                    &nbsp;</td>
                <td class="style18">
                    &nbsp;</td>
                <td class="style16">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style14">
                    <asp:Label ID="Label5" runat="server" Text="Usuario:"></asp:Label>
                </td>
                <td class="style18">
                    <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="txtUsuario" ErrorMessage="*" ForeColor="Red" 
                        ValidationGroup="A"></asp:RequiredFieldValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="txtUsuario" ErrorMessage="*" ForeColor="Red" 
                        ValidationGroup="B"></asp:RequiredFieldValidator>
                </td>
                <td class="style16">
                    <asp:Button ID="btnBuscar" runat="server" onclick="btnBuscar_Click" 
                        Text="Buscar" ValidationGroup="B" />
                </td>
            </tr>
            <tr>
                <td class="style14">
                    <asp:Label ID="Label1" runat="server" Text="Contraseña:"></asp:Label>
                </td>
                <td class="style18">
                    <asp:TextBox ID="txtContraseña" runat="server" Enabled="False" 
                        TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                        ControlToValidate="txtContraseña" ErrorMessage="*" ForeColor="Red" 
                        ValidationGroup="A"></asp:RequiredFieldValidator>
                </td>
                <td class="style16">
                    <asp:Button ID="btnLimpiar" runat="server" onclick="btnLimpiar_Click" 
                        Text="Limpiar" />
                </td>
            </tr>
            <tr>
                <td class="style19">
                    ConfirmarContrsaseña:
                </td>
                <td class="style18">
                    <asp:TextBox ID="txtContraseña0" runat="server" Enabled="False" 
                        TextMode="Password"></asp:TextBox>
                </td>
                <td class="style13">
                    <asp:CompareValidator ID="CompareValidator1" runat="server" 
                        ControlToCompare="txtContraseña" ControlToValidate="txtContraseña0" 
                        ErrorMessage="Las contraseñas no coinciden" ValueToCompare="txtContraseña0"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="style19">
                    <asp:Label ID="Label2" runat="server" Text="Nombre:"></asp:Label>
                </td>
                <td class="style18">
                    <asp:TextBox ID="txtNombre" runat="server" Enabled="False"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                        ControlToValidate="txtNombre" ErrorMessage="*" ForeColor="Red" 
                        ValidationGroup="A"></asp:RequiredFieldValidator>
                </td>
                <td class="style13">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style19">
                    <asp:Label ID="Label3" runat="server" Text="Apellido:"></asp:Label>
                </td>
                <td class="style18">
                    <asp:TextBox ID="txtApellido" runat="server" Enabled="False"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                        ControlToValidate="txtApellido" ErrorMessage="*" ForeColor="Red" 
                        ValidationGroup="A"></asp:RequiredFieldValidator>
                </td>
                <td class="style13">
                    </td>
            </tr>
            <tr>
                <td class="style14">
                    <asp:Label ID="Label6" runat="server" Text="Horario de ingreso:"></asp:Label>
                </td>
                <td class="style18">
                    <asp:TextBox ID="txtHIngreso1" runat="server" Enabled="False" ToolTip="00:00" 
                        Width="26px" MaxLength="2" ValidationGroup="H1"></asp:TextBox>
                    <asp:Label ID="Label9" runat="server" Text=":"></asp:Label>
                    <asp:TextBox ID="txtHoraIngreso2" runat="server" Width="26px" MaxLength="2" 
                        ValidationGroup="H2"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                        ControlToValidate="txtHIngreso1" ErrorMessage="*" ForeColor="Red" 
                        ValidationGroup="A"></asp:RequiredFieldValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" 
                        ControlToValidate="txtHoraIngreso2" ErrorMessage="*" ForeColor="Red" 
                        ValidationGroup="A"></asp:RequiredFieldValidator>
                </td>
                <td class="style16">
                    <asp:RangeValidator ID="RangeValidator2" runat="server" 
                        ControlToValidate="txtHoraIngreso2" Display="Dynamic" 
                        ErrorMessage="Ingrese una hora valida" MaximumValue="59" MinimumValue="0" 
                        Type="Integer"></asp:RangeValidator>
&nbsp;<asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtHIngreso1" 
                        Display="Dynamic" ErrorMessage="Ingrese una hora valida" MaximumValue="23" 
                        MinimumValue="0" SetFocusOnError="True" Type="Integer" ValidationGroup="H1"></asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="style14">
                    <asp:Label ID="Label7" runat="server" Text="Horario de salida:"></asp:Label>
                </td>
                <td class="style18">
                    <asp:TextBox ID="txtHSalida" runat="server" Enabled="False" ToolTip="00:00" 
                        Width="26px" ontextchanged="txtHIngreso2_TextChanged" MaxLength="2" 
                        ValidationGroup="H1"></asp:TextBox>
                    <asp:Label ID="Label10" runat="server" Text=":"></asp:Label>
                    <asp:TextBox ID="txtHSalida2" runat="server" Width="26px" Enabled="False" 
                        MaxLength="2" ValidationGroup="H2"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" 
                        ControlToValidate="txtHSalida" ErrorMessage="*" ForeColor="Red" 
                        ValidationGroup="A"></asp:RequiredFieldValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" 
                        ControlToValidate="txtHSalida2" ErrorMessage="*" ForeColor="Red" 
                        ValidationGroup="A"></asp:RequiredFieldValidator>
                </td>
                <td class="style16">
                    <asp:RangeValidator ID="RangeValidator3" runat="server" 
                        ControlToValidate="txtHSalida" ErrorMessage="Ingrese una hora valida" 
                        MaximumValue="23" MinimumValue="0" Type="Integer"></asp:RangeValidator>
&nbsp;<asp:RangeValidator ID="RangeValidator4" runat="server" ControlToValidate="txtHSalida2" 
                        ErrorMessage="Ingrese una hora valida" MaximumValue="59" MinimumValue="0" 
                        Type="Integer"></asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="style14">
                    &nbsp;</td>
                <td class="style18">
                    &nbsp;</td>
                <td class="style16">
                    <asp:Label ID="lblError" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style10">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td class="style8" colspan="2">
                    <asp:Button ID="btnAgregar" runat="server" onclick="btnAgregar_Click" 
                        Text="Agregar" Enabled="False" ValidationGroup="A" />
                    <asp:Button ID="btnModificar" runat="server" Enabled="False" Text="Modificar" 
                        onclick="btnModificar_Click" ValidationGroup="A" />
                    <asp:Button ID="btnEliminar" runat="server" Enabled="False" Text="Eliminar" 
                        onclick="btnEliminar_Click" ValidationGroup="B" />
                </td>
            </tr>
        </table>
    </p>
    <p>
    </p>
</asp:Content>


