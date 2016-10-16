<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ThemesWithCSS.aspx.vb" Inherits="ThemesWithCSS" Theme="FunkyTheme" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label CssClass="heading1" ID="Label1" runat="server" Text="This Label Uses heading1"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server">Test</asp:TextBox>&nbsp;&nbsp;<br />
        <br />
        <asp:ListBox ID="ListBox1" runat="server" BackColor="#FFFFC0" Width="154px">
            <asp:ListItem>Test</asp:ListItem>
        </asp:ListBox>
        <br />
    </div>
    </form>
</body>
</html>
