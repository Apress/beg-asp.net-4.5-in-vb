<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Untitled Page</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:LoginView ID="LoginView1" runat="server">
        <AnonymousTemplate>
            <h2>You are anonymous</h2>
             Why don't you <a href="Login.aspx">log in</a>?
        </AnonymousTemplate>
        <LoggedInTemplate>
            <h2>You are logged in</h2>
            <p>You are now ready to see this super-secret content.</p>
        </LoggedInTemplate>
    </asp:LoginView>

    </div>
    </form>
</body>
</html>