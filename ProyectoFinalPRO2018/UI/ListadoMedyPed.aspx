<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ListadoMedyPed.aspx.cs" Inherits="ListadoMedyPed" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style3
        {
            width: 168px;
        }
        .style4
        {
            width: 349px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        Seleccionado un medicamento, se desplegaran todos sus pedidos (con todos sus 
        datos), ordenadas cronológicamente. Se podrá filtrar dicha lista de pedidos por: 
        todos (no importa su estado), solo generados, o solo entregados.
    <table style="width:100%;">
        <tr>
            <td class="style3">
                <asp:DropDownList ID="ddl" runat="server" 
                    onselectedindexchanged="ddl_SelectedIndexChanged" AutoPostBack="True" 
                    TabIndex="1">
                    <asp:ListItem Selected="True">Selecciona farmacéutica</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="style4">
                <asp:GridView ID="grdMedicamentos" runat="server" AutoPostback = "True" 
                    Height="100px" onselectedindexchanged="grdMedicamentos_SelectedIndexChanged" 
                    Width="188px" style="margin-left: 0px">
                    <Columns>
                        <asp:CommandField ButtonType="Button" HeaderText="Ver pedidos" 
                            ShowSelectButton="True" />
                    </Columns>
                </asp:GridView>
            </td>
            <td>
                <asp:DropDownList ID="ddlEstado" runat="server">
                    <asp:ListItem Value="1">Todos</asp:ListItem>
                    <asp:ListItem Value="2">Generados</asp:ListItem>
                    <asp:ListItem Value="3">Entregados</asp:ListItem>
                </asp:DropDownList>
                <asp:GridView ID="GridView1" runat="server" style="margin-left: 0px">
                    <Columns>
                        <asp:BoundField />
                        <asp:BoundField />
                        <asp:BoundField />
                        <asp:BoundField />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td class="style4">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                <asp:Label ID="lblError" runat="server"></asp:Label>
            </td>
            <td class="style4">
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

