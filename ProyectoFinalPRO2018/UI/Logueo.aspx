<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Logueo.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
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
        .auto-style1 {
            height: 42px;
        }
        .auto-style2 {
            width: 138px;
            height: 42px;
        }
    </style>
    <title></title>
</head>
<body class="centrar">
    <form id="form1" runat="server">
        <div>
            <table>
                <thead>
                    <tr>
                        <th class="style1">
                            <asp:Label ID="lblUsername" runat="server" Text="Username"></asp:Label>
                        </th>
                        <th class="style2">
                            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvUsername" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtUsername"></asp:RequiredFieldValidator>
                        </th>
                    </tr>
                    <tr>
                        <th class="style1">
                            <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                        </th>
                        <th class="style2">
                            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
                        </th>
                    </tr>
                    <tr>
                        <th></th>
                        <th class="style1">
                            <br/>
                            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
                        </th>
                        <th class="style1">
                            <asp:Label ID="lblError" runat="server"></asp:Label>
                           <br />
                        </th>
                    </tr>
                    <tr>
                        <th></th>
                        <th class="style1">
                            <br />
                            <asp:HyperLink ID="hlRegistro" runat="server" NavigateUrl="~/RegistroCliente.aspx">Registro</asp:HyperLink>
<%--                            <asp:LinkButton ID="lbtnRegistro" runat="server" OnClick="lbtnRegistro_Click">Registrar cliente</asp:LinkButton>--%>
                        </th>
                    </tr>
                    <tr>
                        <th class="auto-style1"></th>
                        <th class="auto-style2">
                            <br />
                            <asp:HyperLink ID="hlConsulta" runat="server" NavigateUrl="~/ConsultaEstadoPedido.aspx">Consultar pedido</asp:HyperLink>
<%--                            <asp:LinkButton ID="lbtnConsulta" runat="server" OnClick="lbtnConsulta_Click">Consultar pedido</asp:LinkButton>--%>
                        </th>
                    </tr>
                </thead>
            </table>
        </div>
    </form>
</body>
</html>
