<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="BienvenidaEmpleado.aspx.cs" Inherits="BienvenidaEmpleado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

    .style7
    {
        width: 219px;
        text-align: center;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="left" style="width: 373px; margin-left: 244px">
        <tr>
            <td class="style7">
                <asp:HyperLink ID="hlFarmacias" runat="server" 
                        NavigateUrl="~/ABMFarmacéuticas.aspx" Font-Size="20pt">ABM Farmacias</asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td class="style7">
                <asp:HyperLink ID="hlMedicamentos" runat="server" 
                        NavigateUrl="~/ABMMedicamentos.aspx" Font-Size="20pt">ABM Medicamentos</asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td class="style7">
                <asp:HyperLink ID="hlEmpleados" runat="server" 
                        NavigateUrl="~/ABMEmpleados.aspx" Font-Size="20pt">ABM Empleados</asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td class="style7">
                <asp:HyperLink ID="hlCambio" runat="server" 
                        NavigateUrl="~/CambioEstadoPedido.aspx" Font-Size="20pt">Cambiar estado de pedido</asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td class="style7">
                <asp:HyperLink ID="hlListado" runat="server" 
                        NavigateUrl="~/ListadoMedyPed.aspx" Font-Size="20pt">Listado de medicamentos y pedidos</asp:HyperLink>
            </td>
        </tr>
    </table>
</asp:Content>

