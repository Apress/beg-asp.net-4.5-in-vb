<%@ Page Language="VB" AutoEventWireup="false" trace="true" CodeFile="TraceExample.aspx.vb" Inherits="TraceExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="cmdWrite" runat="server"  Text="Write" />
        <asp:Button ID="cmdWriteCategory" runat="server" 
            Text="Write Category" />
        <asp:Button ID="cmdError" runat="server" Text="Write Error" />
    
    </div>
    </form>
</body>
</html>

