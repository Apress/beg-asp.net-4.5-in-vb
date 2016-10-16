<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ErrorPage.aspx.vb" Inherits="ErrorPage" %>

<!DOCTYPE html>
 
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    An error occured. Click to go back and try again.<br />
        <br />
        <asp:Button ID="cmdOK" runat="server" Text="OK" />
    </div>
    </form>
</body>
</html>
