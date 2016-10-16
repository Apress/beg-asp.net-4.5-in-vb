<%@ Page Language="VB" AutoEventWireup="false" CodeFile="UnSecuredPage.aspx.vb" Inherits="UnSecuredPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Untitled Page</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Anyone can access this page.<br />
        <br />
        <asp:Label ID="lblInfo" runat="server"></asp:Label><br />
        <br />
        <asp:Button ID="cmdGo" runat="server" Text="Go To Secure Page" />
    </div>
    </form>
</body>
</html>
