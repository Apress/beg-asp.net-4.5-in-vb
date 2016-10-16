<%@ Page Language="VB" AutoEventWireup="false" CodeFile="GetProfile.aspx.vb" Inherits="GetProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Untitled Page</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        User Name: &nbsp;<asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
        <asp:Button ID="cmdGet" runat="server"  Text="Get Profile" /><br />
        <br />
        <asp:Label ID="lbl" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
