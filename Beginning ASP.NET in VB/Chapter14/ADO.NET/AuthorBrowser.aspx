<%@ Page Language="VB" AutoEventWireup="false" CodeFile="AuthorBrowser.aspx.vb" Inherits="AuthorBrowser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Untitled Page</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:label id="Label1" runat="server" Width="120px" Height="20px">Select Author:</asp:label>&nbsp;
        <asp:dropdownlist id="lstAuthor" runat="server" Width="256px" Height="22px" AutoPostBack="True" >
		</asp:dropdownlist>
		<br />
        <br />
        <br />
		<asp:label id="lblResults" runat="server" Width="384px" Height="168px">
		</asp:label>
	</div>
    </form>
</body>
</html>
