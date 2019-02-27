<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="RealizarPedido.aspx.cs" Inherits="RealizarPedido" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        Resumen: Este formulario permitirá generar un nuevo pedido. Para ello se deberá 
        poder seleccionar desde una grilla, el medicamento a pedir (solo uno por 
        pedido). La lista de medicamentos deberá estar ordenada por nombre de 
        medicamento. Cuando el cliente seleccione un medicamento, se deberá desplegar 
        toda su información (incluyendo la farmacéutica que lo produce). El cliente 
        determinara la cantidad que desea pedir, se indicara el costo total del pedido, 
        y podrá confirmar la acción. El usuario cliente actualmente logueado será 
        relacionado al pedido. Por defecto se considera al pedido en estado “generado”<table 
            style="width:100%;">
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:GridView ID="grdMeds" runat="server" 
                        onselectedindexchanged="grdMeds_SelectedIndexChanged">
                        <Columns>
                            <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
                        </Columns>
                    </asp:GridView>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblError" runat="server"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    </p>
</asp:Content>

