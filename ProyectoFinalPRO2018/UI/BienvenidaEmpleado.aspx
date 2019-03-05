<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="BienvenidaEmpleado.aspx.cs" Inherits="BienvenidaEmpleado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 138px;
        }
        .style2
        {
            width: 214px;
        }
        .centrar
        {
		    position: absolute;
		    top:50%;
		    left:50%;
		    width:400px;
		    margin-left:-200px;
		    height:300px;
		    margin-top:-150px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="centrar">
        <table>
            <tr>
                <td>
                    <asp:HyperLink ID="hlFarmacias" runat="server" NavigateUrl="~/ABMFarmacéuticas.aspx">ABM Farmacias</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:HyperLink ID="hlMedicamentos" runat="server" NavigateUrl="~/ABMMedicamentos.aspx">ABM Medicamentos</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:HyperLink ID="hlEmpleados" runat="server" NavigateUrl="~/ABMEmpleados.aspx">ABM Empleados</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:HyperLink ID="hlCambio" runat="server" NavigateUrl="~/CambioEstadoPedido.aspx">Cambiar estado de pedido</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:HyperLink ID="hlListado" runat="server" NavigateUrl="~/ListadoMedyPed.aspx">Listado de medicamentos y pedidos</asp:HyperLink>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>

