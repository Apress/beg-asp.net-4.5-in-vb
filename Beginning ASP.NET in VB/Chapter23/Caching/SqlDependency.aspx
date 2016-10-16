<%@ Page Language="VB" AutoEventWireup="false" CodeFile="SqlDependency.aspx.vb" Inherits="Sql2005Dependency" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="cmdModify" runat="server" Height="24px" 
            Text="Modify Table"
            Width="103px" />
        <asp:Button ID="cmdGetItem" runat="server" Height="24px" 
            Text="Check for Item"
            Width="103px" />
        <br />
        <br />
        <asp:Label ID="lblInfo" runat="server" BackColor="LightYellow" BorderStyle="Groove"
            BorderWidth="2px" Font-Names="Verdana" Font-Size="X-Small" Width="480px">
         </asp:Label>    
    </div>
    </form>
</body>
</html>

