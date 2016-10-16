<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ImageInTheme.aspx.vb" Inherits="ImageInTheme" Theme="FunkyTheme" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
      <div>
        <asp:ImageButton ID="ImageButton1" runat="server" SkinID="OKButton" />
        <asp:ImageButton ID="ImageButton2" runat="server" SkinID="CancelButton" /><br />
        <br />
      </div>
    </form>
</body>
</html>
