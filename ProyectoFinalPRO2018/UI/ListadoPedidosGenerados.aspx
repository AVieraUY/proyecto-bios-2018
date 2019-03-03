<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ListadoPedidosGenerados.aspx.cs" Inherits="ListadoPedidosGenerados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        Resumen: Este formulario mostrara en una grilla, la lista de pedidos en estado 
        “generado” del usuario cliente actualmente logueado. Si se selecciona uno, se 
        deberán desplegar todos los datos del mismo (incluyendo los datos de medicamento 
        y la farmacéutica que lo produce). Deberá permitírsele al usuario cliente, 
        eliminar dicho pedido. Esta acción elimina el pedido del repositorio de datos.
    </p>
    <table style="width:100%;">
        <tr>
            <td>
                <asp:GridView ID="grdPedidos" runat="server">
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
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    <p>
    </p>
</asp:Content>

