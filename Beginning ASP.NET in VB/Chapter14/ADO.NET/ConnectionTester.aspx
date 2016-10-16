<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ConnectionTester.aspx.vb" Inherits="ConnectionTester" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:RadioButton id="optSQL" runat="server" Text="Use SQL Authentication (with sa account)" GroupName="Authentication" Font-Size="Smaller" Font-Names="Verdana"></asp:RadioButton>
		<br />
		<asp:RadioButton id="optWindows" runat="server" Text="Use Windows Integrated Authentication" GroupName="Authentication" Font-Size="Smaller" Font-Names="Verdana" Checked="True"></asp:RadioButton>
        <br />
		<br />
		<asp:button id="cmdConnect" runat="server" Text="Connect"></asp:button>
		<br />
        <br />
		<asp:label id="lblInfo" runat="server" Height="128px" Width="464px" Font-Size="Small" Font-Names="Verdana" ForeColor="Maroon"></asp:label>
    </div>
    </form>
</body>
</html>
