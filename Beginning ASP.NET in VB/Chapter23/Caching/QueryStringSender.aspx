<%@ Page Language="VB" AutoEventWireup="false" CodeFile="QueryStringSender.aspx.vb" Inherits="QueryStringSender" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="cmdNormal" runat="server" Text="Normal Version" /><br />
        <asp:Button ID="cmdLarge" runat="server" Text="Large Version" Width="133px" /><br />
        <asp:Button ID="cmdSmall" runat="server" Text="Small Version" Width="133px" />
    </div>
    </form>
</body>
</html>

