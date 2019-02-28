<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Logueo.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <thead>
                    <tr>
                        <th>
                            <asp:Label ID="lblUsername" runat="server" Text="Username"></asp:Label>
                        </th>
                        <th>
                            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                        </th>
                    </tr>
                    <tr>
                        <th>
                            <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                        </th>
                        <th>
                            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                        </th>
                    </tr>
                    <tr>
                        <th></th>
                        <th>
                            <br/>
                            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
                        </th>
                        <th>
                            <asp:Label ID="lblError" runat="server"></asp:Label>
                           <br />
                        </th>
                    </tr>
                </thead>
            </table>
        </div>
    </form>
</body>
</html>
