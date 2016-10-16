<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Themes.aspx.vb" Inherits="Themes" Theme="FunkyTheme" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox1" runat="server">Test</asp:TextBox>&nbsp;&nbsp;<br />
        <br />
        <asp:ListBox ID="ListBox1" runat="server" BackColor="#FFFFC0" Width="154px">
            <asp:ListItem>Test</asp:ListItem>
        </asp:ListBox>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="OK" Font-Bold="False" Font-Names="Futura Hv BT" Font-Size="Large" Width="69px" SkinID="Dramatic" />
        <asp:Button ID="Button2" runat="server" Text="Cancel" Font-Names="Futura Hv BT" Font-Size="Large" Width="83px" /><br />
        <br />
        <asp:Calendar ID="Calendar2" runat="server" />        
    </div>
    </form>
</body>
</html>
