<%@ Page Language="VB" AutoEventWireup="false" CodeFile="DynamicThemes.aspx.vb" Inherits="DynamicThemes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ListBox ID="lstThemes" runat="server"></asp:ListBox><br />
        <br />
        <asp:Button ID="cmdApply" runat="server" Text="Apply Theme"  />
        <asp:Button ID="cmdClear" runat="server" Text="Clear Themes"  />
    </div>
    </form>
</body>
</html>