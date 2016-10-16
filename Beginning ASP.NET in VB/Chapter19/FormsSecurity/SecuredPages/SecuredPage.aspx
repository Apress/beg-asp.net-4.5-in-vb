<%@ Page Language="VB" AutoEventWireup="false" CodeFile="SecuredPage.aspx.vb" Inherits="SecuredPages_SecuredPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Untitled Page</title>
    <link href="../StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblMessage" runat="server" Font-Bold="True" Font-Size="Large"></asp:Label><br />
        <br />
        <br />
        <asp:Button ID="cmdSignOut" runat="server"  Text="Sign Out" />
    </div>
    </form>
</body>
</html>

