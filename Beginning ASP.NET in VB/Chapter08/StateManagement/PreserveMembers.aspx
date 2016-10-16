<%@ Page Language="VB" AutoEventWireup="false" CodeFile="PreserveMembers.aspx.vb" Inherits="PreserveMembers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txtValue" runat="server" Height="153px" TextMode="MultiLine" Width="460px">This is a test of the PreserveMembers.aspx page</asp:TextBox><br />
        <br />
        <asp:Button ID="cmdSave" runat="server" Text="Save Contents" />
        &nbsp;<asp:Button ID="cmdLoad" runat="server" Text="Load Contents" /></div>
    </form>
</body>
</html>
