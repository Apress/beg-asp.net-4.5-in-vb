<%@ Page Language="VB" AutoEventWireup="false" CodeFile="CacheFileDependency.aspx.vb" Inherits="CacheFileDependency" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Untitled Page</title>
</head>
<body>
	<form id="Form1" method="post" runat="server">
		<asp:button id="cmdModify" runat="server" Text="Modify File" Width="103px" ></asp:button>
		<asp:button id="cmdGetItem" runat="server" Text="Check for Item" Width="103px" Height="24px" ></asp:button>
	    <br /><br />
		<asp:label id="lblInfo" runat="server" Width="480px" BorderWidth="2px" BorderStyle="Groove" Font-Names="Verdana" Font-Size="Small" BackColor="LightYellow"></asp:label>
	</form>
</body>
</html>

