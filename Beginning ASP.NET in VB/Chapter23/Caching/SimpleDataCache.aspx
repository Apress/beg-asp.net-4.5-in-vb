<%@ Page Language="VB" AutoEventWireup="false" CodeFile="SimpleDataCache.aspx.vb" Inherits="SimpleDataCache" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Untitled Page</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" runat="server" Text="Post Back" />
        <br />
        <br />
        <asp:Label ID="lblInfo" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
