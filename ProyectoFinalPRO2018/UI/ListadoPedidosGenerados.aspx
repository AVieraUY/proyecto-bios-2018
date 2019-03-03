<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ListadoPedidosGenerados.aspx.cs" Inherits="ListadoPedidosGenerados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 330px;
        }
    </style>
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
        <td class="style1">
            <asp:GridView ID="grdPedidos" runat="server" AutoGenerateColumns="False" 
                onselectedindexchanged="grdPedidos_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="codigo" HeaderText="Código" />
                    <asp:BoundField DataField="Medicamento.Nombre" HeaderText="Medicamento" />
                    <asp:BoundField DataField="Cliente.userName" HeaderText="Cliente" />
                    <asp:CommandField ButtonType="Button" SelectText="Ver mas" 
                        ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
        </td>
        <td>
            <asp:Button ID="btnEliminar" runat="server" onclick="btnEliminar_Click" 
                Text="Eliminar pedido" Visible="False" />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="codigo" HeaderText="Código" />
                    <asp:BoundField DataField="cantidad" HeaderText="Cantidad" />
                    <asp:BoundField DataField="estado" HeaderText="Estado" />
                    <asp:BoundField DataField="Medicamento.Farmaceutica.Ruc" 
                        HeaderText="Farmaceutica del medicamento" />
                    <asp:BoundField DataField="Medicamento.codigo" 
                        HeaderText="Código del medicamento" />
                    <asp:BoundField DataField="Cliente.userName" HeaderText="Cliente" />
                </Columns>
            </asp:GridView>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style1">
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style1">
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

