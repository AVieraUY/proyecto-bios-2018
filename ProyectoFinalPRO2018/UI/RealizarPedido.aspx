<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="RealizarPedido.aspx.cs" Inherits="RealizarPedido" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 129px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <table 
            style="width:100%;">
            <tr>
                <td class="style1">
                    <asp:GridView ID="grdMeds" runat="server" 
                        onselectedindexchanged="grdMeds_SelectedIndexChanged" 
                        AutoGenerateColumns="False">
                        <Columns>
                            <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                            <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
                        </Columns>
                    </asp:GridView>
                </td>
                <td>
                    <asp:GridView ID="grd1Med" runat="server" AutoGenerateColumns="False" 
                        onselectedindexchanged="grd1Med_SelectedIndexChanged" Height="79px">
                        <Columns>
                            <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                            <asp:BoundField DataField="Codigo" HeaderText="Código" />
                            <asp:BoundField DataField="Precio" HeaderText="Precio" />
                            <asp:BoundField DataField="Descripcion" HeaderText="Descripción" />
                            <asp:BoundField DataField="Farmaceutica.Nombre" HeaderText="Farmaceutica" />
                            <asp:BoundField DataField="Farmaceutica.Ruc" HeaderText="Rut Farmaceutica" />
                        </Columns>
                    </asp:GridView>
                    <br />
                    <asp:Label ID="Label1" runat="server" Text="Cantidad a pedir:" Visible="False"></asp:Label>
                    <asp:TextBox ID="txtCantidad" runat="server" Visible="False"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtCantidad" ErrorMessage="*" ForeColor="Red" 
                        ValidationGroup="a"></asp:RequiredFieldValidator>
                    <asp:Button ID="btnListo" runat="server" onclick="btnListo_Click" Text="Listo" 
                        Visible="False" ValidationGroup="a" />
                    <br />
                    <br />
                    <br />
                    <asp:Label ID="lblPrecio" runat="server" Visible="False"></asp:Label>
                    <asp:Button ID="BtnPedir" runat="server" onclick="BtnPedir_Click" 
                        Text="Confirmar Pedido" Visible="False" />
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
        </table>
    </p>
</asp:Content>

