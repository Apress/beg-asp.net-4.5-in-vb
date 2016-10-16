<%@ Page Language="VB" AutoEventWireup="false" CodeFile="SimpleCounter.aspx.vb" Inherits="SimpleCounter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="cmdIncrement" runat="server" Text="Increment" /><br />
        <br />
        <asp:Label ID="lblCount" runat="server"></asp:Label>&nbsp;</div>
    </form>
</body>
</html>
