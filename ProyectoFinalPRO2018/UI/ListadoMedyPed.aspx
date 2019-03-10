<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ListadoMedyPed.aspx.cs" Inherits="ListadoMedyPed" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style3
        {
    }
        .style4
        {
            width: 349px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <table style="width:100%;">
        <tr>
            <td class="style3" colspan="2">
                <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" ForeColor="#000099" 
                    Text="Listado medicamentos y pedidos" Width="426px"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                <asp:DropDownList ID="ddl" runat="server" 
                    onselectedindexchanged="ddl_SelectedIndexChanged" AutoPostBack="True" 
                    TabIndex="1">
                </asp:DropDownList>
            </td>
            <td class="style4">
                <asp:GridView ID="grdMedicamentos" runat="server" AutoPostback = "True" 
                    Height="100px" onselectedindexchanged="grdMedicamentos_SelectedIndexChanged" 
                    Width="188px" style="margin-left: 0px" BackColor="White" 
                    BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" 
                    ForeColor="Black" GridLines="Vertical">
                    <AlternatingRowStyle BackColor="#CCCCCC" />
                    <Columns>
                        <asp:CommandField ButtonType="Button" HeaderText="Ver pedidos" 
                            ShowSelectButton="True" />
                    </Columns>
                    <FooterStyle BackColor="#CCCCCC" />
                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                    <sortedascendingcellstyle backcolor="#F1F1F1" />
                    <sortedascendingheaderstyle backcolor="#808080" />
                    <sorteddescendingcellstyle backcolor="#CAC9C9" />
                    <sorteddescendingheaderstyle backcolor="#383838" />
                </asp:GridView>
            </td>
            <td>
                <asp:DropDownList ID="ddlEstado" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="ddlEstado_SelectedIndexChanged" Visible="False">
                    <asp:ListItem Value="1">Todos</asp:ListItem>
                    <asp:ListItem Value="2">Generados</asp:ListItem>
                    <asp:ListItem Value="3">Entregados</asp:ListItem>
                </asp:DropDownList>
                <asp:GridView ID="GridView1" runat="server" style="margin-left: 0px" 
                    AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" 
                    BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" 
                    GridLines="Vertical">
                    <AlternatingRowStyle BackColor="#CCCCCC" />
                    <Columns>
                        <asp:BoundField DataField="codigo" HeaderText="Código" />
                        <asp:BoundField DataField="cantidad" HeaderText="Cantidad" />
                        <asp:BoundField DataField="estado" HeaderText="Estado" />
                        <asp:BoundField DataField="Cliente.userName" HeaderText="Cliente" />
                    </Columns>
                    <FooterStyle BackColor="#CCCCCC" />
                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#808080" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#383838" />
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

