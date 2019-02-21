<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ListadoMedyPed.aspx.cs" Inherits="ListadoMedyPed" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        Seleccionado un medicamento, se desplegaran todos sus pedidos (con todos sus 
        datos), ordenadas cronológicamente. Se podrá filtrar dicha lista de pedidos por: 
        todos (no importa su estado), solo generados, o solo entregados.
    <table style="width:100%;">
        <tr>
            <td>
                <asp:DropDownList ID="ddl" runat="server" 
                    onselectedindexchanged="ddl_SelectedIndexChanged" AutoPostBack="True" 
                    TabIndex="1">
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:GridView ID="grdMedicamentos" runat="server" AutoPostback = "True" 
                    Height="100px" onselectedindexchanged="grdMedicamentos_SelectedIndexChanged" 
                    Width="188px">
                    <Columns>
                        <asp:CommandField ButtonType="Button" HeaderText="Ver pedidos" 
                            ShowSelectButton="True" />
                    </Columns>
                </asp:GridView>
            </td>
            <td>
                <asp:GridView ID="GridView1" runat="server">
                </asp:GridView>
            </td>
        </tr>
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
                <asp:Label ID="lblError" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</p>
<p>
</p>
<p>
</p>
</asp:Content>

