<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Logueo.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <style type="text/css">
        .style1
        {
        }
        .style2
        {
            width: 321px;
            text-align: left;
        }
        .centrar
        {
		    position: absolute;
		    top:36%;
		    left:42%;
		    width:590px;
		    margin-left:-200px;
		    height:356px;
		    margin-top:-150px;
        }
        .auto-style1 {
            height: 42px;
        }
        .auto-style2 {
            width: 138px;
            height: 42px;
        }
        .style3
        {
            width: 321px;
            height: 42px;
            text-align: center;
        }
        #form1
        {
            width: 557px;
            margin-left: 0px;
            margin-top: 0px;
        }
        .style5
        {
            width: 321px;
            text-align: left;
        }
        .style6
        {
            width: 321px;
            text-align: left;
        }
        .style7
        {
            width: 697px;
        }
        .style8
        {
            width: 697px;
            height: 42px;
            text-align: center;
        }
        .style9
        {
            width: 1570px;
            text-align: left;
        }
        .style10
        {
            width: 1570px;
            text-align: center;
        }
        .style11
        {
            width: 1570px;
            height: 42px;
            text-align: center;
        }
    </style>
    <title></title>
</head>
<body class="centrar" bgcolor="#e1e1ff">
    <form id="form1" runat="server">
        <div>
            <table align="center" style="width: 514px">
                <thead>
                    <tr>
                        <th class="style1" colspan="3">
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label1" runat="server" Font-Size="50pt" ForeColor="#000099" 
                                Text="Bienvenido"></asp:Label>
                        </th>
                    </tr>
                    <tr>
                        <th class="style7">
                            &nbsp;</th>
                        <th class="style9" rowspan="2">
                            &nbsp;</th>
                        <th class="style2" rowspan="2">
                            &nbsp;</th>
                    </tr>
                    <tr>
                        <th class="style7">
                            &nbsp;</th>
                    </tr>
                    <tr>
                        <th class="style7">
                            &nbsp;</th>
                        <th class="style10">
                            <asp:Label ID="lblUsername0" runat="server" Text="Username"></asp:Label>
                        &nbsp;&nbsp;
                            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvUsername" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtUsername"></asp:RequiredFieldValidator>
                        </th>
                        <th class="style2">
                            &nbsp;</th>
                    </tr>
                    <tr>
                        <th class="style7">
                            &nbsp;</th>
                        <th class="style10">
                            <asp:Label ID="lblPassword0" runat="server" Text="Password"></asp:Label>
                        &nbsp;&nbsp;&nbsp;
                            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
                        </th>
                        <th class="style5">
                            &nbsp;</th>
                    </tr>
                    <tr>
                        <th class="style7"></th>
                        <th class="style10">
                            <br/>
                            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
                        </th>
                        <th class="style6">
                            <asp:Label ID="lblError" runat="server" style="text-align: left"></asp:Label>
                        </th>
                        <th class="style1">
                           <br />
                        </th>
                    </tr>
                    <tr>
                        <th class="style7"></th>
                        <th class="style10">
                            <br />
                            <asp:HyperLink ID="hlRegistro" runat="server" NavigateUrl="~/RegistroCliente.aspx">Registro</asp:HyperLink>
                            <%--                            <asp:LinkButton ID="lbtnRegistro" runat="server" OnClick="lbtnRegistro_Click">Registrar cliente</asp:LinkButton>--%>
                        </th>
                        <th class="style6">
                            &nbsp;</th>
                    </tr>
                    <tr>
                        <th class="style8"></th>
                        <th class="style11">
                            <br />
                            <asp:HyperLink ID="hlConsulta" runat="server" NavigateUrl="~/ConsultaEstadoPedido.aspx">Consultar pedido</asp:HyperLink>
                            <%--                            <asp:LinkButton ID="lbtnConsulta" runat="server" OnClick="lbtnConsulta_Click">Consultar pedido</asp:LinkButton>--%>
                        </th>
                        <th class="style3">
                            &nbsp;</th>
                    </tr>
                </thead>
            </table>
        </div>
    </form>
</body>
</html>
